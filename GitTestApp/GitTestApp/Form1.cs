﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace GitTestApp
{
    public partial class Form1 : Form
    {
        private string _myThing = "Change from Master";

        public Form1()
        {
            InitializeComponent();

            var thing = new List<string>()
            {
                "hello",
                "dolly",
                "well",
                "hello dolly"
            };
        }
    }
}
