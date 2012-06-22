using System.Windows.Forms;
namespace Shoppy.Cam
{
    partial class CamViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.butVertical = new System.Windows.Forms.Button();
            this.butTop = new System.Windows.Forms.Button();
            this.butHorizontal = new System.Windows.Forms.Button();
            this.butBottom = new System.Windows.Forms.Button();
            this.butCenter = new System.Windows.Forms.Button();
            this.m_picture = new Cam.CamViewerPicture();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_picture, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(320, 280);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.butLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butRight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butVertical, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.butTop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.butHorizontal, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.butBottom, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.butCenter, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 233);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // butLeft
            // 
            this.butLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butLeft.Location = new System.Drawing.Point(3, 3);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(39, 41);
            this.butLeft.TabIndex = 0;
            this.butLeft.Text = " < ";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.but_Click);
            // 
            // butRight
            // 
            this.butRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butRight.Location = new System.Drawing.Point(48, 3);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(39, 41);
            this.butRight.TabIndex = 1;
            this.butRight.Text = " > ";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.but_Click);
            // 
            // butVertical
            // 
            this.butVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butVertical.Location = new System.Drawing.Point(273, 3);
            this.butVertical.Name = "butVertical";
            this.butVertical.Size = new System.Drawing.Size(44, 41);
            this.butVertical.TabIndex = 6;
            this.butVertical.Text = "^v";
            this.butVertical.UseVisualStyleBackColor = true;
            this.butVertical.Click += new System.EventHandler(this.but_Click);
            // 
            // butTop
            // 
            this.butTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butTop.Location = new System.Drawing.Point(93, 3);
            this.butTop.Name = "butTop";
            this.butTop.Size = new System.Drawing.Size(39, 41);
            this.butTop.TabIndex = 2;
            this.butTop.Text = " ^ ";
            this.butTop.UseVisualStyleBackColor = true;
            this.butTop.Click += new System.EventHandler(this.but_Click);
            // 
            // butHorizontal
            // 
            this.butHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butHorizontal.Location = new System.Drawing.Point(228, 3);
            this.butHorizontal.Name = "butHorizontal";
            this.butHorizontal.Size = new System.Drawing.Size(39, 41);
            this.butHorizontal.TabIndex = 5;
            this.butHorizontal.Text = "--";
            this.butHorizontal.UseVisualStyleBackColor = true;
            this.butHorizontal.Click += new System.EventHandler(this.but_Click);
            // 
            // butBottom
            // 
            this.butBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBottom.Location = new System.Drawing.Point(138, 3);
            this.butBottom.Name = "butBottom";
            this.butBottom.Size = new System.Drawing.Size(39, 41);
            this.butBottom.TabIndex = 3;
            this.butBottom.Text = " v ";
            this.butBottom.UseVisualStyleBackColor = true;
            this.butBottom.Click += new System.EventHandler(this.but_Click);
            // 
            // butCenter
            // 
            this.butCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCenter.Location = new System.Drawing.Point(183, 3);
            this.butCenter.Name = "butCenter";
            this.butCenter.Size = new System.Drawing.Size(39, 41);
            this.butCenter.TabIndex = 4;
            this.butCenter.Text = "|";
            this.butCenter.UseVisualStyleBackColor = true;
            this.butCenter.Click += new System.EventHandler(this.but_Click);
            // 
            // m_picture
            // 
            this.m_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_picture.Location = new System.Drawing.Point(0, 0);
            this.m_picture.Margin = new System.Windows.Forms.Padding(0);
            this.m_picture.MinimumSize = new System.Drawing.Size(320, 240);
            this.m_picture.Name = "m_picture";
            this.m_picture.Password = null;
            this.m_picture.Size = new System.Drawing.Size(320, 240);
            this.m_picture.TabIndex = 1;
            this.m_picture.TabStop = false;
            this.m_picture.Url = null;
            this.m_picture.User = null;
            // 
            // CamViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(320, 280);
            this.Name = "CamViewer";
            this.Size = new System.Drawing.Size(320, 280);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Cam.CamViewerPicture m_picture;
        private System.Windows.Forms.Button butTop;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butVertical;
        private System.Windows.Forms.Button butHorizontal;
        private System.Windows.Forms.Button butCenter;
        private System.Windows.Forms.Button butBottom;
        private string m_url;
        private string m_user;
        private string m_password;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;

    }
}
