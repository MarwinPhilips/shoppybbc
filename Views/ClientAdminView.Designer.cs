﻿namespace Shoppy.Views
{
    partial class ClientAdminView
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
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Löschen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.txtUpdateVorname = new System.Windows.Forms.TextBox();
            this.txtUpdateRFID = new System.Windows.Forms.TextBox();
            this.txtNewVorname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateGeld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewGeld = new System.Windows.Forms.TextBox();
            this.Anzeigename = new System.Windows.Forms.Label();
            this.txtUpdatePasswort = new System.Windows.Forms.TextBox();
            this.txtNewPasswort = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewRFID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateClient.Location = new System.Drawing.Point(820, 64);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(154, 67);
            this.btnUpdateClient.TabIndex = 0;
            this.btnUpdateClient.Text = "Kundeninfo anpassen";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(980, 303);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Löschen
            // 
            this.Löschen.HeaderText = "Löschen";
            this.Löschen.Name = "Löschen";
            // 
            // btnNewClient
            // 
            this.btnNewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewClient.Location = new System.Drawing.Point(820, 143);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(154, 154);
            this.btnNewClient.TabIndex = 2;
            this.btnNewClient.Text = "Neue Kunde erfassen";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // txtUpdateVorname
            // 
            this.txtUpdateVorname.Location = new System.Drawing.Point(331, 64);
            this.txtUpdateVorname.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateVorname.Name = "txtUpdateVorname";
            this.txtUpdateVorname.Size = new System.Drawing.Size(151, 31);
            this.txtUpdateVorname.TabIndex = 4;
            // 
            // txtUpdateRFID
            // 
            this.txtUpdateRFID.Location = new System.Drawing.Point(6, 64);
            this.txtUpdateRFID.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateRFID.Name = "txtUpdateRFID";
            this.txtUpdateRFID.ReadOnly = true;
            this.txtUpdateRFID.Size = new System.Drawing.Size(1, 31);
            this.txtUpdateRFID.TabIndex = 5;
            // 
            // txtNewVorname
            // 
            this.txtNewVorname.Location = new System.Drawing.Point(331, 143);
            this.txtNewVorname.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewVorname.Name = "txtNewVorname";
            this.txtNewVorname.Size = new System.Drawing.Size(151, 31);
            this.txtNewVorname.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58872F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.74461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewVorname, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateRFID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateVorname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateGeld, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewGeld, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Anzeigename, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateClient, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNewClient, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdatePasswort, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPasswort, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewRFID, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 321);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 303);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Passwort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vorname";
            // 
            // txtUpdateGeld
            // 
            this.txtUpdateGeld.Location = new System.Drawing.Point(494, 64);
            this.txtUpdateGeld.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateGeld.Name = "txtUpdateGeld";
            this.txtUpdateGeld.Size = new System.Drawing.Size(151, 31);
            this.txtUpdateGeld.TabIndex = 14;
            this.txtUpdateGeld.TextChanged += new System.EventHandler(this.txtUpdateGeld_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Geld";
            // 
            // txtNewGeld
            // 
            this.txtNewGeld.Location = new System.Drawing.Point(494, 143);
            this.txtNewGeld.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewGeld.Name = "txtNewGeld";
            this.txtNewGeld.Size = new System.Drawing.Size(151, 31);
            this.txtNewGeld.TabIndex = 16;
            this.txtNewGeld.TextChanged += new System.EventHandler(this.txtNewGeld_TextChanged);
            // 
            // Anzeigename
            // 
            this.Anzeigename.AutoSize = true;
            this.Anzeigename.Location = new System.Drawing.Point(6, 0);
            this.Anzeigename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Anzeigename.Name = "Anzeigename";
            this.Anzeigename.Size = new System.Drawing.Size(60, 25);
            this.Anzeigename.TabIndex = 11;
            this.Anzeigename.Text = "RFID";
            // 
            // txtUpdatePasswort
            // 
            this.txtUpdatePasswort.Location = new System.Drawing.Point(657, 64);
            this.txtUpdatePasswort.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdatePasswort.Name = "txtUpdatePasswort";
            this.txtUpdatePasswort.Size = new System.Drawing.Size(151, 31);
            this.txtUpdatePasswort.TabIndex = 17;
            // 
            // txtNewPasswort
            // 
            this.txtNewPasswort.Location = new System.Drawing.Point(657, 143);
            this.txtNewPasswort.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewPasswort.Name = "txtNewPasswort";
            this.txtNewPasswort.Size = new System.Drawing.Size(151, 31);
            this.txtNewPasswort.TabIndex = 18;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(158, 64);
            this.txtUpdateName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(1, 31);
            this.txtUpdateName.TabIndex = 19;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(158, 143);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(1, 31);
            this.txtNewName.TabIndex = 20;
            // 
            // txtNewRFID
            // 
            this.txtNewRFID.HideSelection = false;
            this.txtNewRFID.Location = new System.Drawing.Point(6, 143);
            this.txtNewRFID.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewRFID.Name = "txtNewRFID";
            this.txtNewRFID.Size = new System.Drawing.Size(1, 31);
            this.txtNewRFID.TabIndex = 22;
            this.txtNewRFID.TextChanged += new System.EventHandler(this.txtNewRFID_TextChanged);
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
            // ClientAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ClientAdminView";
            this.Size = new System.Drawing.Size(992, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Löschen;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.TextBox txtUpdateVorname;
        private System.Windows.Forms.TextBox txtUpdateRFID;
        private System.Windows.Forms.TextBox txtNewVorname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Anzeigename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateGeld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewGeld;
        private System.Windows.Forms.TextBox txtUpdatePasswort;
        private System.Windows.Forms.TextBox txtNewPasswort;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewRFID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
