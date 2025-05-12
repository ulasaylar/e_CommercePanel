namespace E_CommercePanel
{
    partial class FrmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrders));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListOrderDetail = new System.Windows.Forms.Button();
            this.btnListOrders = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(7, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order ID :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(198, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 426);
            this.panel1.TabIndex = 3;
            // 
            // btnListOrderDetail
            // 
            this.btnListOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListOrderDetail.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnListOrderDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListOrderDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOrderDetail.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.btnListOrderDetail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListOrderDetail.Location = new System.Drawing.Point(14, 496);
            this.btnListOrderDetail.Name = "btnListOrderDetail";
            this.btnListOrderDetail.Size = new System.Drawing.Size(169, 46);
            this.btnListOrderDetail.TabIndex = 4;
            this.btnListOrderDetail.Text = "List Order Detail";
            this.btnListOrderDetail.UseVisualStyleBackColor = true;
            this.btnListOrderDetail.Click += new System.EventHandler(this.btnListOrderDetail_Click);
            // 
            // btnListOrders
            // 
            this.btnListOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListOrders.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnListOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOrders.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.btnListOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListOrders.Location = new System.Drawing.Point(14, 116);
            this.btnListOrders.Name = "btnListOrders";
            this.btnListOrders.Size = new System.Drawing.Size(169, 46);
            this.btnListOrders.TabIndex = 5;
            this.btnListOrders.Text = "List Orders";
            this.btnListOrders.UseVisualStyleBackColor = true;
            this.btnListOrders.Click += new System.EventHandler(this.btnListOrders_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 32.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(210, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 62);
            this.label2.TabIndex = 8;
            this.label2.Text = "Admin Panel - Orders";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(14, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 90);
            this.btnBack.TabIndex = 18;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(702, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 90);
            this.btnExit.TabIndex = 19;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(153, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 1);
            this.panel2.TabIndex = 20;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderID.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.txtOrderID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtOrderID.Location = new System.Drawing.Point(128, 442);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(55, 39);
            this.txtOrderID.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(128, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 1);
            this.panel3.TabIndex = 22;
            // 
            // FrmOrders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(806, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListOrders);
            this.Controls.Add(this.btnListOrderDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListOrderDetail;
        private System.Windows.Forms.Button btnListOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Panel panel3;
    }
}