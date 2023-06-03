namespace PaymentSystem.Core.Dtos.Payzee.Request
{
    public class PaymentRequest
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Lang { get; set; }
        public string ApiKey { get; set; }
        public int MerchantId { get; set; }
        public int MemberId { get; set; }
    }
}
