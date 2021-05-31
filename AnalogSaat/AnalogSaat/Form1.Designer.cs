
namespace AnalogSaat
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
            this.pictureBoxSAAT = new System.Windows.Forms.PictureBox();
            this.pictureBoxAKREP = new System.Windows.Forms.PictureBox();
            this.buttonCevir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSAAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAKREP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSAAT
            // 
            this.pictureBoxSAAT.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSAAT.Image = global::AnalogSaat.Properties.Resources.kadran;
            this.pictureBoxSAAT.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSAAT.Name = "pictureBoxSAAT";
            this.pictureBoxSAAT.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxSAAT.TabIndex = 0;
            this.pictureBoxSAAT.TabStop = false;
            // 
            // pictureBoxAKREP
            // 
            this.pictureBoxAKREP.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAKREP.Image = global::AnalogSaat.Properties.Resources.akrep;
            this.pictureBoxAKREP.Location = new System.Drawing.Point(0, 12);
            this.pictureBoxAKREP.Name = "pictureBoxAKREP";
            this.pictureBoxAKREP.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxAKREP.TabIndex = 1;
            this.pictureBoxAKREP.TabStop = false;
            // 
            // buttonCevir
            // 
            this.buttonCevir.Location = new System.Drawing.Point(256, 12);
            this.buttonCevir.Name = "buttonCevir";
            this.buttonCevir.Size = new System.Drawing.Size(75, 23);
            this.buttonCevir.TabIndex = 2;
            this.buttonCevir.Text = "ÇEVİR";
            this.buttonCevir.UseVisualStyleBackColor = true;
            this.buttonCevir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 270);
            this.Controls.Add(this.buttonCevir);
            this.Controls.Add(this.pictureBoxAKREP);
            this.Controls.Add(this.pictureBoxSAAT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSAAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAKREP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSAAT;
        private System.Windows.Forms.PictureBox pictureBoxAKREP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCEVIR;
        private System.Windows.Forms.Button buttonCevir;
    }
}

