using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace REST_core
{
    public class DELETE_API
    {


        public static async Task<clsRespond> SendDeleteRequest(string url)
        {
            clsRespond result = new clsRespond();
            HttpClient httpClient = new HttpClient();

            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    result.body = await response.Content.ReadAsStringAsync();
                }
             

                result.code = response.StatusCode;
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }









    }
}
