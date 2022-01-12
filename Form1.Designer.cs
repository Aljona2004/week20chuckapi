namespace ChuckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokeBtn = new System.Windows.Forms.Button();
            this.JokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getJokeBtn
            // 
            this.getJokeBtn.Location = new System.Drawing.Point(278, 188);
            this.getJokeBtn.Name = "getJokeBtn";
            this.getJokeBtn.Size = new System.Drawing.Size(267, 174);
            this.getJokeBtn.TabIndex = 0;
            this.getJokeBtn.Text = "GetJoke";
            this.getJokeBtn.UseVisualStyleBackColor = true;
            this.getJokeBtn.Click += new System.EventHandler(this.getJokeBtn_Click);
            // 
            // JokeBox
            // 
            this.JokeBox.Location = new System.Drawing.Point(121, 399);
            this.JokeBox.Name = "JokeBox";
            this.JokeBox.Size = new System.Drawing.Size(550, 96);
            this.JokeBox.TabIndex = 1;
            this.JokeBox.Text = "Get a joke, I dear you!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.JokeBox);
            this.Controls.Add(this.getJokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokeBtn;
        private System.Windows.Forms.RichTextBox JokeBox;
    }
}

