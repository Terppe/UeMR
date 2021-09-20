using System.Threading.Tasks;

namespace UeMR.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
