namespace WindowCalculator.Forms
{
    partial class MainForm
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
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            txtSections = new TextBox();
            txtOpeningSections = new TextBox();
            txtFramePrice = new TextBox();
            txtGlassPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalculate = new Button();
            btnMaterials = new Button();
            groupBox1 = new GroupBox();
            btnOrders = new Button();
            btnAdmin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(145, 31);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 0;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(145, 64);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 1;
            // 
            // txtSections
            // 
            txtSections.Location = new Point(145, 110);
            txtSections.Name = "txtSections";
            txtSections.Size = new Size(125, 27);
            txtSections.TabIndex = 2;
            // 
            // txtOpeningSections
            // 
            txtOpeningSections.Location = new Point(145, 143);
            txtOpeningSections.Name = "txtOpeningSections";
            txtOpeningSections.Size = new Size(125, 27);
            txtOpeningSections.TabIndex = 3;
            // 
            // txtFramePrice
            // 
            txtFramePrice.Location = new Point(145, 192);
            txtFramePrice.Name = "txtFramePrice";
            txtFramePrice.Size = new Size(125, 27);
            txtFramePrice.TabIndex = 4;
            // 
            // txtGlassPrice
            // 
            txtGlassPrice.Location = new Point(145, 225);
            txtGlassPrice.Name = "txtGlassPrice";
            txtGlassPrice.Size = new Size(125, 27);
            txtGlassPrice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 6;
            label1.Text = "Ширина:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(15, 65);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 7;
            label2.Text = "Висока:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 114);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 8;
            label3.Text = "Секції:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(15, 144);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 9;
            label4.Text = "Відкривається:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(15, 193);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 10;
            label5.Text = "Ціна рами:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(15, 226);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 11;
            label6.Text = "Ціна скла:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(15, 290);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(124, 29);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnMaterials
            // 
            btnMaterials.Location = new Point(27, 348);
            btnMaterials.Name = "btnMaterials";
            btnMaterials.Size = new Size(120, 29);
            btnMaterials.TabIndex = 13;
            btnMaterials.Text = "Матеріали";
            btnMaterials.UseVisualStyleBackColor = true;
            btnMaterials.Click += btnMaterials_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtWidth);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSections);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtOpeningSections);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFramePrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGlassPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 330);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(153, 348);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(120, 29);
            btnOrders.TabIndex = 15;
            btnOrders.Text = "Замовлення";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(27, 383);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(118, 29);
            btnAdmin.TabIndex = 16;
            btnAdmin.Text = "Адмін";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnOrders);
            Controls.Add(groupBox1);
            Controls.Add(btnMaterials);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtWidth;
        private TextBox txtHeight;
        private TextBox txtSections;
        private TextBox txtOpeningSections;
        private TextBox txtFramePrice;
        private TextBox txtGlassPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalculate;
        private Button btnMaterials;
        private GroupBox groupBox1;
        private Button btnOrders;
        private Button btnAdmin;
    }
}