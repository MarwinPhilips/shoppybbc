using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


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

        public static bool TextBoxFilled(TextBox[] textboxen)
        {
            for (int i = 0; i < textboxen.GetLength(0); i++)
            {
                if (textboxen[i].Text == "")
                    return false;
            }
            return true;
        }

        public static void txtBoxValue_IsNumber(TextBox[] textboxen)
        {
            for (int i = 0; i < textboxen.GetLength(0); i++)
            {
                if (textboxen[i].Text != null && !textboxen[i].Text.Equals(""))
                {
                    try
                    {
                        double.Parse(textboxen[i].Text);
                    }
                    catch
                    {
                        string txt = textboxen[i].Text;
                        string p = @"[0-9.]";

                        MatchCollection matches = Regex.Matches(txt, p);
                        string[] str = new string[matches.Count];
                        int punkt = 0;


                        for (int j = 0; j < matches.Count; j++)
                        {
                            str[j] = matches[j].Value;
                        }

                        for (int r = 0; r < str.Length; r++)
                        {
                            if (str[0].Equals("."))
                            {
                                str[0] = "";
                            }

                            if(str[r].Equals("."))
                            {
                                punkt++;
                                if (punkt > 1)
                                {
                                    str[r] = "";
                                }
                            }
                        }

                        string result = string.Join("",str);
                        MessageBox.Show("Geben Sie bitte die Zahl richtig ein");
                        textboxen[i].Text = result;
                        textboxen[i].Select(textboxen[i].Text.Length, 0);
                    }
                }
            }
        }

        public static void txtBoxValue_IsString(TextBox[] textboxen)
        {
            for (int i = 0; i < textboxen.GetLength(0); i++)
            {
                if (textboxen[i].Text != null && !textboxen[i].Text.Equals(""))
                {

                    string txt = textboxen[i].Text;
                    string p = @"[^a-zA-z]";

                    MatchCollection matches = Regex.Matches(txt, p);
                    string[] str = new string[matches.Count];
                    
                    

                    for (int j = 0; j < matches.Count; j++)
                    {
                        str[j] = matches[j].Value;
                    }

                    if (matches.Count > 0)
                    {
                        string txt2 = textboxen[i].Text;
                        string p2 = @"[A-Za-z]";

                        MatchCollection matches2 = Regex.Matches(txt2, p2);
                        string[] str2 = new string[matches2.Count];


                        for (int j = 0; j < matches2.Count; j++)
                        {
                            str2[j] = matches2[j].Value;
                        }

                        string result = string.Join("", str2);
                        MessageBox.Show("Es können keine Zahlen oder Sonderzeichen eingegeben werden");
                        textboxen[i].Text = result;
                        textboxen[i].Select(textboxen[i].Text.Length, 0);

                    }
                }
            }
        }
    }
}
