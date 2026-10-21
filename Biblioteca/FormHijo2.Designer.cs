namespace Biblioteca
{
    partial class FormHijo2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbTituloConsulta = new System.Windows.Forms.Label();
            this.lbAutorEditorialConsulta = new System.Windows.Forms.Label();
            this.lbFotoPortadaConsulta = new System.Windows.Forms.Label();
            this.gpBTipoConsulta = new System.Windows.Forms.GroupBox();
            this.rdButtonEditorialConsulta = new System.Windows.Forms.RadioButton();
            this.rdButtonAutorConsulta = new System.Windows.Forms.RadioButton();
            this.listBoxTituloConsulta = new System.Windows.Forms.ListBox();
            this.listBoxAutorEditorialConsulta = new System.Windows.Forms.ListBox();
            this.pcBHijo2 = new System.Windows.Forms.PictureBox();
            this.gpBTipoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBHijo2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbTituloConsulta
            // 
            this.lbTituloConsulta.AutoSize = true;
            this.lbTituloConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloConsulta.Location = new System.Drawing.Point(69, 231);
            this.lbTituloConsulta.Name = "lbTituloConsulta";
            this.lbTituloConsulta.Size = new System.Drawing.Size(56, 20);
            this.lbTituloConsulta.TabIndex = 1;
            this.lbTituloConsulta.Text = "Título";
            // 
            // lbAutorEditorialConsulta
            // 
            this.lbAutorEditorialConsulta.AutoSize = true;
            this.lbAutorEditorialConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutorEditorialConsulta.Location = new System.Drawing.Point(373, 231);
            this.lbAutorEditorialConsulta.Name = "lbAutorEditorialConsulta";
            this.lbAutorEditorialConsulta.Size = new System.Drawing.Size(142, 20);
            this.lbAutorEditorialConsulta.TabIndex = 2;
            this.lbAutorEditorialConsulta.Text = "Autor / Editorial";
            // 
            // lbFotoPortadaConsulta
            // 
            this.lbFotoPortadaConsulta.AutoSize = true;
            this.lbFotoPortadaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFotoPortadaConsulta.Location = new System.Drawing.Point(677, 231);
            this.lbFotoPortadaConsulta.Name = "lbFotoPortadaConsulta";
            this.lbFotoPortadaConsulta.Size = new System.Drawing.Size(117, 20);
            this.lbFotoPortadaConsulta.TabIndex = 3;
            this.lbFotoPortadaConsulta.Text = "Foto Portada";
            // 
            // gpBTipoConsulta
            // 
            this.gpBTipoConsulta.Controls.Add(this.rdButtonEditorialConsulta);
            this.gpBTipoConsulta.Controls.Add(this.rdButtonAutorConsulta);
            this.gpBTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBTipoConsulta.Location = new System.Drawing.Point(71, 65);
            this.gpBTipoConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBTipoConsulta.Name = "gpBTipoConsulta";
            this.gpBTipoConsulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBTipoConsulta.Size = new System.Drawing.Size(401, 110);
            this.gpBTipoConsulta.TabIndex = 4;
            this.gpBTipoConsulta.TabStop = false;
            this.gpBTipoConsulta.Text = "Tipo Consulta";
            // 
            // rdButtonEditorialConsulta
            // 
            this.rdButtonEditorialConsulta.AutoSize = true;
            this.rdButtonEditorialConsulta.Location = new System.Drawing.Point(31, 69);
            this.rdButtonEditorialConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdButtonEditorialConsulta.Name = "rdButtonEditorialConsulta";
            this.rdButtonEditorialConsulta.Size = new System.Drawing.Size(100, 24);
            this.rdButtonEditorialConsulta.TabIndex = 1;
            this.rdButtonEditorialConsulta.TabStop = true;
            this.rdButtonEditorialConsulta.Text = "Editorial";
            this.rdButtonEditorialConsulta.UseVisualStyleBackColor = true;
            this.rdButtonEditorialConsulta.CheckedChanged += new System.EventHandler(this.comprobarCheckado);
            // 
            // rdButtonAutorConsulta
            // 
            this.rdButtonAutorConsulta.AutoSize = true;
            this.rdButtonAutorConsulta.Location = new System.Drawing.Point(31, 38);
            this.rdButtonAutorConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdButtonAutorConsulta.Name = "rdButtonAutorConsulta";
            this.rdButtonAutorConsulta.Size = new System.Drawing.Size(75, 24);
            this.rdButtonAutorConsulta.TabIndex = 0;
            this.rdButtonAutorConsulta.TabStop = true;
            this.rdButtonAutorConsulta.Text = "Autor";
            this.rdButtonAutorConsulta.UseVisualStyleBackColor = true;
            this.rdButtonAutorConsulta.CheckedChanged += new System.EventHandler(this.comprobarCheckado);
            // 
            // listBoxTituloConsulta
            // 
            this.listBoxTituloConsulta.FormattingEnabled = true;
            this.listBoxTituloConsulta.ItemHeight = 16;
            this.listBoxTituloConsulta.Location = new System.Drawing.Point(61, 282);
            this.listBoxTituloConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTituloConsulta.Name = "listBoxTituloConsulta";
            this.listBoxTituloConsulta.Size = new System.Drawing.Size(191, 228);
            this.listBoxTituloConsulta.TabIndex = 5;
            this.listBoxTituloConsulta.SelectedIndexChanged += new System.EventHandler(this.listBoxTituloConsulta_SelectedIndexChanged);
            // 
            // listBoxAutorEditorialConsulta
            // 
            this.listBoxAutorEditorialConsulta.FormattingEnabled = true;
            this.listBoxAutorEditorialConsulta.ItemHeight = 16;
            this.listBoxAutorEditorialConsulta.Location = new System.Drawing.Point(347, 282);
            this.listBoxAutorEditorialConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAutorEditorialConsulta.Name = "listBoxAutorEditorialConsulta";
            this.listBoxAutorEditorialConsulta.Size = new System.Drawing.Size(201, 228);
            this.listBoxAutorEditorialConsulta.TabIndex = 6;
            // 
            // pcBHijo2
            // 
            this.pcBHijo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcBHijo2.Location = new System.Drawing.Point(681, 282);
            this.pcBHijo2.Name = "pcBHijo2";
            this.pcBHijo2.Size = new System.Drawing.Size(146, 228);
            this.pcBHijo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBHijo2.TabIndex = 7;
            this.pcBHijo2.TabStop = false;
            // 
            // FormHijo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.pcBHijo2);
            this.Controls.Add(this.listBoxAutorEditorialConsulta);
            this.Controls.Add(this.listBoxTituloConsulta);
            this.Controls.Add(this.gpBTipoConsulta);
            this.Controls.Add(this.lbFotoPortadaConsulta);
            this.Controls.Add(this.lbAutorEditorialConsulta);
            this.Controls.Add(this.lbTituloConsulta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHijo2";
            this.Text = "Consulta de Libros";
            this.Load += new System.EventHandler(this.FormHijo2_Load);
            this.gpBTipoConsulta.ResumeLayout(false);
            this.gpBTipoConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBHijo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbTituloConsulta;
        private System.Windows.Forms.Label lbAutorEditorialConsulta;
        private System.Windows.Forms.Label lbFotoPortadaConsulta;
        private System.Windows.Forms.GroupBox gpBTipoConsulta;
        private System.Windows.Forms.RadioButton rdButtonEditorialConsulta;
        private System.Windows.Forms.RadioButton rdButtonAutorConsulta;
        private System.Windows.Forms.ListBox listBoxTituloConsulta;
        private System.Windows.Forms.ListBox listBoxAutorEditorialConsulta;
        private System.Windows.Forms.PictureBox pcBHijo2;
    }
}