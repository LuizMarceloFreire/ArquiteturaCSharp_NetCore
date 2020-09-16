using SOLID._1___SRP.Repositorio;
using SOLID._1___SRP.SRP.Solucao;

namespace SOLID._1___SRP.Services
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados invalidos";

            var repositorio = new ClienteRepository();
            repositorio.AdicionarCliente(cliente);

            EmailService.Enviar("luiz@gmail.com", cliente.Email.Endereco, "Bem vindo", "Parabéns! Você está cadastrado");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
