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

namespace Moonbase
{
    public partial class WestwingForm : Form
    {
        private SoundPlayer soundPlayer;
        public WestwingForm()
        {
            InitializeComponent();

            // Set the window state to Maximized for full screen
            this.WindowState = FormWindowState.Maximized;

            //Initialize the soundPlayer with the path to your audio file
            soundPlayer = new SoundPlayer("fsm-team-escp-please-dont-forget-me.mp3");
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
        private void Westwing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Close the current form (Westwing.cs)
            this.Close();

            // Show Form1
            form1.Show();
        }
    }
}
