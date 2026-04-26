namespace _1131405_邱懷萱_poker
{
    partial class frmPoker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBetting = new System.Windows.Forms.GroupBox();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblTotalCapital = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.grpButton.SuspendLayout();
            this.grpBetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(28, 27);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(643, 168);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            this.grpPoker.Enter += new System.EventHandler(this.grpPoker_Enter);
            // 
            // grpButton
            // 
            this.grpButton.BackColor = System.Drawing.Color.LightCoral;
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(28, 348);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(643, 112);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            this.grpButton.Enter += new System.EventHandler(this.grpButton_Enter);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(363, 40);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(234, 45);
            this.lblResult.TabIndex = 3;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(222, 43);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(118, 38);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(120, 43);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(96, 38);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(18, 43);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(96, 38);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpBetting
            // 
            this.grpBetting.BackColor = System.Drawing.Color.OliveDrab;
            this.grpBetting.Controls.Add(this.txtBetAmount);
            this.grpBetting.Controls.Add(this.lblBetAmount);
            this.grpBetting.Controls.Add(this.lblTotalCapital);
            this.grpBetting.Controls.Add(this.lblTotalMoney);
            this.grpBetting.Controls.Add(this.btnBet);
            this.grpBetting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBetting.Location = new System.Drawing.Point(28, 218);
            this.grpBetting.Name = "grpBetting";
            this.grpBetting.Size = new System.Drawing.Size(643, 112);
            this.grpBetting.TabIndex = 2;
            this.grpBetting.TabStop = false;
            this.grpBetting.Text = "下注";
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(418, 54);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(97, 39);
            this.txtBetAmount.TabIndex = 6;
            this.txtBetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.BackColor = System.Drawing.Color.Ivory;
            this.lblBetAmount.Location = new System.Drawing.Point(296, 53);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(110, 31);
            this.lblBetAmount.TabIndex = 5;
            this.lblBetAmount.Text = "押注金額";
            this.lblBetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCapital
            // 
            this.lblTotalCapital.BackColor = System.Drawing.Color.Ivory;
            this.lblTotalCapital.Location = new System.Drawing.Point(19, 53);
            this.lblTotalCapital.Name = "lblTotalCapital";
            this.lblTotalCapital.Size = new System.Drawing.Size(92, 31);
            this.lblTotalCapital.TabIndex = 4;
            this.lblTotalCapital.Text = "總資金";
            this.lblTotalCapital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalMoney.Location = new System.Drawing.Point(117, 53);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(167, 31);
            this.lblTotalMoney.TabIndex = 3;
            this.lblTotalMoney.Text = "1000000";
            this.lblTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.Maroon;
            this.btnBet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBet.Location = new System.Drawing.Point(527, 49);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(96, 38);
            this.btnBet.TabIndex = 0;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(701, 472);
            this.Controls.Add(this.grpBetting);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.Load += new System.EventHandler(this.frmPoker_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpButton.ResumeLayout(false);
            this.grpBetting.ResumeLayout(false);
            this.grpBetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpBetting;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblTotalCapital;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Label lblTotalMoney;
    }
}