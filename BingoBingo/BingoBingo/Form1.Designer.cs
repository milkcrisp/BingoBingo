namespace BingoBingo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Input = new System.Windows.Forms.TextBox();
            this.txtBox_inputsuperNo = new System.Windows.Forms.TextBox();
            this.txtBox_BigorSmall = new System.Windows.Forms.TextBox();
            this.txtBox_OddorEVEN = new System.Windows.Forms.TextBox();
            this.lbllayout_numberLabels = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_yourInput = new System.Windows.Forms.Label();
            this.lbl_OddOrEven = new System.Windows.Forms.Label();
            this.lbl_BigOrSmall = new System.Windows.Forms.Label();
            this.lbl_superNo = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.roundButton4 = new BingoBingo.RoundButton();
            this.roundButton3 = new BingoBingo.RoundButton();
            this.roundButton2 = new BingoBingo.RoundButton();
            this.rBtn_InputNo = new BingoBingo.RoundButton();
            this.roundButton6 = new BingoBingo.RoundButton();
            this.roundButton5 = new BingoBingo.RoundButton();
            this.rBtn_choose = new BingoBingo.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(590, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "BINGO BINGO賓果賓果";
            // 
            // txtBox_Input
            // 
            this.txtBox_Input.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_Input.Location = new System.Drawing.Point(12, 63);
            this.txtBox_Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Input.Name = "txtBox_Input";
            this.txtBox_Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_Input.Size = new System.Drawing.Size(240, 43);
            this.txtBox_Input.TabIndex = 7;
            this.txtBox_Input.Text = "請輸入選號";
            // 
            // txtBox_inputsuperNo
            // 
            this.txtBox_inputsuperNo.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_inputsuperNo.Location = new System.Drawing.Point(12, 240);
            this.txtBox_inputsuperNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_inputsuperNo.Name = "txtBox_inputsuperNo";
            this.txtBox_inputsuperNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_inputsuperNo.Size = new System.Drawing.Size(240, 43);
            this.txtBox_inputsuperNo.TabIndex = 8;
            this.txtBox_inputsuperNo.Text = "請輸入超級選號";
            // 
            // txtBox_BigorSmall
            // 
            this.txtBox_BigorSmall.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_BigorSmall.Location = new System.Drawing.Point(12, 410);
            this.txtBox_BigorSmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_BigorSmall.Name = "txtBox_BigorSmall";
            this.txtBox_BigorSmall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_BigorSmall.Size = new System.Drawing.Size(240, 43);
            this.txtBox_BigorSmall.TabIndex = 9;
            this.txtBox_BigorSmall.Text = "請輸入大或小";
            // 
            // txtBox_OddorEVEN
            // 
            this.txtBox_OddorEVEN.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_OddorEVEN.Location = new System.Drawing.Point(12, 570);
            this.txtBox_OddorEVEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_OddorEVEN.Name = "txtBox_OddorEVEN";
            this.txtBox_OddorEVEN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_OddorEVEN.Size = new System.Drawing.Size(240, 43);
            this.txtBox_OddorEVEN.TabIndex = 10;
            this.txtBox_OddorEVEN.Text = "請輸入單或雙";
            // 
            // lbllayout_numberLabels
            // 
            this.lbllayout_numberLabels.BackColor = System.Drawing.SystemColors.Window;
            this.lbllayout_numberLabels.ColumnCount = 8;
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.lbllayout_numberLabels.Location = new System.Drawing.Point(495, 201);
            this.lbllayout_numberLabels.Name = "lbllayout_numberLabels";
            this.lbllayout_numberLabels.RowCount = 10;
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lbllayout_numberLabels.Size = new System.Drawing.Size(590, 449);
            this.lbllayout_numberLabels.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 71);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.rBtn_choose);
            this.panel2.Controls.Add(this.roundButton4);
            this.panel2.Controls.Add(this.roundButton3);
            this.panel2.Controls.Add(this.roundButton2);
            this.panel2.Controls.Add(this.rBtn_InputNo);
            this.panel2.Controls.Add(this.txtBox_Input);
            this.panel2.Controls.Add(this.txtBox_OddorEVEN);
            this.panel2.Controls.Add(this.txtBox_inputsuperNo);
            this.panel2.Controls.Add(this.txtBox_BigorSmall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 782);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.roundButton6);
            this.panel3.Controls.Add(this.roundButton5);
            this.panel3.Controls.Add(this.lbllayout_numberLabels);
            this.panel3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1582, 853);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.lbl_yourInput);
            this.panel4.Controls.Add(this.lbl_OddOrEven);
            this.panel4.Controls.Add(this.lbl_BigOrSmall);
            this.panel4.Controls.Add(this.lbl_superNo);
            this.panel4.Controls.Add(this.lbl_result);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel4.Location = new System.Drawing.Point(1207, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 782);
            this.panel4.TabIndex = 21;
            // 
            // lbl_yourInput
            // 
            this.lbl_yourInput.AutoSize = true;
            this.lbl_yourInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_yourInput.Location = new System.Drawing.Point(35, 290);
            this.lbl_yourInput.Name = "lbl_yourInput";
            this.lbl_yourInput.Size = new System.Drawing.Size(155, 36);
            this.lbl_yourInput.TabIndex = 23;
            this.lbl_yourInput.Text = "你的選號：";
            // 
            // lbl_OddOrEven
            // 
            this.lbl_OddOrEven.AutoSize = true;
            this.lbl_OddOrEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_OddOrEven.Location = new System.Drawing.Point(35, 204);
            this.lbl_OddOrEven.Name = "lbl_OddOrEven";
            this.lbl_OddOrEven.Size = new System.Drawing.Size(99, 36);
            this.lbl_OddOrEven.TabIndex = 22;
            this.lbl_OddOrEven.Text = "單雙：";
            // 
            // lbl_BigOrSmall
            // 
            this.lbl_BigOrSmall.AutoSize = true;
            this.lbl_BigOrSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_BigOrSmall.Location = new System.Drawing.Point(35, 130);
            this.lbl_BigOrSmall.Name = "lbl_BigOrSmall";
            this.lbl_BigOrSmall.Size = new System.Drawing.Size(99, 36);
            this.lbl_BigOrSmall.TabIndex = 18;
            this.lbl_BigOrSmall.Text = "大小：";
            // 
            // lbl_superNo
            // 
            this.lbl_superNo.AutoSize = true;
            this.lbl_superNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_superNo.Location = new System.Drawing.Point(35, 63);
            this.lbl_superNo.Name = "lbl_superNo";
            this.lbl_superNo.Size = new System.Drawing.Size(155, 36);
            this.lbl_superNo.TabIndex = 21;
            this.lbl_superNo.Text = "超級選號：";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_result.Location = new System.Drawing.Point(35, 496);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(127, 36);
            this.lbl_result.TabIndex = 21;
            this.lbl_result.Text = "中獎結果";
            // 
            // roundButton4
            // 
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roundButton4.Location = new System.Drawing.Point(274, 554);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(131, 131);
            this.roundButton4.TabIndex = 14;
            this.roundButton4.Text = "猜單雙";
            this.roundButton4.UseVisualStyleBackColor = true;
            // 
            // roundButton3
            // 
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roundButton3.Location = new System.Drawing.Point(274, 365);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(131, 131);
            this.roundButton3.TabIndex = 13;
            this.roundButton3.Text = "猜大小";
            this.roundButton3.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roundButton2.Location = new System.Drawing.Point(274, 195);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(131, 131);
            this.roundButton2.TabIndex = 12;
            this.roundButton2.Text = "超級選號";
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // rBtn_InputNo
            // 
            this.rBtn_InputNo.BackColor = System.Drawing.Color.White;
            this.rBtn_InputNo.FlatAppearance.BorderSize = 0;
            this.rBtn_InputNo.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn_InputNo.Location = new System.Drawing.Point(274, 18);
            this.rBtn_InputNo.Name = "rBtn_InputNo";
            this.rBtn_InputNo.Size = new System.Drawing.Size(131, 131);
            this.rBtn_InputNo.TabIndex = 11;
            this.rBtn_InputNo.Text = "點我選號";
            this.rBtn_InputNo.UseVisualStyleBackColor = false;
            this.rBtn_InputNo.Click += new System.EventHandler(this.rBtn_InputNo_Click);
            // 
            // roundButton6
            // 
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roundButton6.Location = new System.Drawing.Point(532, 677);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(131, 131);
            this.roundButton6.TabIndex = 16;
            this.roundButton6.Text = "電腦選號";
            this.roundButton6.UseVisualStyleBackColor = true;
            // 
            // roundButton5
            // 
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roundButton5.Location = new System.Drawing.Point(924, 677);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(131, 131);
            this.roundButton5.TabIndex = 15;
            this.roundButton5.Text = "點我開獎";
            this.roundButton5.UseVisualStyleBackColor = true;
            this.roundButton5.Click += new System.EventHandler(this.btn_open);
            // 
            // rBtn_choose
            // 
            this.rBtn_choose.BackColor = System.Drawing.Color.White;
            this.rBtn_choose.FlatAppearance.BorderSize = 0;
            this.rBtn_choose.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn_choose.Location = new System.Drawing.Point(121, 111);
            this.rBtn_choose.Name = "rBtn_choose";
            this.rBtn_choose.Size = new System.Drawing.Size(131, 131);
            this.rBtn_choose.TabIndex = 15;
            this.rBtn_choose.Text = "點我選號";
            this.rBtn_choose.UseVisualStyleBackColor = false;
            this.rBtn_choose.Click += new System.EventHandler(this.rBtn_choose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.Text = "BingoBingo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Input;
        private System.Windows.Forms.TextBox txtBox_inputsuperNo;
        private System.Windows.Forms.TextBox txtBox_BigorSmall;
        private System.Windows.Forms.TextBox txtBox_OddorEVEN;
        private System.Windows.Forms.TableLayoutPanel lbllayout_numberLabels;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RoundButton rBtn_InputNo;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
        private RoundButton roundButton6;
        private RoundButton roundButton5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_BigOrSmall;
        private System.Windows.Forms.Label lbl_superNo;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_OddOrEven;
        private System.Windows.Forms.Label lbl_yourInput;
        private RoundButton rBtn_choose;
    }
}

