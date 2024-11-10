namespace CalculatorApplication
{
    partial class FrmCalculator
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
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            btnEqual = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDisplayTotal = new Label();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(226, 15);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(285, 34);
            txtBoxInput1.TabIndex = 0;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(226, 106);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(285, 34);
            txtBoxInput2.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 8.25F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(338, 65);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(70, 25);
            cbOperator.TabIndex = 2;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 12F);
            btnEqual.Location = new Point(319, 209);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(121, 29);
            btnEqual.TabIndex = 4;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 18);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 5;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 6;
            label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(141, 155);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 7;
            label3.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 11F, FontStyle.Underline);
            lblDisplayTotal.Location = new Point(226, 162);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(292, 25);
            lblDisplayTotal.TabIndex = 9;
            lblDisplayTotal.Text = "___________________________________";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 250);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Button btnEqual;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDisplayTotal;
    }
}
