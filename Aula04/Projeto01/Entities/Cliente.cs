﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities.Types;

namespace Projeto01.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }

        public Cliente(){ }

        public Cliente(int idCliente, string nome, string email, Sexo sexo, EstadoCivil estadoCivil)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

        public override string ToString()
        {
            return $"IdCliente: {IdCliente}, Nome: {Nome}, Email: {Email}, Sexo: {Sexo}, Estado Civil: {EstadoCivil}";
        }
    }
}
