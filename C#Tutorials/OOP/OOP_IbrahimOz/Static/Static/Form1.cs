﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shagird s = new Shagird();
            s.adi = "Terlan";
           
            Shagird s2 = new Shagird();
            s.adi = "Isa";

            Shagird.Save();
        }
    }
}
