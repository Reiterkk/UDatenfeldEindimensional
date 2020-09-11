namespace UDatenfeldEindimensional
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
            this.CmdMinima = new System.Windows.Forms.Button();
            this.LstZahlen = new System.Windows.Forms.ListBox();
            this.LblMinima = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdMinima
            // 
            this.CmdMinima.Location = new System.Drawing.Point(183, 89);
            this.CmdMinima.Name = "CmdMinima";
            this.CmdMinima.Size = new System.Drawing.Size(75, 23);
            this.CmdMinima.TabIndex = 0;
            this.CmdMinima.Text = "Minima";
            this.CmdMinima.UseVisualStyleBackColor = true;
            // 
            // LstZahlen
            // 
            this.LstZahlen.Enabled = false;
            this.LstZahlen.FormattingEnabled = true;
            this.LstZahlen.ItemHeight = 15;
            this.LstZahlen.Location = new System.Drawing.Point(25, 89);
            this.LstZahlen.Name = "LstZahlen";
            this.LstZahlen.Size = new System.Drawing.Size(120, 229);
            this.LstZahlen.TabIndex = 1;
            // 
            // LblMinima
            // 
            this.LblMinima.AutoSize = true;
            this.LblMinima.Location = new System.Drawing.Point(183, 124);
            this.LblMinima.Name = "LblMinima";
            this.LblMinima.Size = new System.Drawing.Size(63, 15);
            this.LblMinima.TabIndex = 2;
            this.LblMinima.Text = "Minimum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMinima);
            this.Controls.Add(this.LstZahlen);
            this.Controls.Add(this.CmdMinima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMinima;
        private System.Windows.Forms.ListBox LstZahlen;
        private System.Windows.Forms.Label LblMinima;
    }
}

