namespace Aparkalekua
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
            this.components = new System.ComponentModel.Container();
            this.matrikulaLabel = new System.Windows.Forms.Label();
            this.matrikulaTextBox = new System.Windows.Forms.TextBox();
            this.motaLabel = new System.Windows.Forms.Label();
            this.motaComboBox = new System.Windows.Forms.ComboBox();
            this.luzeraLabel = new System.Windows.Forms.Label();
            this.luzeraTextBox = new System.Windows.Forms.TextBox();
            this.eserlekuKopLabel = new System.Windows.Forms.Label();
            this.eserlekuKopTextBox = new System.Windows.Forms.TextBox();
            this.gehituButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVehiclesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ibilgailuakListBox = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrikulaLabel
            // 
            this.matrikulaLabel.AutoSize = true;
            this.matrikulaLabel.Location = new System.Drawing.Point(12, 40);
            this.matrikulaLabel.Name = "matrikulaLabel";
            this.matrikulaLabel.Size = new System.Drawing.Size(53, 13);
            this.matrikulaLabel.TabIndex = 0;
            this.matrikulaLabel.Text = "Matrikula:";
            // 
            // matrikulaTextBox
            // 
            this.matrikulaTextBox.Location = new System.Drawing.Point(71, 37);
            this.matrikulaTextBox.Name = "matrikulaTextBox";
            this.matrikulaTextBox.Size = new System.Drawing.Size(121, 20);
            this.matrikulaTextBox.TabIndex = 1;
            // 
            // motaLabel
            // 
            this.motaLabel.AutoSize = true;
            this.motaLabel.Location = new System.Drawing.Point(12, 66);
            this.motaLabel.Name = "motaLabel";
            this.motaLabel.Size = new System.Drawing.Size(33, 13);
            this.motaLabel.TabIndex = 2;
            this.motaLabel.Text = "Mota:";
            // 
            // motaComboBox
            // 
            this.motaComboBox.FormattingEnabled = true;
            this.motaComboBox.Items.AddRange(new object[] {
            "Kotxea",
            "Furgoneta",
            "Autobusa"});
            this.motaComboBox.Location = new System.Drawing.Point(71, 63);
            this.motaComboBox.Name = "motaComboBox";
            this.motaComboBox.Size = new System.Drawing.Size(121, 21);
            this.motaComboBox.TabIndex = 3;
            this.motaComboBox.SelectedIndexChanged += new System.EventHandler(this.MotaComboBox_SelectedIndexChanged);
            // 
            // luzeraLabel
            // 
            this.luzeraLabel.AutoSize = true;
            this.luzeraLabel.Location = new System.Drawing.Point(12, 93);
            this.luzeraLabel.Name = "luzeraLabel";
            this.luzeraLabel.Size = new System.Drawing.Size(42, 13);
            this.luzeraLabel.TabIndex = 4;
            this.luzeraLabel.Text = "Luzera:";
            this.luzeraLabel.Visible = false;
            // 
            // luzeraTextBox
            // 
            this.luzeraTextBox.Location = new System.Drawing.Point(71, 90);
            this.luzeraTextBox.Name = "luzeraTextBox";
            this.luzeraTextBox.Size = new System.Drawing.Size(121, 20);
            this.luzeraTextBox.TabIndex = 5;
            this.luzeraTextBox.Visible = false;
            // 
            // eserlekuKopLabel
            // 
            this.eserlekuKopLabel.AutoSize = true;
            this.eserlekuKopLabel.Location = new System.Drawing.Point(12, 119);
            this.eserlekuKopLabel.Name = "eserlekuKopLabel";
            this.eserlekuKopLabel.Size = new System.Drawing.Size(53, 13);
            this.eserlekuKopLabel.TabIndex = 6;
            this.eserlekuKopLabel.Text = "Eserleku:";
            this.eserlekuKopLabel.Visible = false;
            // 
            // eserlekuKopTextBox
            // 
            this.eserlekuKopTextBox.Location = new System.Drawing.Point(71, 116);
            this.eserlekuKopTextBox.Name = "eserlekuKopTextBox";
            this.eserlekuKopTextBox.Size = new System.Drawing.Size(121, 20);
            this.eserlekuKopTextBox.TabIndex = 7;
            this.eserlekuKopTextBox.Visible = false;
            // 
            // gehituButton
            // 
            this.gehituButton.Location = new System.Drawing.Point(71, 142);
            this.gehituButton.Name = "gehituButton";
            this.gehituButton.Size = new System.Drawing.Size(121, 23);
            this.gehituButton.TabIndex = 8;
            this.gehituButton.Text = "Gehitu Ibilgailua";
            this.gehituButton.UseVisualStyleBackColor = true;
            this.gehituButton.Click += new System.EventHandler(this.GehituButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewVehiclesMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(52, 20);
            this.viewMenuItem.Text = "Ikusi";
            // 
            // viewVehiclesMenuItem
            // 
            this.viewVehiclesMenuItem.Name = "viewVehiclesMenuItem";
            this.viewVehiclesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewVehiclesMenuItem.Text = "Ibilgailuak";
            this.viewVehiclesMenuItem.Click += new System.EventHandler(this.ViewVehiclesMenuItem_Click);
            // 
            // ibilgailuakListBox
            // 
            this.ibilgailuakListBox.FormattingEnabled = true;
            this.ibilgailuakListBox.Location = new System.Drawing.Point(15, 181);
            this.ibilgailuakListBox.Name = "ibilgailuakListBox";
            this.ibilgailuakListBox.Size = new System.Drawing.Size(257, 95);
            this.ibilgailuakListBox.TabIndex = 10;
            this.ibilgailuakListBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.ibilgailuakListBox);
            this.Controls.Add(this.gehituButton);
            this.Controls.Add(this.eserlekuKopTextBox);
            this.Controls.Add(this.eserlekuKopLabel);
            this.Controls.Add(this.luzeraTextBox);
            this.Controls.Add(this.luzeraLabel);
            this.Controls.Add(this.motaComboBox);
            this.Controls.Add(this.motaLabel);
            this.Controls.Add(this.matrikulaTextBox);
            this.Controls.Add(this.matrikulaLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Aparkalekua";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label matrikulaLabel;
        private System.Windows.Forms.TextBox matrikulaTextBox;
        private System.Windows.Forms.Label motaLabel;
        private System.Windows.Forms.ComboBox motaComboBox;
        private System.Windows.Forms.Label luzeraLabel;
        private System.Windows.Forms.TextBox luzeraTextBox;
        private System.Windows.Forms.Label eserlekuKopLabel;
        private System.Windows.Forms.TextBox eserlekuKopTextBox;
        private System.Windows.Forms.Button gehituButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVehiclesMenuItem;
        private System.Windows.Forms.ListBox ibilgailuakListBox;
    }
}