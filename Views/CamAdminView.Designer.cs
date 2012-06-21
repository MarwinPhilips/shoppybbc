namespace Shoppy.Views
{
	partial class CamAdminView
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
            this.btnUpdateCam = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Löschen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNewCam = new System.Windows.Forms.Button();
            this.txtUpdateAnzeigename = new System.Windows.Forms.TextBox();
            this.txtUpdateLoginname = new System.Windows.Forms.TextBox();
            this.txtUpdateIP = new System.Windows.Forms.TextBox();
            this.txtNewIP = new System.Windows.Forms.TextBox();
            this.txtNewLoginname = new System.Windows.Forms.TextBox();
            this.txtNewAnzeigename = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdatePasswort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPasswort = new System.Windows.Forms.TextBox();
            this.Anzeigename = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCam
            // 
            this.btnUpdateCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateCam.Location = new System.Drawing.Point(584, 80);
            this.btnUpdateCam.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateCam.Name = "btnUpdateCam";
            this.btnUpdateCam.Size = new System.Drawing.Size(390, 115);
            this.btnUpdateCam.TabIndex = 5;
            this.btnUpdateCam.Text = "Kameraeinstellung anpassen";
            this.btnUpdateCam.UseVisualStyleBackColor = true;
            this.btnUpdateCam.Click += new System.EventHandler(this.btnUpdateCam_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Löschen});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(980, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Löschen
            // 
            this.Löschen.HeaderText = "Löschen";
            this.Löschen.Name = "Löschen";
            this.Löschen.ReadOnly = true;
            // 
            // btnNewCam
            // 
            this.btnNewCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewCam.Location = new System.Drawing.Point(584, 207);
            this.btnNewCam.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewCam.Name = "btnNewCam";
            this.btnNewCam.Size = new System.Drawing.Size(390, 90);
            this.btnNewCam.TabIndex = 10;
            this.btnNewCam.Text = "Neue Kamera erfassen";
            this.btnNewCam.UseVisualStyleBackColor = true;
            this.btnNewCam.Click += new System.EventHandler(this.btnNewCam_Click);
            // 
            // txtUpdateAnzeigename
            // 
            this.txtUpdateAnzeigename.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUpdateAnzeigename.Location = new System.Drawing.Point(157, 80);
            this.txtUpdateAnzeigename.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateAnzeigename.Name = "txtUpdateAnzeigename";
            this.txtUpdateAnzeigename.Size = new System.Drawing.Size(141, 31);
            this.txtUpdateAnzeigename.TabIndex = 2;
            // 
            // txtUpdateLoginname
            // 
            this.txtUpdateLoginname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUpdateLoginname.Location = new System.Drawing.Point(310, 80);
            this.txtUpdateLoginname.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateLoginname.Name = "txtUpdateLoginname";
            this.txtUpdateLoginname.Size = new System.Drawing.Size(123, 31);
            this.txtUpdateLoginname.TabIndex = 3;
            // 
            // txtUpdateIP
            // 
            this.txtUpdateIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUpdateIP.Location = new System.Drawing.Point(6, 80);
            this.txtUpdateIP.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateIP.Name = "txtUpdateIP";
            this.txtUpdateIP.Size = new System.Drawing.Size(139, 31);
            this.txtUpdateIP.TabIndex = 1;
            // 
            // txtNewIP
            // 
            this.txtNewIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNewIP.Location = new System.Drawing.Point(6, 207);
            this.txtNewIP.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewIP.Name = "txtNewIP";
            this.txtNewIP.Size = new System.Drawing.Size(139, 31);
            this.txtNewIP.TabIndex = 6;
            // 
            // txtNewLoginname
            // 
            this.txtNewLoginname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNewLoginname.Location = new System.Drawing.Point(310, 207);
            this.txtNewLoginname.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewLoginname.Name = "txtNewLoginname";
            this.txtNewLoginname.Size = new System.Drawing.Size(123, 31);
            this.txtNewLoginname.TabIndex = 8;
            // 
            // txtNewAnzeigename
            // 
            this.txtNewAnzeigename.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNewAnzeigename.Location = new System.Drawing.Point(157, 207);
            this.txtNewAnzeigename.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewAnzeigename.Name = "txtNewAnzeigename";
            this.txtNewAnzeigename.Size = new System.Drawing.Size(141, 31);
            this.txtNewAnzeigename.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 401F));
            this.tableLayoutPanel1.Controls.Add(this.txtNewIP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewAnzeigename, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewLoginname, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewCam, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateIP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateAnzeigename, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateLoginname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateCam, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdatePasswort, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPasswort, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Anzeigename, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 321);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.61539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.84615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 303);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Anzeigename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loginname";
            // 
            // txtUpdatePasswort
            // 
            this.txtUpdatePasswort.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUpdatePasswort.Location = new System.Drawing.Point(445, 80);
            this.txtUpdatePasswort.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdatePasswort.Name = "txtUpdatePasswort";
            this.txtUpdatePasswort.Size = new System.Drawing.Size(127, 31);
            this.txtUpdatePasswort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Passwort";
            // 
            // txtNewPasswort
            // 
            this.txtNewPasswort.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNewPasswort.Location = new System.Drawing.Point(445, 207);
            this.txtNewPasswort.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewPasswort.Name = "txtNewPasswort";
            this.txtNewPasswort.Size = new System.Drawing.Size(127, 31);
            this.txtNewPasswort.TabIndex = 9;
            // 
            // Anzeigename
            // 
            this.Anzeigename.AutoSize = true;
            this.Anzeigename.Location = new System.Drawing.Point(6, 0);
            this.Anzeigename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Anzeigename.Name = "Anzeigename";
            this.Anzeigename.Size = new System.Drawing.Size(117, 25);
            this.Anzeigename.TabIndex = 11;
            this.Anzeigename.Text = "IP-Adresse";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(992, 630);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // CamAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CamAdminView";
            this.Size = new System.Drawing.Size(992, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button btnUpdateCam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Löschen;
        private System.Windows.Forms.Button btnNewCam;
        private System.Windows.Forms.TextBox txtUpdateAnzeigename;
        private System.Windows.Forms.TextBox txtUpdateLoginname;
        private System.Windows.Forms.TextBox txtUpdateIP;
        private System.Windows.Forms.TextBox txtNewIP;
        private System.Windows.Forms.TextBox txtNewLoginname;
        private System.Windows.Forms.TextBox txtNewAnzeigename;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Anzeigename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdatePasswort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPasswort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}
