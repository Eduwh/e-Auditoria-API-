﻿namespace eAuditoria.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Locacao> Locacoes { get; set; }
    }
}
