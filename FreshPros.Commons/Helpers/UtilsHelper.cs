using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreshPros.Commons.Helpers
{
    public class UtilsHelper
    {
        public static string GetIP()
        {
           return HttpContext.Current.Request.UserHostAddress;
        }


        public static string base64Encode(string sData) // Encode    
        {
            if (sData == null)
                return string.Empty;
            byte[] encData_byte = new byte[sData.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;

        }


        public static string base64Decode(string sData) //Decode    
        {
            if (sData == null)
                return string.Empty;

            var encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecodeByte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecodeByte, 0, todecodeByte.Length);
            char[] decodedChar = new char[charCount];
            utf8Decode.GetChars(todecodeByte, 0, todecodeByte.Length, decodedChar, 0);
            string result = new String(decodedChar);
            return result;
        }
    }
}