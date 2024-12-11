namespace WinFormMethod02
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnCircumference = new Button();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnOutputParameter = new Button();
            txtInput = new TextBox();
            btnRefParameter = new Button();
            txtSize = new TextBox();
            txtLetter = new TextBox();
            btnTriangle01 = new Button();
            txtOutput = new TextBox();
            btnArrayParameter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LemonChiffon;
            groupBox1.Controls.Add(btnCircumference);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(445, 58);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(94, 29);
            btnCircumference.TabIndex = 4;
            btnCircumference.Text = "เส้นรอบวง";
            btnCircumference.UseVisualStyleBackColor = true;
            btnCircumference.Click += btnCircumference_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(324, 58);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(94, 29);
            btnCircleArea.TabIndex = 3;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(129, 58);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(165, 27);
            txtRadius.TabIndex = 2;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.PaleGreen;
            lblResult.Font = new Font("Segoe UI", 15F);
            lblResult.Location = new Point(129, 100);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(216, 62);
            lblResult.TabIndex = 1;
            lblResult.Text = ".....";
            lblResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SandyBrown;
            groupBox2.Controls.Add(btnOutputParameter);
            groupBox2.Controls.Add(txtInput);
            groupBox2.Controls.Add(btnRefParameter);
            groupBox2.Controls.Add(txtSize);
            groupBox2.Controls.Add(txtLetter);
            groupBox2.Controls.Add(btnTriangle01);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(27, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(571, 357);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ function";
            // 
            // btnOutputParameter
            // 
            btnOutputParameter.Location = new Point(235, 252);
            btnOutputParameter.Name = "btnOutputParameter";
            btnOutputParameter.Size = new Size(304, 50);
            btnOutputParameter.TabIndex = 6;
            btnOutputParameter.Text = "ทดสอบ output Parameter";
            btnOutputParameter.UseVisualStyleBackColor = true;
            btnOutputParameter.Click += btnOutputParameter_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(235, 126);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(304, 27);
            txtInput.TabIndex = 5;
            // 
            // btnRefParameter
            // 
            btnRefParameter.Location = new Point(235, 170);
            btnRefParameter.Name = "btnRefParameter";
            btnRefParameter.Size = new Size(304, 50);
            btnRefParameter.TabIndex = 4;
            btnRefParameter.Text = "ทดสอบ reference parameter";
            btnRefParameter.UseVisualStyleBackColor = true;
            btnRefParameter.Click += btnRefParameter_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(247, 74);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 3;
            txtSize.Text = "5";
            txtSize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(247, 26);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(125, 27);
            txtLetter.TabIndex = 2;
            txtLetter.Text = "A";
            txtLetter.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(434, 26);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(94, 44);
            btnTriangle01.TabIndex = 1;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(20, 26);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(188, 231);
            txtOutput.TabIndex = 0;
            // 
            // btnArrayParameter
            // 
            btnArrayParameter.Location = new Point(731, 43);
            btnArrayParameter.Name = "btnArrayParameter";
            btnArrayParameter.Size = new Size(200, 77);
            btnArrayParameter.TabIndex = 2;
            btnArrayParameter.Text = "Parameter แบบ Array";
            btnArrayParameter.UseVisualStyleBackColor = true;
            btnArrayParameter.Click += btnArrayParameter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1062, 600);
            Controls.Add(btnArrayParameter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRadius;
        private Label lblResult;
        private Label label1;
        private Button btnCircumference;
        private Button btnCircleArea;
        private GroupBox groupBox2;
        private TextBox txtOutput;
        private Button btnTriangle01;
        private TextBox txtSize;
        private TextBox txtLetter;
        private Button btnRefParameter;
        private TextBox txtInput;
        private Button btnOutputParameter;
        private Button btnArrayParameter;
    }
}
