using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;

namespace Shoppy.Views
{
	public partial class SurveyViewCamSwitcher: UserControl
	{
        CamAdmin database = new CamAdmin();
		public SurveyViewCamSwitcher()
		{
			InitializeComponent();
            FillCams();
		}

        private void SetCam(string id)
        {
            
            DataRow row = database.GetSingleCamInfo(id);
            tableLayoutPanel1.Controls.Remove(camViewer1);
            this.Controls.Remove(camViewer1);
            this.camViewer1 = new CamViewer();
            ((System.ComponentModel.ISupportInitialize)(this.camViewer1)).BeginInit();
            this.SuspendLayout();
            this.camViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camViewer1.Location = new System.Drawing.Point(3, 3);
            this.camViewer1.Name = "camViewer1";
            this.camViewer1.Size = new System.Drawing.Size(320, 280);
            this.camViewer1.TabIndex = 4;
            camViewer1.Name = "camViewer1";
            camViewer1.Password = row.ItemArray[2].ToString();
            camViewer1.User = row.ItemArray[1].ToString();
            camViewer1.Url = row.ItemArray[0].ToString();
            this.Controls.Add(this.camViewer1); 
            ((System.ComponentModel.ISupportInitialize)(this.camViewer1)).EndInit();
            this.tableLayoutPanel1.Controls.Add(this.camViewer1, 0, 0);
            this.ResumeLayout(false);
        }

        private void FillCams()
        {
            dataGridView1.DataSource =  database.getSurveyViewCams();
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCam(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
	}
}
