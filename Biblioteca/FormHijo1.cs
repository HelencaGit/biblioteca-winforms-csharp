using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace Biblioteca
{
    public partial class FormHijo1 : Form
    {
        public FormHijo1()
        {
            InitializeComponent();
        }

        //Botón para cargar una foto
        private void btnCargarFotoClick(object sender, EventArgs e)
        {   
            //para cargar la foto
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Imágenes (*.jpg)|*.jpg|Todos los ficheros (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();

            //para mostrar la imagen
            Bitmap imagen = new Bitmap (openFileDialog1.FileName);
            pcBoxFotoPortada.Image = imagen;

        }

        // Botón: Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbTitulo.Text = "";
            tbAutor.Text = "";
            tbEditorial.Text = "";
            chkBNuevo.Checked = false;
            pcBoxFotoPortada.Image = null;
        }

        // Botón: Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro nuevoLibro = new Libro {

                 titulo = tbTitulo.Text.Trim(), //Trim elimina los espacios al principio y al final
                 autor = tbAutor.Text.Trim(),
                 editorial = tbEditorial.Text.Trim(),
                 esNuevo = chkBNuevo.Checked,//verifica si el checkBox dice que es nuevo o no el libro
                 portada = pcBoxFotoPortada.Image,//obtiene la imagen que fue cargada
            };

            //verificar que los 3 campos no esten nulos sino mandar un mensage
            if (string.IsNullOrEmpty(nuevoLibro.titulo) || string.IsNullOrEmpty(nuevoLibro.autor) || string.IsNullOrEmpty(nuevoLibro.editorial) || nuevoLibro.portada==null)
            {
                MessageBox.Show("Por favor, completa todos los campos. Y rellena la foto.");//Opcional poner tambien "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning
                return;
            }

            //lo añadimos a la lista del formulario padre
            FormPadre.Biblioteca.Add(nuevoLibro);

            guardarPortadaFisicamente(nuevoLibro);

            // Si todo va bien muestra un mensaje de que todo está bien. (Necesito guardar los datos en una lista)
            MessageBox.Show("Libro guardado correctamente.");//Opcional poner "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information

            // Limpiar después de guardar:
            btnLimpiar_Click(sender, e);
        }

        private void guardarPortadaFisicamente(Libro libro)
        {
            //Sólo si no existe la crea, sino ya está
            string rutaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes");
            Directory.CreateDirectory(rutaImagenes);

            Image fotoLibro = libro.portada;
            string tituloLibro = libro.titulo;

            // Ruta completa
            string rutaCompleta = Path.Combine(rutaImagenes, tituloLibro+".jpg");
            fotoLibro.Save(rutaCompleta, System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Imagen guardada en: " + rutaCompleta);
        }

    }
}
