﻿
namespace AdventureGame.WinHost
{
    partial class AddCharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtCharacterName = new System.Windows.Forms.TextBox();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this._txtBiography = new System.Windows.Forms.TextBox();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(499, 368);
            this._btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(86, 31);
            this._btnSave.TabIndex = 0;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(615, 368);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(86, 31);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biography";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Intelligence";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Agility";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Constitution";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Charisma";
            // 
            // _txtCharacterName
            // 
            this._txtCharacterName.Location = new System.Drawing.Point(134, 34);
            this._txtCharacterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtCharacterName.Name = "_txtCharacterName";
            this._txtCharacterName.Size = new System.Drawing.Size(114, 27);
            this._txtCharacterName.TabIndex = 11;
            //this._txtCharacterName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
            // 
            // _cbProfession
            // 
            this._cbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Items.AddRange(new object[] {
            "Psychologist",
            "Doctor",
            "Contractor",
            "Athlete",
            "Singer"});
            this._cbProfession.Location = new System.Drawing.Point(134, 79);
            this._cbProfession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(138, 28);
            this._cbProfession.TabIndex = 12;
            //this._cbProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRaceOrProfession);
            // 
            // _cbRace
            // 
            this._cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Items.AddRange(new object[] {
            "Froggler",
            "Doggler",
            "Hoggler",
            "Snakeman",
            "Martian"});
            this._cbRace.Location = new System.Drawing.Point(134, 129);
            this._cbRace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(138, 28);
            this._cbRace.TabIndex = 13;
            //this._cbRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRaceOrProfession);
            // 
            // _txtBiography
            // 
            this._txtBiography.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtBiography.Location = new System.Drawing.Point(134, 171);
            this._txtBiography.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtBiography.Multiline = true;
            this._txtBiography.Name = "_txtBiography";
            this._txtBiography.PlaceholderText = "Type short history of your character";
            this._txtBiography.Size = new System.Drawing.Size(250, 72);
            this._txtBiography.TabIndex = 13;
            // 
            // _txtStrength
            // 
            this._txtStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._txtStrength.Location = new System.Drawing.Point(134, 251);
            this._txtStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.PlaceholderText = "50";
            this._txtStrength.Size = new System.Drawing.Size(114, 27);
            this._txtStrength.TabIndex = 14;
            this._txtStrength.Text = "50";
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributeValues);
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._txtIntelligence.Location = new System.Drawing.Point(134, 287);
            this._txtIntelligence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(114, 27);
            this._txtIntelligence.TabIndex = 15;
            this._txtIntelligence.Text = "50";
            this._txtIntelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributeValues);
            // 
            // _txtAgility
            // 
            this._txtAgility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._txtAgility.Location = new System.Drawing.Point(134, 322);
            this._txtAgility.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(114, 27);
            this._txtAgility.TabIndex = 16;
            this._txtAgility.Text = "50";
            this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributeValues);
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._txtConstitution.Location = new System.Drawing.Point(134, 357);
            this._txtConstitution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(114, 27);
            this._txtConstitution.TabIndex = 17;
            this._txtConstitution.Text = "50";
            this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributeValues);
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._txtCharisma.Location = new System.Drawing.Point(134, 392);
            this._txtCharisma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(114, 27);
            this._txtCharisma.TabIndex = 18;
            this._txtCharisma.Text = "50";
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributeValues);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(745, 494);
            this.Controls.Add(this._txtCharacterName);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this._txtBiography);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(763, 541);
            this.MinimumSize = new System.Drawing.Size(763, 541);
            this.Name = "AddCharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Character  Details";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtCharacterName;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.TextBox _txtBiography;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.TextBox _txtIntelligence;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}