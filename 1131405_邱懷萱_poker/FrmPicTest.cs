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
    public partial class FrmPicTest : Form
    {
        public FrmPicTest()
        {
            InitializeComponent();
        }

        #region
        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }
        private Image GetImage(int num)
        {
            return GetImage($"pic{num}");
        }
        #endregion



        #region 事件程序 

        //測試按鈕事件，點擊後會隨機顯示一張撲克牌的圖
        private void btnTest_Click(object sender, EventArgs e)
        {
            //產生1~53的亂數，對應撲克牌的52張圖
            Random random = new Random();
            //從資源檔中取出對應的圖，並顯示在picTest上
            int picNum = random.Next(1, 53);
            this.picTest.Image = GetImage(picNum);
            lblNum.Text = picNum.ToString();
        }
        private void FrmPicTest_Load(object sender, EventArgs e)
        {

        }

        private void picTest_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
