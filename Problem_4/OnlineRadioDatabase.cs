class Workspace
{
    static void Main()
    {
        List<Song> playlist = new List<Song>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            try
            {
                string[] input = Console.ReadLine().Split(';');
                string artistName = input[0];
                string albumName = input[1];
                string[] songLenght = input[2].Split(':');
                int minuts = int.Parse(songLenght[0]);
                int seconds = int.Parse(songLenght[1]);

                Song song = new Song(artistName, albumName, minuts, seconds);
                playlist.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException e) { Console.WriteLine(e.Message); }
        }

        Console.WriteLine("Song added: {0}", playlist.Count);
        Console.WriteLine("Playlist lenght: {0}", countPlaylistLenght(playlist));
    }

    static string countPlaylistLenght(List<Song> songs)
    {
        int hours = 0, minutes = 0, seconds = 0;
        foreach (Song song in songs) { 
            seconds += song.Seconds;
            minutes += song.Minutes;
        }

        if(seconds > 59) { 
            minutes += seconds / 60;
            seconds = seconds % 60;
                }
        if(minutes > 59) { 
            hours += minutes / 60;
            minutes = minutes % 60;
        }

        return $"{hours}h {minutes}m {seconds}s";
    }
}