using Newtonsoft.Json;
using PaymentSystem.Core.Dtos.Payzee.Request;
using PaymentSystem.Core.ResponseModel.PayzeeResponses;
using RestSharp;

namespace PaymentSystem.Core.ExternalServices.PayzeeServices
{
    public class PayzeeLoginService
    {
      

        public static LoginResponse Auth(LoginRequest request)
        {

            var loginUrl = "https://ppgsecurity-test.birlesikodeme.com:55002/api/ppg/Securities/authenticationMerchan";
            var client = new RestClient("https://ppgsecurity-test.birlesikodeme.com:55002/api/ppg/Securities/authenticationMerchant");

            var req = new RestRequest(loginUrl, Method.Post);
            req.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(request);

            req.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = client.Execute(req);

            var responseJson = JsonConvert.DeserializeObject<LoginResponse>(response.Content);

            return responseJson;

        }
    }
}
