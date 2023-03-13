using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    public class Livros : EntidadeBase
    {
        public Genero Genero { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Ano { get; private set; }
        public int Paginas { get; private set; }
        public string Autor {get; private set;}
        public bool Excluido { get; private set;}

        public Livros(int id, Genero genero, string Titulo, string descricao, int ano, int paginas, string autor)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Paginas = paginas;
            this.Autor = autor;
         }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero" + this.Genero + Environment.NewLine;
            retorno += "Título" + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento" + this.Ano + Environment.NewLine;
            retorno += "Total de páginas" + this.Paginas + Environment.NewLine;
            retorno += "Nome do Autor" + this.Autor + Environment.NewLine;

            return retorno;
            
        }

        private string retornaTitulo()
        {
            return this.Titulo;
        }

        private int retornaId()
        {
            return this.Id;
        }
    }
}
