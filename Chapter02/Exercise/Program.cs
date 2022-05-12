using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args)
        {
            //2.1.3
            //List<Song> songs = new List<Song>();

            //var song1 = new Song("アンパンマン", "バイキンマン", 60);
            //songs.Add(song1);

            //var song2 = new Song("バイキンマン", "カレーパンマン", 120);
            //songs.Add(song2);

            //var song3 = new Song("カレーパンマン", "しょくぱんまん", 180);
            //songs.Add(song3);

            var songs = new Song[] {
                new Song("アンパンマン", "バイキンマン", 60),
                new Song("バイキンマン", "カレーパンマン", 120),
                new Song("カレーパンマン", "しょくぱんまん", 180),
                new Song("しょくぱんまん", "チーズ", 170),
                new Song("チーズ", "バタコさん", 90),
             };

            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(IEnumerable<Song> songs)
        {
            foreach (var song in songs)
            {
                //Console.Write("{0},{1},",song.Title,song.ArtistName);
                //Console.WriteLine(TimeSpan.FromSeconds(song.Length).ToString(@"mm\:ss"));
                Console.WriteLine("{0},{1},{2:mm\\:ss}", song.Title, song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }

        //private static void PrintSongs(List<Song> songs) { 
        //}
    }
}
