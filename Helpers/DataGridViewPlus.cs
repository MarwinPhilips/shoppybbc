﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shoppy.Helpers
{
    // Diese Klasse fängt fehlerhafte Paint-Events ab und zwingt das DataGridView zum erneuten Zeichnen.
    public partial class DataGridViewPlus : DataGridView
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);
            }
            catch
            {
                Invalidate();
            }
        }
    }
}
