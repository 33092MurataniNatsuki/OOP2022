
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
            this.tbpublishingOffice = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbreportDatetime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTargetArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.tbTodayWeather = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTomorrowWeather = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpublishingOffice
            // 
            this.tbpublishingOffice.Location = new System.Drawing.Point(121, 69);
            this.tbpublishingOffice.Multiline = true;
            this.tbpublishingOffice.Name = "tbpublishingOffice";
            this.tbpublishingOffice.Size = new System.Drawing.Size(158, 27);
            this.tbpublishingOffice.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(31, 21);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(84, 29);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(121, 30);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 20);
            this.cbArea.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "発表者：";
            // 
            // tbreportDatetime
            // 
            this.tbreportDatetime.Location = new System.Drawing.Point(121, 102);
            this.tbreportDatetime.Multiline = true;
            this.tbreportDatetime.Name = "tbreportDatetime";
            this.tbreportDatetime.Size = new System.Drawing.Size(228, 27);
            this.tbreportDatetime.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "報告日時：";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(121, 168);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(333, 198);
            this.tbText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(42, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "天気概況：";
            // 
            // tbTargetArea
            // 
            this.tbTargetArea.Location = new System.Drawing.Point(121, 135);
            this.tbTargetArea.Multiline = true;
            this.tbTargetArea.Name = "tbTargetArea";
            this.tbTargetArea.Size = new System.Drawing.Size(228, 27);
            this.tbTargetArea.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(42, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "対象地域：";
            // 
            // pbWeather
            // 
            this.pbWeather.Location = new System.Drawing.Point(370, 30);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(129, 127);
            this.pbWeather.TabIndex = 11;
            this.pbWeather.TabStop = false;
            // 
            // tbTodayWeather
            // 
            this.tbTodayWeather.Location = new System.Drawing.Point(132, 385);
            this.tbTodayWeather.Multiline = true;
            this.tbTodayWeather.Name = "tbTodayWeather";
            this.tbTodayWeather.Size = new System.Drawing.Size(322, 27);
            this.tbTodayWeather.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(42, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "今日の天気：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(41, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "明日の天気：";
            // 
            // tbTomorrowWeather
            // 
            this.tbTomorrowWeather.Location = new System.Drawing.Point(132, 419);
            this.tbTomorrowWeather.Multiline = true;
            this.tbTomorrowWeather.Name = "tbTomorrowWeather";
            this.tbTomorrowWeather.Size = new System.Drawing.Size(322, 27);
            this.tbTomorrowWeather.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 489);
            this.Controls.Add(this.tbTomorrowWeather);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTodayWeather);
            this.Controls.Add(this.pbWeather);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTargetArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbreportDatetime);
            this.Controls.Add(this.tbpublishingOffice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbpublishingOffice;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbreportDatetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTargetArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbWeather;
        private System.Windows.Forms.TextBox tbTodayWeather;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTomorrowWeather;
    }
}

