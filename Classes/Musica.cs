using System;

namespace CAD.Musicas
{
    public class Musica : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Nome { get; set; }
        private string Artista { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get;set;}
        public Musica(int Id, Genero genero, string nome, string artista, int ano)
        {
            this.Genero = genero;
            this.Nome = nome;
            this.Artista = artista;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero :" + this.Genero + Environment.NewLine;
            retorno += "Nome :" + this.Nome + Environment.NewLine;
            retorno += "Artista :" + this.Artista + Environment.NewLine;
            retorno += "Ano de lançamento :" + this.Ano;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string RetornaNomeMusica (){
            return this.Nome;
        }
        public int retornaIdMusica(){
            return this.Id;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }

}