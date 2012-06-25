using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Shoppy.Cam;

namespace Shoppy.Views
{
	public partial class SurveyViewCamSwitcher: UserControl
	{
        CamAdmin database = new CamAdmin();
        // Initialisert das Objekt und füllt das DGV.
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
            camViewer1.Dispose();
            this.camViewer1 = new Cam.CamViewer();
            camViewer1.BeginInit();
            this.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            this.camViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camViewer1.Location = new System.Drawing.Point(3, 3);
            camViewer1.Name = "camViewer1";
            camViewer1.Password = row.ItemArray[2].ToString();
            camViewer1.User = row.ItemArray[1].ToString();
            camViewer1.Url = row.ItemArray[0].ToString();
            this.camViewer1.EndInit();
            this.Controls.Add(this.camViewer1);             
            this.tableLayoutPanel1.Controls.Add(this.camViewer1, 0, 0);
            tableLayoutPanel1.ResumeLayout();
            this.ResumeLayout(false);
        }

        private void FillCams()
        {
            dataGridView1.DataSource =  database.getSurveyViewCams();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Helpers.Eingabeüberprüfung.BinEineZeile(dataGridView1,e.RowIndex,e.ColumnIndex))
            {
                SetCam(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
        // Initialisiert das KameraFeld
        internal void Survey_View_Cam_Switcher_Reload(int position)
        {
            if((dataGridView1.Rows.Count>position) && dataGridView1.Rows[position-1].Cells[0].Value.ToString() != "")
            {
                SetCam(dataGridView1.Rows[position-1].Cells[0].Value.ToString());
            }
        }
    }
}
