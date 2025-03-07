namespace SoccerGame
{
    partial class ControlsForm
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
            btn_Update = new Button();
            TeamOneStrategyComboBox = new ComboBox();
            TeamOneLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TeamTwoStrategyComboBox = new ComboBox();
            TeamOneName = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            TeamTwoName = new ComboBox();
            TeamOneClothesCoboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            TeamTwoClothesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(167, 377);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(177, 32);
            btn_Update.TabIndex = 0;
            btn_Update.Text = "Update Context";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // TeamOneStrategyComboBox
            // 
            TeamOneStrategyComboBox.FormattingEnabled = true;
            TeamOneStrategyComboBox.Location = new Point(21, 187);
            TeamOneStrategyComboBox.Name = "TeamOneStrategyComboBox";
            TeamOneStrategyComboBox.Size = new Size(151, 28);
            TeamOneStrategyComboBox.TabIndex = 1;
            // 
            // TeamOneLabel
            // 
            TeamOneLabel.AutoSize = true;
            TeamOneLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneLabel.Location = new Point(21, 9);
            TeamOneLabel.Name = "TeamOneLabel";
            TeamOneLabel.Size = new Size(152, 41);
            TeamOneLabel.TabIndex = 2;
            TeamOneLabel.Text = "Team One";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(21, 156);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 3;
            label1.Text = "Strategy";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(374, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 41);
            label2.TabIndex = 4;
            label2.Text = "Team Two";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(373, 156);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 6;
            label3.Text = "Strategy";
            // 
            // TeamTwoStrategyComboBox
            // 
            TeamTwoStrategyComboBox.FormattingEnabled = true;
            TeamTwoStrategyComboBox.Location = new Point(373, 187);
            TeamTwoStrategyComboBox.Name = "TeamTwoStrategyComboBox";
            TeamTwoStrategyComboBox.Size = new Size(151, 28);
            TeamTwoStrategyComboBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            TeamOneName.FormattingEnabled = true;
            TeamOneName.Location = new Point(21, 116);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(151, 28);
            TeamOneName.TabIndex = 7;
            TeamOneName.SelectedIndexChanged += TeamOneName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 85);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 8;
            label4.Text = "Team Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(375, 85);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 10;
            label5.Text = "Team Name";
            // 
            // TeamTwoName
            // 
            TeamTwoName.FormattingEnabled = true;
            TeamTwoName.Location = new Point(375, 116);
            TeamTwoName.Name = "TeamTwoName";
            TeamTwoName.Size = new Size(151, 28);
            TeamTwoName.TabIndex = 9;
            TeamTwoName.SelectedIndexChanged += TeamTwoName_SelectedIndexChanged;
            // 
            // TeamOneClothesCoboBox
            // 
            TeamOneClothesCoboBox.FormattingEnabled = true;
            TeamOneClothesCoboBox.Location = new Point(21, 260);
            TeamOneClothesCoboBox.Name = "TeamOneClothesCoboBox";
            TeamOneClothesCoboBox.Size = new Size(151, 28);
            TeamOneClothesCoboBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(373, 229);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 12;
            label6.Text = "Clothes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(21, 229);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 13;
            label7.Text = "Clothes";
            // 
            // TeamTwoClothesComboBox
            // 
            TeamTwoClothesComboBox.FormattingEnabled = true;
            TeamTwoClothesComboBox.Location = new Point(373, 260);
            TeamTwoClothesComboBox.Name = "TeamTwoClothesComboBox";
            TeamTwoClothesComboBox.Size = new Size(151, 28);
            TeamTwoClothesComboBox.TabIndex = 14;
            // 
            // ControlsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 419);
            Controls.Add(TeamTwoClothesComboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TeamOneClothesCoboBox);
            Controls.Add(label5);
            Controls.Add(TeamTwoName);
            Controls.Add(label4);
            Controls.Add(TeamOneName);
            Controls.Add(label3);
            Controls.Add(TeamTwoStrategyComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TeamOneLabel);
            Controls.Add(TeamOneStrategyComboBox);
            Controls.Add(btn_Update);
            Name = "ControlsForm";
            Text = "ControlsForm";
            Load += ControlsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Update;
        private ComboBox TeamOneStrategyComboBox;
        private Label TeamOneLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox TeamTwoStrategyComboBox;
        private ComboBox TeamOneName;
        private Label label4;
        private Label label5;
        private ComboBox TeamTwoName;
        private ComboBox TeamOneClothesCoboBox;
        private Label label6;
        private Label label7;
        private ComboBox TeamTwoClothesComboBox;
    }
}