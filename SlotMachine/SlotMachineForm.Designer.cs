namespace SlotMachine
{
    partial class SlotMachineForm
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
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(336, 436);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
    }
}