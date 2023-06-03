namespace PaymentSystem.Core.ResponseModel.PayzeeResponses
{
    public class PaymentResponse
    {

        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public string orderId { get; set; }
        public string txnType { get; set; }
        public string txnStatus { get; set; }
        public int vposId { get; set; }
        public string vposName { get; set; }
        public string authCode { get; set; }
        public string hostReference { get; set; }
        public string totalAmount { get; set; }
    }
    public class Root
    {
        public bool fail { get; set; }
        public int statusCode { get; set; }
        public PaymentResponse result { get; set; }
    }
}
