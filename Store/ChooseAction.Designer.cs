namespace Store
{
    partial class ChooseAction
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttApplication = new Button();
            buttProducts = new Button();
            buttStaff = new Button();
            buttPosts = new Button();
            buttClients = new Button();
            label1 = new Label();
            panel1 = new Panel();
            buttStorages = new Button();
            buttShops = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttApplication
            // 
            buttApplication.BackColor = SystemColors.AppWorkspace;
            buttApplication.FlatStyle = FlatStyle.Popup;
            buttApplication.Location = new Point(33, 62);
            buttApplication.Margin = new Padding(4);
            buttApplication.Name = "buttApplication";
            buttApplication.Size = new Size(266, 50);
            buttApplication.TabIndex = 0;
            buttApplication.TabStop = false;
            buttApplication.Text = "Оформить новую заявку";
            buttApplication.UseVisualStyleBackColor = false;
            buttApplication.Click += buttApplication_Click;
            // 
            // buttProducts
            // 
            buttProducts.BackColor = SystemColors.ButtonFace;
            buttProducts.FlatStyle = FlatStyle.Popup;
            buttProducts.Location = new Point(78, 178);
            buttProducts.Margin = new Padding(4);
            buttProducts.Name = "buttProducts";
            buttProducts.Size = new Size(180, 50);
            buttProducts.TabIndex = 1;
            buttProducts.TabStop = false;
            buttProducts.Text = "Товары";
            buttProducts.UseVisualStyleBackColor = false;
            buttProducts.Click += buttProducts_Click;
            // 
            // buttStaff
            // 
            buttStaff.BackColor = SystemColors.ButtonFace;
            buttStaff.FlatStyle = FlatStyle.Popup;
            buttStaff.Location = new Point(78, 236);
            buttStaff.Margin = new Padding(4);
            buttStaff.Name = "buttStaff";
            buttStaff.Size = new Size(180, 50);
            buttStaff.TabIndex = 2;
            buttStaff.TabStop = false;
            buttStaff.Text = "Сотрудники";
            buttStaff.UseVisualStyleBackColor = false;
            buttStaff.Click += buttStaff_Click;
            // 
            // buttPosts
            // 
            buttPosts.BackColor = SystemColors.ButtonFace;
            buttPosts.FlatStyle = FlatStyle.Popup;
            buttPosts.Location = new Point(78, 294);
            buttPosts.Margin = new Padding(4);
            buttPosts.Name = "buttPosts";
            buttPosts.Size = new Size(180, 50);
            buttPosts.TabIndex = 3;
            buttPosts.TabStop = false;
            buttPosts.Text = "Должности";
            buttPosts.UseVisualStyleBackColor = false;
            buttPosts.Click += buttPosts_Click;
            // 
            // buttClients
            // 
            buttClients.BackColor = SystemColors.ButtonFace;
            buttClients.FlatStyle = FlatStyle.Popup;
            buttClients.Location = new Point(78, 120);
            buttClients.Margin = new Padding(4);
            buttClients.Name = "buttClients";
            buttClients.Size = new Size(180, 50);
            buttClients.TabIndex = 4;
            buttClients.TabStop = false;
            buttClients.Text = "Клиенты";
            buttClients.UseVisualStyleBackColor = false;
            buttClients.Click += buttClients_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 23);
            label1.TabIndex = 5;
            label1.Text = "Выберите, с чем хотите работать";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 33);
            panel1.TabIndex = 6;
            // 
            // buttStorages
            // 
            buttStorages.BackColor = SystemColors.ButtonFace;
            buttStorages.FlatStyle = FlatStyle.Popup;
            buttStorages.Location = new Point(78, 410);
            buttStorages.Margin = new Padding(4);
            buttStorages.Name = "buttStorages";
            buttStorages.Size = new Size(180, 50);
            buttStorages.TabIndex = 8;
            buttStorages.TabStop = false;
            buttStorages.Text = "Склады";
            buttStorages.UseVisualStyleBackColor = false;
            buttStorages.Click += buttStorages_Click;
            // 
            // buttShops
            // 
            buttShops.BackColor = SystemColors.ButtonFace;
            buttShops.FlatStyle = FlatStyle.Popup;
            buttShops.Location = new Point(78, 352);
            buttShops.Margin = new Padding(4);
            buttShops.Name = "buttShops";
            buttShops.Size = new Size(180, 50);
            buttShops.TabIndex = 7;
            buttShops.TabStop = false;
            buttShops.Text = "Магазины";
            buttShops.UseVisualStyleBackColor = false;
            buttShops.Click += buttShops_Click;
            // 
            // ChooseAction
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 475);
            Controls.Add(buttStorages);
            Controls.Add(buttShops);
            Controls.Add(panel1);
            Controls.Add(buttClients);
            Controls.Add(buttPosts);
            Controls.Add(buttStaff);
            Controls.Add(buttProducts);
            Controls.Add(buttApplication);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ChooseAction";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttApplication;
        private Button buttProducts;
        private Button buttStaff;
        private Button buttPosts;
        private Button buttClients;
        private Label label1;
        private Panel panel1;
        private Button buttStorages;
        private Button buttShops;
    }
}