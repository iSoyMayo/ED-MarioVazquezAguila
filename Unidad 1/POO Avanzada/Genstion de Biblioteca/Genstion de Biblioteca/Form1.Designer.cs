namespace Genstion_de_Biblioteca
{
    partial class Form1
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
            this.dtgPrestamos = new System.Windows.Forms.DataGridView();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cbDevolucion = new System.Windows.Forms.CheckBox();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPrestamos
            // 
            this.dtgPrestamos.AllowUserToAddRows = false;
            this.dtgPrestamos.AllowUserToDeleteRows = false;
            this.dtgPrestamos.AllowUserToResizeColumns = false;
            this.dtgPrestamos.AllowUserToResizeRows = false;
            this.dtgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.isbn,
            this.IdUsuario,
            this.Usuario,
            this.Devolucion});
            this.dtgPrestamos.Location = new System.Drawing.Point(12, 12);
            this.dtgPrestamos.Name = "dtgPrestamos";
            this.dtgPrestamos.ReadOnly = true;
            this.dtgPrestamos.Size = new System.Drawing.Size(665, 359);
            this.dtgPrestamos.TabIndex = 0;
            this.dtgPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrestamos_CellContentClick);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(10, 65);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(683, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Libro";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(13, 39);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(155, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(13, 78);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(155, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(13, 117);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(155, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombreUsuario);
            this.groupBox2.Controls.Add(this.txtidUsuario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblNombreUsuario);
            this.groupBox2.Location = new System.Drawing.Point(683, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 120);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IdUsuario";
            // 
            // txtidUsuario
            // 
            this.txtidUsuario.Location = new System.Drawing.Point(13, 42);
            this.txtidUsuario.Name = "txtidUsuario";
            this.txtidUsuario.Size = new System.Drawing.Size(155, 20);
            this.txtidUsuario.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(13, 81);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(155, 20);
            this.txtNombreUsuario.TabIndex = 9;
            // 
            // cbDevolucion
            // 
            this.cbDevolucion.AutoSize = true;
            this.cbDevolucion.Location = new System.Drawing.Point(683, 309);
            this.cbDevolucion.Name = "cbDevolucion";
            this.cbDevolucion.Size = new System.Drawing.Size(123, 17);
            this.cbDevolucion.TabIndex = 7;
            this.cbDevolucion.Text = "Devolucion del Libro";
            this.cbDevolucion.UseVisualStyleBackColor = true;
            this.cbDevolucion.CheckedChanged += new System.EventHandler(this.cbDevolucion_CheckedChanged);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(683, 332);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(93, 36);
            this.btnPrestar.TabIndex = 8;
            this.btnPrestar.Text = "Registar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "NumControl";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Devolucion
            // 
            this.Devolucion.HeaderText = "Devuelto";
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.ReadOnly = true;
            this.Devolucion.Width = 60;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(782, 332);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 36);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 380);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.cbDevolucion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilbioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrestamos;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtidUsuario;
        private System.Windows.Forms.CheckBox cbDevolucion;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Devolucion;
        private System.Windows.Forms.Button btnListar;
    }
}

