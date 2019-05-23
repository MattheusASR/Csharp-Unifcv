using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula16_10.Models
{
    public enum Uf
    {
        AC, AL, AM, AP, BA, CE, DF, ES, GO, MA, MG, MS, MT, PA, PB, PE, PI, PR, RJ, RN, RO, RR, RS, SC, SE, SP,TO
    }
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Fone { get; set; }
        public string Endereço { get; set; }
        public string Bairro { get; set; }
        public int CidadeID { get; set; }
        public Uf? Uf { get; set; }
        public string Cep { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}