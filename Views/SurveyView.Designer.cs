namespace Shoppy.Views
{
	partial class SurveyView
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
            this.camViewer1 = new CamView.CamViewer();
            this.panel1 = new CamView.CamViewer();
            ((System.ComponentModel.ISupportInitialize)(this.camViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.SuspendLayout();
            // 
            // camViewer1
            // 
            this.camViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camViewer1.Location = new System.Drawing.Point(355, 163);
            this.camViewer1.Name = "camViewer1";
            this.camViewer1.Password = "weitblick";
            this.camViewer1.Size = new System.Drawing.Size(320, 275);
            this.camViewer1.TabIndex = 3;
            this.camViewer1.Url = "172.16.1.252";
            this.camViewer1.User = "camera";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 163);
            this.panel1.Name = "panel1";
            this.panel1.Password = "weitblick";
            this.panel1.Size = new System.Drawing.Size(320, 275);
            this.panel1.TabIndex = 2;
            this.panel1.Url = "172.16.1.251";
            this.panel1.User = "camera";
            // 
            // SurveyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.camViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "SurveyView";
            this.Size = new System.Drawing.Size(680, 600);
            ((System.ComponentModel.ISupportInitialize)(this.camViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private CamView.CamViewer camViewer1;
        private CamView.CamViewer panel1;
	}
}
