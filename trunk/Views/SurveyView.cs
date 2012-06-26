using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Shoppy.Views
{
    // In diesem UserControl werden vier SurveyViewCamSwitcher dargestellt.
	public partial class SurveyView: UserControl
	{
        // Initialisiert das Objekt.
		public SurveyView()
		{
			InitializeComponent();
            surveyViewCamSwitcher1.Survey_View_Cam_Switcher_Reload(1);
            surveyViewCamSwitcher2.Survey_View_Cam_Switcher_Reload(2);
            surveyViewCamSwitcher3.Survey_View_Cam_Switcher_Reload(3);
            surveyViewCamSwitcher4.Survey_View_Cam_Switcher_Reload(4);
		}
    }
}
