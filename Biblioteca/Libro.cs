using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        public String titulo {  get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public bool esNuevo { get; set; }
        public Image portada { get; set; }

        public Libro() { }

        public Libro(string titulo, string autor, string editorial, bool esNuevo, Image portada)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.esNuevo = esNuevo;
            this.portada = portada;
        }
    }
}
