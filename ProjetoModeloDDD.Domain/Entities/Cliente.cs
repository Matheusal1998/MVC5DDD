﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DateCadastro { get; set; }
        public bool Ativo { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DateCadastro.Year >= 5 
        }
    }
}
