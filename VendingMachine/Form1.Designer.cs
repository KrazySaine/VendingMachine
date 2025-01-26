﻿namespace VendingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbFlashDrive = new PictureBox();
            pbGamerFuel = new PictureBox();
            pbPeach = new PictureBox();
            pbRedPony = new PictureBox();
            pbZergling = new PictureBox();
            txtDisplay = new TextBox();
            btnVendOver = new Button();
            btnCard = new Button();
            pbLogo = new PictureBox();
            pbFungiFriends = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFlashDrive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGamerFuel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPeach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRedPony).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbZergling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFungiFriends).BeginInit();
            SuspendLayout();
            // 
            // pbFlashDrive
            // 
            pbFlashDrive.Image = (Image)resources.GetObject("pbFlashDrive.Image");
            pbFlashDrive.Location = new Point(263, 216);
            pbFlashDrive.Name = "pbFlashDrive";
            pbFlashDrive.Size = new Size(100, 63);
            pbFlashDrive.TabIndex = 1;
            pbFlashDrive.TabStop = false;
            pbFlashDrive.Click += pbFlashDrive_Click;
            // 
            // pbGamerFuel
            // 
            pbGamerFuel.Image = (Image)resources.GetObject("pbGamerFuel.Image");
            pbGamerFuel.Location = new Point(397, 179);
            pbGamerFuel.Name = "pbGamerFuel";
            pbGamerFuel.Size = new Size(100, 100);
            pbGamerFuel.TabIndex = 2;
            pbGamerFuel.TabStop = false;
            pbGamerFuel.Click += pbGamerFuel_Click;
            // 
            // pbPeach
            // 
            pbPeach.Image = (Image)resources.GetObject("pbPeach.Image");
            pbPeach.Location = new Point(117, 308);
            pbPeach.Name = "pbPeach";
            pbPeach.Size = new Size(100, 54);
            pbPeach.TabIndex = 3;
            pbPeach.TabStop = false;
            pbPeach.Click += pbPeach_Click;
            // 
            // pbRedPony
            // 
            pbRedPony.Image = (Image)resources.GetObject("pbRedPony.Image");
            pbRedPony.Location = new Point(263, 308);
            pbRedPony.Name = "pbRedPony";
            pbRedPony.Size = new Size(100, 54);
            pbRedPony.TabIndex = 4;
            pbRedPony.TabStop = false;
            pbRedPony.Click += pbRedPony_Click;
            // 
            // pbZergling
            // 
            pbZergling.Image = (Image)resources.GetObject("pbZergling.Image");
            pbZergling.Location = new Point(117, 179);
            pbZergling.Name = "pbZergling";
            pbZergling.Size = new Size(100, 100);
            pbZergling.TabIndex = 5;
            pbZergling.TabStop = false;
            pbZergling.Click += pbZergling_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(593, 114);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(149, 165);
            txtDisplay.TabIndex = 6;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnVendOver
            // 
            btnVendOver.Location = new Point(619, 308);
            btnVendOver.Name = "btnVendOver";
            btnVendOver.Size = new Size(97, 23);
            btnVendOver.TabIndex = 7;
            btnVendOver.Text = "End Purchase";
            btnVendOver.UseVisualStyleBackColor = true;
            btnVendOver.Click += btnVendOver_Click;
            // 
            // btnCard
            // 
            btnCard.Location = new Point(630, 85);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(75, 23);
            btnCard.TabIndex = 8;
            btnCard.Text = "Insert Card";
            btnCard.UseVisualStyleBackColor = true;
            btnCard.Click += btnCard_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(201, 452);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(202, 179);
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // pbFungiFriends
            // 
            pbFungiFriends.Image = (Image)resources.GetObject("pbFungiFriends.Image");
            pbFungiFriends.Location = new Point(550, 337);
            pbFungiFriends.Name = "pbFungiFriends";
            pbFungiFriends.Size = new Size(230, 294);
            pbFungiFriends.TabIndex = 10;
            pbFungiFriends.TabStop = false;
            pbFungiFriends.Click += pbFungiFriends_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 688);
            Controls.Add(pbFungiFriends);
            Controls.Add(pbLogo);
            Controls.Add(btnCard);
            Controls.Add(btnVendOver);
            Controls.Add(txtDisplay);
            Controls.Add(pbZergling);
            Controls.Add(pbRedPony);
            Controls.Add(pbPeach);
            Controls.Add(pbGamerFuel);
            Controls.Add(pbFlashDrive);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbFlashDrive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGamerFuel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPeach).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRedPony).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbZergling).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFungiFriends).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFlashDrive;
        private PictureBox pbGamerFuel;
        private PictureBox pbPeach;
        private PictureBox pbRedPony;
        private PictureBox pbZergling;
        private TextBox txtDisplay;
        private Button btnVendOver;
        private Button btnCard;
        private PictureBox pbLogo;
        private PictureBox pbFungiFriends;
    }
}
