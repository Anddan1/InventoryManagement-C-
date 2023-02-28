namespace Disertatie.UI
{
    partial class Inventar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.disertatieDataSet = new Disertatie.DisertatieDataSet();
            this.disertatieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disertatieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disertatieDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // disertatieDataSet
            // 
            this.disertatieDataSet.DataSetName = "DisertatieDataSet";
            this.disertatieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disertatieDataSetBindingSource
            // 
            this.disertatieDataSetBindingSource.DataSource = this.disertatieDataSet;
            this.disertatieDataSetBindingSource.Position = 0;
            // 
            // Inventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 466);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventar";
            this.Text = "Inventar";
            this.Load += new System.EventHandler(this.Inventar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disertatieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disertatieDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource disertatieDataSetBindingSource;
        private DisertatieDataSet disertatieDataSet;
    }
}