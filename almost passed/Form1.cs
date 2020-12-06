using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almost_passed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void JumpButton_Click(object sender, EventArgs e)
        {
            var buildingName = BuildingBox.Text;
            var height = Convert.ToInt32(HeightBox.Text);
            var floor = Convert.ToInt32(FloorBox.Text);
            var building = Draw.draw(buildingName, height, floor);
            DialogResult dr = MessageBox.Show(building, "almost passed", MessageBoxButtons.YesNo);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}