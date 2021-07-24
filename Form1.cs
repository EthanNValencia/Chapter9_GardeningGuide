using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9_GardeningGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBoxTrees_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBoxTrees.Text = " ";
            foreach(int treeIndex in lstBoxTrees.SelectedIndices)
            {
                this.txtBoxTrees.Text += lstBoxTrees.Items[treeIndex] + " ";
            }
        }

        private void comboBoxFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBoxFlower.Text = this.comboBoxFlowers.SelectedItem.ToString();
        }
    }
}
