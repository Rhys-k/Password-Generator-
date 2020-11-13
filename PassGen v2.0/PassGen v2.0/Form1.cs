using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen_v2._0
{
    public partial class rootPanel: Form
    {
        public rootPanel()
        {
            InitializeComponent();
        }

        private void genPass_Click(object sender, EventArgs e)
        {

        }

        private void genPassBtn_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!£$%^&*()-=+_[]{}@#/?><,.";
            var stringChars = new char[passLength.Value];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            passtxt.Text = finalString;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(@"C:\Users\rhysa\OneDrive - University of Chester\Level 4\cs4\CO4225 Programming\C#\PassGen v2.0\PassGen v2.0\bin\Debug\passwords.txt"))
            {
                sw.Write(webApptxt.Text);
                sw.Write(": ");
                sw.Write(passtxt.Text+"\n");
                sw.Close();
                passtxt.Clear();
                webApptxt.Clear();
            }
        }

        private void viewPassBtn_Click(object sender, EventArgs e)
        {
            Process.Start("passwords.txt", @"C:\Users\rhysa\OneDrive - University of Chester\Level 4\cs4\CO4225 Programming\C#\PassGen v2.0\PassGen v2.0\bin\Debug\passwords.txt");
        }
    }
}
