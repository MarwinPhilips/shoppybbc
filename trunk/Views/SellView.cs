using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Shoppy.Views
{
	public partial class SellView: UserControl
	{
		public SellView()
		{
			InitializeComponent();
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtInputBarcode.Text.Length == 12) {
                /*...*/

            }
        }
	}
}
