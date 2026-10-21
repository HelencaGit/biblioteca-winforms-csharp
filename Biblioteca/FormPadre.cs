using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormPadre : Form
    {

        //coleccion tienen que verla los dos hijos (sera statica en el padre o en los hijos q lo hereden)
        static internal ArrayList Biblioteca { get; set; } = new ArrayList();// internal es q se puede usar en cualquier sitio del proyecto
        public FormPadre()
        {
            InitializeComponent();
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHijo1 f = new FormHijo1();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHijo2 f = new FormHijo2();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;//que aparezca igual de grande que el padre
            f.Show();
        }
        /*
        private void organizarHijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);//organiza los hijos en un mosaico horizontal
        }
        */

        /*
        private void recorrerhijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {//sólo salen los hijos del padre
                MessageBox.Show(f.GetType().Name);//metodo que me dice de que tipo son los formularios creados
            }
            
            foreach (Form f in Application.OpenForms)//salen todos los formularios de la app
            {
                MessageBox.Show(f.GetType().Name);//metodo que me dice de que tipo son los formularios creados

            }
            
        }*/

        //hora
        private void HoraTick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Hora actual: " + DateTime.Now.ToString("HH:mm:ss");
        }

        //click de salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Para la "X"
        private void FormPadre_FormClosing(object sender, FormClosingEventArgs e) {
            
            DialogResult resultado = MessageBox.Show("¿Desea realmente salir?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre
            }

        }
    }
}
