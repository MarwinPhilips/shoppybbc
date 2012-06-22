﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shoppy.Helpers
{
    static class Eingabeüberprüfung
    {
        public static bool BinEineZeile(DataGridView dgv, int rowindex, int columnindex)
        {
            if (rowindex != -1)
            {
                if (dgv.Columns[columnindex] is DataGridViewTextBoxColumn && columnindex != -1)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static bool BinEinButton(DataGridView dgv, int rowindex, int columnindex)
        {
            if (rowindex != -1)
            {
                if (dgv.Columns[columnindex] is DataGridViewButtonColumn && columnindex != -1)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
