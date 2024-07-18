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
        private List<int> UserselectedNumbers = new List<int>(); // 儲存使用者選擇的號碼
        private NumberGenerator numberGenerator;
        private UIHelper uiHelper;
        private TableLayoutPanel openLayoutPanel;  // 改為不同的名稱
        private TableLayoutPanel chooseLayoutPanel;  // 改為不同的名稱
        public Form1()
        {
            InitializeComponent();
            InitializeNumberLabels();  // 呼叫這個方法來初始化 numberLabels
            numberGenerator = new NumberGenerator();

            uiHelper = new UIHelper();

            // 初始化 openLayoutPanel
            openLayoutPanel = new TableLayoutPanel();
            openLayoutPanel.Name = "openLayoutPanel"; // 可選：設定名稱
            openLayoutPanel.Dock = DockStyle.Fill;
            Controls.Add(openLayoutPanel); // 加入到表單的 Controls 集合中

            // 初始化 chooseLayoutPanel
            chooseLayoutPanel = new TableLayoutPanel();
            chooseLayoutPanel.Name = "chooseLayoutPanel"; // 可選：設定名稱
            chooseLayoutPanel.Dock = DockStyle.Fill;
            Controls.Add(chooseLayoutPanel); // 加入到表單的 Controls 集合中

            //生成按鈕
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
                openTableLayoutPanel.Controls.Add(label);
                numberLabels.Add(label);
            }
        }

        private void btn_open(object sender, EventArgs e)
        {
            // 顯示openTableLayoutPanel，隱藏chooseTableLayoutPanel
            openTableLayoutPanel.Visible = true;
            chooseTableLayoutPanel.Visible = false;

            if (UserselectedNumbers == null || UserselectedNumbers.Count == 0)
            {
                MessageBox.Show("請先輸入號碼並按確認按鈕。");
                return;
            }
            // 清空先前的開獎號碼
            foreach (Label label in numberLabels)
            {
                label.BackColor = SystemColors.Control;
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
            // 看有沒有中獎
            List<int> matchedNumbers = userNumbers.Intersect(selectedNumbers).ToList();

            var formattedMatchedNumbers = matchedNumbers.Select(n => n < 10 ? $"0{n}" : n.ToString()).ToList();
            var matchedNumbersText = new StringBuilder("中獎號碼:\n");

            for (int i = 0; i < formattedMatchedNumbers.Count; i++)
            {
                matchedNumbersText.Append(formattedMatchedNumbers[i] + " ");
                if ((i + 1) % 5 == 0) matchedNumbersText.Append("\n");
            }

            lbl_result.Text = matchedNumbersText.ToString();
            // 顯示開獎號碼
            // 格式化開獎號碼並分行顯示
            var formattedNumbers = selectedNumbers.Select(n => n < 10 ? $"0{n}" : n.ToString()).ToList();
            var displayText = new StringBuilder("開獎號碼:\n");

            for (int i = 0; i < formattedNumbers.Count; i++)
            {
                displayText.Append(formattedNumbers[i] + " ");
                if ((i + 1) % 5 == 0) displayText.Append("\n");
            }

            lbl_openNumbers.Text = displayText.ToString();

        }



        private void rBtn_choose_Click(object sender, EventArgs e)
        {
            userNumbers = new List<int>();
            UserselectedNumbers = new List<int>();
            lbl_yourInput.Text = $"你的選號：\n";
            // 清空 chooseTableLayoutPanel 中的所有控制項
            chooseTableLayoutPanel.Controls.Clear();
            chooseTableLayoutPanel.RowStyles.Clear();
            chooseTableLayoutPanel.ColumnStyles.Clear();

            // 設置 chooseTableLayoutPanel 的行和列
            chooseTableLayoutPanel.ColumnCount = 10;
            chooseTableLayoutPanel.RowCount = 8;

            // 設置每列和每行的大小
            for (int i = 0; i < 10; i++)
            {
                chooseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            }
            for (int i = 0; i < 8; i++)
            {
                chooseTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            }

            // 填充 chooseTableLayoutPanel 中的號碼按鈕
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
                        btnNumber.Click += BtnNumberForSelection_Click; // 添加點擊事件處理程序

                        chooseTableLayoutPanel.Controls.Add(btnNumber, col, row);
                        number++;
                    }
                }
            }
            // 顯示chooseTableLayoutPanel，隱藏openTableLayoutPanel
            chooseTableLayoutPanel.Visible = true;
            openTableLayoutPanel.Visible = false;
        }
       
        //這裡是點我選號的時候 按按鈕選擇號碼
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
            var formattedUserNumbers = UserselectedNumbers.Select(n => n < 10 ? $"0{n}" : n.ToString()).ToList();
            var userNumbersText = new StringBuilder("你的選號:\n");

            for (int i = 0; i < formattedUserNumbers.Count; i++)
            {
                userNumbersText.Append(formattedUserNumbers[i] + " ");
                if ((i + 1) % 5 == 0) userNumbersText.Append("\n");
            }

            lbl_yourInput.Text = userNumbersText.ToString();
            // 更新 userNumbers 列表
            userNumbers = new List<int>(UserselectedNumbers);
        }
        // 點我確認所選號碼
        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            if (UserselectedNumbers.Count == 0)
            {
                MessageBox.Show("請先選擇號碼後再確認。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 如果有選擇號碼，顯示使用者所選的號碼
            MessageBox.Show($"您選擇了號碼: {string.Join(", ", UserselectedNumbers)}", "確認選號結果", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 將選擇的號碼存儲到 userNumbers 中，以便開獎使用
            userNumbers = new List<int>(UserselectedNumbers);
            // 清空先前的開獎號碼
            foreach (Label label in numberLabels)
            {
                label.ForeColor = SystemColors.ControlText;
                label.Font = new Font(label.Font, FontStyle.Regular);
                label.BackColor = Color.White;
            }

        }

    }
}
