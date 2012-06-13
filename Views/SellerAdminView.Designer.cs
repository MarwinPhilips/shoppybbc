namespace Shoppy.Views
{
	partial class SellerAdminView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Löschen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewRFID = new System.Windows.Forms.TextBox();
            this.txtNewVorname = new System.Windows.Forms.TextBox();
            this.txtUpdateRFID = new System.Windows.Forms.TextBox();
            this.txtUpdateVorname = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Label();
            this.Preis = new System.Windows.Forms.Label();
            this.txtUpdateLoginname = new System.Windows.Forms.TextBox();
            this.Vorrat = new System.Windows.Forms.Label();
            this.txtNewLoginname = new System.Windows.Forms.TextBox();
            this.Produkt = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnUpdateSeller = new System.Windows.Forms.Button();
            this.btnNewSeller = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdatePasswort = new System.Windows.Forms.TextBox();
            this.txtNewPasswort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(643, 276);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Löschen
            // 
            this.Löschen.HeaderText = "Löschen";
            this.Löschen.Name = "Löschen";
            this.Löschen.ReadOnly = true;
            this.Löschen.Width = 54;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.76617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.23383F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtNewRFID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewVorname, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateRFID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateVorname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Barcode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Preis, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateLoginname, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Vorrat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewLoginname, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Produkt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateSeller, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNewSeller, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdatePasswort, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPasswort, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 321);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 170);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // txtNewRFID
            // 
            this.txtNewRFID.Location = new System.Drawing.Point(3, 86);
            this.txtNewRFID.Name = "txtNewRFID";
            this.txtNewRFID.Size = new System.Drawing.Size(87, 20);
            this.txtNewRFID.TabIndex = 9;
            // 
            // txtNewVorname
            // 
            this.txtNewVorname.Location = new System.Drawing.Point(214, 86);
            this.txtNewVorname.Name = "txtNewVorname";
            this.txtNewVorname.Size = new System.Drawing.Size(99, 20);
            this.txtNewVorname.TabIndex = 8;
            // 
            // txtUpdateRFID
            // 
            this.txtUpdateRFID.Enabled = false;
            this.txtUpdateRFID.Location = new System.Drawing.Point(3, 38);
            this.txtUpdateRFID.Name = "txtUpdateRFID";
            this.txtUpdateRFID.Size = new System.Drawing.Size(87, 20);
            this.txtUpdateRFID.TabIndex = 5;
            // 
            // txtUpdateVorname
            // 
            this.txtUpdateVorname.Location = new System.Drawing.Point(214, 38);
            this.txtUpdateVorname.Name = "txtUpdateVorname";
            this.txtUpdateVorname.Size = new System.Drawing.Size(99, 20);
            this.txtUpdateVorname.TabIndex = 4;
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(102, 0);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(35, 13);
            this.Barcode.TabIndex = 12;
            this.Barcode.Text = "Name";
            // 
            // Preis
            // 
            this.Preis.AutoSize = true;
            this.Preis.Location = new System.Drawing.Point(214, 0);
            this.Preis.Name = "Preis";
            this.Preis.Size = new System.Drawing.Size(49, 13);
            this.Preis.TabIndex = 13;
            this.Preis.Text = "Vorname";
            // 
            // txtUpdateLoginname
            // 
            this.txtUpdateLoginname.Location = new System.Drawing.Point(319, 38);
            this.txtUpdateLoginname.Name = "txtUpdateLoginname";
            this.txtUpdateLoginname.Size = new System.Drawing.Size(93, 20);
            this.txtUpdateLoginname.TabIndex = 14;
            // 
            // Vorrat
            // 
            this.Vorrat.AutoSize = true;
            this.Vorrat.Location = new System.Drawing.Point(319, 0);
            this.Vorrat.Name = "Vorrat";
            this.Vorrat.Size = new System.Drawing.Size(59, 13);
            this.Vorrat.TabIndex = 15;
            this.Vorrat.Text = "Loginname";
            // 
            // txtNewLoginname
            // 
            this.txtNewLoginname.Location = new System.Drawing.Point(319, 86);
            this.txtNewLoginname.Name = "txtNewLoginname";
            this.txtNewLoginname.Size = new System.Drawing.Size(93, 20);
            this.txtNewLoginname.TabIndex = 16;
            // 
            // Produkt
            // 
            this.Produkt.AutoSize = true;
            this.Produkt.Location = new System.Drawing.Point(3, 0);
            this.Produkt.Name = "Produkt";
            this.Produkt.Size = new System.Drawing.Size(32, 13);
            this.Produkt.TabIndex = 11;
            this.Produkt.Text = "RFID";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(102, 38);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(99, 20);
            this.txtUpdateName.TabIndex = 19;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(102, 86);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(99, 20);
            this.txtNewName.TabIndex = 20;
            // 
            // btnUpdateSeller
            // 
            this.btnUpdateSeller.Location = new System.Drawing.Point(520, 38);
            this.btnUpdateSeller.Name = "btnUpdateSeller";
            this.btnUpdateSeller.Size = new System.Drawing.Size(111, 23);
            this.btnUpdateSeller.TabIndex = 0;
            this.btnUpdateSeller.Text = "Verkäufer anpassen";
            this.btnUpdateSeller.UseVisualStyleBackColor = true;
            this.btnUpdateSeller.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnNewSeller
            // 
            this.btnNewSeller.Location = new System.Drawing.Point(520, 86);
            this.btnNewSeller.Name = "btnNewSeller";
            this.btnNewSeller.Size = new System.Drawing.Size(111, 20);
            this.btnNewSeller.TabIndex = 2;
            this.btnNewSeller.Text = "Neuen Verkäufer erfassen";
            this.btnNewSeller.UseVisualStyleBackColor = true;
            this.btnNewSeller.Click += new System.EventHandler(this.btnNewSeller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Passwort";
            // 
            // txtUpdatePasswort
            // 
            this.txtUpdatePasswort.Location = new System.Drawing.Point(418, 38);
            this.txtUpdatePasswort.Name = "txtUpdatePasswort";
            this.txtUpdatePasswort.Size = new System.Drawing.Size(96, 20);
            this.txtUpdatePasswort.TabIndex = 22;
            // 
            // txtNewPasswort
            // 
            this.txtNewPasswort.Location = new System.Drawing.Point(418, 86);
            this.txtNewPasswort.Name = "txtNewPasswort";
            this.txtNewPasswort.Size = new System.Drawing.Size(96, 20);
            this.txtNewPasswort.TabIndex = 23;
            // 
            // SellerAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SellerAdminView";
            this.Size = new System.Drawing.Size(643, 491);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Löschen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNewRFID;
        private System.Windows.Forms.TextBox txtNewVorname;
        private System.Windows.Forms.TextBox txtUpdateRFID;
        private System.Windows.Forms.TextBox txtUpdateVorname;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.Label Preis;
        private System.Windows.Forms.TextBox txtUpdateLoginname;
        private System.Windows.Forms.Label Vorrat;
        private System.Windows.Forms.TextBox txtNewLoginname;
        private System.Windows.Forms.Label Produkt;
        private System.Windows.Forms.Button btnUpdateSeller;
        private System.Windows.Forms.Button btnNewSeller;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdatePasswort;
        private System.Windows.Forms.TextBox txtNewPasswort;
	}
}
