namespace PaymentSystem.Core.Dtos.Transaction.Request
{
    public class TransactionAddOrUpdateRequest
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int TypeId { get; set; }
        public string Amount { get; set; }
        public string CardPan { get; set; }
        public string ResponseCode { get; set; }
        public int Status { get; set; }
    }
}
