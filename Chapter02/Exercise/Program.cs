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

            //var song2 = new Song("アンパンマン", "バイキンマン", 60);
            //songs.Add(song2);

            //var song3 = new Song("アンパンマン", "バイキンマン", 60);
            //songs.Add(song3);

            var songs = new Song[] {
                new Song("アンパンマン", "バイキンマン", 60),
                new Song("バイキンマン", "カレーパンマン", 60),
                new Song("カレーパンマン", "しょくぱんまん", 60),
                new Song("しょくぱんまん", "チーズ", 60),
                new Song("チーズ", "バタコさん", 60),
             };

        }
    }
}
