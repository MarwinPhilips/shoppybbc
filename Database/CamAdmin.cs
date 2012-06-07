using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shoppy.Database
{
	class CamAdmin : Abfragen
	{
        public string[,] getCams()
        {
            string[,] returner = Select("");
            return returner;
        }
	}
}
