namespace Alarm
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
            this.labelZAMAN = new System.Windows.Forms.Label();
            this.numericUpDownSAAT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDAKIKA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSANIYE = new System.Windows.Forms.NumericUpDown();
            this.buttonBASLA = new System.Windows.Forms.Button();
            this.buttonDURDUR = new System.Windows.Forms.Button();
            this.timerZAMAN = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSAAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDAKIKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSANIYE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelZAMAN
            // 
            this.labelZAMAN.AutoSize = true;
            this.labelZAMAN.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelZAMAN.Location = new System.Drawing.Point(82, 38);
            this.labelZAMAN.Name = "labelZAMAN";
            this.labelZAMAN.Size = new System.Drawing.Size(146, 45);
            this.labelZAMAN.TabIndex = 0;
            this.labelZAMAN.Text = "00:00:00";
            // 
            // numericUpDownSAAT
            // 
            this.numericUpDownSAAT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSAAT.Location = new System.Drawing.Point(43, 86);
            this.numericUpDownSAAT.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSAAT.Name = "numericUpDownSAAT";
            this.numericUpDownSAAT.Size = new System.Drawing.Size(63, 39);
            this.numericUpDownSAAT.TabIndex = 1;
            // 
            // numericUpDownDAKIKA
            // 
            this.numericUpDownDAKIKA.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownDAKIKA.Location = new System.Drawing.Point(119, 86);
            this.numericUpDownDAKIKA.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownDAKIKA.Name = "numericUpDownDAKIKA";
            this.numericUpDownDAKIKA.Size = new System.Drawing.Size(63, 39);
            this.numericUpDownDAKIKA.TabIndex = 2;
            // 
            // numericUpDownSANIYE
            // 
            this.numericUpDownSANIYE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSANIYE.Location = new System.Drawing.Point(194, 86);
            this.numericUpDownSANIYE.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSANIYE.Name = "numericUpDownSANIYE";
            this.numericUpDownSANIYE.Size = new System.Drawing.Size(63, 39);
            this.numericUpDownSANIYE.TabIndex = 3;
            // 
            // buttonBASLA
            // 
            this.buttonBASLA.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonBASLA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBASLA.Location = new System.Drawing.Point(43, 140);
            this.buttonBASLA.Name = "buttonBASLA";
            this.buttonBASLA.Size = new System.Drawing.Size(82, 30);
            this.buttonBASLA.TabIndex = 4;
            this.buttonBASLA.Text = "BAŞLAT";
            this.buttonBASLA.UseVisualStyleBackColor = false;
            this.buttonBASLA.Click += new System.EventHandler(this.buttonBASLA_Click);
            // 
            // buttonDURDUR
            // 
            this.buttonDURDUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDURDUR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDURDUR.Location = new System.Drawing.Point(153, 140);
            this.buttonDURDUR.Name = "buttonDURDUR";
            this.buttonDURDUR.Size = new System.Drawing.Size(90, 30);
            this.buttonDURDUR.TabIndex = 5;
            this.buttonDURDUR.Text = "DURDUR";
            this.buttonDURDUR.UseVisualStyleBackColor = false;
            this.buttonDURDUR.Click += new System.EventHandler(this.buttonDURDUR_Click);
            // 
            // timerZAMAN
            // 
            this.timerZAMAN.Interval = 1000;
            this.timerZAMAN.Tick += new System.EventHandler(this.timerZAMAN_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(312, 222);
            this.Controls.Add(this.buttonDURDUR);
            this.Controls.Add(this.buttonBASLA);
            this.Controls.Add(this.numericUpDownSANIYE);
            this.Controls.Add(this.numericUpDownDAKIKA);
            this.Controls.Add(this.numericUpDownSAAT);
            this.Controls.Add(this.labelZAMAN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSAAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDAKIKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSANIYE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZAMAN;
        private System.Windows.Forms.NumericUpDown numericUpDownSAAT;
        private System.Windows.Forms.NumericUpDown numericUpDownDAKIKA;
        private System.Windows.Forms.NumericUpDown numericUpDownSANIYE;
        private System.Windows.Forms.Button buttonBASLA;
        private System.Windows.Forms.Button buttonDURDUR;
        private System.Windows.Forms.Timer timerZAMAN;
    }
}