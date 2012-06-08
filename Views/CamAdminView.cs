using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;

namespace Shoppy.Views
{
	public partial class CamAdminView: UserControl
	{
        CamAdmin database = new CamAdmin();
		public CamAdminView()
		{
			InitializeComponent();
            dataGridView1.DataSource = database.getCams();
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (binEinButton(e))
            {
                deleteRow(e);
            }
        }

        private bool binEinButton(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void deleteRow(DataGridViewCellEventArgs e)
        { 
            
        }

	}
}
