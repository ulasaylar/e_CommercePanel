namespace E_CommercePanel
{
    partial class FrmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrders = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReviews);
            this.groupBox1.Controls.Add(this.btnOrders);
            this.groupBox1.Location = new System.Drawing.Point(148, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnOrders
            // 
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrders.Location = new System.Drawing.Point(22, 51);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(205, 50);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditCustomers);
            this.groupBox2.Controls.Add(this.btnCustomers);
            this.groupBox2.Location = new System.Drawing.Point(403, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomers.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEditCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomers.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.btnEditCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditCustomers.Location = new System.Drawing.Point(24, 139);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(205, 50);
            this.btnEditCustomers.TabIndex = 5;
            this.btnEditCustomers.Text = "Edit Customers";
            this.btnEditCustomers.UseVisualStyleBackColor = true;
            this.btnEditCustomers.Click += new System.EventHandler(this.btnEditCustomers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomers.Location = new System.Drawing.Point(24, 51);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(205, 50);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(244, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(470, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customers";
            // 
            // btnReviews
            // 
            this.btnReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviews.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReviews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnReviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.btnReviews.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReviews.Location = new System.Drawing.Point(22, 139);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(205, 50);
            this.btnReviews.TabIndex = 1;
            this.btnReviews.Text = "Reviews";
            this.btnReviews.UseVisualStyleBackColor = true;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(683, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 90);
            this.btnExit.TabIndex = 23;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 90);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}