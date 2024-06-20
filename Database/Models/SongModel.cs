﻿using System.ComponentModel.DataAnnotations;

namespace SwiftTrueRandom.Database.Models
{
    public class SongModel
    {
        [Key]
        public int DatabaseKey { get; set; }

        public string Artist { get; set; } = "";

        public string AlbumTitle { get; set; } = "";

        public string SongTitle { get; set; } = "";

        public string SongPath { get; set; } = "";

        public int SongLength { get; set; } = int.MinValue;

        public int AudioStreamIndex { get; set; } = int.MinValue;

        public bool IsEnabled { get; set; } = true;

        public SongModel() { }

        public SongModel(string artist, string albumTitle, string songTitle, string songPath, int songLength, int audioStreamIndex)
        {
            Artist = artist;
            AlbumTitle = albumTitle;
            SongTitle = songTitle;
            SongPath = songPath;
            SongLength = songLength;
            AudioStreamIndex = audioStreamIndex;
        }
    }
}
