namespace WindowCalculator.Forms
{
    partial class AdminForm
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
            txtCategory = new TextBox();
            txtName = new TextBox();
            txtColor = new TextBox();
            txtPrice = new TextBox();
            txtDesc = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(109, 12);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(109, 78);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(125, 27);
            txtColor.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(109, 111);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(109, 144);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(125, 27);
            txtDesc.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 6;
            label1.Text = "Категорія:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 7;
            label2.Text = "Назва:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "Колір:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 9;
            label4.Text = "Ціна:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "Опис:";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 238);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtDesc);
            Controls.Add(txtPrice);
            Controls.Add(txtColor);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategory;
        private TextBox txtName;
        private TextBox txtColor;
        private TextBox txtPrice;
        private TextBox txtDesc;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}