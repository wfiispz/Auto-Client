using RestSharp;
using System;
using System.Threading.Tasks;

namespace AutoClientApplication {

    class DataRestDownloader {

        public static async Task<IRestResponse<T>> GetDataAsync<T>(string wsName, string address, string username, string password, string parameters = null, Action<string> errorCallback = null) where T : class, new() {
            var uri = new Uri(address + (parameters != null ? ("/" + parameters) : string.Empty));
            var client = new RestClient(uri);
            var taskCompletionSource = new TaskCompletionSource<IRestResponse<T>>();
            RestRequest request = new RestSharp.Newtonsoft.Json.RestRequest(wsName, Method.GET);
            request.AddHeader("Content-type", "application/json");
            String encoded = Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.AddHeader("Authorization", "Basic " + encoded);
            client.ExecuteAsync<T>(request, restResponse => {
                if (restResponse.ErrorException != null) {
                    errorCallback("Error retrieving " + wsName + " from address: " + address + " with message: " + restResponse.ErrorException.Message);
                    return;
                }
                taskCompletionSource.SetResult(restResponse);
            });

            return await taskCompletionSource.Task;
        }
    }
}
