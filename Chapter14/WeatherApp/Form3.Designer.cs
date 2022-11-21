
namespace WeatherApp {
    partial class Form3 {
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
            this.pbWeatherMap = new System.Windows.Forms.PictureBox();
            this.btJapanColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btJapanSirokuro = new System.Windows.Forms.Button();
            this.btAsiaColor = new System.Windows.Forms.Button();
            this.btAsiaSirokuro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWeatherMap
            // 
            this.pbWeatherMap.Location = new System.Drawing.Point(12, 37);
            this.pbWeatherMap.Name = "pbWeatherMap";
            this.pbWeatherMap.Size = new System.Drawing.Size(598, 505);
            this.pbWeatherMap.TabIndex = 0;
            this.pbWeatherMap.TabStop = false;
            // 
            // btJapanColor
            // 
            this.btJapanColor.Location = new System.Drawing.Point(105, 8);
            this.btJapanColor.Name = "btJapanColor";
            this.btJapanColor.Size = new System.Drawing.Size(101, 23);
            this.btJapanColor.TabIndex = 1;
            this.btJapanColor.Text = "日本周辺カラー";
            this.btJapanColor.UseVisualStyleBackColor = true;
            this.btJapanColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "表示領域";
            // 
            // btJapanSirokuro
            // 
            this.btJapanSirokuro.Location = new System.Drawing.Point(212, 8);
            this.btJapanSirokuro.Name = "btJapanSirokuro";
            this.btJapanSirokuro.Size = new System.Drawing.Size(101, 23);
            this.btJapanSirokuro.TabIndex = 1;
            this.btJapanSirokuro.Text = "日本周辺白黒";
            this.btJapanSirokuro.UseVisualStyleBackColor = true;
            this.btJapanSirokuro.Click += new System.EventHandler(this.btJapanSirokuro_Click);
            // 
            // btAsiaColor
            // 
            this.btAsiaColor.Location = new System.Drawing.Point(319, 8);
            this.btAsiaColor.Name = "btAsiaColor";
            this.btAsiaColor.Size = new System.Drawing.Size(141, 23);
            this.btAsiaColor.TabIndex = 1;
            this.btAsiaColor.Text = "アジア太平洋域カラー";
            this.btAsiaColor.UseVisualStyleBackColor = true;
            this.btAsiaColor.Click += new System.EventHandler(this.btAsiaColor_Click);
            // 
            // btAsiaSirokuro
            // 
            this.btAsiaSirokuro.Location = new System.Drawing.Point(466, 8);
            this.btAsiaSirokuro.Name = "btAsiaSirokuro";
            this.btAsiaSirokuro.Size = new System.Drawing.Size(119, 23);
            this.btAsiaSirokuro.TabIndex = 1;
            this.btAsiaSirokuro.Text = "アジア太平洋域白黒";
            this.btAsiaSirokuro.UseVisualStyleBackColor = true;
            this.btAsiaSirokuro.Click += new System.EventHandler(this.btAsiaSirokuro_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAsiaSirokuro);
            this.Controls.Add(this.btAsiaColor);
            this.Controls.Add(this.btJapanSirokuro);
            this.Controls.Add(this.btJapanColor);
            this.Controls.Add(this.pbWeatherMap);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWeatherMap;
        private System.Windows.Forms.Button btJapanColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btJapanSirokuro;
        private System.Windows.Forms.Button btAsiaColor;
        private System.Windows.Forms.Button btAsiaSirokuro;
    }
}