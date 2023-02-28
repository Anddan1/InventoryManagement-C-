namespace Disertatie
{
    partial class Produs
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
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.grdProd = new System.Windows.Forms.DataGridView();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(51, 163);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(293, 20);
            this.txtDenumire.TabIndex = 0;
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(51, 250);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(293, 20);
            this.txtUM.TabIndex = 2;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnAdauga.FlatAppearance.BorderSize = 0;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdauga.Location = new System.Drawing.Point(51, 498);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(293, 29);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnActualizare.FlatAppearance.BorderSize = 0;
            this.btnActualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizare.Location = new System.Drawing.Point(538, 498);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(293, 29);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // grdProd
            // 
            this.grdProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProd.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdProd.Location = new System.Drawing.Point(390, 163);
            this.grdProd.Name = "grdProd";
            this.grdProd.Size = new System.Drawing.Size(588, 256);
            this.grdProd.TabIndex = 18;
            this.grdProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProd_CellDoubleClick);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(538, 128);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(293, 20);
            this.txtCautare.TabIndex = 19;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(51, 314);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(293, 105);
            this.txtDescriere.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Unitate De Masura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(469, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cautare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(48, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Descriere";
            // 
            // Produs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.grdProd);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Produs";
            this.Text = "Produs";
            this.Load += new System.EventHandler(this.Produs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.DataGridView grdProd;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}