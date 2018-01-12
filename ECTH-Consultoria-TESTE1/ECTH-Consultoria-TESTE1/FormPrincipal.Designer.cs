namespace ECTH_Consultoria_TESTE1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgListar = new System.Windows.Forms.DataGridView();
            this.btListar = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListar
            // 
            this.dgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListar.Location = new System.Drawing.Point(14, 103);
            this.dgListar.Name = "dgListar";
            this.dgListar.Size = new System.Drawing.Size(894, 379);
            this.dgListar.TabIndex = 0;
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(833, 29);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 23);
            this.btListar.TabIndex = 1;
            this.btListar.Text = "Listar";
            this.btListar.UseSelectable = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(479, 29);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(170, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 517);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.dgListar);
            this.Name = "FormPrincipal";
            this.Text = "Drenagem Superficial Fernao Dias";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListar;
        private MetroFramework.Controls.MetroButton btListar;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}

