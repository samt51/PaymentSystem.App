using PaymentSystem.Core.Dtos.Customer.Response;

namespace PaymentSystem.Core.Dtos.Transaction.Response
{
    public class TransactionResponse
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public CustomerResponse customerResponse { get; set; }
        public int OrderId { get; set; }
        public int TypeId { get; set; }
        public string Amount { get; set; }
        public string CardPan { get; set; }
        public string ResponseCode { get; set; }
        public int Status { get; set; }
    }
}
