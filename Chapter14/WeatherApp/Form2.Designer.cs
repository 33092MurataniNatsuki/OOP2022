
namespace WeatherApp {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbTomorrowWeather = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTodayWeather = new System.Windows.Forms.TextBox();
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTargetArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.tbreportDatetime = new System.Windows.Forms.TextBox();
            this.tbpublishingOffice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTomorrowWeather
            // 
            this.tbTomorrowWeather.Location = new System.Drawing.Point(140, 427);
            this.tbTomorrowWeather.Multiline = true;
            this.tbTomorrowWeather.Name = "tbTomorrowWeather";
            this.tbTomorrowWeather.Size = new System.Drawing.Size(322, 27);
            this.tbTomorrowWeather.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(49, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "明日の天気：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(50, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "今日の天気：";
            // 
            // tbTodayWeather
            // 
            this.tbTodayWeather.Location = new System.Drawing.Point(140, 393);
            this.tbTodayWeather.Multiline = true;
            this.tbTodayWeather.Name = "tbTodayWeather";
            this.tbTodayWeather.Size = new System.Drawing.Size(322, 27);
            this.tbTodayWeather.TabIndex = 28;
            // 
            // pbWeather
            // 
            this.pbWeather.Location = new System.Drawing.Point(378, 38);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(129, 127);
            this.pbWeather.TabIndex = 27;
            this.pbWeather.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(50, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "対象地域：";
            // 
            // tbTargetArea
            // 
            this.tbTargetArea.Location = new System.Drawing.Point(129, 143);
            this.tbTargetArea.Multiline = true;
            this.tbTargetArea.Name = "tbTargetArea";
            this.tbTargetArea.Size = new System.Drawing.Size(228, 27);
            this.tbTargetArea.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(50, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "天気概況：";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(129, 176);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(333, 198);
            this.tbText.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "報告日時：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(49, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "発表者：";
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(129, 38);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 20);
            this.cbArea.TabIndex = 20;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(39, 29);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(84, 29);
            this.btWeatherGet.TabIndex = 19;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click_1);
            // 
            // tbreportDatetime
            // 
            this.tbreportDatetime.Location = new System.Drawing.Point(129, 110);
            this.tbreportDatetime.Multiline = true;
            this.tbreportDatetime.Name = "tbreportDatetime";
            this.tbreportDatetime.Size = new System.Drawing.Size(228, 27);
            this.tbreportDatetime.TabIndex = 17;
            // 
            // tbpublishingOffice
            // 
            this.tbpublishingOffice.Location = new System.Drawing.Point(129, 77);
            this.tbpublishingOffice.Multiline = true;
            this.tbpublishingOffice.Name = "tbpublishingOffice";
            this.tbpublishingOffice.Size = new System.Drawing.Size(158, 27);
            this.tbpublishingOffice.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 507);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTomorrowWeather;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTodayWeather;
        private System.Windows.Forms.PictureBox pbWeather;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTargetArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.TextBox tbreportDatetime;
        private System.Windows.Forms.TextBox tbpublishingOffice;
    }
}