
namespace CharacterCreator.WinHost
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
            // this._chkIsClassic = new System.Windows.Forms.CheckBox();
            //this._cbRating = new System.Windows.Forms.ComboBox();
            this._txtCharacterName = new System.Windows.Forms.TextBox();
            this._txtProfession = new System.Windows.Forms.ComboBox();
            this._txtRace = new System.Windows.Forms.ComboBox();
            this._txtBiography = new System.Windows.Forms.TextBox();
            //this._txtRunLength = new System.Windows.Forms.TextBox();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
           
            this.SuspendLayout();
            // 
            // _btnSave
            // 
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
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biography";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Strength";
            // 

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label6";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Intelligence";
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label7";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Agility";
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label8";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Constitution";
            //
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label9";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Charisma";
            // _chkIsClassic
            // _chkIsClassic
            // 
            // this._chkIsClassic.AutoSize = true;
            // this._chkIsClassic.Location = new System.Drawing.Point(137, 304);
            // this._chkIsClassic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // this._chkIsClassic.Name = "_chkIsClassic";
            // this._chkIsClassic.Size = new System.Drawing.Size(96, 24);
            // this._chkIsClassic.TabIndex = 8;
            // this._chkIsClassic.Text = "Is Classic?";
            // this._chkIsClassic.UseVisualStyleBackColor = true;
            // 

            // _txtCharacterName
            // 
            this._txtCharacterName.Location = new System.Drawing.Point(137, 32);
            this._txtCharacterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtCharacterName.Name = "_txtCharacterName";
            this._txtCharacterName.Size = new System.Drawing.Size(114, 27);
            this._txtCharacterName.TabIndex = 11;
            // 
            // _cbRating
            // 
            this._cbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this._cbProfession.Location = new System.Drawing.Point(137, 129);
            this._cbProfession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(138, 28);
            this._cbProfession.TabIndex = 12;
            // 
            // 
            this._cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Items.AddRange(new object[] {
            "G",    
            "PG",   
            "PG-13",
            "R"});  
            this._cbRace.Location = new System.Drawing.Point(137, 129);
            this._cbRace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(138, 28);
            this._cbRace.TabIndex = 13;
            // 
           
            // _txtRunLength
            // 
           //this._txtRunLength.Location = new System.Drawing.Point(137, 69);
           //this._txtRunLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
           //this._txtRunLength.Name = "_txtRunLength";
           //this._txtRunLength.Size = new System.Drawing.Size(114, 27);
           //this._txtRunLength.TabIndex = 11;
            // 
           
            // _txtBiography
            // 
            this._txtBiography.Location = new System.Drawing.Point(137, 239);
            this._txtBiography.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtBiography.Name = "_txtBiography";
            this._txtBiography.Size = new System.Drawing.Size(114, 27);
            this._txtBiography.TabIndex = 13;
            // 
            // Agility
            // 
            this._txtStrength.Location = new System.Drawing.Point(137, 193);
            this._txtStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtStrength.Name = "Strength";
            this._txtStrength.Size = new System.Drawing.Size(114, 27);
            this._txtStrength.TabIndex = 14;
            // 
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(137, 193);
            this._txtIntelligence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtIntelligence.Name = "Intelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(114, 27);
            this._txtIntelligence.TabIndex = 15;
            // 
            // 
            this._txtAgility.Location = new System.Drawing.Point(137, 193);
            this._txtAgility.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtAgility.Name = "Agility";
            this._txtAgility.Size = new System.Drawing.Size(114, 27);
            this._txtAgility.TabIndex = 16;
            // 
            // 
            this._txtConstitution.Location = new System.Drawing.Point(137, 193);
            this._txtConstitution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtConstitution.Name = "Constitution";
            this._txtConstitution.Size = new System.Drawing.Size(114, 27);
            this._txtConstitution.TabIndex = 17;
            // 
            // 
            this._txtCharisma.Location = new System.Drawing.Point(137, 193);
            this._txtCharisma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtCharisma.Name = "Charisma";
            this._txtCharisma.Size = new System.Drawing.Size(114, 27);
            this._txtCharisma.TabIndex = 18;
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 437);
            
            //this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this._txtCharacterName);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this._txtBiography);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtCharisma);
            //this.Controls.Add(this._chkIsClassic);
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
            this.Name = "AddCharacterForm";
            this.Text = "Character  Details";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
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
    }
}