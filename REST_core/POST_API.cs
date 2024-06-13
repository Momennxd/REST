using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace REST_core
{
    public class POST_API
    {
        

        public static async Task<clsRespond> SendPostRequest(string url, string ReqBody)
        {
            clsRespond result = new clsRespond();
            HttpClient httpClient = new HttpClient();

            try
            {

                HttpContent content = new StringContent(ReqBody);

                HttpResponseMessage response = await httpClient.PostAsync(url, content);

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
