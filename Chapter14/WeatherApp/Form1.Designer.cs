
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.btKanto = new System.Windows.Forms.Button();
            this.btTokai = new System.Windows.Forms.Button();
            this.btHokuriku = new System.Windows.Forms.Button();
            this.btTohoku = new System.Windows.Forms.Button();
            this.btHokkaido = new System.Windows.Forms.Button();
            this.btKinki = new System.Windows.Forms.Button();
            this.btTyugoku = new System.Windows.Forms.Button();
            this.btSikoku = new System.Windows.Forms.Button();
            this.btKyusyu = new System.Windows.Forms.Button();
            this.btOkinawa = new System.Windows.Forms.Button();
            this.tbTihoumei = new System.Windows.Forms.TextBox();
            this.btWeatherMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(414, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "全国を表示";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbMap
            // 
            this.pbMap.Location = new System.Drawing.Point(12, 12);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(583, 583);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap.TabIndex = 1;
            this.pbMap.TabStop = false;
            // 
            // btKanto
            // 
            this.btKanto.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKanto.Location = new System.Drawing.Point(410, 373);
            this.btKanto.Name = "btKanto";
            this.btKanto.Size = new System.Drawing.Size(88, 35);
            this.btKanto.TabIndex = 4;
            this.btKanto.Text = "関東甲信";
            this.btKanto.UseVisualStyleBackColor = true;
            this.btKanto.Click += new System.EventHandler(this.btKanto_Click);
            // 
            // btTokai
            // 
            this.btTokai.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTokai.Location = new System.Drawing.Point(304, 446);
            this.btTokai.Name = "btTokai";
            this.btTokai.Size = new System.Drawing.Size(72, 35);
            this.btTokai.TabIndex = 5;
            this.btTokai.Text = "東海";
            this.btTokai.UseVisualStyleBackColor = true;
            this.btTokai.Click += new System.EventHandler(this.btTokai_Click);
            // 
            // btHokuriku
            // 
            this.btHokuriku.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btHokuriku.Location = new System.Drawing.Point(243, 264);
            this.btHokuriku.Name = "btHokuriku";
            this.btHokuriku.Size = new System.Drawing.Size(72, 35);
            this.btHokuriku.TabIndex = 6;
            this.btHokuriku.Text = "北陸";
            this.btHokuriku.UseVisualStyleBackColor = true;
            this.btHokuriku.Click += new System.EventHandler(this.btHokuriku_Click);
            // 
            // btTohoku
            // 
            this.btTohoku.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTohoku.Location = new System.Drawing.Point(453, 239);
            this.btTohoku.Name = "btTohoku";
            this.btTohoku.Size = new System.Drawing.Size(72, 35);
            this.btTohoku.TabIndex = 3;
            this.btTohoku.Text = "東北";
            this.btTohoku.UseVisualStyleBackColor = true;
            this.btTohoku.Click += new System.EventHandler(this.btTohoku_Click);
            // 
            // btHokkaido
            // 
            this.btHokkaido.BackColor = System.Drawing.SystemColors.Control;
            this.btHokkaido.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btHokkaido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btHokkaido.Location = new System.Drawing.Point(484, 128);
            this.btHokkaido.Name = "btHokkaido";
            this.btHokkaido.Size = new System.Drawing.Size(72, 35);
            this.btHokkaido.TabIndex = 2;
            this.btHokkaido.Text = "北海道";
            this.btHokkaido.UseVisualStyleBackColor = false;
            this.btHokkaido.Click += new System.EventHandler(this.btHokkaido_Click);
            // 
            // btKinki
            // 
            this.btKinki.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKinki.Location = new System.Drawing.Point(209, 497);
            this.btKinki.Name = "btKinki";
            this.btKinki.Size = new System.Drawing.Size(72, 35);
            this.btKinki.TabIndex = 7;
            this.btKinki.Text = "近畿";
            this.btKinki.UseVisualStyleBackColor = true;
            this.btKinki.Click += new System.EventHandler(this.btKinki_Click);
            // 
            // btTyugoku
            // 
            this.btTyugoku.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTyugoku.Location = new System.Drawing.Point(80, 333);
            this.btTyugoku.Name = "btTyugoku";
            this.btTyugoku.Size = new System.Drawing.Size(72, 35);
            this.btTyugoku.TabIndex = 7;
            this.btTyugoku.Text = "中国";
            this.btTyugoku.UseVisualStyleBackColor = true;
            this.btTyugoku.Click += new System.EventHandler(this.btTyugoku_Click);
            // 
            // btSikoku
            // 
            this.btSikoku.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSikoku.Location = new System.Drawing.Point(153, 333);
            this.btSikoku.Name = "btSikoku";
            this.btSikoku.Size = new System.Drawing.Size(72, 35);
            this.btSikoku.TabIndex = 7;
            this.btSikoku.Text = "四国";
            this.btSikoku.UseVisualStyleBackColor = true;
            this.btSikoku.Click += new System.EventHandler(this.btSikoku_Click);
            // 
            // btKyusyu
            // 
            this.btKyusyu.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKyusyu.Location = new System.Drawing.Point(98, 551);
            this.btKyusyu.Name = "btKyusyu";
            this.btKyusyu.Size = new System.Drawing.Size(110, 35);
            this.btKyusyu.TabIndex = 7;
            this.btKyusyu.Text = "九州";
            this.btKyusyu.UseVisualStyleBackColor = true;
            this.btKyusyu.Click += new System.EventHandler(this.btKyusyu_Click);
            // 
            // btOkinawa
            // 
            this.btOkinawa.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOkinawa.Location = new System.Drawing.Point(84, 181);
            this.btOkinawa.Name = "btOkinawa";
            this.btOkinawa.Size = new System.Drawing.Size(72, 35);
            this.btOkinawa.TabIndex = 7;
            this.btOkinawa.Text = "沖縄";
            this.btOkinawa.UseVisualStyleBackColor = true;
            this.btOkinawa.Click += new System.EventHandler(this.btOkinawa_Click);
            // 
            // tbTihoumei
            // 
            this.tbTihoumei.Location = new System.Drawing.Point(153, 603);
            this.tbTihoumei.Name = "tbTihoumei";
            this.tbTihoumei.Size = new System.Drawing.Size(255, 19);
            this.tbTihoumei.TabIndex = 8;
            // 
            // btWeatherMap
            // 
            this.btWeatherMap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btWeatherMap.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherMap.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btWeatherMap.Location = new System.Drawing.Point(558, 475);
            this.btWeatherMap.Name = "btWeatherMap";
            this.btWeatherMap.Size = new System.Drawing.Size(37, 149);
            this.btWeatherMap.TabIndex = 9;
            this.btWeatherMap.Text = "天気図";
            this.btWeatherMap.UseVisualStyleBackColor = false;
            this.btWeatherMap.Click += new System.EventHandler(this.btWeatherMap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 64);
            this.label1.TabIndex = 10;
            this.label1.Text = "天気予報";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherMap);
            this.Controls.Add(this.tbTihoumei);
            this.Controls.Add(this.btKyusyu);
            this.Controls.Add(this.btOkinawa);
            this.Controls.Add(this.btSikoku);
            this.Controls.Add(this.btTyugoku);
            this.Controls.Add(this.btKinki);
            this.Controls.Add(this.btHokuriku);
            this.Controls.Add(this.btTokai);
            this.Controls.Add(this.btKanto);
            this.Controls.Add(this.btTohoku);
            this.Controls.Add(this.btHokkaido);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button btKanto;
        private System.Windows.Forms.Button btTokai;
        private System.Windows.Forms.Button btHokuriku;
        private System.Windows.Forms.Button btTohoku;
        private System.Windows.Forms.Button btHokkaido;
        private System.Windows.Forms.Button btKinki;
        private System.Windows.Forms.Button btTyugoku;
        private System.Windows.Forms.Button btSikoku;
        private System.Windows.Forms.Button btKyusyu;
        private System.Windows.Forms.Button btOkinawa;
        private System.Windows.Forms.TextBox tbTihoumei;
        private System.Windows.Forms.Button btWeatherMap;
        private System.Windows.Forms.Label label1;
    }
}

