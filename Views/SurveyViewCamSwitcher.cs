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
            cam.Url = row.ItemArray[0].ToString();
            cam.User = row.ItemArray[1].ToString();
            cam.Password = row.ItemArray[2].ToString();
            cam.BeginInit();
            cam.EndInit();
            MessageBox.Show(row.ItemArray[0].ToString());
        }

        private void FillCams()
        {
            dataGridView1.DataSource =  database.getSurveyViewCams();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCam(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
	}
}
