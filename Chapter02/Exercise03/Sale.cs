﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {

    public class Sale { //publicって打つ
        //店舗名
        public string ShopName { get; set; } //プロパティ(自動実装プロパティ)

        //商品カテゴリー
        public string ProductCategory { get; set; }

        //売上高
        public int Amount { get; set; }
    }
}