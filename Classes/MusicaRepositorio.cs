using System;
using System.Collections.Generic;
using CAD.Musicas.Interfaces;

namespace CAD.Musicas.Classes
{
    public class MusicaRepositorio : IRepositorio<Musica>
    {
        private List<Musica> listaMusica =  new List<Musica>();
        public void Atualizar(int id, Musica entidade)
        {
            listaMusica[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaMusica[id].Excluir();
        }

        public void Insere(Musica entrada)
        {
            listaMusica.Add(entrada);
        }

        public List<Musica> Lista()
        {
            return listaMusica;
        }

        public int ProximoId()
        {
            return listaMusica.Count;
        }

        public Musica RetornaPorId(int id)
        {
            return listaMusica[id];
        }
    }
}