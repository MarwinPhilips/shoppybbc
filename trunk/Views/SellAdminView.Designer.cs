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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewProdukt
            // 
            this.txtNewProdukt.Location = new System.Drawing.Point(6, 143);
            this.txtNewProdukt.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewProdukt.Name = "txtNewProdukt";
            this.txtNewProdukt.Size = new System.Drawing.Size(87, 31);
            this.txtNewProdukt.TabIndex = 9;
            // 
            // txtNewPreis
            // 
            this.txtNewPreis.Location = new System.Drawing.Point(270, 143);
            this.txtNewPreis.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewPreis.Name = "txtNewPreis";
            this.txtNewPreis.Size = new System.Drawing.Size(99, 31);
            this.txtNewPreis.TabIndex = 8;
            // 
            // txtUpdateProdukt
            // 
            this.txtUpdateProdukt.Location = new System.Drawing.Point(6, 64);
            this.txtUpdateProdukt.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateProdukt.Name = "txtUpdateProdukt";
            this.txtUpdateProdukt.Size = new System.Drawing.Size(87, 31);
            this.txtUpdateProdukt.TabIndex = 5;
            // 
            // txtUpdatePreis
            // 
            this.txtUpdatePreis.Location = new System.Drawing.Point(270, 64);
            this.txtUpdatePreis.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdatePreis.Name = "txtUpdatePreis";
            this.txtUpdatePreis.Size = new System.Drawing.Size(99, 31);
            this.txtUpdatePreis.TabIndex = 4;
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(105, 0);
            this.Barcode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(92, 25);
            this.Barcode.TabIndex = 12;
            this.Barcode.Text = "Barcode";
            // 
            // Preis
            // 
            this.Preis.AutoSize = true;
            this.Preis.Location = new System.Drawing.Point(270, 0);
            this.Preis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Preis.Name = "Preis";
            this.Preis.Size = new System.Drawing.Size(61, 25);
            this.Preis.TabIndex = 13;
            this.Preis.Text = "Preis";
            // 
            // txtUpdateVorrat
            // 
            this.txtUpdateVorrat.Location = new System.Drawing.Point(381, 64);
            this.txtUpdateVorrat.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateVorrat.Name = "txtUpdateVorrat";
            this.txtUpdateVorrat.Size = new System.Drawing.Size(182, 31);
            this.txtUpdateVorrat.TabIndex = 14;
            // 
            // Vorrat
            // 
            this.Vorrat.AutoSize = true;
            this.Vorrat.Location = new System.Drawing.Point(381, 0);
            this.Vorrat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Vorrat.Name = "Vorrat";
            this.Vorrat.Size = new System.Drawing.Size(70, 25);
            this.Vorrat.TabIndex = 15;
            this.Vorrat.Text = "Vorrat";
            // 
            // txtNewVorrat
            // 
            this.txtNewVorrat.Location = new System.Drawing.Point(381, 143);
            this.txtNewVorrat.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewVorrat.Name = "txtNewVorrat";
            this.txtNewVorrat.Size = new System.Drawing.Size(182, 31);
            this.txtNewVorrat.TabIndex = 16;
            // 
            // Produkt
            // 
            this.Produkt.AutoSize = true;
            this.Produkt.Location = new System.Drawing.Point(6, 0);
            this.Produkt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Produkt.Name = "Produkt";
            this.Produkt.Size = new System.Drawing.Size(86, 25);
            this.Produkt.TabIndex = 11;
            this.Produkt.Text = "Produkt";
            // 
            // btnUpdateSell
            // 
            this.btnUpdateSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateSell.Location = new System.Drawing.Point(579, 64);
            this.btnUpdateSell.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateSell.Name = "btnUpdateSell";
            this.btnUpdateSell.Size = new System.Drawing.Size(395, 67);
            this.btnUpdateSell.TabIndex = 0;
            this.btnUpdateSell.Text = "Artikel anpassen";
            this.btnUpdateSell.UseVisualStyleBackColor = true;
            this.btnUpdateSell.Click += new System.EventHandler(this.btnUpdateSell_Click);
            // 
            // btnNewSell
            // 
            this.btnNewSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewSell.Location = new System.Drawing.Point(579, 143);
            this.btnNewSell.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewSell.Name = "btnNewSell";
            this.btnNewSell.Size = new System.Drawing.Size(395, 154);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 303);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Löschen
            // 
            this.Löschen.HeaderText = "Löschen";
            this.Löschen.Name = "Löschen";
            // 
            // txtUpdateBarcode
            // 
            this.txtUpdateBarcode.Location = new System.Drawing.Point(105, 64);
            this.txtUpdateBarcode.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateBarcode.Name = "txtUpdateBarcode";
            this.txtUpdateBarcode.Size = new System.Drawing.Size(153, 31);
            this.txtUpdateBarcode.TabIndex = 19;
            // 
            // txtNewBarcode
            // 
            this.txtNewBarcode.Location = new System.Drawing.Point(105, 143);
            this.txtNewBarcode.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewBarcode.Name = "txtNewBarcode";
            this.txtNewBarcode.Size = new System.Drawing.Size(153, 31);
            this.txtNewBarcode.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.73006F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.26994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 321);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 303);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(992, 630);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // SellAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SellAdminView";
            this.Size = new System.Drawing.Size(992, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}
