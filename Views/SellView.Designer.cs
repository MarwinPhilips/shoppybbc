namespace Shoppy.Views
{
	partial class SellView
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
            this.btnSellPay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Löschen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Produkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.SellMultipleProdukt = new System.Windows.Forms.Button();
            this.txtMultipleProdukt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSellDeleteAll = new System.Windows.Forms.Button();
            this.btnPrintSell = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.txtInputBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelGehalt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGehalt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSellPay
            // 
            this.btnSellPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSellPay.Enabled = false;
            this.btnSellPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSellPay.Location = new System.Drawing.Point(6, 6);
            this.btnSellPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnSellPay.MinimumSize = new System.Drawing.Size(150, 70);
            this.btnSellPay.Name = "btnSellPay";
            this.btnSellPay.Size = new System.Drawing.Size(313, 140);
            this.btnSellPay.TabIndex = 4;
            this.btnSellPay.Text = "Bezahlen";
            this.btnSellPay.UseVisualStyleBackColor = true;
            this.btnSellPay.Click += new System.EventHandler(this.btnSellPay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Löschen,
            this.Produkt,
            this.BarCode,
            this.Preis,
            this.Anzahl});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(988, 323);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Löschen
            // 
            this.Löschen.HeaderText = "Löschen";
            this.Löschen.MinimumWidth = 50;
            this.Löschen.Name = "Löschen";
            this.Löschen.ReadOnly = true;
            this.Löschen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Löschen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Produkt
            // 
            this.Produkt.HeaderText = "ProduktName";
            this.Produkt.MinimumWidth = 50;
            this.Produkt.Name = "Produkt";
            this.Produkt.ReadOnly = true;
            this.Produkt.Width = 300;
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "BarCode";
            this.BarCode.MinimumWidth = 50;
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 200;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.MinimumWidth = 50;
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.MinimumWidth = 50;
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            this.Anzahl.Width = 95;
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTotalPay.Location = new System.Drawing.Point(0, 0);
            this.txtTotalPay.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.txtTotalPay.MinimumSize = new System.Drawing.Size(109, 32);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(188, 32);
            this.txtTotalPay.TabIndex = 2;
            this.txtTotalPay.TabStop = false;
            this.txtTotalPay.Text = "0.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSellPay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 169);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 152);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.SellMultipleProdukt, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtMultipleProdukt, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(328, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.54795F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.45205F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(319, 146);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // SellMultipleProdukt
            // 
            this.SellMultipleProdukt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellMultipleProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SellMultipleProdukt.Location = new System.Drawing.Point(6, 3);
            this.SellMultipleProdukt.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.SellMultipleProdukt.MinimumSize = new System.Drawing.Size(140, 60);
            this.SellMultipleProdukt.Name = "SellMultipleProdukt";
            this.SellMultipleProdukt.Size = new System.Drawing.Size(307, 94);
            this.SellMultipleProdukt.TabIndex = 2;
            this.SellMultipleProdukt.Text = "Mehrere Produkte";
            this.SellMultipleProdukt.UseVisualStyleBackColor = true;
            this.SellMultipleProdukt.Click += new System.EventHandler(this.SellMultipleProdukt_Click);
            // 
            // txtMultipleProdukt
            // 
            this.txtMultipleProdukt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMultipleProdukt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMultipleProdukt.Location = new System.Drawing.Point(6, 110);
            this.txtMultipleProdukt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 3);
            this.txtMultipleProdukt.MinimumSize = new System.Drawing.Size(150, 32);
            this.txtMultipleProdukt.Name = "txtMultipleProdukt";
            this.txtMultipleProdukt.Size = new System.Drawing.Size(307, 31);
            this.txtMultipleProdukt.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.btnSellDeleteAll, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnPrintSell, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(653, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(320, 146);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // btnSellDeleteAll
            // 
            this.btnSellDeleteAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSellDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSellDeleteAll.Location = new System.Drawing.Point(3, 76);
            this.btnSellDeleteAll.MinimumSize = new System.Drawing.Size(150, 60);
            this.btnSellDeleteAll.Name = "btnSellDeleteAll";
            this.btnSellDeleteAll.Size = new System.Drawing.Size(314, 67);
            this.btnSellDeleteAll.TabIndex = 4;
            this.btnSellDeleteAll.Text = "Alle Produkte löschen";
            this.btnSellDeleteAll.UseVisualStyleBackColor = true;
            this.btnSellDeleteAll.Click += new System.EventHandler(this.btnSellDeleteAll_Click);
            // 
            // btnPrintSell
            // 
            this.btnPrintSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintSell.Location = new System.Drawing.Point(3, 3);
            this.btnPrintSell.MinimumSize = new System.Drawing.Size(150, 60);
            this.btnPrintSell.Name = "btnPrintSell";
            this.btnPrintSell.Size = new System.Drawing.Size(314, 67);
            this.btnPrintSell.TabIndex = 5;
            this.btnPrintSell.Text = "Quittung ausdrucken";
            this.btnPrintSell.UseVisualStyleBackColor = true;
            this.btnPrintSell.Click += new System.EventHandler(this.btnPrintSell_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text.Location = new System.Drawing.Point(6, 0);
            this.text.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.text.MinimumSize = new System.Drawing.Size(100, 89);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(199, 89);
            this.text.TabIndex = 4;
            this.text.Text = "Gesamtbetrag:";
            // 
            // txtInputBarcode
            // 
            this.txtInputBarcode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtInputBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtInputBarcode.Location = new System.Drawing.Point(218, 75);
            this.txtInputBarcode.Margin = new System.Windows.Forms.Padding(7, 0, 6, 6);
            this.txtInputBarcode.MinimumSize = new System.Drawing.Size(180, 32);
            this.txtInputBarcode.Name = "txtInputBarcode";
            this.txtInputBarcode.Size = new System.Drawing.Size(382, 32);
            this.txtInputBarcode.TabIndex = 1;
            this.txtInputBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputBarcode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.MinimumSize = new System.Drawing.Size(125, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produkt-BarCode:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 341);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 327);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.72131F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.27869F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtInputBarcode, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.text, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(976, 151);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.txtTotalPay, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelGehalt, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtGehalt, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(217, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(753, 69);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // labelGehalt
            // 
            this.labelGehalt.AutoSize = true;
            this.labelGehalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelGehalt.Location = new System.Drawing.Point(396, 6);
            this.labelGehalt.Margin = new System.Windows.Forms.Padding(20, 6, 0, 0);
            this.labelGehalt.MinimumSize = new System.Drawing.Size(50, 30);
            this.labelGehalt.Name = "labelGehalt";
            this.labelGehalt.Size = new System.Drawing.Size(116, 30);
            this.labelGehalt.TabIndex = 5;
            this.labelGehalt.Text = "Kotostand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(188, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 2, 6, 0);
            this.label3.MinimumSize = new System.Drawing.Size(60, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 81);
            this.label3.TabIndex = 5;
            this.label3.Text = "CHF";
            // 
            // txtGehalt
            // 
            this.txtGehalt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGehalt.Location = new System.Drawing.Point(567, 3);
            this.txtGehalt.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtGehalt.Name = "txtGehalt";
            this.txtGehalt.ReadOnly = true;
            this.txtGehalt.Size = new System.Drawing.Size(183, 31);
            this.txtGehalt.TabIndex = 6;
            this.txtGehalt.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.85163F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.14837F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1000, 674);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // SellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SellView";
            this.Size = new System.Drawing.Size(1000, 674);
            this.Load += new System.EventHandler(this.SellView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button btnSellPay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox txtInputBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button SellMultipleProdukt;
        private System.Windows.Forms.TextBox txtMultipleProdukt;
        private System.Windows.Forms.Label labelGehalt;
        private System.Windows.Forms.TextBox txtGehalt;
        private System.Windows.Forms.DataGridViewButtonColumn Löschen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnPrintSell;
        private System.Windows.Forms.Button btnSellDeleteAll;
	}
}
