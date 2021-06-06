
namespace ProyectoFinal.VISTA
{
    partial class FrmMPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuPrincial = new System.Windows.Forms.Panel();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btmAlumos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenuPrincial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registros";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 433);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenuPrincial
            // 
            this.panelMenuPrincial.BackColor = System.Drawing.Color.White;
            this.panelMenuPrincial.Controls.Add(this.btnCuenta);
            this.panelMenuPrincial.Controls.Add(this.btnDocentes);
            this.panelMenuPrincial.Controls.Add(this.btnMatricula);
            this.panelMenuPrincial.Controls.Add(this.btmAlumos);
            this.panelMenuPrincial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuPrincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuPrincial.Location = new System.Drawing.Point(269, 0);
            this.panelMenuPrincial.Name = "panelMenuPrincial";
            this.panelMenuPrincial.Size = new System.Drawing.Size(643, 433);
            this.panelMenuPrincial.TabIndex = 3;
            // 
            // btnCuenta
            // 
            this.btnCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCuenta.Image")));
            this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCuenta.Location = new System.Drawing.Point(349, 265);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(161, 126);
            this.btnCuenta.TabIndex = 3;
            this.btnCuenta.Text = "Cuentas";
            this.btnCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnDocentes.Image")));
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDocentes.Location = new System.Drawing.Point(349, 69);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(161, 126);
            this.btnDocentes.TabIndex = 2;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDocentes.UseVisualStyleBackColor = false;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnMatricula.Image")));
            this.btnMatricula.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMatricula.Location = new System.Drawing.Point(126, 265);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(161, 126);
            this.btnMatricula.TabIndex = 1;
            this.btnMatricula.Text = "Matricula";
            this.btnMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatriculas_Click);
            // 
            // btmAlumos
            // 
            this.btmAlumos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmAlumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.btmAlumos.FlatAppearance.BorderSize = 0;
            this.btmAlumos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btmAlumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btmAlumos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAlumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAlumos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmAlumos.Image = ((System.Drawing.Image)(resources.GetObject("btmAlumos.Image")));
            this.btmAlumos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmAlumos.Location = new System.Drawing.Point(126, 69);
            this.btmAlumos.Name = "btmAlumos";
            this.btmAlumos.Size = new System.Drawing.Size(161, 126);
            this.btmAlumos.TabIndex = 0;
            this.btmAlumos.Text = "Alumnos";
            this.btmAlumos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btmAlumos.UseVisualStyleBackColor = false;
            this.btmAlumos.Click += new System.EventHandler(this.btmAlumos_Click);
            // 
            // FrmMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 433);
            this.Controls.Add(this.panelMenuPrincial);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMPrincipal";
            this.Text = "FrmMPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenuPrincial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenuPrincial;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btmAlumos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCuenta;
    }
}