namespace PaymentSystem.Core.Dtos.Payzee.Request
{
    public class LoginRequest
    {
        public string ApiKey { get; set; }
        public string Email { get; set; }
        public string Lang { get; set; }
    }
}
