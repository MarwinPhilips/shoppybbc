﻿using System;
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
            FillData();
            
		}

        private void FillData()
        {
            dataGridView1.DataSource = database.GetCams();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BinEinButton(e))
            {
                DeleteRow(e);
            }
            else if (BinEineZeile(e))
            {
                FillUpdateBoxes(e);
            }
        }

        private void FillUpdateBoxes(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtUpdateAnzeigename.Text = row.Cells[3].Value.ToString();
            txtUpdateLoginname.Text = row.Cells[4].Value.ToString();
            txtUpdateIP.Text = row.Cells[2].Value.ToString();
            txtUpdatePasswort.Text = row.Cells[5].Value.ToString();
            btnUpdateCam.Tag = row.Cells[1].Value.ToString();
        }

        private bool BinEineZeile(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex !=-1)
            {
                return true;
            }
            return false;
        }

        private bool BinEinButton(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            database.DeleteCam(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            FillData();
        }

	}
}
