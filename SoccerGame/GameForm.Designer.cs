﻿namespace SoccerGame
{
    partial class GameForm
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
            SuspendLayout();
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource.SoccerGameBackgroud;
            ClientSize = new Size(1052, 682);
            MaximumSize = new Size(1070, 729);
            MinimumSize = new Size(1070, 729);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            ResumeLayout(false);
        }

        #endregion
    }
}