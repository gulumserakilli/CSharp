namespace Kronometre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelKronometre = new System.Windows.Forms.Label();
            this.buttonBASLA = new System.Windows.Forms.Button();
            this.buttonBEKLE = new System.Windows.Forms.Button();
            this.buttonTEKRAR = new System.Windows.Forms.Button();
            this.timerKronometre = new System.Windows.Forms.Timer(this.components);
            this.buttonKAYDET = new System.Windows.Forms.Button();
            this.Kayıtlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelKronometre
            // 
            this.labelKronometre.AutoSize = true;
            this.labelKronometre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKronometre.Location = new System.Drawing.Point(69, 9);
            this.labelKronometre.Name = "labelKronometre";
            this.labelKronometre.Size = new System.Drawing.Size(184, 29);
            this.labelKronometre.TabIndex = 0;
            this.labelKronometre.Text = "00:00:00:00:000";
            // 
            // buttonBASLA
            // 
            this.buttonBASLA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonBASLA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBASLA.Location = new System.Drawing.Point(8, 51);
            this.buttonBASLA.Name = "buttonBASLA";
            this.buttonBASLA.Size = new System.Drawing.Size(66, 28);
            this.buttonBASLA.TabIndex = 1;
            this.buttonBASLA.Text = "BAŞLA";
            this.buttonBASLA.UseVisualStyleBackColor = false;
            this.buttonBASLA.Click += new System.EventHandler(this.buttonBASLA_Click);
            // 
            // buttonBEKLE
            // 
            this.buttonBEKLE.BackColor = System.Drawing.Color.Khaki;
            this.buttonBEKLE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBEKLE.Location = new System.Drawing.Point(80, 51);
            this.buttonBEKLE.Name = "buttonBEKLE";
            this.buttonBEKLE.Size = new System.Drawing.Size(69, 28);
            this.buttonBEKLE.TabIndex = 2;
            this.buttonBEKLE.Text = "BEKLE";
            this.buttonBEKLE.UseVisualStyleBackColor = false;
            this.buttonBEKLE.Click += new System.EventHandler(this.buttonBEKLE_Click);
            // 
            // buttonTEKRAR
            // 
            this.buttonTEKRAR.BackColor = System.Drawing.Color.Plum;
            this.buttonTEKRAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTEKRAR.Location = new System.Drawing.Point(155, 51);
            this.buttonTEKRAR.Name = "buttonTEKRAR";
            this.buttonTEKRAR.Size = new System.Drawing.Size(75, 28);
            this.buttonTEKRAR.TabIndex = 3;
            this.buttonTEKRAR.Text = "TEKRAR";
            this.buttonTEKRAR.UseVisualStyleBackColor = false;
            this.buttonTEKRAR.Click += new System.EventHandler(this.buttonTEKRAR_Click);
            // 
            // timerKronometre
            // 
            this.timerKronometre.Enabled = true;
            this.timerKronometre.Interval = 1;
            this.timerKronometre.Tick += new System.EventHandler(this.timerKronometre_Tick);
            // 
            // buttonKAYDET
            // 
            this.buttonKAYDET.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonKAYDET.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKAYDET.Location = new System.Drawing.Point(236, 51);
            this.buttonKAYDET.Name = "buttonKAYDET";
            this.buttonKAYDET.Size = new System.Drawing.Size(91, 28);
            this.buttonKAYDET.TabIndex = 4;
            this.buttonKAYDET.Text = "KAYDET";
            this.buttonKAYDET.UseVisualStyleBackColor = false;
            this.buttonKAYDET.Click += new System.EventHandler(this.buttonKAYDET_Click);
            // 
            // Kayıtlar
            // 
            this.Kayıtlar.BackColor = System.Drawing.Color.LightCoral;
            this.Kayıtlar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kayıtlar.FormattingEnabled = true;
            this.Kayıtlar.ItemHeight = 24;
            this.Kayıtlar.Location = new System.Drawing.Point(12, 85);
            this.Kayıtlar.Name = "Kayıtlar";
            this.Kayıtlar.Size = new System.Drawing.Size(315, 148);
            this.Kayıtlar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(339, 261);
            this.Controls.Add(this.Kayıtlar);
            this.Controls.Add(this.buttonKAYDET);
            this.Controls.Add(this.buttonTEKRAR);
            this.Controls.Add(this.buttonBEKLE);
            this.Controls.Add(this.buttonBASLA);
            this.Controls.Add(this.labelKronometre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kronometre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKronometre;
        private System.Windows.Forms.Button buttonBASLA;
        private System.Windows.Forms.Button buttonBEKLE;
        private System.Windows.Forms.Button buttonTEKRAR;
        private System.Windows.Forms.Timer timerKronometre;
        private System.Windows.Forms.Button buttonKAYDET;
        private System.Windows.Forms.ListBox Kayıtlar;
    }
}