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
        String PathOfTrackFolder = Directory.GetCurrentDirectory() + "\\Tracks\\"; // Gets the path of the folder for the tracks 

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
            if(IsSongPlaying == true){//If a song is playing....
                Playlist_lst.Items.Add(WhichSongChosen);//Add the selected song to the playlist list box 
            }else if(IsSongPlaying == false){//If there are no songs playing....
                PresentlyPlaying_txt.Text = WhichSongChosen;//Storing the song that has been chosen in the textbox so we know what song is playing
                Mediaplayer_wmp.URL = PathOfTrackFolder + WhichSongChosen; //Creating the whole URL/Path for the Windows Media Player
                Play_Windows_Media_Player();//Calling the function to play the media player
                
            }
        }

        private void IncrementToNextTrack(){
            int index = 0;//create a variable to assign an index value to
            PresentlyPlaying_txt.Text = Playlist_lst.Items[index].ToString();//Adds in the next presently playing track to the text box for presently playing
            Playlist_lst.Items.RemoveAt(index);//Removes the song that was before it

            Mediaplayer_wmp.URL = PathOfTrackFolder + PresentlyPlaying_txt.Text;//Creating the complete URL/PATH for the media player
            Play_Windows_Media_Player();//Calling the function to play the media player
        }

        private void Play_Windows_Media_Player(){
            Mediaplayer_wmp.Ctlcontrols.play();//Initiating the windows media player
            IsSongPlaying = true;//set the boolean to true as a song is currently playing
        }


        private void Mediaplayer_wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e){
            if(Mediaplayer_wmp.playState == WMPLib.WMPPlayState.wmppsStopped){//Checking to see if the media player status is stopped
                //if it is....
                IsSongPlaying = false;//Set the boolean var to false
            }else{
                //If it isnt....
                IsSongPlaying = true;//set boolean var to true
            }
        }

    }
}
