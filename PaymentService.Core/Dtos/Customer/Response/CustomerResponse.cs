namespace PaymentSystem.Core.Dtos.Customer.Response
{
    public class CustomerResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string IdentityNo { get; set; }
        public string IdentityNoVerified { get; set; }
        public int Status { get; set; }
    }
}
