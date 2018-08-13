namespace FatKillerSimpleAdministrator
{
    partial class AdministratorMainPanel
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
            this.ProductManagerButton = new System.Windows.Forms.Button();
            this.UserManagerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductManagerButton
            // 
            this.ProductManagerButton.Location = new System.Drawing.Point(12, 12);
            this.ProductManagerButton.Name = "ProductManagerButton";
            this.ProductManagerButton.Size = new System.Drawing.Size(218, 51);
            this.ProductManagerButton.TabIndex = 1;
            this.ProductManagerButton.Text = "Panel zarządzania produktami";
            this.ProductManagerButton.UseVisualStyleBackColor = true;
            this.ProductManagerButton.Click += new System.EventHandler(this.GoToProductManagerButton_Click);
            // 
            // UserManagerButton
            // 
            this.UserManagerButton.Location = new System.Drawing.Point(12, 69);
            this.UserManagerButton.Name = "UserManagerButton";
            this.UserManagerButton.Size = new System.Drawing.Size(218, 51);
            this.UserManagerButton.TabIndex = 2;
            this.UserManagerButton.Text = "Panel zarządzania użytkownikiem";
            this.UserManagerButton.UseVisualStyleBackColor = true;
            // 
            // AdministratorMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 450);
            this.Controls.Add(this.UserManagerButton);
            this.Controls.Add(this.ProductManagerButton);
            this.Name = "AdministratorMainPanel";
            this.Text = "Panel administratora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductManagerButton;
        private System.Windows.Forms.Button UserManagerButton;
    }
}

