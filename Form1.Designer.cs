﻿namespace Shoppy
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sellView1 = new Views.SellView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.payment_View1 = new Views.Payment_View();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.surveyView1 = new Views.SurveyView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.clientAdminView1 = new Views.ClientAdminView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.sellAdminView1 = new Views.SellAdminView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.camAdminView2 = new Views.CamAdminView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.sellerAdminView1 = new Views.SellerAdminView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.logout1 = new Views.Logout();
            this.login1 = new Views.Login();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 716);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sellView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(976, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sell";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sellView1
            // 
            this.sellView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellView1.Location = new System.Drawing.Point(6, 6);
            this.sellView1.Margin = new System.Windows.Forms.Padding(0);
            this.sellView1.Name = "sellView1";
            this.sellView1.Size = new System.Drawing.Size(964, 646);
            this.sellView1.TabIndex = 0;
            this.sellView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.payment_View1);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(976, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // payment_View1
            // 
            this.payment_View1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment_View1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_View1.Location = new System.Drawing.Point(6, 6);
            this.payment_View1.Margin = new System.Windows.Forms.Padding(6);
            this.payment_View1.Name = "payment_View1";
            this.payment_View1.Size = new System.Drawing.Size(180, 62);
            this.payment_View1.TabIndex = 0;
            this.payment_View1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.surveyView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(976, 658);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Survey";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // surveyView1
            // 
            this.surveyView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surveyView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyView1.Location = new System.Drawing.Point(0, 0);
            this.surveyView1.Margin = new System.Windows.Forms.Padding(6);
            this.surveyView1.MinimumSize = new System.Drawing.Size(1000, 674);
            this.surveyView1.Name = "surveyView1";
            this.surveyView1.Size = new System.Drawing.Size(1000, 674);
            this.surveyView1.TabIndex = 0;
            this.surveyView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl2);
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(976, 658);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(150, 50);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(976, 658);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.clientAdminView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 54);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage5.Size = new System.Drawing.Size(968, 600);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Client";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // clientAdminView1
            // 
            this.clientAdminView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientAdminView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAdminView1.Location = new System.Drawing.Point(6, 6);
            this.clientAdminView1.Margin = new System.Windows.Forms.Padding(6);
            this.clientAdminView1.Name = "clientAdminView1";
            this.clientAdminView1.Size = new System.Drawing.Size(956, 588);
            this.clientAdminView1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.sellAdminView1);
            this.tabPage6.Location = new System.Drawing.Point(4, 54);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage6.Size = new System.Drawing.Size(184, 16);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Sell";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // sellAdminView1
            // 
            this.sellAdminView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellAdminView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellAdminView1.Location = new System.Drawing.Point(6, 6);
            this.sellAdminView1.Margin = new System.Windows.Forms.Padding(6);
            this.sellAdminView1.Name = "sellAdminView1";
            this.sellAdminView1.Size = new System.Drawing.Size(956, 588);
            this.sellAdminView1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.camAdminView2);
            this.tabPage7.Location = new System.Drawing.Point(4, 54);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(184, 16);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Survey";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // camAdminView2
            // 
            this.camAdminView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camAdminView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camAdminView2.Location = new System.Drawing.Point(0, 0);
            this.camAdminView2.Margin = new System.Windows.Forms.Padding(6);
            this.camAdminView2.Name = "camAdminView2";
            this.camAdminView2.Size = new System.Drawing.Size(968, 600);
            this.camAdminView2.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.sellerAdminView1);
            this.tabPage8.Location = new System.Drawing.Point(4, 54);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(184, 16);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Seller";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // sellerAdminView1
            // 
            this.sellerAdminView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellerAdminView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerAdminView1.Location = new System.Drawing.Point(0, 0);
            this.sellerAdminView1.Margin = new System.Windows.Forms.Padding(6);
            this.sellerAdminView1.Name = "sellerAdminView1";
            this.sellerAdminView1.Size = new System.Drawing.Size(968, 600);
            this.sellerAdminView1.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.logout1);
            this.tabPage9.Location = new System.Drawing.Point(4, 54);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(976, 658);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Logout";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // logout1
            // 
            this.logout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logout1.Location = new System.Drawing.Point(0, 0);
            this.logout1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.logout1.Name = "logout1";
            this.logout1.Size = new System.Drawing.Size(192, 74);
            this.logout1.TabIndex = 0;
            // 
            // login1
            // 
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Margin = new System.Windows.Forms.Padding(0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(984, 716);
            this.login1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 738);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "Form1";
            this.Text = "SHOPPY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Views.SurveyView surveyView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Views.SellAdminView sellAdminView1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private Views.SellerAdminView sellerAdminView1;
        private Views.CamAdminView camAdminView2;
        private Views.Payment_View payment_View1;
        private Views.ClientAdminView clientAdminView1;
        private Views.Login login1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage9;
        private Views.Logout logout1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public Views.SellView sellView1;



    }
}