
namespace NumberGame {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.btInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "1から";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(151, 164);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(120, 44);
            this.Number.TabIndex = 1;
            // 
            // btInput
            // 
            this.btInput.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btInput.Location = new System.Drawing.Point(307, 164);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(149, 44);
            this.btInput.TabIndex = 2;
            this.btInput.Text = "判定！";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(275, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "の中で好きな数字を入力";
            // 
            // nudNum
            // 
            this.nudNum.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum.Location = new System.Drawing.Point(151, 76);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(113, 44);
            this.nudNum.TabIndex = 4;
            this.nudNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNum.ValueChanged += new System.EventHandler(this.nudNum_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nudNum);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

