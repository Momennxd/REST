using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace REST_core
{
    public class PUT_API
    {



        public static async Task<clsRespond> SendPutRequest(string url, string requestBody)
        {
            clsRespond result = new clsRespond();
            HttpClient httpClient = new HttpClient();

            try
            {
                // Create a StringContent object with the request body
                HttpContent requestContent = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PutAsync(url, requestContent);

                if (response.IsSuccessStatusCode)
                {
                    result.body = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // MessageBox.Show("Request failed. Status code: " + response.StatusCode, "Request Failed");
                }

                result.code = response.StatusCode;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

            return result;
        }














    }
}
