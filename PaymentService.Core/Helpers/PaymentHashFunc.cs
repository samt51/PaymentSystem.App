using PaymentSystem.Core.Dtos;

namespace PaymentSystem.Core.Helpers
{
    public class PaymentHashFunc
    {
        public static string CreateHash(PaymentHashRequest request)

        {

            var hashString = $"{request.HashPassword}{request.UserCode}{request.Rnd}{request.TxnType}{request.TotalAmount}{ request.CustomerId}{ request.OrderId}";

System.Security.Cryptography.SHA512 s512 = System.Security.Cryptography.SHA512.Create();

            System.Text.UnicodeEncoding ByteConverter = new System.Text.UnicodeEncoding();

            byte[] bytes = s512.ComputeHash(ByteConverter.GetBytes(hashString));
            var hash = System.BitConverter.ToString(bytes).Replace("-", "");
            return hash;

        }

    }
}
