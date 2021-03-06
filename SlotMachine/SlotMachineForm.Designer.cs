﻿namespace SlotMachine
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
            this.Bet1PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet2PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet5PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet10PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet500PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet100PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet50PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet25PictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.JackpotTextBox = new System.Windows.Forms.TextBox();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.WinnerPaidTextBox = new System.Windows.Forms.TextBox();
            this.TotalCreditsTextBox = new System.Windows.Forms.TextBox();
            this.PowerButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelFirstPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelSecondPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelThirdPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerStatsButton = new System.Windows.Forms.Button();
            this.ResetBetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet10PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet500PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet100PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet50PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet25PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelFirstPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelSecondPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThirdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(331, 436);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(65, 57);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Tag = "Spin";
            this.SpinPictureBox.Click += new System.EventHandler(this._pictureBoxButtonHandler);
            // 
            // Bet1PictureBox
            // 
            this.Bet1PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet1PictureBox.Image = global::SlotMachine.Properties.Resources.bet1;
            this.Bet1PictureBox.Location = new System.Drawing.Point(71, 431);
            this.Bet1PictureBox.Name = "Bet1PictureBox";
            this.Bet1PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet1PictureBox.TabIndex = 7;
            this.Bet1PictureBox.TabStop = false;
            this.Bet1PictureBox.Tag = "1";
            this.Bet1PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // Bet2PictureBox
            // 
            this.Bet2PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet2PictureBox.Image = global::SlotMachine.Properties.Resources.bet2;
            this.Bet2PictureBox.Location = new System.Drawing.Point(114, 431);
            this.Bet2PictureBox.Name = "Bet2PictureBox";
            this.Bet2PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet2PictureBox.TabIndex = 8;
            this.Bet2PictureBox.TabStop = false;
            this.Bet2PictureBox.Tag = "2";
            this.Bet2PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // Bet5PictureBox
            // 
            this.Bet5PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet5PictureBox.Image = global::SlotMachine.Properties.Resources.bet5;
            this.Bet5PictureBox.Location = new System.Drawing.Point(157, 431);
            this.Bet5PictureBox.Name = "Bet5PictureBox";
            this.Bet5PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet5PictureBox.TabIndex = 9;
            this.Bet5PictureBox.TabStop = false;
            this.Bet5PictureBox.Tag = "5";
            this.Bet5PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // Bet10PictureBox
            // 
            this.Bet10PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet10PictureBox.Image = global::SlotMachine.Properties.Resources.bet10;
            this.Bet10PictureBox.Location = new System.Drawing.Point(200, 431);
            this.Bet10PictureBox.Name = "Bet10PictureBox";
            this.Bet10PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet10PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet10PictureBox.TabIndex = 10;
            this.Bet10PictureBox.TabStop = false;
            this.Bet10PictureBox.Tag = "10";
            this.Bet10PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // Bet500PictureBox
            // 
            this.Bet500PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet500PictureBox.Image = global::SlotMachine.Properties.Resources.bet500;
            this.Bet500PictureBox.Location = new System.Drawing.Point(200, 466);
            this.Bet500PictureBox.Name = "Bet500PictureBox";
            this.Bet500PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet500PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet500PictureBox.TabIndex = 14;
            this.Bet500PictureBox.TabStop = false;
            this.Bet500PictureBox.Tag = "500";
            this.Bet500PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // Bet100PictureBox
            // 
            this.Bet100PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet100PictureBox.Image = global::SlotMachine.Properties.Resources.bet100;
            this.Bet100PictureBox.Location = new System.Drawing.Point(157, 466);
            this.Bet100PictureBox.Name = "Bet100PictureBox";
            this.Bet100PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet100PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet100PictureBox.TabIndex = 13;
            this.Bet100PictureBox.TabStop = false;
            this.Bet100PictureBox.Tag = "100";
            this.Bet100PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // Bet50PictureBox
            // 
            this.Bet50PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet50PictureBox.Image = global::SlotMachine.Properties.Resources.bet50;
            this.Bet50PictureBox.Location = new System.Drawing.Point(114, 466);
            this.Bet50PictureBox.Name = "Bet50PictureBox";
            this.Bet50PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet50PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet50PictureBox.TabIndex = 12;
            this.Bet50PictureBox.TabStop = false;
            this.Bet50PictureBox.Tag = "50";
            this.Bet50PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // Bet25PictureBox
            // 
            this.Bet25PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bet25PictureBox.Image = global::SlotMachine.Properties.Resources.bet25;
            this.Bet25PictureBox.Location = new System.Drawing.Point(71, 466);
            this.Bet25PictureBox.Name = "Bet25PictureBox";
            this.Bet25PictureBox.Size = new System.Drawing.Size(37, 35);
            this.Bet25PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet25PictureBox.TabIndex = 11;
            this.Bet25PictureBox.TabStop = false;
            this.Bet25PictureBox.Tag = "25";
            this.Bet25PictureBox.Click += new System.EventHandler(this._betHandler);
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ResetPictureBox.Image = global::SlotMachine.Properties.Resources.reset;
            this.ResetPictureBox.Location = new System.Drawing.Point(254, 436);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(71, 57);
            this.ResetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetPictureBox.TabIndex = 15;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Tag = "Reset";
            this.ResetPictureBox.Click += new System.EventHandler(this._pictureBoxButtonHandler);
            // 
            // JackpotTextBox
            // 
            this.JackpotTextBox.BackColor = System.Drawing.Color.Black;
            this.JackpotTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JackpotTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackpotTextBox.ForeColor = System.Drawing.Color.Red;
            this.JackpotTextBox.Location = new System.Drawing.Point(184, 164);
            this.JackpotTextBox.Name = "JackpotTextBox";
            this.JackpotTextBox.ReadOnly = true;
            this.JackpotTextBox.Size = new System.Drawing.Size(98, 18);
            this.JackpotTextBox.TabIndex = 16;
            this.JackpotTextBox.TabStop = false;
            this.JackpotTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BetTextBox
            // 
            this.BetTextBox.BackColor = System.Drawing.Color.Black;
            this.BetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BetTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.BetTextBox.ForeColor = System.Drawing.Color.Red;
            this.BetTextBox.Location = new System.Drawing.Point(201, 376);
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.ReadOnly = true;
            this.BetTextBox.Size = new System.Drawing.Size(56, 18);
            this.BetTextBox.TabIndex = 18;
            this.BetTextBox.TabStop = false;
            this.BetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinnerPaidTextBox
            // 
            this.WinnerPaidTextBox.BackColor = System.Drawing.Color.Black;
            this.WinnerPaidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinnerPaidTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.WinnerPaidTextBox.ForeColor = System.Drawing.Color.Red;
            this.WinnerPaidTextBox.Location = new System.Drawing.Point(289, 376);
            this.WinnerPaidTextBox.Name = "WinnerPaidTextBox";
            this.WinnerPaidTextBox.ReadOnly = true;
            this.WinnerPaidTextBox.Size = new System.Drawing.Size(98, 18);
            this.WinnerPaidTextBox.TabIndex = 19;
            this.WinnerPaidTextBox.TabStop = false;
            this.WinnerPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalCreditsTextBox
            // 
            this.TotalCreditsTextBox.BackColor = System.Drawing.Color.Black;
            this.TotalCreditsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalCreditsTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.TotalCreditsTextBox.ForeColor = System.Drawing.Color.Red;
            this.TotalCreditsTextBox.Location = new System.Drawing.Point(73, 376);
            this.TotalCreditsTextBox.Name = "TotalCreditsTextBox";
            this.TotalCreditsTextBox.ReadOnly = true;
            this.TotalCreditsTextBox.Size = new System.Drawing.Size(98, 18);
            this.TotalCreditsTextBox.TabIndex = 17;
            this.TotalCreditsTextBox.TabStop = false;
            this.TotalCreditsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PowerButtonPictureBox
            // 
            this.PowerButtonPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PowerButtonPictureBox.Image = global::SlotMachine.Properties.Resources.powerbutton;
            this.PowerButtonPictureBox.Location = new System.Drawing.Point(46, 99);
            this.PowerButtonPictureBox.Name = "PowerButtonPictureBox";
            this.PowerButtonPictureBox.Size = new System.Drawing.Size(56, 56);
            this.PowerButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PowerButtonPictureBox.TabIndex = 20;
            this.PowerButtonPictureBox.TabStop = false;
            this.PowerButtonPictureBox.Tag = "Power";
            this.PowerButtonPictureBox.Click += new System.EventHandler(this._pictureBoxButtonHandler);
            // 
            // ReelFirstPictureBox
            // 
            this.ReelFirstPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ReelFirstPictureBox.Location = new System.Drawing.Point(77, 254);
            this.ReelFirstPictureBox.Name = "ReelFirstPictureBox";
            this.ReelFirstPictureBox.Size = new System.Drawing.Size(81, 83);
            this.ReelFirstPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReelFirstPictureBox.TabIndex = 21;
            this.ReelFirstPictureBox.TabStop = false;
            // 
            // ReelSecondPictureBox
            // 
            this.ReelSecondPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ReelSecondPictureBox.Location = new System.Drawing.Point(189, 254);
            this.ReelSecondPictureBox.Name = "ReelSecondPictureBox";
            this.ReelSecondPictureBox.Size = new System.Drawing.Size(81, 83);
            this.ReelSecondPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReelSecondPictureBox.TabIndex = 22;
            this.ReelSecondPictureBox.TabStop = false;
            // 
            // ReelThirdPictureBox
            // 
            this.ReelThirdPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ReelThirdPictureBox.Location = new System.Drawing.Point(302, 254);
            this.ReelThirdPictureBox.Name = "ReelThirdPictureBox";
            this.ReelThirdPictureBox.Size = new System.Drawing.Size(81, 83);
            this.ReelThirdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReelThirdPictureBox.TabIndex = 23;
            this.ReelThirdPictureBox.TabStop = false;
            // 
            // PlayerStatsButton
            // 
            this.PlayerStatsButton.BackColor = System.Drawing.Color.Yellow;
            this.PlayerStatsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsButton.ForeColor = System.Drawing.Color.Black;
            this.PlayerStatsButton.Location = new System.Drawing.Point(315, 102);
            this.PlayerStatsButton.Name = "PlayerStatsButton";
            this.PlayerStatsButton.Size = new System.Drawing.Size(91, 23);
            this.PlayerStatsButton.TabIndex = 24;
            this.PlayerStatsButton.Tag = "Player Stats";
            this.PlayerStatsButton.Text = "Player Stats";
            this.PlayerStatsButton.UseVisualStyleBackColor = false;
            this.PlayerStatsButton.Click += new System.EventHandler(this._buttonHandler);
            // 
            // ResetBetButton
            // 
            this.ResetBetButton.BackColor = System.Drawing.Color.Yellow;
            this.ResetBetButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetBetButton.Location = new System.Drawing.Point(315, 154);
            this.ResetBetButton.Name = "ResetBetButton";
            this.ResetBetButton.Size = new System.Drawing.Size(91, 23);
            this.ResetBetButton.TabIndex = 25;
            this.ResetBetButton.Tag = "Reset Bet";
            this.ResetBetButton.Text = "Reset Bet";
            this.ResetBetButton.UseVisualStyleBackColor = false;
            this.ResetBetButton.Click += new System.EventHandler(this._buttonHandler);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.ControlBox = false;
            this.Controls.Add(this.ResetBetButton);
            this.Controls.Add(this.PlayerStatsButton);
            this.Controls.Add(this.ReelThirdPictureBox);
            this.Controls.Add(this.ReelSecondPictureBox);
            this.Controls.Add(this.ReelFirstPictureBox);
            this.Controls.Add(this.PowerButtonPictureBox);
            this.Controls.Add(this.TotalCreditsTextBox);
            this.Controls.Add(this.WinnerPaidTextBox);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.JackpotTextBox);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.Bet500PictureBox);
            this.Controls.Add(this.Bet100PictureBox);
            this.Controls.Add(this.Bet50PictureBox);
            this.Controls.Add(this.Bet25PictureBox);
            this.Controls.Add(this.Bet10PictureBox);
            this.Controls.Add(this.Bet5PictureBox);
            this.Controls.Add(this.Bet2PictureBox);
            this.Controls.Add(this.Bet1PictureBox);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet10PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet500PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet100PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet50PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet25PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelFirstPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelSecondPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThirdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox Bet1PictureBox;
        private System.Windows.Forms.PictureBox Bet2PictureBox;
        private System.Windows.Forms.PictureBox Bet5PictureBox;
        private System.Windows.Forms.PictureBox Bet10PictureBox;
        private System.Windows.Forms.PictureBox Bet500PictureBox;
        private System.Windows.Forms.PictureBox Bet100PictureBox;
        private System.Windows.Forms.PictureBox Bet50PictureBox;
        private System.Windows.Forms.PictureBox Bet25PictureBox;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.TextBox JackpotTextBox;
        private System.Windows.Forms.TextBox BetTextBox;
        private System.Windows.Forms.TextBox WinnerPaidTextBox;
        private System.Windows.Forms.TextBox TotalCreditsTextBox;
        private System.Windows.Forms.PictureBox PowerButtonPictureBox;
        private System.Windows.Forms.PictureBox ReelFirstPictureBox;
        private System.Windows.Forms.PictureBox ReelSecondPictureBox;
        private System.Windows.Forms.PictureBox ReelThirdPictureBox;
        private System.Windows.Forms.Button PlayerStatsButton;
        private System.Windows.Forms.Button ResetBetButton;
    }
}