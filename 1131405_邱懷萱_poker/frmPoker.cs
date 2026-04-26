using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1131405_邱懷萱_poker
{
    public partial class frmPoker : Form
    {

        PictureBox[] pic = new PictureBox[5];
        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        // 新增變數 
        int totalMoney = 1000000;  // 總資金
        int betAmount = 0;  // 本局下注金額

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
        }

        #region 自編程序
        // 從資源檔中取出對應的圖，並顯示在picTest上
        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }
        private Image GetImage(int num)
        {
            return GetImage($"pic{num}");
        }
        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }
        #endregion

        #region 自定義方法
        private void InitializePoker()
        {
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetImage("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag ="back";
                // 將 pic 丟至到 grpPorker 內
                this.grpPoker.Controls.Add(pic[i]);
                pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }
        #endregion

        /// <summary>
        /// 顯示五張撲克牌到桌面上
        private void ShowCards()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = this.GetImage($"pic{playerPoker[i] + 1}");
            }
        }

        private void grpPoker_Enter(object sender, EventArgs e)
        {

        }

        private void frmPoker_Load(object sender, EventArgs e)
        {
            lblTotalMoney.Text = totalMoney.ToString(); // 顯示總資金
            btnDealCard.Enabled = false;   // 尚未下注前不能發牌
        }

        private void grpButton_Enter(object sender, EventArgs e)
        {

        }
        #region 撲克牌事件處理
        private void pic_Click(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int index = int.Parse(pic.Name.Replace("pic", ""));
            int cardNum = playerPoker[index] + 1;
            // 如果 pic 的 Tag 為 back，則將顯示撲克牌
            if (pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = GetImage(cardNum);
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetImage("back");
            }
        }
        private async void btnDealCard_Click(object sender, EventArgs e)
        {
            this.lblResult.Text = "";
            // 先將牌面蓋掉
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Image = GetImage("back");
            }
            // 產生1~52的亂數，對應撲克牌的52張圖
            for (int i = 0; i < allPoker.Length; i++)
            {
                allPoker[i] = i ;
            }
            // 洗牌
            this.Shuffle();
            //暫停
            await Task.Delay(300);
            //發牌
            for (int i=0; i < playerPoker.Length; i++)
            {
                playerPoker[i] = allPoker[ i];
                pic[i].Image = GetImage("pic" + (allPoker[i] + 1));
            }
            // 啟用 pic 的事件
            for (int i = 0; i < 5; i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }
            // 啟用換牌按鈕
            btnChangeCard.Enabled = true;
            btnDealCard.Enabled = false;

        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int startIndex = 5;
            for(int i = 0; i < pic.Length; i++){
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[startIndex];
                    startIndex++;
                    pic[i].Image = GetImage(playerPoker[i] + 1);
                    pic[i].Tag = "front";
                }
            }
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Enabled = false;
            }
             this.btnChangeCard.Enabled = false;
             this.btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q","K" };
            // 計錄目前五張撲克牌的花色和點數的陣列
            int[] pokerColor = new int[5];
            // 記錄目前五張撲克牌的點數的陣列
            int[] pokerPoint = new int[5];
            // 將每張牌的顏色和點數分別存入 pokerColor 和 pokerPoint 陣列
            for (int i = 0; i < 5; i++)
            {
                // 以 playerPoker[i] 除以 4 的餘數來決定花色，0-3 分別對應梅花、方塊、愛心、黑桃
                pokerColor[i] = playerPoker[i] % 4;
                // 以 playerPoker[i] 除以 4 的商來決定點數，0-12 分別對應 A、2、3、4、5、6、7、8、9、10、J、Q、K
                pokerPoint[i] = playerPoker[i] / 4;
            }
            // 統計 color 和 point 出現次數
            int[] colorCount = new int[4];
            int[] pointCount = new int[13];
            for (int i = 0; i < 5; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }
            // 排序 colorCount 和 pointCount 由大到小
            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            // 判斷是否為同花
            bool isFlush = (colorCount[0] == 5);
            // 判斷是否為五張單張
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 &&
            pointCount[3] == 1 && pointCount[4] == 1);
            // 判斷是否為差四
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            // 判斷是否為大順
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) &&
            pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            // 判斷是否為同花大順
            bool isRoyalisFlush = isFlush && isRoyal;
            // 判斷是否為同花順
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            // 判斷是否為順子
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            // 判斷是否為鐵支
            bool isFourOfAKind = (pointCount[0] == 4);
            // 判斷是否為葫蘆
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            // 判斷是否為三條
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            // 判斷是否為兩對
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            // 判斷是否為一對
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);

            string result = "";
            if (isRoyalisFlush)
            {
                result = $"{colorList[0]} 同花大順";
            }
            else if (isStraightFlush)
            {
                result = $"{colorList[0]} 同花順";
            }
            else if (isStraight)
            {
                result = "順子";
            }
            else if (isFourOfAKind)
            {
                result = $"{pointList[0]} 鐵支";
            }
            else if (isFullHouse)
            {
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
            }
            else if (isFlush)
            {
                result = $"{colorList[0]} 同花";
            }
            else if (isThreeOfAKind)
            {
                result = $"{pointList[0]} 三條";
            }
            else if (isTwoPair)
            {
                result = $"{pointList[0]},{pointList[1]} 兩對";
            }
            else if (isOnePair)
            {
                result = $"{pointList[0]} 一對";
            }
            else
            {
                result = "雜牌";
            }
            lblResult.Text = result;

            //新增賠率計算 
            int odds = 0;
            // 根據牌型設定賠率
            if (result.Contains("同花大順")) odds = 250;
            else if (result.Contains("同花順")) odds = 50;
            else if (result.Contains("鐵支")) odds = 25;
            else if (result.Contains("葫蘆")) odds = 9;
            else if (result.Contains("同花")) odds = 6;
            else if (result.Contains("順子")) odds = 4;
            else if (result.Contains("三條")) odds = 3;
            else if (result.Contains("兩對")) odds = 2;
            else if (result.Contains("一對")) odds = 1;
            else odds = 0; // 雜牌

            int winMoney = betAmount * odds;
            totalMoney += winMoney; // 加上獎金

            // 更新顯示
            lblTotalMoney.Text = totalMoney.ToString();
            lblResult.Text = $"{result}\n(獲得獎金: {winMoney})";

            // 回復狀態，準備下一局
            btnBet.Enabled = true;        
            txtBetAmount.Enabled = true;  
            btnCheck.Enabled = false;    
            btnDealCard.Enabled = false; 
            btnChangeCard.Enabled = false;

        }

        // 按下鍵盤時觸發的事件處理程序，目前尚未實作任何功能
        private void frmPoker_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 如果正在輸入金額，不觸發作弊 
            if (txtBetAmount.Focused)
            {
                return;
            }

            if (btnChangeCard.Enabled == true)
            {
                switch ((int)e.KeyChar)
                {
                    case 113: //ASCII code for q鍵
                              // 同花大順
                        playerPoker[0] = 51;
                        playerPoker[1] = 47;
                        playerPoker[2] = 43;
                        playerPoker[3] = 39;
                        playerPoker[4] = 3;
                        break;
                    case 119: // w鍵
                              // 同花順
                        playerPoker[0] = 37;
                        playerPoker[1] = 33;
                        playerPoker[2] = 29;
                        playerPoker[3] = 25;
                        playerPoker[4] = 21;
                        break;
                    case 101: // e鍵
                              // 同花
                        playerPoker[0] = 50;
                        playerPoker[1] = 38;
                        playerPoker[2] = 34;
                        playerPoker[3] = 22;
                        playerPoker[4] = 18;
                        break;
                    case 114: // r鍵
                              // 鐵支
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 38;
                        playerPoker[3] = 37;
                        playerPoker[4] = 36;
                        break;
                    case 116:  // t鍵
                               // 葫蘆
                        playerPoker[0] = 30;
                        playerPoker[1] = 29;
                        playerPoker[2] = 6;
                        playerPoker[3] = 5;
                        playerPoker[4] = 4;
                        break;
                    case 121:  // y鍵
                               // 三條
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 15;
                        playerPoker[3] = 14;
                        playerPoker[4] = 13;
                        break;
                }
                // 顯示五張撲克牌到桌面上
                ShowCards();
            }
        }
        #endregion

        #region 撲克牌押注相關事件處理
        private void btnBet_Click(object sender, EventArgs e)
        {
            // 檢查 TextBox 輸入是否為正確數字
            if (int.TryParse(txtBetAmount.Text, out betAmount) && betAmount > 0)
            {
                if (totalMoney >= betAmount)
                {
                    totalMoney -= betAmount; // 扣除總資金
                    lblTotalMoney.Text = totalMoney.ToString(); // 更新 Label 顯示

                    btnBet.Enabled = false;  // 鎖定下注按鈕
                    txtBetAmount.Enabled = false;  // 鎖定金額輸入框
                    btnDealCard.Enabled = true;  // 允許發牌
                }
                else
                {
                    MessageBox.Show("餘額不足！");
                }
            }
            else
            {
                MessageBox.Show("請輸入正確的下注金額！");
            }
        }
        #endregion

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
