namespace PaymentSystem.Core.Dtos
{
    public class PaymentHashRequest
    {
      /// <summary>
      /// ApiKey bilgisi
      /// </summary>
        public string HashPassword { get; set; }
        public string UserCode { get; set; }
        public string Rnd { get; set; }
        public string TxnType { get; set; }
        public string TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string OkUrl { get; set; }
        public string FailUrl { get; set; }
    }
}
