namespace Store
{
    partial class Products
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
            panel = new Panel();
            tbSearch = new TextBox();
            buttReload = new Button();
            tbTitle = new TextBox();
            dataGridView1 = new DataGridView();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = SystemColors.GradientActiveCaption;
            panel.Controls.Add(tbSearch);
            panel.Controls.Add(buttReload);
            panel.Controls.Add(tbTitle);
            panel.Location = new Point(17, 14);
            panel.Margin = new Padding(5);
            panel.Name = "panel";
            panel.Size = new Size(800, 78);
            panel.TabIndex = 4;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(168, 22);
            tbSearch.Margin = new Padding(4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(146, 30);
            tbSearch.TabIndex = 3;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // buttReload
            // 
            buttReload.Image = Properties.Resources.icons8_refresh_801;
            buttReload.Location = new Point(331, 22);
            buttReload.Margin = new Padding(4);
            buttReload.Name = "buttReload";
            buttReload.Size = new Size(30, 30);
            buttReload.TabIndex = 2;
            buttReload.UseVisualStyleBackColor = true;
            buttReload.Click += buttReload_Click;
            // 
            // tbTitle
            // 
            tbTitle.BackColor = SystemColors.GradientActiveCaption;
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbTitle.ForeColor = SystemColors.WindowText;
            tbTitle.Location = new Point(19, 20);
            tbTitle.Margin = new Padding(5);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(140, 35);
            tbTitle.TabIndex = 0;
            tbTitle.Text = "Товары";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 102);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 300);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(panel);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Products_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private TextBox tbSearch;
        private Button buttReload;
        private TextBox tbTitle;
        private DataGridView dataGridView1;
    }
}