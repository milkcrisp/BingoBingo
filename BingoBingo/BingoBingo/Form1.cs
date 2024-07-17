using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoBingo
{
    public partial class Form1 : Form
    {
        private List<Label> numberLabels;
        private List<int> userNumbers;
        private NumberGenerator numberGenerator;
        private UserInputParser userInputParser;
        private UIHelper uiHelper;
        public Form1()
        {
            InitializeComponent();
            InitializeNumberLabels();
            numberGenerator = new NumberGenerator();
            userInputParser = new UserInputParser();
            uiHelper = new UIHelper();
            var roundButton = new RoundButton
            {
                Text = "圓形按鈕",
                Size = new Size(100, 100),
                Location = new Point(50, 50)
            };
            this.Controls.Add(roundButton);
        }


        private void InitializeNumberLabels()
        {
            numberLabels = new List<Label>();

            // 添加80個球的標籤到 tableLayoutPanelNumbers 中
            for (int i = 1; i <= 80; i++)
            {
                Label label = new Label();
                label.Text = i.ToString();
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                lbllayout_numberLabels.Controls.Add(label);
                numberLabels.Add(label);
            }
        }

        private void btn_open(object sender, EventArgs e)
        {
            if (userNumbers == null || userNumbers.Count == 0)
            {
                MessageBox.Show("請先輸入號碼並按確認按鈕。");
                return;
            }

            List<int> selectedNumbers = numberGenerator.GenerateNumbers(1, 80, 20);
            // 更新顯示的數字，標記被選中的號碼
            int lastIndex = selectedNumbers.Count - 1; // 取得最後一個選中的數字的索引
            int lastNumber = selectedNumbers[lastIndex]; // 取得最後一個選中的數字的值
            uiHelper.UpdateLabels(numberLabels, selectedNumbers, lastNumber);
            
            string superNo = Convert.ToString(lastNumber);
            lbl_superNo.Text = $"超級選號： {superNo} 號";
            var (big, small, odd, even) = numberGenerator.AnalyzeNumbers(selectedNumbers);
            if (big >= 13)
            {
                lbl_BigOrSmall.Text = "猜大小的結果為：大";
            }
            else if (small >= 13)
            {
                lbl_BigOrSmall.Text = "猜大小的結果為：小";
            }
            else
            {
                lbl_BigOrSmall.Text = "猜大小的結果為：中間值";
            }

            if (odd >= 13)
            {
                lbl_OddOrEven.Text = "猜單雙的結果為：單";
            }
            else if (even >= 13)
            {
                lbl_OddOrEven.Text = "猜單雙的結果為：雙";
            }
            else
            {
                lbl_OddOrEven.Text = "猜單雙的結果為：中間值";
            }

            List<int> matchedNumbers = userNumbers.Intersect(selectedNumbers).ToList();
            if (matchedNumbers.Count > 0)
            {
                lbl_result.Text = $"中獎號碼: {string.Join(", ", matchedNumbers)}";
            }
            else
            {
                lbl_result.Text = "沒有中獎號碼";
            }
        }

        private void lbl_BigOrSmall_Click(object sender, EventArgs e)
        {

        }

        private void rBtn_InputNo_Click(object sender, EventArgs e)
        {
            string input = txtBox_Input.Text;
            userNumbers = userInputParser.ParseUserInput(input);

            if (userNumbers == null || userNumbers.Count == 0)
            {
                MessageBox.Show("請輸入 1 到 10 個不重複的數字（1 到 80）。");
                return;
            }
            string userNumbersText = $"你的選號：\n";
            if (userNumbers.Count > 5)
            {
                userNumbersText += string.Join(", ", userNumbers.Take(5)) + "\n";
                userNumbersText += string.Join(", ", userNumbers.Skip(5));
            }
            else
            {
                userNumbersText += string.Join(", ", userNumbers);
            }

            lbl_yourInput.Text = userNumbersText;
            MessageBox.Show($"您選擇的號碼是: {string.Join(", ", userNumbers)}");
        }

        private List<int> UserselectedNumbers = new List<int>(); // 儲存使用者選擇的號碼
        private void rBtn_choose_Click(object sender, EventArgs e)
        {
            // 清空號碼
            UserselectedNumbers.Clear();
            lbl_yourInput.Text = $"你的選號：\n";

            lbllayout_numberLabels.Controls.Clear();
            lbllayout_numberLabels.RowStyles.Clear();
            lbllayout_numberLabels.ColumnStyles.Clear();

            // 設置 TableLayoutPanel 的行和列
            lbllayout_numberLabels.ColumnCount = 10;
            lbllayout_numberLabels.RowCount = 8;

            // 設置每列和每行的大小
            for (int i = 0; i < 10; i++)
            {
                lbllayout_numberLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            }
            for (int i = 0; i < 8; i++)
            {
                lbllayout_numberLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            }

            // 填充 TableLayoutPanel 中的號碼按鈕
            int number = 1;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (number <= 80)
                    {
                        Button btnNumber = new Button();
                        btnNumber.Text = number.ToString();
                        btnNumber.Dock = DockStyle.Fill;
                        btnNumber.Margin = new Padding(5);
                        btnNumber.Click += BtnNumberForSelection_Click; // 添加點擊事件

                        lbllayout_numberLabels.Controls.Add(btnNumber, col, row);
                        number++;
                    }
                }
            }
        }
       

        private void BtnNumberForSelection_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string selectedNumber = clickedButton.Text;
                int number;
                if (int.TryParse(selectedNumber, out number))
                {
                    // 檢查是否已選擇，若未選擇則添加到 selectedNumbers 中
                    if (!UserselectedNumbers.Contains(number))
                    {
                        if (UserselectedNumbers.Count < 10) // 檢查是否超過10個號碼
                        {
                            UserselectedNumbers.Add(number);
                            clickedButton.BackColor = Color.Green; // 或者其他選中的標示
                        }
                        else
                        {
                            MessageBox.Show("最多只能選擇10個號碼。", "選擇錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        UserselectedNumbers.Remove(number);
                        clickedButton.BackColor = SystemColors.Control; // 或者恢復原本的背景色
                    }

                    // 更新顯示已選擇的號碼
                    UpdateSelectedNumbersDisplay();
                }
            }
        }

        private void UpdateSelectedNumbersDisplay()
        {
            lbl_yourInput.Text = $"你的選號：\n";
            if (UserselectedNumbers.Count > 5)
            {
                lbl_yourInput.Text += string.Join(", ", UserselectedNumbers.Take(5)) + "\n";
                lbl_yourInput.Text += string.Join(", ", UserselectedNumbers.Skip(5));
            }
            else
            {
                lbl_yourInput.Text += string.Join(", ", UserselectedNumbers);
            }
        }

    }
}
