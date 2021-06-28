using Refit;
using System;
using System.Threading.Tasks;

namespace Consuming_Api_Rest_Cep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
                Console.WriteLine("Informe o seu cep");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informações do CEP: " + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);
               
                Console.WriteLine($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}\nCidade:{address.Localidade}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de CEP " + e.Message);
            }
        }
    }
}
