using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mp3_player
{
    /// <summary>
    /// A playlist class that stores a playlist of songs
    /// </summary>
    public class Playlist
    {
        //Creates a list to store each song in the playlist
        public List<Song> SongList;


        public Playlist() 
        { 
            SongList = new List<Song>();
        }

        /// <summary>
        /// Returns the next valid song ID. Naively one more than the playlist length
        /// </summary>
        
        public int NextId
        {
            get
            {
                return SongList.Count + 1; //Gets next ID number to use 
            }
        }
        public int SongCount()
        { return SongList.Count; }

        /// <summary>
        /// Adds a song to the playlist. Provided here for information hiding in case the SongList is not public
        /// </summary>
        /// <param name=""></param>
        public void AddSong(Song newsong)
        {
            SongList.Add(newsong);
        }
        
        public Song GetSong(int index) 
        {
            if (index >= 0 && index < SongList.Count)
            {
                return SongList[index]; // Return the song at the specified index
            }
            else
            {
                // Optionally handle invalid index scenario, e.g., by throwing an exception or returning null
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

        }

        public void UpdateListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            listBox.Items.Add(SongList);
        }
    }
}
