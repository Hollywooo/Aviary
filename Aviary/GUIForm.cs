﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviary
{
    public partial class GUIFormMain : Form
    {
        private Comparison results { get; set; }
        private Analytical ana { get; set; }
        private Objectives obj { get; set; }

        public GUIFormMain()
        {
            InitializeComponent();
        }

        private void buttonLoadROs_Click(object sender, EventArgs e)
        {
            obj = new Objectives();
        }

        private void buttonLoadAnalytical_Click(object sender, EventArgs e)
        {
            ana = new Analytical();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPerformComp_Click(object sender, EventArgs e)
        {
            ////Display results in listbox
            results = new Comparison(ana, obj);
            List<string> display = Output.ListBoxOutput(results);
            listBoxDisplayResults.DataSource = display;
            buttonExceedOnly.Enabled = true;
        }

        private void buttonExportToCSV_Click(object sender, EventArgs e)
        {
            ////Export a csv
            Output.Report(results);
            Output.TextReport(results);
        }

        private void GUIFormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void listBoxDisplayResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panelFilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelFilters_Click(object sender, EventArgs e)
        {

        }

        private void labelByExceedance_Click(object sender, EventArgs e)
        {

        }

        private void labelByMatrix_Click(object sender, EventArgs e)
        {

        }

        private void buttonExceedOnly_Click(object sender, EventArgs e)
        {
            results = new Comparison(ana, obj);
            List<string> displayXCDOnly = Output.ListBoxOutputXCDOnly(results);
            listBoxDisplayResults.DataSource = displayXCDOnly;
        }

        private void buttonWaterOnly_Click(object sender, EventArgs e)
        {

        }

        private void buttonSoilOnly_Click(object sender, EventArgs e)
        {

        }
    }
}
