using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shoppy
{
    public partial class Form1 : Form
    {

        int pageIndex;


        public Form1()
        {
            InitializeComponent();
            pageIndex = 0;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose(true);
        }


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Entfernen
            //SellView
            if (pageIndex == 0)
            {
                sellView1.View_Unload();

            }
            //Payment
            else if (pageIndex == 1)
            {
                payment_View1.Payment_View_Unload();
            }
            
            
            //Hinzufügen
            //Payment
            if (e.TabPageIndex == 1)
            {
                payment_View1.Payment_View_MyLoad();
                
            }
            //SellView
            else if (e.TabPageIndex == 0)
            {
                sellView1.View_MyLoad();
            }


            

            pageIndex = e.TabPageIndex;

        }
    }
}

