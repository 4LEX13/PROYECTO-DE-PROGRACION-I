
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelMenuPrincial = new System.Windows.Forms.Panel();
            this.btnClassrom = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnAulas = new System.Windows.Forms.Button();
            this.btmAlumos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMenuPrincial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = " Menú principal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 431);
            this.panel1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 225);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panelMenuPrincial
            // 
            this.panelMenuPrincial.BackColor = System.Drawing.Color.Gray;
            this.panelMenuPrincial.Controls.Add(this.btnClassrom);
            this.panelMenuPrincial.Controls.Add(this.btnDocentes);
            this.panelMenuPrincial.Controls.Add(this.btnAulas);
            this.panelMenuPrincial.Controls.Add(this.btmAlumos);
            this.panelMenuPrincial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuPrincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuPrincial.Location = new System.Drawing.Point(280, 0);
            this.panelMenuPrincial.Name = "panelMenuPrincial";
            this.panelMenuPrincial.Size = new System.Drawing.Size(439, 431);
            this.panelMenuPrincial.TabIndex = 3;
            // 
            // btnClassrom
            // 
            this.btnClassrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClassrom.BackColor = System.Drawing.Color.Silver;
            this.btnClassrom.FlatAppearance.BorderSize = 0;
            this.btnClassrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClassrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClassrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClassrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClassrom.Image = ((System.Drawing.Image)(resources.GetObject("btnClassrom.Image")));
            this.btnClassrom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClassrom.Location = new System.Drawing.Point(217, 261);
            this.btnClassrom.Name = "btnClassrom";
            this.btnClassrom.Size = new System.Drawing.Size(161, 126);
            this.btnClassrom.TabIndex = 3;
            this.btnClassrom.Text = "Classrom";
            this.btnClassrom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnClassrom.UseVisualStyleBackColor = false;
            this.btnClassrom.Click += new System.EventHandler(this.btnClassrom_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDocentes.BackColor = System.Drawing.Color.Silver;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnDocentes.Image")));
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDocentes.Location = new System.Drawing.Point(29, 261);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(161, 126);
            this.btnDocentes.TabIndex = 2;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDocentes.UseVisualStyleBackColor = false;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAulas.BackColor = System.Drawing.Color.Silver;
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAulas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAulas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAulas.Image = ((System.Drawing.Image)(resources.GetObject("btnAulas.Image")));
            this.btnAulas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAulas.Location = new System.Drawing.Point(217, 74);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(161, 126);
            this.btnAulas.TabIndex = 1;
            this.btnAulas.Text = "Aulas";
            this.btnAulas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAulas.UseVisualStyleBackColor = false;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btmAlumos
            // 
            this.btmAlumos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmAlumos.BackColor = System.Drawing.Color.Silver;
            this.btmAlumos.FlatAppearance.BorderSize = 0;
            this.btmAlumos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btmAlumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btmAlumos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAlumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAlumos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmAlumos.Image = ((System.Drawing.Image)(resources.GetObject("btmAlumos.Image")));
            this.btmAlumos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmAlumos.Location = new System.Drawing.Point(29, 74);
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
            this.ClientSize = new System.Drawing.Size(719, 431);
            this.Controls.Add(this.panelMenuPrincial);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMPrincipal";
            this.Text = "FrmMPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenuPrincial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panelMenuPrincial;
        private System.Windows.Forms.Button btnClassrom;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btmAlumos;
    }
}