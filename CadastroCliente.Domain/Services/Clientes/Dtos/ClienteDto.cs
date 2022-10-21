﻿using CadastroCliente.Domain.Enums;
using CadastroCliente.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Domain.Services.Clientes.Dtos
{
    public class ClienteDto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatório")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Cpf é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Address é obrigatório")]
        public Address Address { get; set; }

        [Required(ErrorMessage = "Sexo é obrigatório")]
        public ESexo Sexo { get; set; }
    }
}
