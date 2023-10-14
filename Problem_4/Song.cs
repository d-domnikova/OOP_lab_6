class Song
{
    private string artistName;
    public string ArtistName {  get { return artistName; }
        set
        { if (value.Length >= 3 && value.Length <= 20) { artistName = value; }
            else throw new InvalidArtistNameException();
        }
    }

    private string songName;
    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length >= 3 && value.Length <= 30) { songName = value; }
            else throw new InvalidSongNameException();
        }
    }

    private int minutes;
    public int Minutes { get { return minutes; }
        set
        { if (value >= 0 && value <= 14) { minutes = value; }
            else throw new InvalidSongMinutesException();
        }
    }

    private int seconds;
     public int Seconds { get { return seconds; }
        set
        { if (value >= 0 && value <= 59) { seconds = value; }
            else throw new InvalidSongSecondsException();
        }
    }

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }
}