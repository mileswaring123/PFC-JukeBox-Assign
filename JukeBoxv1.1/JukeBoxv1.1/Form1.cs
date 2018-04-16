using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        String PathOFMediaFolder = Directory.GetCurrentDirectory() + "\\Media\\"; //Gets the path for the folder of the songs

        private void Mediaplayer_wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

        }

        private void Form1_Load(object sender, EventArgs e){
            StreamReader SongsFromMediaFolder = File.OpenText(PathOFMediaFolder + "Media.txt"); //Opens the text file containing the info about the songs
            String ReadMediaInformation = SongsFromMediaFolder.ReadLine(); //Reads each line of the text file to get the track data
            int CheckIfLineIsInt; //creating variable to check if text file is a integer
            if(int.TryParse(ReadMediaInformation, out CheckIfLineIsInt)){//Checks if the line is a number
                Imported_Songs = new ListBox[CheckIfLineIsInt];//if the line is a number then create a new listbox
            }

            int CountOfImportedTracks = Imported_Songs.Count(); //Counts the amount of songs that are in the listbox
            HScrollBar.Maximum = CountOfImportedTracks - 1;//Sets the scope for the horizontal scroll bar
            Name_of_Genre = new string[CountOfImportedTracks];//Assgns the Title of the listbox to the global variable
            ReadMediaInformation = SongsFromMediaFolder.ReadLine();//Reads the line of the textfile again and assigns to local var

            for(int index = 0; index < CountOfImportedTracks; index++){//For loop to go through each line of the text file to pull out the required information
                Imported_Songs[index] = new ListBox();//Creates a new list box
                if(int.TryParse(ReadMediaInformation, out CheckIfLineIsInt) == true){//Check to make sure the line is an integer
                    //If it is integer....
                    ReadMediaInformation = SongsFromMediaFolder.ReadLine();//Reads a line from the text file..
                    Name_of_Genre[index] = ReadMediaInformation;//Assigns the first line of the file to the genre title string global var
                    ReadMediaInformation = SongsFromMediaFolder.ReadLine();//Reads another line from the text file...

                    while (ReadMediaInformation != null && (int.TryParse(ReadMediaInformation, out CheckIfLineIsInt) == true){//While loop to check if th line is either empty or an integer
                        Imported_Songs[index].Items.Add(SongsFromMediaFolder);//Adding items to the listbox 
                        ReadMediaInformation = SongsFromMediaFolder.ReadLine();// Reading Another line from the text file
                    }
                }
            }
        }

        private void GenreList_lst_MouseDoubleClick(object sender, MouseEventArgs e) { 
            string WhichSongChosen = GenreList_lst.Items[GenreList_lst.SelectedIndex].ToString();
            //Assigns the song that has been double clicked by getting the selected index
            if(IsSongPlaying == true){
                Playlist_lst.Items.Add(WhichSongChosen);
            }else if(Playlist_lst.Items.Count == 0 && IsSongPlaying == false){
                
            }
        }
    }
}
