using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Calibration
{
    public partial class CalibrationForm : Form
    {
        public CalibrationForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            var flowPanel = sender as FlowLayoutPanel;
            flowPanel.Controls.OfType<Panel>().ToList().ForEach(x => {
                x.Width = flowPanel.Width - 25;
            });
        }
    }
}
