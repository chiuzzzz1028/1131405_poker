namespace _1131405_邱懷萱_poker
{
    partial class FrmPicTest
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picTest = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();
            // 
            // picTest
            // 
            this.picTest.Image = global::_1131405_邱懷萱_poker.Properties.Resources.back;
            this.picTest.Location = new System.Drawing.Point(62, 59);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(85, 115);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTest.TabIndex = 0;
            this.picTest.TabStop = false;
            this.picTest.Click += new System.EventHandler(this.picTest_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTest.Location = new System.Drawing.Point(206, 59);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(95, 45);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "換牌";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblNum
            // 
            this.lblNum.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNum.Location = new System.Drawing.Point(206, 130);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(95, 44);
            this.lblNum.TabIndex = 2;
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(394, 245);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.picTest);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPicTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖片資源測試";
            this.Load += new System.EventHandler(this.FrmPicTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblNum;
    }
}

