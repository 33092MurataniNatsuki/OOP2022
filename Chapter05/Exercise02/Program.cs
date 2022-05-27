using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var line = Console.ReadLine(); //数値　数字

            int num; 

            //p.126
            if (int.TryParse(line, out num)) {
                //p.154.155
                Console.WriteLine("{0:#,#}",num); //整数への変換成功
                //Console.WriteLine(num.ToString("#,0"));
            } else {
                Console.WriteLine("数値文字列ではありません"); //変換失敗
            }
        }
    }
}
