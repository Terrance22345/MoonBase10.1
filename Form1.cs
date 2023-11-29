using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Moonbase
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();

            // Set the window state to Maximized for full screen
            this.WindowState = FormWindowState.Maximized;

            //Initialize the soundPlayer with the path to your audio file
            soundPlayer = new SoundPlayer("fsm-team-escp-midnight-room.mp3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Play the music when the form is loaded
            soundPlayer.Play();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the music when the form is closing
            soundPlayer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This code pop up a message box asking you a question. Then either close
            //the box or the program depending on the input.
            DialogResult dr = MessageBox.Show("Are you sure you don't want to go on the Space Adventure!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            
        {
            // Simple code that checks if the box was checked. Then allows you to press sign up
            button2.Enabled = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Just shows the acccount was created then closes the program.
            MessageBox.Show("Account is Created. Welcome to the Team!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Code to navigate to WestwingForm
            WestwingForm westwingForm = new WestwingForm();
            westwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when WestwingForm is closed
            westwingForm.Show();


        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            // Code to navigate to EastwingForm
            EastwingForm eastwingForm = new EastwingForm();
            eastwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when EastwingForm is closed
            eastwingForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Code to navigate to SouthwingForm
            SouthwingForm southwingForm = new SouthwingForm();
            southwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when SouthwingForm is closed
            southwingForm.Show();
        }
    }
}
