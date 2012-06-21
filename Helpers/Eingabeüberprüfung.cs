using System;
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
            if (columnindex != -1)
            {
                if (dgv.Columns[rowindex] is DataGridViewTextBoxColumn && rowindex != -1)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static bool BinEinButton(DataGridView dgv, int rowindex, int columnindex)
        {
            if (columnindex != -1)
            {
                if (dgv.Columns[rowindex] is DataGridViewButtonColumn && rowindex != -1)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
