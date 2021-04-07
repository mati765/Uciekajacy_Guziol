
namespace UciekającyGuziol
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
            this.components = new System.ComponentModel.Container();
            this.Guziolek = new System.Windows.Forms.Button();
            this.CzasZmiany = new System.Windows.Forms.Timer(this.components);
            this.statusPunkcioszków = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPunkcioszków.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guziolek
            // 
            this.Guziolek.Location = new System.Drawing.Point(186, 130);
            this.Guziolek.Name = "Guziolek";
            this.Guziolek.Size = new System.Drawing.Size(88, 23);
            this.Guziolek.TabIndex = 0;
            this.Guziolek.Text = "Złap Guziola!";
            this.Guziolek.UseVisualStyleBackColor = true;
            this.Guziolek.Click += new System.EventHandler(this.Guziolek_Click);
            // 
            // CzasZmiany
            // 
            this.CzasZmiany.Interval = 2000;
            this.CzasZmiany.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusPunkcioszków
            // 
            this.statusPunkcioszków.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusPunkcioszków.Location = new System.Drawing.Point(0, 428);
            this.statusPunkcioszków.Name = "statusPunkcioszków";
            this.statusPunkcioszków.Size = new System.Drawing.Size(800, 22);
            this.statusPunkcioszków.TabIndex = 2;
            this.statusPunkcioszków.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "Punkcioszki : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusPunkcioszków);
            this.Controls.Add(this.Guziolek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusPunkcioszków.ResumeLayout(false);
            this.statusPunkcioszków.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guziolek;
        private System.Windows.Forms.Timer CzasZmiany;
        private System.Windows.Forms.StatusStrip statusPunkcioszków;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

