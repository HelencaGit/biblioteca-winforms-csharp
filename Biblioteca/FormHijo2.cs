using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormHijo2 : Form
    {

        public FormHijo2()
        {
            InitializeComponent(); 
        }

        private void FormHijo2_Load(object sender, EventArgs e)
        {
            ArrayList libros = FormPadre.Biblioteca;
            foreach (Libro libro in libros)
            {
                listBoxTituloConsulta.Items.Add(libro.titulo);
            }
        }

        private void listBoxTituloConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Del listBox que tiene los títulos, se obtiene el que han hecho click y de el nombre.
            Le concatenamos .jpg porque asi tendremos el nombre completo de la imagen a buscar en la carpeta.
            */
            string nombreImagen = listBoxTituloConsulta.SelectedItem.ToString() + ".jpg";

            string rutaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes");
            string rutaFinal = Path.Combine(rutaImagenes, nombreImagen);

            Image fotoLibroElegido = Image.FromFile(rutaFinal);
            pcBHijo2.Image = fotoLibroElegido;

        }

        private void comprobarCheckado(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                if (radioButton.Name == "rdButtonAutorConsulta")
                {
                    //Si estamos aquí ordenamos por autor
                    ArrayList libros = FormPadre.Biblioteca;
                    listBoxAutorEditorialConsulta.Items.Clear();
                    foreach (Libro libro in libros)
                    {
                        listBoxAutorEditorialConsulta.Items.Add(libro.autor);
                    }
                }
                else
                {
                    //Si estamos aquí ordenamos por editorial
                    ArrayList libros = FormPadre.Biblioteca;
                    listBoxAutorEditorialConsulta.Items.Clear();
                    foreach (Libro libro in libros)
                    {
                        listBoxAutorEditorialConsulta.Items.Add(libro.editorial);
                    }
                }
            }
        }
    }
}
