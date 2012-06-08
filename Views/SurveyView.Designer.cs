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
            this.surveyViewCamSwitcher2 = new Shoppy.Views.SurveyViewCamSwitcher();
            this.surveyViewCamSwitcher1 = new Shoppy.Views.SurveyViewCamSwitcher();
            this.SuspendLayout();
            // 
            // surveyViewCamSwitcher2
            // 
            this.surveyViewCamSwitcher2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.surveyViewCamSwitcher2.Location = new System.Drawing.Point(0, 307);
            this.surveyViewCamSwitcher2.Name = "surveyViewCamSwitcher2";
            this.surveyViewCamSwitcher2.Size = new System.Drawing.Size(680, 293);
            this.surveyViewCamSwitcher2.TabIndex = 1;
            // 
            // surveyViewCamSwitcher1
            // 
            this.surveyViewCamSwitcher1.Dock = System.Windows.Forms.DockStyle.Top;
            this.surveyViewCamSwitcher1.Location = new System.Drawing.Point(0, 0);
            this.surveyViewCamSwitcher1.Name = "surveyViewCamSwitcher1";
            this.surveyViewCamSwitcher1.Size = new System.Drawing.Size(680, 293);
            this.surveyViewCamSwitcher1.TabIndex = 2;
            // 
            // SurveyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.surveyViewCamSwitcher1);
            this.Controls.Add(this.surveyViewCamSwitcher2);
            this.Name = "SurveyView";
            this.Size = new System.Drawing.Size(680, 600);
            this.ResumeLayout(false);

		}

		#endregion

        private SurveyViewCamSwitcher surveyViewCamSwitcher2;
        private SurveyViewCamSwitcher surveyViewCamSwitcher1;

    }
}
