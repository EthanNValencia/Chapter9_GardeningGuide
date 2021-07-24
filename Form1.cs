using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * I encountered a weird problem with visual studio. I could not delete anything. It would
 * cause a windows noise when I pushed the delete key. Alt + Enter fixed the problem. 
 */
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
            foreach (int treeIndex in lstBoxTrees.SelectedIndices)
            {
                this.txtBoxTrees.Text += lstBoxTrees.Items[treeIndex] + " ";
            }
        }
        
        private void comboBoxFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBoxFlower.Text = this.comboBoxFlowers.SelectedItem.ToString();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // Displays version information when the about menu btn is clicked.
        {
            MessageBox.Show("Gardenning Guide Application\n\n\nVersion 10", "About Gardening");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Exits the application.
        {
            Application.Exit();
        }

        /*
         * Example 9-19, pg 511
         */
        private void fontToolStripMenuItem_Click(object sender, EventArgs e) // This is pretty cool
        {
            /*
             * This is used to change the font of the text in the label. 
             */
            fontDialog1.Font = lblOutput.Font; // This retrieves the current font setting. 
            if(fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.Font = fontDialog1.Font;
            }
        }
        /*
         * Example 9-19, pg 511
         */
        private void colorToolStripMenuItem_Click(object sender, EventArgs e) // This is pretty cool
        {
            /*
             * This is used to change the color of the text in the label.
             */
            colorDialog1.Color = lblOutput.ForeColor; // This retrieves the current color setting.
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.ForeColor = colorDialog1.Color;
            }
        }
    }
}
