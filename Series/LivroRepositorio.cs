using Series.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    public class LivroRepositorio : IRepositorio<Livros>
    {
        public List<Livros> ListaLivros = new List<Livros>();
        public void Atualiza(int id, Livros entidade)
        {
            listaLivros[id] = entidade;
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Livros entidade)
        {
            throw new NotImplementedException();
        }

        public List<Livros> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Livros RetornarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
