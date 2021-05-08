
namespace ProyectoFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdminsitrador = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(158, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "CÓMO QUIERES INICIAR SECIÓN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnProfesor);
            this.panel2.Location = new System.Drawing.Point(395, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 314);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnProfesor
            // 
            this.btnProfesor.FlatAppearance.BorderSize = 0;
            this.btnProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProfesor.Location = new System.Drawing.Point(3, 263);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(280, 48);
            this.btnProfesor.TabIndex = 0;
            this.btnProfesor.Text = "PROFESOR";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAdminsitrador);
            this.panel1.Location = new System.Drawing.Point(83, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 314);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdminsitrador
            // 
            this.btnAdminsitrador.FlatAppearance.BorderSize = 0;
            this.btnAdminsitrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdminsitrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAdminsitrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminsitrador.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminsitrador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdminsitrador.Location = new System.Drawing.Point(3, 263);
            this.btnAdminsitrador.Name = "btnAdminsitrador";
            this.btnAdminsitrador.Size = new System.Drawing.Size(270, 48);
            this.btnAdminsitrador.TabIndex = 3;
            this.btnAdminsitrador.Text = "ADMINISTRADOR";
            this.btnAdminsitrador.UseVisualStyleBackColor = true;
            this.btnAdminsitrador.Click += new System.EventHandler(this.btnAdminsitrador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(737, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdminsitrador;
    }
}

