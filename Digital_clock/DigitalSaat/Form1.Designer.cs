namespace DigitalSaat
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
            this.labelZaman = new System.Windows.Forms.Label();
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.labelYıl = new System.Windows.Forms.Label();
            this.labelAy = new System.Windows.Forms.Label();
            this.labelGün = new System.Windows.Forms.Label();
            this.labelHgun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelZaman.Location = new System.Drawing.Point(12, 18);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(92, 32);
            this.labelZaman.TabIndex = 0;
            this.labelZaman.Text = "label1";
            // 
            // timerZaman
            // 
            this.timerZaman.Enabled = true;
            this.timerZaman.Interval = 1000;
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // labelYıl
            // 
            this.labelYıl.AutoSize = true;
            this.labelYıl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYıl.Location = new System.Drawing.Point(272, 77);
            this.labelYıl.Name = "labelYıl";
            this.labelYıl.Size = new System.Drawing.Size(41, 24);
            this.labelYıl.TabIndex = 1;
            this.labelYıl.Text = "YIL";
            // 
            // labelAy
            // 
            this.labelAy.AutoSize = true;
            this.labelAy.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAy.Location = new System.Drawing.Point(57, 77);
            this.labelAy.Name = "labelAy";
            this.labelAy.Size = new System.Drawing.Size(36, 24);
            this.labelAy.TabIndex = 2;
            this.labelAy.Text = "AY";
            // 
            // labelGün
            // 
            this.labelGün.AutoSize = true;
            this.labelGün.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGün.Location = new System.Drawing.Point(12, 77);
            this.labelGün.Name = "labelGün";
            this.labelGün.Size = new System.Drawing.Size(54, 24);
            this.labelGün.TabIndex = 3;
            this.labelGün.Text = "GÜN";
            // 
            // labelHgun
            // 
            this.labelHgun.AutoSize = true;
            this.labelHgun.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHgun.Location = new System.Drawing.Point(132, 77);
            this.labelHgun.Name = "labelHgun";
            this.labelHgun.Size = new System.Drawing.Size(108, 24);
            this.labelHgun.TabIndex = 4;
            this.labelHgun.Text = "hangiGün";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 203);
            this.Controls.Add(this.labelHgun);
            this.Controls.Add(this.labelGün);
            this.Controls.Add(this.labelAy);
            this.Controls.Add(this.labelYıl);
            this.Controls.Add(this.labelZaman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.Label labelYıl;
        private System.Windows.Forms.Label labelAy;
        private System.Windows.Forms.Label labelGün;
        private System.Windows.Forms.Label labelHgun;
    }
}
