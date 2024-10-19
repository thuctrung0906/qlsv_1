namespace DUONGTRUNGTHUC_QLSV
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRegister = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(329, 54);
            label1.Name = "label1";
            label1.Size = new Size(119, 41);
            label1.TabIndex = 0;
            label1.Text = "Đăng kí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 125);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 209);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.LightSeaGreen;
            buttonRegister.Font = new Font("Segoe UI", 11F);
            buttonRegister.Location = new Point(295, 287);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(134, 38);
            buttonRegister.TabIndex = 2;
            buttonRegister.Text = "Đăng kí";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(295, 125);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(269, 31);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(295, 203);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(269, 31);
            textBoxPassword.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(829, 453);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRegister;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
    }
}