using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventTest.TestAction;

namespace EventTest
{
    public partial class Form1 : Form
    {

        #region member
        private bool start_flag = true;
        #endregion
        private Action<string> action;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (start_flag)
            {
                //
                //
                action = DelegText;
                new TestWriteAction(action);
                start_flag = false;
                btn_start.Text = "Stop";
            }
            else
            {
                start_flag = true;
                btn_start.Text = "Start";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_write.Text = string.Empty;
        }

        private void DelegText(string msg)
        {
            SetText(textBox_write, msg);
        }    
    
        private void SetText(TextBox textBox, string msg)
        {
            textBox.Text = textBox.Text + Environment.NewLine + msg;
        }
    }
}
