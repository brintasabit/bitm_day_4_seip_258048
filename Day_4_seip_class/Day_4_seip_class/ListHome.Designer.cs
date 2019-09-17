namespace Day_4_seip_class
{
    partial class ListHome
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.add2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(555, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(227, 130);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(247, 20);
            this.addTextBox.TabIndex = 2;
            // 
            // add2Button
            // 
            this.add2Button.Location = new System.Drawing.Point(555, 229);
            this.add2Button.Name = "add2Button";
            this.add2Button.Size = new System.Drawing.Size(75, 23);
            this.add2Button.TabIndex = 3;
            this.add2Button.Text = "Add 2";
            this.add2Button.UseVisualStyleBackColor = true;
            this.add2Button.Click += new System.EventHandler(this.add2Button_Click);
            // 
            // ListHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add2Button);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "ListHome";
            this.Text = "List Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button add2Button;
    }
}

