﻿namespace Flags
{
    partial class flagViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flagViewerForm));
            this.countryGroupBox = new System.Windows.Forms.GroupBox();
            this.FranceRadioButton = new System.Windows.Forms.RadioButton();
            this.USARadioButton = new System.Windows.Forms.RadioButton();
            this.ColombiaRadioButton = new System.Windows.Forms.RadioButton();
            this.PhilippinesRadioButton = new System.Windows.Forms.RadioButton();
            this.FlagViewerLabel = new System.Windows.Forms.Label();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.ProgrammerCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryNameCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleCheckBox = new System.Windows.Forms.CheckBox();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.PhilippinesPictureBox = new System.Windows.Forms.PictureBox();
            this.ColombiaPictureBox = new System.Windows.Forms.PictureBox();
            this.FrancePictureBox = new System.Windows.Forms.PictureBox();
            this.USAPictureBox = new System.Windows.Forms.PictureBox();
            this.countryGroupBox.SuspendLayout();
            this.DisplayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhilippinesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColombiaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USAPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countryGroupBox
            // 
            this.countryGroupBox.Controls.Add(this.FranceRadioButton);
            this.countryGroupBox.Controls.Add(this.USARadioButton);
            this.countryGroupBox.Controls.Add(this.ColombiaRadioButton);
            this.countryGroupBox.Controls.Add(this.PhilippinesRadioButton);
            this.countryGroupBox.Location = new System.Drawing.Point(12, 81);
            this.countryGroupBox.Name = "countryGroupBox";
            this.countryGroupBox.Size = new System.Drawing.Size(200, 157);
            this.countryGroupBox.TabIndex = 0;
            this.countryGroupBox.TabStop = false;
            this.countryGroupBox.Text = "Country";
            // 
            // FranceRadioButton
            // 
            this.FranceRadioButton.AutoSize = true;
            this.FranceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranceRadioButton.Location = new System.Drawing.Point(17, 112);
            this.FranceRadioButton.Name = "FranceRadioButton";
            this.FranceRadioButton.Size = new System.Drawing.Size(63, 19);
            this.FranceRadioButton.TabIndex = 3;
            this.FranceRadioButton.TabStop = true;
            this.FranceRadioButton.Text = "France";
            this.FranceRadioButton.UseVisualStyleBackColor = true;
            this.FranceRadioButton.CheckedChanged += new System.EventHandler(this.FranceRadioButton_CheckedChanged);
            // 
            // USARadioButton
            // 
            this.USARadioButton.AutoSize = true;
            this.USARadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USARadioButton.Location = new System.Drawing.Point(17, 87);
            this.USARadioButton.Name = "USARadioButton";
            this.USARadioButton.Size = new System.Drawing.Size(49, 19);
            this.USARadioButton.TabIndex = 2;
            this.USARadioButton.TabStop = true;
            this.USARadioButton.Text = "USA";
            this.USARadioButton.UseVisualStyleBackColor = true;
            this.USARadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ColombiaRadioButton
            // 
            this.ColombiaRadioButton.AutoSize = true;
            this.ColombiaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColombiaRadioButton.Location = new System.Drawing.Point(17, 62);
            this.ColombiaRadioButton.Name = "ColombiaRadioButton";
            this.ColombiaRadioButton.Size = new System.Drawing.Size(78, 19);
            this.ColombiaRadioButton.TabIndex = 1;
            this.ColombiaRadioButton.TabStop = true;
            this.ColombiaRadioButton.Text = "Colombia";
            this.ColombiaRadioButton.UseVisualStyleBackColor = true;
            this.ColombiaRadioButton.CheckedChanged += new System.EventHandler(this.ColombiaRadioButton_CheckedChanged);
            // 
            // PhilippinesRadioButton
            // 
            this.PhilippinesRadioButton.AutoSize = true;
            this.PhilippinesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhilippinesRadioButton.Location = new System.Drawing.Point(17, 37);
            this.PhilippinesRadioButton.Name = "PhilippinesRadioButton";
            this.PhilippinesRadioButton.Size = new System.Drawing.Size(86, 19);
            this.PhilippinesRadioButton.TabIndex = 0;
            this.PhilippinesRadioButton.TabStop = true;
            this.PhilippinesRadioButton.Text = "Philippines";
            this.PhilippinesRadioButton.UseVisualStyleBackColor = true;
            this.PhilippinesRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FlagViewerLabel
            // 
            this.FlagViewerLabel.AutoSize = true;
            this.FlagViewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagViewerLabel.Location = new System.Drawing.Point(229, 27);
            this.FlagViewerLabel.Name = "FlagViewerLabel";
            this.FlagViewerLabel.Size = new System.Drawing.Size(153, 29);
            this.FlagViewerLabel.TabIndex = 1;
            this.FlagViewerLabel.Text = "Flag Viewer";
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.Controls.Add(this.ProgrammerCheckBox);
            this.DisplayGroupBox.Controls.Add(this.CountryNameCheckBox);
            this.DisplayGroupBox.Controls.Add(this.TitleCheckBox);
            this.DisplayGroupBox.Location = new System.Drawing.Point(400, 81);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(200, 157);
            this.DisplayGroupBox.TabIndex = 2;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Display";
            // 
            // ProgrammerCheckBox
            // 
            this.ProgrammerCheckBox.AutoSize = true;
            this.ProgrammerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerCheckBox.Location = new System.Drawing.Point(17, 102);
            this.ProgrammerCheckBox.Name = "ProgrammerCheckBox";
            this.ProgrammerCheckBox.Size = new System.Drawing.Size(96, 19);
            this.ProgrammerCheckBox.TabIndex = 2;
            this.ProgrammerCheckBox.Text = "Programmer";
            this.ProgrammerCheckBox.UseVisualStyleBackColor = true;
            this.ProgrammerCheckBox.CheckedChanged += new System.EventHandler(this.ProgrammerCheckBox_CheckedChanged);
            // 
            // CountryNameCheckBox
            // 
            this.CountryNameCheckBox.AutoSize = true;
            this.CountryNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameCheckBox.Location = new System.Drawing.Point(17, 67);
            this.CountryNameCheckBox.Name = "CountryNameCheckBox";
            this.CountryNameCheckBox.Size = new System.Drawing.Size(104, 19);
            this.CountryNameCheckBox.TabIndex = 1;
            this.CountryNameCheckBox.Text = "Country Name";
            this.CountryNameCheckBox.UseVisualStyleBackColor = true;
            this.CountryNameCheckBox.CheckedChanged += new System.EventHandler(this.CountryNameCheckBox_CheckedChanged);
            // 
            // TitleCheckBox
            // 
            this.TitleCheckBox.AutoSize = true;
            this.TitleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCheckBox.Location = new System.Drawing.Point(17, 32);
            this.TitleCheckBox.Name = "TitleCheckBox";
            this.TitleCheckBox.Size = new System.Drawing.Size(49, 19);
            this.TitleCheckBox.TabIndex = 0;
            this.TitleCheckBox.Text = "Title";
            this.TitleCheckBox.UseVisualStyleBackColor = true;
            this.TitleCheckBox.CheckedChanged += new System.EventHandler(this.TitleCheckBox_CheckedChanged);
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerLabel.Location = new System.Drawing.Point(25, 318);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(173, 20);
            this.ProgrammerLabel.TabIndex = 3;
            this.ProgrammerLabel.Text = "Rumart Baron Tatoy";
            this.ProgrammerLabel.Visible = false;
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameLabel.Location = new System.Drawing.Point(247, 242);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(0, 25);
            this.CountryNameLabel.TabIndex = 4;
            this.CountryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhilippinesPictureBox
            // 
            this.PhilippinesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PhilippinesPictureBox.Image")));
            this.PhilippinesPictureBox.InitialImage = null;
            this.PhilippinesPictureBox.Location = new System.Drawing.Point(218, 117);
            this.PhilippinesPictureBox.Name = "PhilippinesPictureBox";
            this.PhilippinesPictureBox.Size = new System.Drawing.Size(176, 105);
            this.PhilippinesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhilippinesPictureBox.TabIndex = 5;
            this.PhilippinesPictureBox.TabStop = false;
            this.PhilippinesPictureBox.Visible = false;
            // 
            // ColombiaPictureBox
            // 
            this.ColombiaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ColombiaPictureBox.Image")));
            this.ColombiaPictureBox.InitialImage = null;
            this.ColombiaPictureBox.Location = new System.Drawing.Point(218, 117);
            this.ColombiaPictureBox.Name = "ColombiaPictureBox";
            this.ColombiaPictureBox.Size = new System.Drawing.Size(176, 105);
            this.ColombiaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ColombiaPictureBox.TabIndex = 6;
            this.ColombiaPictureBox.TabStop = false;
            this.ColombiaPictureBox.Visible = false;
            // 
            // FrancePictureBox
            // 
            this.FrancePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FrancePictureBox.Image")));
            this.FrancePictureBox.InitialImage = null;
            this.FrancePictureBox.Location = new System.Drawing.Point(218, 117);
            this.FrancePictureBox.Name = "FrancePictureBox";
            this.FrancePictureBox.Size = new System.Drawing.Size(176, 105);
            this.FrancePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FrancePictureBox.TabIndex = 8;
            this.FrancePictureBox.TabStop = false;
            this.FrancePictureBox.Visible = false;
            // 
            // USAPictureBox
            // 
            this.USAPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("USAPictureBox.Image")));
            this.USAPictureBox.InitialImage = null;
            this.USAPictureBox.Location = new System.Drawing.Point(218, 117);
            this.USAPictureBox.Name = "USAPictureBox";
            this.USAPictureBox.Size = new System.Drawing.Size(176, 105);
            this.USAPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.USAPictureBox.TabIndex = 7;
            this.USAPictureBox.TabStop = false;
            this.USAPictureBox.Visible = false;
            // 
            // flagViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 403);
            this.Controls.Add(this.FrancePictureBox);
            this.Controls.Add(this.USAPictureBox);
            this.Controls.Add(this.ColombiaPictureBox);
            this.Controls.Add(this.PhilippinesPictureBox);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.DisplayGroupBox);
            this.Controls.Add(this.FlagViewerLabel);
            this.Controls.Add(this.countryGroupBox);
            this.Name = "flagViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flag Viewer";
            this.countryGroupBox.ResumeLayout(false);
            this.countryGroupBox.PerformLayout();
            this.DisplayGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhilippinesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColombiaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USAPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox countryGroupBox;
        private System.Windows.Forms.Label FlagViewerLabel;
        private System.Windows.Forms.RadioButton PhilippinesRadioButton;
        private System.Windows.Forms.RadioButton FranceRadioButton;
        private System.Windows.Forms.RadioButton USARadioButton;
        private System.Windows.Forms.RadioButton ColombiaRadioButton;
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private System.Windows.Forms.CheckBox TitleCheckBox;
        private System.Windows.Forms.Label ProgrammerLabel;
        private System.Windows.Forms.CheckBox ProgrammerCheckBox;
        private System.Windows.Forms.CheckBox CountryNameCheckBox;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.PictureBox PhilippinesPictureBox;
        private System.Windows.Forms.PictureBox ColombiaPictureBox;
        private System.Windows.Forms.PictureBox FrancePictureBox;
        private System.Windows.Forms.PictureBox USAPictureBox;
    }
}

