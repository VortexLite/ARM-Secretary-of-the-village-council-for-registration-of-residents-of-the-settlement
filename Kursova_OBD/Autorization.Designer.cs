namespace Kursova_OBD
{
    partial class Autorization
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
            panel1 = new Panel();
            btn_in = new Button();
            label3 = new Label();
            tb_password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb_login = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btn_in);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tb_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_login);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 478);
            panel1.TabIndex = 0;
            // 
            // btn_in
            // 
            btn_in.BackColor = Color.Lavender;
            btn_in.Cursor = Cursors.Hand;
            btn_in.FlatAppearance.BorderSize = 0;
            btn_in.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            btn_in.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_in.FlatStyle = FlatStyle.Flat;
            btn_in.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_in.Location = new Point(123, 339);
            btn_in.Margin = new Padding(3, 2, 3, 2);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(268, 57);
            btn_in.TabIndex = 8;
            btn_in.Text = "Увійти";
            btn_in.UseVisualStyleBackColor = false;
            btn_in.Click += btn_in_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Indigo;
            label3.Font = new Font("Segoe UI Emoji", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(541, 128);
            label3.TabIndex = 7;
            label3.Text = "Авторизація";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tb_password.Location = new Point(123, 267);
            tb_password.Margin = new Padding(3, 2, 3, 2);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(268, 38);
            tb_password.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(212, 227);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 146);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 4;
            label1.Text = "Логін";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_login
            // 
            tb_login.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_login.Location = new Point(123, 187);
            tb_login.Margin = new Padding(3, 2, 3, 2);
            tb_login.Multiline = true;
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(268, 38);
            tb_login.TabIndex = 3;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(540, 476);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Autorization";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox tb_login;
        private Button btn_in;
        private Label label3;
        private TextBox tb_password;
        private Label label2;
        private Label label1;
    }
}