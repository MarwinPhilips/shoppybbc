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
        int pageIndex2;

        public Form1()
        {
            InitializeComponent();
            //pageIndex = 0;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose(true);
        }


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //--------Entfernen----------
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
            else if (e.TabPageIndex == 2)
            {
                sellView1.View_Unload();
                payment_View1.Payment_View_Unload();
            }
            else if (e.TabPageIndex == 3)
            {
                sellView1.View_Unload();
                payment_View1.Payment_View_Unload();
            }
            else if (pageIndex == 3)
            {
                sellerAdminView1.View_Unload();
                clientAdminView1.View_Unload();
            }
            
            
            //-------Hinzufügen----------
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


       private void tabControl2_Selecting(object sender, TabControlCancelEventArgs e)
       {
             
            //--------Entfernen---------
            if (pageIndex2 == 0)
            {
                clientAdminView1.View_Unload();
            }

            //Seller
            else if (pageIndex2 == 3)
            {
                sellerAdminView1.View_Unload();
            }
            if (e.TabPageIndex == 1 || e.TabPageIndex == 2)
            {
                sellerAdminView1.View_Unload();
                clientAdminView1.View_Unload();
            }
            

            //---------Hinzufügen----------
            //ClientAdmin
            if (e.TabPageIndex == 0)
            {
                clientAdminView1.View_MyLoad();
            }
            else if (e.TabPageIndex == 3)
            {
                sellerAdminView1.View_MyLoad();
            }

            pageIndex2 = e.TabPageIndex;
       }
    }
}

