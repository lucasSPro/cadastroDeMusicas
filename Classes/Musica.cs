using System;

namespace CAD.Musicas
{
    public class Musica : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        public Musica(int Id, Genero genero, string nome, string descricao, int ano)
        {
            this.Genero = genero;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Ano = ano;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero :" + this.Genero + Environment.NewLine;
            retorno += "Nome :" + this.Nome + Environment.NewLine;
            retorno += "Artista :" + this.Descricao + Environment.NewLine;
            retorno += "Ano de lançamento :" + this.Ano;
            return retorno;
        }

        public string RetornaNomeMusica (){
            return this.Nome;
        }
        public int retornaIdMusica(){
            return this.Id;
        }
    }

}