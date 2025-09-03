namespace Convertir_C_a_F
{
    partial class frmInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGradosC = new System.Windows.Forms.TextBox();
            this.btnConvertir = new FontAwesome.Sharp.IconButton();
            this.txtGradosF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreser Temperatura en C";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura en F";
            // 
            // txtGradosC
            // 
            this.txtGradosC.Location = new System.Drawing.Point(151, 24);
            this.txtGradosC.Name = "txtGradosC";
            this.txtGradosC.Size = new System.Drawing.Size(33, 20);
            this.txtGradosC.TabIndex = 2;
            // 
            // btnConvertir
            // 
            this.btnConvertir.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnConvertir.IconColor = System.Drawing.Color.Black;
            this.btnConvertir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConvertir.IconSize = 20;
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertir.Location = new System.Drawing.Point(206, 33);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(76, 25);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtGradosF
            // 
            this.txtGradosF.Location = new System.Drawing.Point(151, 54);
            this.txtGradosF.Name = "txtGradosF";
            this.txtGradosF.Size = new System.Drawing.Size(33, 20);
            this.txtGradosF.TabIndex = 4;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 88);
            this.Controls.Add(this.txtGradosF);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtGradosC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGradosC;
        private FontAwesome.Sharp.IconButton btnConvertir;
        private System.Windows.Forms.TextBox txtGradosF;
    }
}

