﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOverview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Processor.Text = logic.GetComponent("Win32_Processor", "Name");
            Video.Text = logic.GetComponent("Win32_VideoController", "Name");
            Baseboard.Text = logic.GetComponent("Win32_BaseBoard", "Manufacturer") + " " + logic.GetComponent("Win32_BaseBoard", "Product");
            Ram.Text = logic.GetPhysicalMemory();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }

}
