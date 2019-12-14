using HelpApp.Core.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestLibrary.Cors
{
    public class RequestSender
    {
#if DEBUG
        private const string _BaseUrl = "https://localhost:44335/";
#else
        private const string _BaseUrl= "production link";
#endif 

        private readonly RestClient _client = null;
        public RequestSender()
        {
            _client = new RestClient(_BaseUrl);
        }

        public async Task<RequestResult<T>> Response<T>(string url, Action<IRestRequest> action = null, Method method = Method.GET) where T : new()
        {
            try
            {
                var request = new RestRequest(url, method);

                action?.Invoke(request);

                var response = _client.Execute<StandartAnswer<T>>(request);

                return new RequestResult<T>
                {
                    IsSucced = response.IsSuccessful,
                    Answer = response.Data,
                    ErrorMessage = response.ErrorMessage,
                };

            }
            catch (Exception ex)
            {
                return new RequestResult<T>
                {
                    IsSucced = false,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
