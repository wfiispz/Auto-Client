using RestSharp;
using System;
using System.Threading.Tasks;

namespace AutoClientApplication {

    class DataRestDownloader {

        public static async Task<IRestResponse<T>> GetDataAsync<T>(string wsName, string address, string username, string password) where T : class, new() {
            var client = new RestClient(address);
            var taskCompletionSource = new TaskCompletionSource<IRestResponse<T>>();
            RestRequest request = new RestRequest(wsName, Method.GET);
            request.AddHeader("Content-type", "application/json");
            String encoded = Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.AddHeader("Authorization", "Basic " + encoded);
            client.ExecuteAsync<T>(request, restResponse => {
                if (restResponse.ErrorException != null) {
                    const string message = "Error retrieving response.";
                    throw new ApplicationException(message, restResponse.ErrorException);
                }
                taskCompletionSource.SetResult(restResponse);
            });

            return await taskCompletionSource.Task;
        }
    }
}
