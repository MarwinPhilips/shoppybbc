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
            this.Anzeigename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdatePasswort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPasswort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCam
            // 
            this.btnUpdateCam.Location = new System.Drawing.Point(513, 62);
            this.btnUpdateCam.Name = "btnUpdateCam";
            this.btnUpdateCam.Size = new System.Drawing.Size(178, 23);
            this.btnUpdateCam.TabIndex = 0;
            this.btnUpdateCam.Text = "Kameraeinstellung anpassen";
            this.btnUpdateCam.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(695, 297);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Löschen
            // 
            this.Löschen.HeaderText = "Löschen";
            this.Löschen.Name = "Löschen";
            this.Löschen.Width = 54;
            // 
            // btnNewCam
            // 
            this.btnNewCam.Location = new System.Drawing.Point(513, 143);
            this.btnNewCam.Name = "btnNewCam";
            this.btnNewCam.Size = new System.Drawing.Size(179, 20);
            this.btnNewCam.TabIndex = 2;
            this.btnNewCam.Text = "Neue Kamera erfassen";
            this.btnNewCam.UseVisualStyleBackColor = true;
            // 
            // txtUpdateAnzeigename
            // 
            this.txtUpdateAnzeigename.Location = new System.Drawing.Point(137, 62);
            this.txtUpdateAnzeigename.Name = "txtUpdateAnzeigename";
            this.txtUpdateAnzeigename.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAnzeigename.TabIndex = 3;
            // 
            // txtUpdateLoginname
            // 
            this.txtUpdateLoginname.Location = new System.Drawing.Point(259, 62);
            this.txtUpdateLoginname.Name = "txtUpdateLoginname";
            this.txtUpdateLoginname.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateLoginname.TabIndex = 4;
            // 
            // txtUpdateIP
            // 
            this.txtUpdateIP.Location = new System.Drawing.Point(3, 62);
            this.txtUpdateIP.Name = "txtUpdateIP";
            this.txtUpdateIP.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateIP.TabIndex = 5;
            // 
            // txtNewIP
            // 
            this.txtNewIP.Location = new System.Drawing.Point(3, 143);
            this.txtNewIP.Name = "txtNewIP";
            this.txtNewIP.Size = new System.Drawing.Size(100, 20);
            this.txtNewIP.TabIndex = 9;
            // 
            // txtNewLoginname
            // 
            this.txtNewLoginname.Location = new System.Drawing.Point(259, 143);
            this.txtNewLoginname.Name = "txtNewLoginname";
            this.txtNewLoginname.Size = new System.Drawing.Size(100, 20);
            this.txtNewLoginname.TabIndex = 8;
            // 
            // txtNewAnzeigename
            // 
            this.txtNewAnzeigename.Location = new System.Drawing.Point(137, 143);
            this.txtNewAnzeigename.Name = "txtNewAnzeigename";
            this.txtNewAnzeigename.Size = new System.Drawing.Size(100, 20);
            this.txtNewAnzeigename.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Controls.Add(this.txtNewIP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewAnzeigename, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewLoginname, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewCam, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateIP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateAnzeigename, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateLoginname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateCam, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Anzeigename, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdatePasswort, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPasswort, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 303);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 227);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Anzeigename
            // 
            this.Anzeigename.AutoSize = true;
            this.Anzeigename.Location = new System.Drawing.Point(3, 0);
            this.Anzeigename.Name = "Anzeigename";
            this.Anzeigename.Size = new System.Drawing.Size(58, 13);
            this.Anzeigename.TabIndex = 11;
            this.Anzeigename.Text = "IP-Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Anzeigename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loginname";
            // 
            // txtUpdatePasswort
            // 
            this.txtUpdatePasswort.Location = new System.Drawing.Point(393, 62);
            this.txtUpdatePasswort.Name = "txtUpdatePasswort";
            this.txtUpdatePasswort.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePasswort.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Passwort";
            // 
            // txtNewPasswort
            // 
            this.txtNewPasswort.Location = new System.Drawing.Point(393, 143);
            this.txtNewPasswort.Name = "txtNewPasswort";
            this.txtNewPasswort.Size = new System.Drawing.Size(100, 20);
            this.txtNewPasswort.TabIndex = 16;
            // 
            // CamAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CamAdminView";
            this.Size = new System.Drawing.Size(695, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
	}
}
