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
            this.dataGridView1 = new Helpers.DataGridViewPlus();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 321);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 303);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // txtNewRFID
            // 
            this.txtNewRFID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewRFID.Location = new System.Drawing.Point(6, 208);
            this.txtNewRFID.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewRFID.Name = "txtNewRFID";
            this.txtNewRFID.Size = new System.Drawing.Size(151, 31);
            this.txtNewRFID.TabIndex = 7;
            this.txtNewRFID.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // txtNewVorname
            // 
            this.txtNewVorname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewVorname.Location = new System.Drawing.Point(332, 208);
            this.txtNewVorname.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewVorname.Name = "txtNewVorname";
            this.txtNewVorname.Size = new System.Drawing.Size(151, 31);
            this.txtNewVorname.TabIndex = 9;
            this.txtNewVorname.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // txtUpdateRFID
            // 
            this.txtUpdateRFID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdateRFID.Enabled = false;
            this.txtUpdateRFID.Location = new System.Drawing.Point(6, 107);
            this.txtUpdateRFID.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateRFID.Name = "txtUpdateRFID";
            this.txtUpdateRFID.Size = new System.Drawing.Size(151, 31);
            this.txtUpdateRFID.TabIndex = 1;
            this.txtUpdateRFID.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // txtUpdateVorname
            // 
            this.txtUpdateVorname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdateVorname.Enabled = false;
            this.txtUpdateVorname.Location = new System.Drawing.Point(332, 107);
            this.txtUpdateVorname.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateVorname.Name = "txtUpdateVorname";
            this.txtUpdateVorname.Size = new System.Drawing.Size(151, 31);
            this.txtUpdateVorname.TabIndex = 3;
            this.txtUpdateVorname.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(169, 0);
            this.Barcode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Barcode.MinimumSize = new System.Drawing.Size(68, 25);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(68, 25);
            this.Barcode.TabIndex = 12;
            this.Barcode.Text = "Name";
            // 
            // Preis
            // 
            this.Preis.AutoSize = true;
            this.Preis.Location = new System.Drawing.Point(332, 0);
            this.Preis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Preis.MinimumSize = new System.Drawing.Size(98, 25);
            this.Preis.Name = "Preis";
            this.Preis.Size = new System.Drawing.Size(98, 25);
            this.Preis.TabIndex = 13;
            this.Preis.Text = "Vorname";
            // 
            // txtUpdateLoginname
            // 
            this.txtUpdateLoginname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdateLoginname.Enabled = false;
            this.txtUpdateLoginname.Location = new System.Drawing.Point(495, 107);
            this.txtUpdateLoginname.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateLoginname.Name = "txtUpdateLoginname";
            this.txtUpdateLoginname.Size = new System.Drawing.Size(151, 31);
            this.txtUpdateLoginname.TabIndex = 4;
            this.txtUpdateLoginname.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // Vorrat
            // 
            this.Vorrat.AutoSize = true;
            this.Vorrat.Location = new System.Drawing.Point(495, 0);
            this.Vorrat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Vorrat.MinimumSize = new System.Drawing.Size(118, 25);
            this.Vorrat.Name = "Vorrat";
            this.Vorrat.Size = new System.Drawing.Size(118, 25);
            this.Vorrat.TabIndex = 15;
            this.Vorrat.Text = "Loginname";
            // 
            // txtNewLoginname
            // 
            this.txtNewLoginname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewLoginname.Location = new System.Drawing.Point(495, 208);
            this.txtNewLoginname.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewLoginname.Name = "txtNewLoginname";
            this.txtNewLoginname.Size = new System.Drawing.Size(151, 31);
            this.txtNewLoginname.TabIndex = 10;
            this.txtNewLoginname.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // Produkt
            // 
            this.Produkt.AutoSize = true;
            this.Produkt.Location = new System.Drawing.Point(6, 0);
            this.Produkt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Produkt.MinimumSize = new System.Drawing.Size(60, 25);
            this.Produkt.Name = "Produkt";
            this.Produkt.Size = new System.Drawing.Size(60, 25);
            this.Produkt.TabIndex = 11;
            this.Produkt.Text = "RFID";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdateName.Enabled = false;
            this.txtUpdateName.Location = new System.Drawing.Point(169, 107);
            this.txtUpdateName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(151, 31);
            this.txtUpdateName.TabIndex = 2;
            this.txtUpdateName.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // txtNewName
            // 
            this.txtNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewName.Location = new System.Drawing.Point(169, 208);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(151, 31);
            this.txtNewName.TabIndex = 8;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // btnUpdateSeller
            // 
            this.btnUpdateSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateSeller.Enabled = false;
            this.btnUpdateSeller.Location = new System.Drawing.Point(821, 107);
            this.btnUpdateSeller.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateSeller.Name = "btnUpdateSeller";
            this.btnUpdateSeller.Size = new System.Drawing.Size(153, 89);
            this.btnUpdateSeller.TabIndex = 6;
            this.btnUpdateSeller.Text = "Verkäufer anpassen";
            this.btnUpdateSeller.UseVisualStyleBackColor = true;
            this.btnUpdateSeller.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnNewSeller
            // 
            this.btnNewSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewSeller.Enabled = false;
            this.btnNewSeller.Location = new System.Drawing.Point(821, 208);
            this.btnNewSeller.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewSeller.Name = "btnNewSeller";
            this.btnNewSeller.Size = new System.Drawing.Size(153, 89);
            this.btnNewSeller.TabIndex = 12;
            this.btnNewSeller.Text = "Neuen Verkäufer erfassen";
            this.btnNewSeller.UseVisualStyleBackColor = true;
            this.btnNewSeller.Click += new System.EventHandler(this.btnNewSeller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.MinimumSize = new System.Drawing.Size(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Passwort";
            // 
            // txtUpdatePasswort
            // 
            this.txtUpdatePasswort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdatePasswort.Enabled = false;
            this.txtUpdatePasswort.Location = new System.Drawing.Point(658, 107);
            this.txtUpdatePasswort.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdatePasswort.Name = "txtUpdatePasswort";
            this.txtUpdatePasswort.Size = new System.Drawing.Size(151, 31);
            this.txtUpdatePasswort.TabIndex = 5;
            this.txtUpdatePasswort.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // txtNewPasswort
            // 
            this.txtNewPasswort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPasswort.Location = new System.Drawing.Point(658, 208);
            this.txtNewPasswort.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewPasswort.Name = "txtNewPasswort";
            this.txtNewPasswort.Size = new System.Drawing.Size(151, 31);
            this.txtNewPasswort.TabIndex = 11;
            this.txtNewPasswort.TextChanged += new System.EventHandler(this.txtFields_Changed);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(992, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Löschen";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(992, 630);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // SellerAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SellerAdminView";
            this.Size = new System.Drawing.Size(992, 630);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

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
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Helpers.DataGridViewPlus dataGridView1;
	}
}
