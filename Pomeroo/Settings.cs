using Pomeroo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomeroo
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            // assign new values to model
            TimerModel.workTime = int.Parse(txtWorkTime.Text);
            TimerModel.shortRest = int.Parse(txtShortRest.Text);
            TimerModel.longRest = int.Parse(txtLongRest.Text);
            TimerModel.cycleCount = int.Parse(txtCycleCount.Text);

            // close window
            this.DialogResult = DialogResult.OK;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtWorkTime.Text = TimerModel.workTime.ToString();
            txtShortRest.Text = TimerModel.shortRest.ToString();
            txtLongRest.Text = TimerModel.longRest.ToString();
            txtCycleCount.Text = TimerModel.cycleCount.ToString();
        }
    }
}
