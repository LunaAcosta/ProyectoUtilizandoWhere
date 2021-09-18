
namespace ProyectoUtilizandoWhere
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
            this.btnClic = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnclic2 = new System.Windows.Forms.Button();
            this.lstDatos2 = new System.Windows.Forms.ListBox();
            this.btnClic3 = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClic
            // 
            this.btnClic.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClic.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClic.Location = new System.Drawing.Point(295, 37);
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(228, 29);
            this.btnClic.TabIndex = 0;
            this.btnClic.Text = "Mostrar Elementos < 5 De la lista";
            this.btnClic.UseVisualStyleBackColor = false;
            this.btnClic.Click += new System.EventHandler(this.btnClic_Click);
            // 
            // lstData
            // 
            this.lstData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(352, 88);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(120, 186);
            this.lstData.TabIndex = 1;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // btnclic2
            // 
            this.btnclic2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclic2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnclic2.Location = new System.Drawing.Point(550, 37);
            this.btnclic2.Name = "btnclic2";
            this.btnclic2.Size = new System.Drawing.Size(228, 29);
            this.btnclic2.TabIndex = 2;
            this.btnclic2.Text = "Mostrar Numeros Pares";
            this.btnclic2.UseVisualStyleBackColor = false;
            this.btnclic2.Click += new System.EventHandler(this.btnclic2_Click);
            // 
            // lstDatos2
            // 
            this.lstDatos2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstDatos2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstDatos2.FormattingEnabled = true;
            this.lstDatos2.Location = new System.Drawing.Point(612, 88);
            this.lstDatos2.Name = "lstDatos2";
            this.lstDatos2.Size = new System.Drawing.Size(120, 186);
            this.lstDatos2.TabIndex = 3;
            // 
            // btnClic3
            // 
            this.btnClic3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClic3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClic3.Location = new System.Drawing.Point(34, 37);
            this.btnClic3.Name = "btnClic3";
            this.btnClic3.Size = new System.Drawing.Size(228, 29);
            this.btnClic3.TabIndex = 4;
            this.btnClic3.Text = "Mostrar Lista";
            this.btnClic3.UseVisualStyleBackColor = false;
            this.btnClic3.Click += new System.EventHandler(this.btnClic3_Click);
            // 
            // lstLista
            // 
            this.lstLista.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstLista.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(87, 88);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(120, 186);
            this.lstLista.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnClic3);
            this.Controls.Add(this.lstDatos2);
            this.Controls.Add(this.btnclic2);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnClic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClic;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnclic2;
        private System.Windows.Forms.ListBox lstDatos2;
        private System.Windows.Forms.Button btnClic3;
        private System.Windows.Forms.ListBox lstLista;
    }
}

