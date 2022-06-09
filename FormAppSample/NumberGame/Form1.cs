using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        private Random rand = new Random();
        //乱数
        private int randomNumber;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            //randomNumber = rand.Next(1, (int)nudNum.Value);
            //this.Text = randomNumber.ToString();
            getRandom();
        }

        private void btInput_Click(object sender, EventArgs e) {
            //入力した値とあらかじめ取得した乱数を比較し結果を表示
            if (Number.Value == randomNumber) {
                toolStripStatusLabel1.Text = "正解！";
            }else if (Number.Value < randomNumber) {
                toolStripStatusLabel1.Text = "もっと大きいです。";
            } else {
                toolStripStatusLabel1.Text = "もっと小さいです。";
            }
        }

        private void nudNum_ValueChanged(object sender, EventArgs e) {
            //Form1_Load(sender, e);
            getRandom();
        }

        private void getRandom() {
            randomNumber = rand.Next(1, (int)nudNum.Value);
            this.Text = randomNumber.ToString();
        }
    }
}
