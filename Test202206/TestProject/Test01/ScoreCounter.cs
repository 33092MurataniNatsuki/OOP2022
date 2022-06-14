using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);


            
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            






            
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            //var dict = new Dictionary<string, int>();
            //foreach (var score in _score) {
            //    if (dict.ContainsKey(score.ShopName))
            //        dict[score.ShopName] += score.Amount;
            //    else
            //        dict[score.ShopName] = score.Amount;
            //}
            //return dict;





        }
    }
}
