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

		}

	}
}
