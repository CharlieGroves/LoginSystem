namespace GUI
{
    partial class Form1
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
            this.btnLoginPage = new System.Windows.Forms.Button();
            this.btnCreateAccountPage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginPage
            // 
            this.btnLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPage.Location = new System.Drawing.Point(308, 238);
            this.btnLoginPage.Name = "btnLoginPage";
            this.btnLoginPage.Size = new System.Drawing.Size(170, 95);
            this.btnLoginPage.TabIndex = 0;
            this.btnLoginPage.Text = "Login";
            this.btnLoginPage.UseVisualStyleBackColor = true;
            this.btnLoginPage.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnCreateAccountPage
            // 
            this.btnCreateAccountPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccountPage.Location = new System.Drawing.Point(508, 238);
            this.btnCreateAccountPage.Name = "btnCreateAccountPage";
            this.btnCreateAccountPage.Size = new System.Drawing.Size(170, 95);
            this.btnCreateAccountPage.TabIndex = 1;
            this.btnCreateAccountPage.Text = "Create Account";
            this.btnCreateAccountPage.UseVisualStyleBackColor = true;
            this.btnCreateAccountPage.Click += new System.EventHandler(this.btnCreateAccountPage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateAccountPage);
            this.Controls.Add(this.btnLoginPage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginPage;
        private System.Windows.Forms.Button btnCreateAccountPage;
        private System.Windows.Forms.Button button1;
    }
}

