using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FreshPros.Commons.Constants
{
    public class Strings
    {
        #region Configs and URLs
        public static string ZILLOW = ConfigurationManager.AppSettings["ZillowAPI"];
        public static string SEARCH_URL = "http://www.zillow.com/webservice/GetDeepSearchResults.htm?zws-id=";
        public static string CLIENTTZ_URL = "http://www.webservicex.net/uszip.asmx/GetInfoByZIP?USZip=";
        public static string Storeorigins = ConfigurationManager.AppSettings["ORIGINS"];



        public static string AI = ConfigurationManager.AppSettings["AI"];
        public static string SK = ConfigurationManager.AppSettings["SK"];
        public static string MODE = ConfigurationManager.AppSettings["MODE"] == null ? "TEST" : ConfigurationManager.AppSettings["MODE"];

        public static string IMAP = ConfigurationManager.AppSettings["IMAP"];
        public static int IMAPPORT = int.Parse(ConfigurationManager.AppSettings["IMAPPORT"] == null ? "993" : ConfigurationManager.AppSettings["IMAPPORT"]);
        public static string CompanyMailUser = ConfigurationManager.AppSettings["CompanyMailUser"];
        public static string CompanyMailPassword = ConfigurationManager.AppSettings["CompanyMailPassword"];

        public static string COMPANY_WEBSITE = ConfigurationManager.AppSettings["FL_SITE"];
        #endregion
        

        #region Status Strings
        public static string ERROR = "An error occurred while processing your request. Please try again.";
        public static string UPDATE_SUCCESS = "Update Success!";
        public static string UPDATE_REDIRECT = "Update Success! Redirecting...";
        public static string UPDATE_WAIT = "Update Success! Please Wait...";
        public static string REQUEST_QUOTE = "Request Success.";
        public static string SESSION_EXPIRED = "Session Expired. Please refresh the page.";
        public static string DUPLICATE_EMAIL = "Email Address already exist.";
        public static string DUPLICATE_ADDRESS = "Address already exist.";
        public static string DUPLICATE_PHONE = "Phone number already exist.";
        public static string INVALID_INPUT = "Invalid input. Please try again.";
        public static string REG_SUCCESS = "Registration Success! Please check your email address to verify your account";
        public static string INVALID_PARAM = "Invalid Username / Password. Please try again. ";
        public static string RESETPW_SUCCESS = "Reset Password Success! You can now access your account.";
        public static string UPDATE_SUCCESS_EMAIL = "Update Success! Please check your email to verify.";
        public static string RECORD_NOT_FOUND = "Record not found. Please try again";
        public static string FILE_NOT_FOUND = "File not found. Please try again";
        public static string PORTAL_VALIDATE_REQUEST = "You can't login right now your manager not yet responding to your request.";
        public static string PORTAL_ENDOT = "You can't login right now your ovetime already finished.";
        public static string PW_NOT_MATCH = "Password not match.";
        public static string EMP_MISSING = "Employee is missing.";
        public static string NO_SERVICE_SELECTED = "No service selected.";
        public static string ADD_SERVICE_SUCCESS = "Add Job/Service Success.";
        public static string UPDATE_SUCCESS_REFRESHPAGE = "Update Success! Please Refresh the page.";
        public static string SHARE_SUCCESS = "Success! This Quote has been sent.";
        public static string CREW_NOT_FOUND = "Crew not found.";
        public static string COMPLETE_FIELDS = "Please complete the required fields.";
        public static string FAILED_TO_CONNECT = "Unable to connect to server. Please try again.";
        public static string SUCCESS = "SUCCESS";


        public static string R_SUCCESS = "success";
        public static string R_SUCCESSWITHURL = "success_url";
        public static string R_SUCCESSWITHURLWAIT = "success_url_wait";
        public static string R_SUCCESSWITHRETURN = "success_with_return";
        public static string R_FAIL = "fail";
        public static string R_FAILCUSTOM = "fail_custom";
        public static string R_SUCCESS_GETWITHRETURN = "success_get_with_return";
        public static string PW_REQ = "request_pw";
        public static string PW_EXPIRED = "expired_pw";
        #endregion

        #region Company Name Strings
        public static string COMPANY_NAME = "Fresh Lawn Mowing Services";
        public static string COMPANY_CLIENTS = "TruGreen Clients";
        public static string COMPANY_PORTAL = "Fresh Lawn Portal";
        public static string COMPANY_PROS = "Fresh Lawn Pros";
        #endregion
    }
}