using Refit;
using System.Threading.Tasks;

namespace Consuming_Api_Rest_Cep
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
