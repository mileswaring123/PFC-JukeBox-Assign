using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JukeBoxv1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUp setUp = new SetUp(); //Creates a new Set Up form
            setUp.ShowDialog();//Opens up the Set Up form
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); //Creates a new About form
            about.ShowDialog();//Opens up the About form
        }

        ListBox[] Imported_Songs; //List box to hold all songs the user wants to listen too
        String[] Name_of_Genre; //String to hold the name of the genre that has been chosen
        bool IsSongPlaying = false; //bool to state if a song is playing of not (for initiating timers)

        private void Mediaplayer_wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

        }
    }
}
