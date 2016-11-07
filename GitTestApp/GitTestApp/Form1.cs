using System.Collections.Generic;
using System.Windows.Forms;

namespace GitTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var thing = new List<string>("hello", "dolly");
        }
    }
}
