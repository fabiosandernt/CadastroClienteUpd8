using CadastroCliente.Domain.Entities;
using CadastroCliente.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Domain.Projections
{
    public static class ClienteProjections
    {
        public static IEnumerable<ClienteViewModel> ToVm(this IEnumerable<Cliente> clientes) => clientes.Select(c => new ClienteViewModel
        {
            Id = c.Id,
            Nome = c.Nome,
            Sexo = c.Sexo,
            BirthDate = c.BirthDate,
            Address = c.Address,
            Cpf = c.Cpf
        });
    }
}
