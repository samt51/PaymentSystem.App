using Newtonsoft.Json;
using PaymentSystem.Core.Dtos.Payzee.Request;
using PaymentSystem.Core.ResponseModel.PayzeeResponses;
using RestSharp;

namespace PaymentSystem.Core.ExternalServices.PayzeeServices
{
    public class PaymentService
    {
        public static PaymentResponse PaymentResponse(PaymentRequest request, string accessToken)
        {
            var address = "https://ppgpayment-test.birlesikodeme.com:20000/api/ppg/Payment/NoneSecurePayment";
            var client = new RestClient("https://ppgpayment-test.birlesikodeme.com:20000/api/ppg/Payment/NoneSecurePayment");

            var req = new RestRequest(address, Method.Post);
            req.AddHeader("Authorization", "Bearer " + accessToken);
            req.AddHeader("Content-Type", "application/json");



            var body = JsonConvert.SerializeObject(request);
            req.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = client.Execute(req);

            var responseJson = JsonConvert.DeserializeObject<PaymentResponse>(response.Content);

            return responseJson;
        }
    }
}
