namespace Biblioteca
{
    partial class FormHijo1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbEditorial = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbEditorial = new System.Windows.Forms.Label();
            this.lbNuevo = new System.Windows.Forms.Label();
            this.lbFotoPortada = new System.Windows.Forms.Label();
            this.chkBNuevo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pcBoxFotoPortada = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFotoPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(42, 85);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(49, 17);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Título";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(136, 85);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTitulo.Multiline = true;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(125, 29);
            this.tbTitulo.TabIndex = 1;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(136, 128);
            this.tbAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAutor.Multiline = true;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(125, 27);
            this.tbAutor.TabIndex = 2;
            // 
            // tbEditorial
            // 
            this.tbEditorial.Location = new System.Drawing.Point(136, 172);
            this.tbEditorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEditorial.Multiline = true;
            this.tbEditorial.Name = "tbEditorial";
            this.tbEditorial.Size = new System.Drawing.Size(125, 28);
            this.tbEditorial.TabIndex = 3;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(44, 128);
            this.lbAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(47, 17);
            this.lbAutor.TabIndex = 4;
            this.lbAutor.Text = "Autor";
            // 
            // lbEditorial
            // 
            this.lbEditorial.AutoSize = true;
            this.lbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditorial.Location = new System.Drawing.Point(42, 172);
            this.lbEditorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(68, 17);
            this.lbEditorial.TabIndex = 5;
            this.lbEditorial.Text = "Editorial";
            // 
            // lbNuevo
            // 
            this.lbNuevo.AutoSize = true;
            this.lbNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevo.Location = new System.Drawing.Point(44, 228);
            this.lbNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNuevo.Name = "lbNuevo";
            this.lbNuevo.Size = new System.Drawing.Size(54, 17);
            this.lbNuevo.TabIndex = 6;
            this.lbNuevo.Text = "Nuevo";
            // 
            // lbFotoPortada
            // 
            this.lbFotoPortada.AutoSize = true;
            this.lbFotoPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFotoPortada.Location = new System.Drawing.Point(367, 54);
            this.lbFotoPortada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFotoPortada.Name = "lbFotoPortada";
            this.lbFotoPortada.Size = new System.Drawing.Size(102, 17);
            this.lbFotoPortada.TabIndex = 7;
            this.lbFotoPortada.Text = "Foto Portada";
            // 
            // chkBNuevo
            // 
            this.chkBNuevo.AutoSize = true;
            this.chkBNuevo.Location = new System.Drawing.Point(136, 228);
            this.chkBNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBNuevo.Name = "chkBNuevo";
            this.chkBNuevo.Size = new System.Drawing.Size(15, 14);
            this.chkBNuevo.TabIndex = 8;
            this.chkBNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(53, 326);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 29);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(188, 326);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(71, 29);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFoto.Location = new System.Drawing.Point(370, 326);
            this.btnCargarFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(96, 28);
            this.btnCargarFoto.TabIndex = 11;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFotoClick);
            // 
            // pcBoxFotoPortada
            // 
            this.pcBoxFotoPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcBoxFotoPortada.Location = new System.Drawing.Point(361, 102);
            this.pcBoxFotoPortada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcBoxFotoPortada.Name = "pcBoxFotoPortada";
            this.pcBoxFotoPortada.Size = new System.Drawing.Size(110, 152);
            this.pcBoxFotoPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxFotoPortada.TabIndex = 12;
            this.pcBoxFotoPortada.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormHijo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 414);
            this.ControlBox = false;
            this.Controls.Add(this.pcBoxFotoPortada);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkBNuevo);
            this.Controls.Add(this.lbFotoPortada);
            this.Controls.Add(this.lbNuevo);
            this.Controls.Add(this.lbEditorial);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.tbEditorial);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHijo1";
            this.Text = "Alta de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFotoPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbEditorial;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbEditorial;
        private System.Windows.Forms.Label lbNuevo;
        private System.Windows.Forms.Label lbFotoPortada;
        private System.Windows.Forms.CheckBox chkBNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.PictureBox pcBoxFotoPortada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

