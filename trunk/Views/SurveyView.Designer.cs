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
            this.surveyViewCamSwitcher1 = new Views.SurveyViewCamSwitcher();
            this.surveyViewCamSwitcher2 = new Views.SurveyViewCamSwitcher();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // surveyViewCamSwitcher1
            // 
            this.surveyViewCamSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surveyViewCamSwitcher1.Location = new System.Drawing.Point(6, 6);
            this.surveyViewCamSwitcher1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.surveyViewCamSwitcher1.Name = "surveyViewCamSwitcher1";
            this.surveyViewCamSwitcher1.Size = new System.Drawing.Size(988, 325);
            this.surveyViewCamSwitcher1.TabIndex = 2;
            // 
            // surveyViewCamSwitcher2
            // 
            this.surveyViewCamSwitcher2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surveyViewCamSwitcher2.Location = new System.Drawing.Point(6, 343);
            this.surveyViewCamSwitcher2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.surveyViewCamSwitcher2.Name = "surveyViewCamSwitcher2";
            this.surveyViewCamSwitcher2.Size = new System.Drawing.Size(988, 325);
            this.surveyViewCamSwitcher2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.surveyViewCamSwitcher1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.surveyViewCamSwitcher2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 674);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SurveyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SurveyView";
            this.Size = new System.Drawing.Size(1000, 674);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private SurveyViewCamSwitcher surveyViewCamSwitcher2;
        private SurveyViewCamSwitcher surveyViewCamSwitcher1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}
