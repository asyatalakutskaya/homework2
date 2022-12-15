
namespace HA
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
            this.messages = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.mail = new System.Windows.Forms.Label();
            this.raiting = new System.Windows.Forms.Label();
            this.friends = new System.Windows.Forms.Label();
            this.countmess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // messages
            // 
            this.messages.AutoSize = true;
            this.messages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messages.Location = new System.Drawing.Point(35, 51);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(98, 45);
            this.messages.TabIndex = 0;
            this.messages.Text = "Имя: ";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.Location = new System.Drawing.Point(720, 345);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(230, 57);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(704, 28);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(270, 270);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mail.Location = new System.Drawing.Point(34, 129);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(125, 45);
            this.mail.TabIndex = 3;
            this.mail.Text = "Почта: ";
            // 
            // raiting
            // 
            this.raiting.AutoSize = true;
            this.raiting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.raiting.Location = new System.Drawing.Point(35, 213);
            this.raiting.Name = "raiting";
            this.raiting.Size = new System.Drawing.Size(152, 45);
            this.raiting.TabIndex = 4;
            this.raiting.Text = "Рейтинг: ";
            // 
            // friends
            // 
            this.friends.AutoSize = true;
            this.friends.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friends.Location = new System.Drawing.Point(33, 293);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(320, 45);
            this.friends.TabIndex = 5;
            this.friends.Text = "Количество друзей: ";
            // 
            // countmess
            // 
            this.countmess.AutoSize = true;
            this.countmess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countmess.Location = new System.Drawing.Point(32, 370);
            this.countmess.Name = "countmess";
            this.countmess.Size = new System.Drawing.Size(452, 45);
            this.countmess.TabIndex = 6;
            this.countmess.Text = "Непрочитанных сообщений: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 454);
            this.Controls.Add(this.countmess);
            this.Controls.Add(this.friends);
            this.Controls.Add(this.raiting);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.messages);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label raiting;
        private System.Windows.Forms.Label friends;
        private System.Windows.Forms.Label countmess;
    }
}