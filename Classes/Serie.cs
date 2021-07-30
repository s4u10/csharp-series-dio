using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atricutos

        private Genero Genero { get; set; }
        private string Tritulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set;}

        // Método

        public Serie(int Id, Genero genero, string Tritulo, string Descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Tritulo = Tritulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            // Environment.NewLine http://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Tritulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            retorno += "Excluida: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Tritulo;
        }
        public int retornaId()
        {
            return this.Id;
        }

         public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}