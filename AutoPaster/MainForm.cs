using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPaster
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            string text = this.tbInput.Text;
            System.Threading.Timer timer = new System.Threading.Timer(x =>
            {
                while (text.Length > 0)
                {
                    string character = text.Substring(0, 1);
                    SendKeys.SendWait(isSpecialChar(character) ? "{" + character + "}" : character);                    
                    text = text.Substring(1);
                    Thread.Sleep(20);
                }
            }, null, TimeSpan.FromMilliseconds(3000), Timeout.InfiniteTimeSpan);
        }

        private bool isSpecialChar(char character)
        {
            char[] specialChars = { '{', '}', '(', ')', '+', '^' };
            foreach(char specialChar in specialChars)
            {
                if (character == specialChar)
                {
                    return true;
                }
            }
            return false;

        }

        private bool isSpecialChar(string character)
        {
            return isSpecialChar(character.ToCharArray()[0]);

        }

    }
}
