namespace CentCom.Interfaces
{
    public interface ICredentialValidationService
    {
         void Validate(string email, string password);
    }
}