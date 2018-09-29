using FreshPros.Commons.Objects.Account;

namespace FreshPros.Commons.Interfaces
{
    public interface IAccountRepository
    {
        AccountToken login(Login param);
    }
}