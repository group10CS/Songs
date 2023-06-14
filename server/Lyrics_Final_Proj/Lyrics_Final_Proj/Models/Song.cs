﻿namespace Lyrics_Final_Proj.Models
{
    public class Song
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Lyrics { get ; set; }
        public string Link { get ; set; }
        public string ArtistName { get; set; }

        public int FavoriteCount { get; set; }
        public static List<Song> ReadAllSongs()
        {
            DBservices dbs = new DBservices();
            return dbs.ReadAllSongs();

        }

        public static List<Song> GetSongsByArtist(string artistName)
        {
            DBservices dbs = new DBservices();
            return dbs.GetSongsByArtist(artistName);

        }

        public static List<Song> GetSongsBySongName(string songName)
        {
            DBservices dbs = new DBservices();
            return dbs.GetSongsBySongName(songName);

        }
    }

}
