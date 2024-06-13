using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace REST_core
{
    public class PATCH_API
    {

        public static async Task<clsRespond> SendPatchRequest(string url, string requestBody)
        {
            clsRespond result = new clsRespond();
            HttpClient httpClient = new HttpClient();

            try
            {
                // Create a StringContent object with the request body
                HttpContent requestContent = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), url);
                request.Content = requestContent;

                HttpResponseMessage response = await httpClient.SendAsync(request);

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
