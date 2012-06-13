namespace Shoppy.Views
{
    partial class SellAdminView
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtNewProdukt = new System.Windows.Forms.TextBox();
            this.txtNewPreis = new System.Windows.Forms.TextBox();
            this.txtUpdateProdukt = new System.Windows.Forms.TextBox();
            this.txtUpdatePreis = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Label();
            this.Preis = new System.Windows.Forms.Label();
            this.txtUpdateVorrat = new System.Windows.Forms.TextBox();
            this.Vorrat = new System.Windows.Forms.Label();
            this.txtNewVorrat = new System.Windows.Forms.TextBox();
            this.Produkt = new System.Windows.Forms.Label();
            this.btnUpdateSell = new System.Windows.Forms.Button();
            this.btnNewSell = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Löschen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtUpdateBarcode = new System.Windows.Forms.TextBox();
            this.txtNewBarcode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewProdukt
            // 
            this.txtNewProdukt.Location = new System.Drawing.Point(3, 143);
            this.txtNewProdukt.Name = "txtNewProdukt";
            this.txtNewProdukt.Size = new System.Drawing.Size(87, 20);
            this.txtNewProdukt.TabIndex = 9;
            // 
            // txtNewPreis
            // 
            this.txtNewPreis.Location = new System.Drawing.Point(287, 143);
            this.txtNewPreis.Name = "txtNewPreis";
            this.txtNewPreis.Size = new System.Drawing.Size(99, 20);
            this.txtNewPreis.TabIndex = 8;
            // 
            // txtUpdateProdukt
            // 
            this.txtUpdateProdukt.Location = new System.Drawing.Point(3, 62);
            this.txtUpdateProdukt.Name = "txtUpdateProdukt";
            this.txtUpdateProdukt.Size = new System.Drawing.Size(87, 20);
            this.txtUpdateProdukt.TabIndex = 5;
            // 
            // txtUpdatePreis
            // 
            this.txtUpdatePreis.Location = new System.Drawing.Point(287, 62);
            this.txtUpdatePreis.Name = "txtUpdatePreis";
            this.txtUpdatePreis.Size = new System.Drawing.Size(99, 20);
            this.txtUpdatePreis.TabIndex = 4;
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(136, 0);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(47, 13);
            this.Barcode.TabIndex = 12;
            this.Barcode.Text = "Barcode";
            // 
            // Preis
            // 
            this.Preis.AutoSize = true;
            this.Preis.Location = new System.Drawing.Point(287, 0);
            this.Preis.Name = "Preis";
            this.Preis.Size = new System.Drawing.Size(30, 13);
            this.Preis.TabIndex = 13;
            this.Preis.Text = "Preis";
            // 
            // txtUpdateVorrat
            // 
            this.txtUpdateVorrat.Location = new System.Drawing.Point(392, 62);
            this.txtUpdateVorrat.Name = "txtUpdateVorrat";
            this.txtUpdateVorrat.Size = new System.Drawing.Size(93, 20);
            this.txtUpdateVorrat.TabIndex = 14;
            // 
            // Vorrat
            // 
            this.Vorrat.AutoSize = true;
            this.Vorrat.Location = new System.Drawing.Point(392, 0);
            this.Vorrat.Name = "Vorrat";
            this.Vorrat.Size = new System.Drawing.Size(35, 13);
            this.Vorrat.TabIndex = 15;
            this.Vorrat.Text = "Vorrat";
            // 
            // txtNewVorrat
            // 
            this.txtNewVorrat.Location = new System.Drawing.Point(392, 143);
            this.txtNewVorrat.Name = "txtNewVorrat";
            this.txtNewVorrat.Size = new System.Drawing.Size(93, 20);
            this.txtNewVorrat.TabIndex = 16;
            // 
            // Produkt
            // 
            this.Produkt.AutoSize = true;
            this.Produkt.Location = new System.Drawing.Point(3, 0);
            this.Produkt.Name = "Produkt";
            this.Produkt.Size = new System.Drawing.Size(44, 13);
            this.Produkt.TabIndex = 11;
            this.Produkt.Text = "Produkt";
            // 
            // btnUpdateSell
            // 
            this.btnUpdateSell.Location = new System.Drawing.Point(491, 62);
            this.btnUpdateSell.Name = "btnUpdateSell";
            this.btnUpdateSell.Size = new System.Drawing.Size(178, 23);
            this.btnUpdateSell.TabIndex = 0;
            this.btnUpdateSell.Text = "Artikel anpassen";
            this.btnUpdateSell.UseVisualStyleBackColor = true;
            this.btnUpdateSell.Click += new System.EventHandler(this.btnUpdateSell_Click);
            // 
            // btnNewSell
            // 
            this.btnNewSell.Location = new System.Drawing.Point(491, 143);
            this.btnNewSell.Name = "btnNewSell";
            this.btnNewSell.Size = new System.Drawing.Size(179, 20);
            this.btnNewSell.TabIndex = 2;
            this.btnNewSell.Text = "Neuer Artikel erfassen";
            this.btnNewSell.UseVisualStyleBackColor = true;
            this.btnNewSell.Click += new System.EventHandler(this.btnNewSell_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Löschen});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(695, 297);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Löschen
            // 
            this.Löschen.HeaderText = "Löschen";
            this.Löschen.Name = "Löschen";
            this.Löschen.ReadOnly = true;
            this.Löschen.Width = 54;
            // 
            // txtUpdateBarcode
            // 
            this.txtUpdateBarcode.Location = new System.Drawing.Point(136, 62);
            this.txtUpdateBarcode.Name = "txtUpdateBarcode";
            this.txtUpdateBarcode.Size = new System.Drawing.Size(99, 20);
            this.txtUpdateBarcode.TabIndex = 19;
            // 
            // txtNewBarcode
            // 
            this.txtNewBarcode.Location = new System.Drawing.Point(136, 143);
            this.txtNewBarcode.Name = "txtNewBarcode";
            this.txtNewBarcode.Size = new System.Drawing.Size(99, 20);
            this.txtNewBarcode.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.76617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.23383F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtNewProdukt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPreis, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateProdukt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdatePreis, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Barcode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Preis, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateVorrat, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Vorrat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewVorrat, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Produkt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateSell, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNewSell, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateBarcode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewBarcode, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 303);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 227);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // SellAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SellAdminView";
            this.Size = new System.Drawing.Size(695, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TextBox txtNewProdukt;
        private System.Windows.Forms.TextBox txtNewPreis;
        private System.Windows.Forms.TextBox txtUpdateProdukt;
        private System.Windows.Forms.TextBox txtUpdatePreis;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.Label Preis;
        private System.Windows.Forms.TextBox txtUpdateVorrat;
        private System.Windows.Forms.Label Vorrat;
        private System.Windows.Forms.TextBox txtNewVorrat;
        private System.Windows.Forms.Label Produkt;
        private System.Windows.Forms.Button btnUpdateSell;
        private System.Windows.Forms.Button btnNewSell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Löschen;
        private System.Windows.Forms.TextBox txtUpdateBarcode;
        private System.Windows.Forms.TextBox txtNewBarcode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
