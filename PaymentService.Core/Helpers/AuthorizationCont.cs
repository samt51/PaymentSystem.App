using System.IdentityModel.Tokens.Jwt;

namespace PaymentSystem.Core.Helpers
{
    public class AuthorizationCont
    {
        public static TokenKeys Authorization(string Token)
        {

            var handler = new JwtSecurityTokenHandler();
            var decodedValue = handler.ReadJwtToken(Token.Replace("Bearer ", ""));
            TokenKeys mytoken = new TokenKeys
            {
                Lang = decodedValue.Payload.Where(x => x.Key == "Lang")?.FirstOrDefault().Value.ToString(),
                Email = decodedValue.Payload.Where(x => x.Key == "Email")?.FirstOrDefault().Value.ToString(),
                UserId = decodedValue.Payload.Where(x => x.Key == "UserId")?.FirstOrDefault().Value.ToString(),
                MemberId = decodedValue.Payload.Where(x => x.Key == "MemberId")?.FirstOrDefault().Value.ToString(),
                MemberCode = decodedValue.Payload.Where(x => x.Key == "MemberCode")?.FirstOrDefault().Value.ToString(),
                MerchantId = decodedValue.Payload.Where(x => x.Key == "MerchantId")?.FirstOrDefault().Value.ToString(),
                MerchantNumber = decodedValue.Payload.Where(x => x.Key == "MerchantNumber")?.FirstOrDefault().Value.ToString(),
                UserStatus = decodedValue.Payload.Where(x => x.Key == "UserStatus")?.FirstOrDefault().Value.ToString(),
                ChangePasswordRequired = decodedValue.Payload.Where(x => x.Key == "ChangePasswordRequired")?.FirstOrDefault().Value.ToString(),
                PasswordStatus = decodedValue.Payload.Where(x => x.Key == "PasswordStatus")?.FirstOrDefault().Value.ToString(),
                UserRoles = decodedValue.Payload.Where(x => x.Key == "UserRoles")?.FirstOrDefault().Value.ToString(),
                RoleScore = decodedValue.Payload.Where(x => x.Key == "RoleScore")?.FirstOrDefault().Value.ToString(),
                TicketType = decodedValue.Payload.Where(x => x.Key == "TicketType")?.FirstOrDefault().Value.ToString(),
                UserType = decodedValue.Payload.Where(x => x.Key == "UserType")?.FirstOrDefault().Value.ToString(),
            };

            return mytoken;


        }
        public class TokenKeys
        {
            public string Lang { get; set; }
            public string Email { get; set; }
            public string UserId { get; set; }
            public string MemberId { get; set; }
            public string MemberCode { get; set; }
            public string MerchantId { get; set; }
            public string MerchantNumber { get; set; }
            public string UserStatus { get; set; }
            public string ChangePasswordRequired { get; set; }
            public string PasswordStatus { get; set; }
            public string UserRoles { get; set; }
            public string RoleScore { get; set; }
            public string TicketType { get; set; }
            public string UserType { get; set; }
        }
    }
}
