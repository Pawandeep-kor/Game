namespace TicTacToeGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblStatus = new Label();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 24F);
            btn1.Location = new Point(12, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 24F);
            btn2.Location = new Point(146, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 24F);
            btn3.Location = new Point(288, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 24F);
            btn4.Location = new Point(12, 109);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 24F);
            btn5.Location = new Point(146, 109);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 24F);
            btn6.Location = new Point(288, 109);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 24F);
            btn7.Location = new Point(12, 215);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 24F);
            btn8.Location = new Point(146, 215);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 24F);
            btn9.Location = new Point(288, 215);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 365);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(101, 20);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Player X's turn";
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Segoe UI", 12F);
            btnRestart.Location = new Point(214, 355);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(100, 40);
            btnRestart.TabIndex = 10;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(lblStatus);
            Controls.Add(btnRestart);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label lblStatus;
        private Button btnRestart;
    }
}
