namespace Aparkalekua
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label matrikulaLabel;
        private System.Windows.Forms.Label sarreraOrduaLabel;
        private System.Windows.Forms.Label ordainduOrduaLabel;
        private System.Windows.Forms.Label luzeraLabel;
        private System.Windows.Forms.Label eserlekuKopLabel;
        private System.Windows.Forms.Label precioLabel; // Nueva etiqueta para el precio
        private System.Windows.Forms.Button ordainduButton;
        private System.Windows.Forms.Button itzuliButton;

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
            this.matrikulaLabel = new System.Windows.Forms.Label();
            this.sarreraOrduaLabel = new System.Windows.Forms.Label();
            this.ordainduOrduaLabel = new System.Windows.Forms.Label();
            this.luzeraLabel = new System.Windows.Forms.Label();
            this.eserlekuKopLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label(); // Inicialización de la nueva etiqueta
            this.ordainduButton = new System.Windows.Forms.Button();
            this.itzuliButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matrikulaLabel
            // 
            this.matrikulaLabel.AutoSize = true;
            this.matrikulaLabel.Location = new System.Drawing.Point(12, 9);
            this.matrikulaLabel.Name = "matrikulaLabel";
            this.matrikulaLabel.Size = new System.Drawing.Size(52, 13);
            this.matrikulaLabel.TabIndex = 0;
            this.matrikulaLabel.Text = "Matrikula:";
            // 
            // sarreraOrduaLabel
            // 
            this.sarreraOrduaLabel.AutoSize = true;
            this.sarreraOrduaLabel.Location = new System.Drawing.Point(12, 32);
            this.sarreraOrduaLabel.Name = "sarreraOrduaLabel";
            this.sarreraOrduaLabel.Size = new System.Drawing.Size(79, 13);
            this.sarreraOrduaLabel.TabIndex = 1;
            this.sarreraOrduaLabel.Text = "Sarrera Ordua:";
            // 
            // ordainduOrduaLabel
            // 
            this.ordainduOrduaLabel.AutoSize = true;
            this.ordainduOrduaLabel.Location = new System.Drawing.Point(12, 55);
            this.ordainduOrduaLabel.Name = "ordainduOrduaLabel";
            this.ordainduOrduaLabel.Size = new System.Drawing.Size(82, 13);
            this.ordainduOrduaLabel.TabIndex = 2;
            this.ordainduOrduaLabel.Text = "Ordaindu Ordua:";
            // 
            // luzeraLabel
            // 
            this.luzeraLabel.AutoSize = true;
            this.luzeraLabel.Location = new System.Drawing.Point(12, 78);
            this.luzeraLabel.Name = "luzeraLabel";
            this.luzeraLabel.Size = new System.Drawing.Size(44, 13);
            this.luzeraLabel.TabIndex = 3;
            this.luzeraLabel.Text = "Luzera:";
            this.luzeraLabel.Visible = false;
            // 
            // eserlekuKopLabel
            // 
            this.eserlekuKopLabel.AutoSize = true;
            this.eserlekuKopLabel.Location = new System.Drawing.Point(12, 101);
            this.eserlekuKopLabel.Name = "eserlekuKopLabel";
            this.eserlekuKopLabel.Size = new System.Drawing.Size(67, 13);
            this.eserlekuKopLabel.TabIndex = 4;
            this.eserlekuKopLabel.Text = "Eserleku Kop:";
            this.eserlekuKopLabel.Visible = false;
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Location = new System.Drawing.Point(12, 124);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(37, 13);
            this.precioLabel.TabIndex = 5;
            this.precioLabel.Text = "Precio:";
            this.precioLabel.Visible = false;
            // 
            // ordainduButton
            // 
            this.ordainduButton.Location = new System.Drawing.Point(15, 150);
            this.ordainduButton.Name = "ordainduButton";
            this.ordainduButton.Size = new System.Drawing.Size(75, 23);
            this.ordainduButton.TabIndex = 6;
            this.ordainduButton.Text = "Ordaindu";
            this.ordainduButton.UseVisualStyleBackColor = true;
            this.ordainduButton.Click += new System.EventHandler(this.OrdainduButton_Click);
            // 
            // itzuliButton
            // 
            this.itzuliButton.Location = new System.Drawing.Point(96, 150);
            this.itzuliButton.Name = "itzuliButton";
            this.itzuliButton.Size = new System.Drawing.Size(75, 23);
            this.itzuliButton.TabIndex = 7;
            this.itzuliButton.Text = "Itzuli";
            this.itzuliButton.UseVisualStyleBackColor = true;
            this.itzuliButton.Click += new System.EventHandler(this.ItzuliButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.itzuliButton);
            this.Controls.Add(this.ordainduButton);
            this.Controls.Add(this.precioLabel); // Añadiendo la nueva etiqueta al formulario
            this.Controls.Add(this.eserlekuKopLabel);
            this.Controls.Add(this.luzeraLabel);
            this.Controls.Add(this.ordainduOrduaLabel);
            this.Controls.Add(this.sarreraOrduaLabel);
            this.Controls.Add(this.matrikulaLabel);
            this.Name = "Form3";
            this.Text = "Aparkaleku - Ordaindu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}