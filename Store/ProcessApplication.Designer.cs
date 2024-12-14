namespace Store
{
    partial class ProcessApplication
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
            panel1 = new Panel();
            tbTitle = new TextBox();
            buttClear = new Button();
            tbIdClient = new TextBox();
            labelDeparture = new Label();
            label1 = new Label();
            tbShopCode = new TextBox();
            label2 = new Label();
            tbOperation = new TextBox();
            label3 = new Label();
            tbProdCount = new TextBox();
            panel2 = new Panel();
            buttRun = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(tbTitle);
            panel1.Controls.Add(buttClear);
            panel1.Location = new Point(12, 16);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 60);
            panel1.TabIndex = 5;
            // 
            // tbTitle
            // 
            tbTitle.BackColor = SystemColors.GradientActiveCaption;
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbTitle.ForeColor = SystemColors.WindowText;
            tbTitle.Location = new Point(12, 12);
            tbTitle.Margin = new Padding(5);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(257, 35);
            tbTitle.TabIndex = 3;
            tbTitle.TabStop = false;
            tbTitle.Text = "Обработка заявки";
            // 
            // buttClear
            // 
            buttClear.Image = Properties.Resources.icons8_eraser_20;
            buttClear.Location = new Point(485, 15);
            buttClear.Margin = new Padding(4);
            buttClear.Name = "buttClear";
            buttClear.Size = new Size(30, 30);
            buttClear.TabIndex = 2;
            buttClear.TabStop = false;
            buttClear.UseVisualStyleBackColor = true;
            buttClear.Click += buttClear_Click;
            // 
            // tbIdClient
            // 
            tbIdClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbIdClient.Location = new Point(202, 88);
            tbIdClient.Margin = new Padding(4);
            tbIdClient.Name = "tbIdClient";
            tbIdClient.Size = new Size(345, 30);
            tbIdClient.TabIndex = 6;
            // 
            // labelDeparture
            // 
            labelDeparture.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDeparture.AutoSize = true;
            labelDeparture.Location = new Point(12, 91);
            labelDeparture.Margin = new Padding(4, 0, 4, 0);
            labelDeparture.Name = "labelDeparture";
            labelDeparture.Size = new Size(100, 22);
            labelDeparture.TabIndex = 7;
            labelDeparture.Text = "Id клиента";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(13, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 9;
            label1.Text = "Код магазина";
            // 
            // tbShopCode
            // 
            tbShopCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbShopCode.Location = new Point(202, 122);
            tbShopCode.Margin = new Padding(4);
            tbShopCode.Name = "tbShopCode";
            tbShopCode.Size = new Size(345, 30);
            tbShopCode.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(13, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 11;
            label2.Text = "Тип операции";
            // 
            // tbOperation
            // 
            tbOperation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOperation.Location = new Point(202, 156);
            tbOperation.Margin = new Padding(4);
            tbOperation.Name = "tbOperation";
            tbOperation.Size = new Size(345, 30);
            tbOperation.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(13, 193);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 22);
            label3.TabIndex = 13;
            label3.Text = "Количество товаров";
            // 
            // tbProdCount
            // 
            tbProdCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbProdCount.Location = new Point(202, 190);
            tbProdCount.Margin = new Padding(4);
            tbProdCount.Name = "tbProdCount";
            tbProdCount.Size = new Size(345, 30);
            tbProdCount.TabIndex = 12;
            tbProdCount.TextChanged += tbProdCount_TextChanged;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Location = new Point(163, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 132);
            panel2.TabIndex = 14;
            // 
            // buttRun
            // 
            buttRun.BackColor = SystemColors.ButtonHighlight;
            buttRun.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttRun.Location = new Point(20, 234);
            buttRun.Name = "buttRun";
            buttRun.Size = new Size(120, 120);
            buttRun.TabIndex = 15;
            buttRun.Text = "Создать заявку";
            buttRun.UseVisualStyleBackColor = false;
            buttRun.Click += buttRun_Click;
            // 
            // ProcessApplication
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(556, 372);
            Controls.Add(buttRun);
            Controls.Add(label3);
            Controls.Add(tbProdCount);
            Controls.Add(label2);
            Controls.Add(tbOperation);
            Controls.Add(label1);
            Controls.Add(tbShopCode);
            Controls.Add(labelDeparture);
            Controls.Add(tbIdClient);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProcessApplication";
            Padding = new Padding(0, 0, 0, 10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttClear;
        private TextBox tbIdClient;
        private Label labelDeparture;
        private Label label1;
        private TextBox tbShopCode;
        private Label label2;
        private TextBox tbOperation;
        private Label label3;
        private TextBox tbProdCount;
        private TextBox tbTitle;
        private Panel panel2;
        private Button buttRun;
    }
}