﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void monthCalendarAdv1_ItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(MCLDLich.SelectedDate.ToShortDateString()); 
        }
    }
}
