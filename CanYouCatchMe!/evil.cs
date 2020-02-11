using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanYouCatchMe_
{
    public partial class evil : Form
    {
        public evil()
        {
            InitializeComponent();
        }

        public void load(string a)
        {
            evilbox.Text = a;
        }
    }
}
