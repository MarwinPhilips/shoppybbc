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
            tableLayoutPanel1.Controls.Remove(cam);
            this.Controls.Remove(cam);
            this.cam = new CamView.CamViewer();
            ((System.ComponentModel.ISupportInitialize)(this.cam)).BeginInit();
            this.SuspendLayout();
            this.cam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam.Location = new System.Drawing.Point(3, 3);
            this.cam.Name = "cam";
            this.cam.Size = new System.Drawing.Size(320, 280);
            this.cam.TabIndex = 4;
            cam.Name = "cam";
            cam.Password = row.ItemArray[2].ToString();
            cam.User = row.ItemArray[1].ToString();
            cam.Url = row.ItemArray[0].ToString();
            this.Controls.Add(this.cam); 
            ((System.ComponentModel.ISupportInitialize)(this.cam)).EndInit();
            this.tableLayoutPanel1.Controls.Add(this.cam, 0, 0);
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
