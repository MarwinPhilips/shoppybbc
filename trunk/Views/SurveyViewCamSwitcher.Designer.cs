namespace Shoppy.Views
{
	partial class SurveyViewCamSwitcher
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
            this.cam = new CamView.CamViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 275);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cam
            // 
            this.cam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cam.Location = new System.Drawing.Point(3, 3);
            this.cam.Name = "cam";
            this.cam.Password = "weitblick";
            this.cam.Size = new System.Drawing.Size(320, 275);
            this.cam.TabIndex = 4;
            this.cam.Url = "172.16.1.251";
            this.cam.User = "camera";
            // 
            // SurveyViewCamSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cam);
            this.Name = "SurveyViewCamSwitcher";
            this.Size = new System.Drawing.Size(579, 286);
            this.Load += new System.EventHandler(this.SurveyViewCamSwitcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CamView.CamViewer cam;
	}
}
