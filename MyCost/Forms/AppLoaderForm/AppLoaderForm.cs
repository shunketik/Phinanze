﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCost.Forms
{
    public partial class AppLoaderForm : Form
    {
        private int _countSeconds = 0;

        public AppLoaderForm()
        {
            InitializeComponent();
        }

        private void AppLoaderForm_Load(object sender, EventArgs e)
        {

        }

        private void TimerTick(object sender, EventArgs e)
        {
            _countSeconds++;

            if(_countSeconds == 3)
            {
                UserAuthenticationForm form = new UserAuthenticationForm();
                form.Show();

                this.Hide();
            }
        }

        private void AppLoaderFormShown(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
    }
}