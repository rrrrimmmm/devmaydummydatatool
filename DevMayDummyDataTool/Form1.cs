using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMayDummyDataTool
{
    public partial class Form1 : Form
    {
        private DateTime firstDate;
        private DateTime lastDate;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            updateDate();
        }

        private void updateDate()
        {
            firstDate = FirstDateTimePicker.Value;
            lastDate = LastDateTimePicker.Value;

            TimeSpan diff = lastDate - firstDate;

            //System.Diagnostics.Debug.WriteLine("diff.TotalSeconds : " + diff.TotalSeconds);

            if (diff.TotalSeconds < 0)
            {
                lastDate = firstDate;
                LastDateTimePicker.Value = lastDate;
            }
        }

        private void onFirstDateValueChanged(object sender, EventArgs e)
        {
            updateDate();
        }

        private void onLastDateValueChanged(object sender, EventArgs e)
        {
            updateDate();
        }               
    }
}
