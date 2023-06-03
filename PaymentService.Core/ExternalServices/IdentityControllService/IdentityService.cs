using ServiceReference1;

namespace PaymentSystem.Core.ExternalServices.IdentityControllService
{
    public class IdentityService
    {
        public static   async Task< bool> MernisControll(long identityNo,string name,string surName,int birthYear)
        {
            var mernis = new ServiceReference1.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await mernis.TCKimlikNoDogrulaAsync(identityNo, name, surName, birthYear);
            if (response.Body.TCKimlikNoDogrulaResult == true)
            {
                return true;
            }
            return false;
        }
    }
}
