using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Shoppy.Views
{
	public partial class SurveyView: UserControl
	{
		public SurveyView()
		{
			InitializeComponent();

            
		}

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }




        internal void Survey_View_Load()
        {
            surveyViewCamSwitcher1.Survey_View_Cam_Switcher_Reload();
            surveyViewCamSwitcher2.Survey_View_Cam_Switcher_Reload();
            surveyViewCamSwitcher3.Survey_View_Cam_Switcher_Reload();
            surveyViewCamSwitcher4.Survey_View_Cam_Switcher_Reload();
        }
    }
}
