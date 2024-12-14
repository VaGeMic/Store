namespace Store
{
    partial class Clients
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
            dataGridView1 = new DataGridView();
            panel = new Panel();
            tbSearch = new TextBox();
            buttReload = new Button();
            tbTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 102);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = SystemColors.GradientActiveCaption;
            panel.Controls.Add(tbSearch);
            panel.Controls.Add(buttReload);
            panel.Controls.Add(tbTitle);
            panel.Location = new Point(17, 13);
            panel.Margin = new Padding(4);
            panel.Name = "panel";
            panel.Size = new Size(800, 79);
            panel.TabIndex = 1;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(166, 22);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(160, 30);
            tbSearch.TabIndex = 3;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // buttReload
            // 
            buttReload.Image = Properties.Resources.icons8_refresh_801;
            buttReload.Location = new Point(345, 22);
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
            tbTitle.Location = new Point(19, 21);
            tbTitle.Margin = new Padding(4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(127, 35);
            tbTitle.TabIndex = 0;
            tbTitle.Text = "Клиенты";
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(panel);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Clients";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Clients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel;
        private TextBox tbTitle;
        private TextBox tbSearch;
        private Button buttReload;
    }
}