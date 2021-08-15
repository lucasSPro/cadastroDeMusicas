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
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Musica entrada)
        {
            throw new NotImplementedException();
        }

        public List<Musica> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Musica RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}