using RestSharp;
using System;
using System.Threading.Tasks;

namespace AutoClientApplication {
    class SensorsRestDownloader {

        public static async Task<IRestResponse<T>> GetSensorsAsync<T>(string address) where T : class, new() {
            var client = new RestClient(address);
            var taskCompletionSource = new TaskCompletionSource<IRestResponse<T>>();
            RestRequest request = new RestRequest("TOP", Method.GET);
            request.AddHeader("Content-type", "application/json");
            client.ExecuteAsync<T>(request, restResponse => {
                if (restResponse.ErrorException != null)
                {
                    const string message = "Error retrieving response.";
                    throw new ApplicationException(message, restResponse.ErrorException);
                }
                taskCompletionSource.SetResult(restResponse);
            });

            return await taskCompletionSource.Task;
        }
    }
}
