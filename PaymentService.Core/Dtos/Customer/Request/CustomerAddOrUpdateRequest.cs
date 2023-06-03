namespace PaymentSystem.Core.Dtos.Customer.Request
{
    public class CustomerAddOrUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public long IdentityNo { get; set; }
        public string IdentityNoVerified { get; set; }
        public int Status { get; set; }
    }
}
