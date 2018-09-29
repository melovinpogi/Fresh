using FreshPros.Commons.Constants;
using FreshPros.Commons.Objects.Account;
using FreshPros.DAL.Repositories;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FreshPros.Commons.Interfaces;
using FreshPros.Commons.Objects.Params;
using System.Transactions;
using FreshPros.DAL.Repositories.Account;
using FreshPros.Commons.Interfaces.Crew;

namespace FreshPros.App.Controllers.Account
{
    public class AccountController : ApiController
    {
        IAccountRepository _repoLogin = new AccountRepository();
        IRegisterCrewRepository _repoRegister = new RegisterCrewRepository();

        [Route("~/api/app/login")]
        [EnableCors(origins: "*", headers: "*", methods: "POST")]
        public IHttpActionResult Login(Login param)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _repoLogin.login(param);
                    if (result._tkn == null || result._tknID == null)
                    {
                        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.Accepted, Strings.INVALID_PARAM));
                    }
                    else
                    {                      
                        return Ok(result);
                    }                   
                }
                else
                {
                    return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.Accepted, Strings.INVALID_PARAM));
                }
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.Accepted, ex.Message.ToString()));
            }
        }

        [Route("~/api/app/signup")]
        [EnableCors(origins: "*", headers: "*", methods: "POST")]
        public IHttpActionResult signup(RegisterCrewParams param)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(var scope = new TransactionScope())
                    {
                        try
                        {
                            _repoRegister.processRegister(param);
                            //send an email when success
                            scope.Complete();

                            return Ok();
                        }
                        catch (Exception ex)
                        {
                            return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.Accepted, ex.Message.ToString()));
                        }                       
                    }                   
                }
                else
                {
                    return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.Accepted, Strings.INVALID_INPUT));
                }
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.Accepted, ex.Message.ToString()));
            }
        }
    }
}