using FreshPros.Commons.Objects.Account;
using FreshPros.Commons.Objects.Crew;
using FreshPros.Commons.Helpers;
using Dapper;
using FreshPros.Commons.Interfaces;

namespace FreshPros.DAL.Repositories
{
    public class AccountRepository : GenericRepository<AccountToken>, IAccountRepository
    {
        protected AccountToken _tkn;
        public AccountRepository()
        {
           _tkn = new AccountToken();
        }

        public AccountToken login(Login param)
        {
            Crews c = new Crews();            
            c = _db.QueryFirstOrDefault<Crews>("SELECT id FROM crew_reg WHERE email = @email and password = @pw", new { email = param.username, pw = pw });
            if(c != null)
            {
                _tkn._tknID = UserHelper.GenerateSHA512String(c.id.ToString());
                _tkn._tkn = UserHelper.GenerateSHA512String(param.username);
            }


            return _tkn;
        } 
    }
}
