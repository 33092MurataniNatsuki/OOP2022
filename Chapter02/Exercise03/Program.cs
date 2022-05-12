using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args)
        {

            var sales = new SalesCounter("sales.csv");
            Console.WriteLine("売上高の表示選択");
            Console.WriteLine("1.店舗別");
            Console.WriteLine("2.商品カテゴリー別");
            var n = int.Parse(Console.ReadLine());
            IDictionary<string, int> amountPerStore;
            if (n == 1)
            {
                amountPerStore = sales.GetPerStoreSales();
            }
            else
            {
                amountPerStore = sales.GetPerProductSales();
            }
            foreach (var obj in amountPerStore)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
