namespace Aparkalekua
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Button ordainduButton;
        private System.Windows.Forms.Button ibilgailuaSartuButton;

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
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.ordainduButton = new System.Windows.Forms.Button();
            this.ibilgailuaSartuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.Location = new System.Drawing.Point(12, 12);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(260, 186);
            this.vehiclesListBox.TabIndex = 0;
            // 
            // ordainduButton
            // 
            this.ordainduButton.Location = new System.Drawing.Point(12, 204);
            this.ordainduButton.Name = "ordainduButton";
            this.ordainduButton.Size = new System.Drawing.Size(75, 23);
            this.ordainduButton.TabIndex = 1;
            this.ordainduButton.Text = "Ordaindu";
            this.ordainduButton.UseVisualStyleBackColor = true;
            this.ordainduButton.Click += new System.EventHandler(this.OrdainduButton_Click);
            // 
            // ibilgailuaSartuButton
            // 
            this.ibilgailuaSartuButton.Location = new System.Drawing.Point(197, 204);
            this.ibilgailuaSartuButton.Name = "ibilgailuaSartuButton";
            this.ibilgailuaSartuButton.Size = new System.Drawing.Size(75, 23);
            this.ibilgailuaSartuButton.TabIndex = 2;
            this.ibilgailuaSartuButton.Text = "Ibilgailua sartu";
            this.ibilgailuaSartuButton.UseVisualStyleBackColor = true;
            this.ibilgailuaSartuButton.Click += new System.EventHandler(this.IbilgailuaSartuButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.ibilgailuaSartuButton);
            this.Controls.Add(this.ordainduButton);
            this.Controls.Add(this.vehiclesListBox);
            this.Name = "Form2";
            this.Text = "Aparkaleku - Ibilgailuak";
            this.ResumeLayout(false);
        }
    }
}