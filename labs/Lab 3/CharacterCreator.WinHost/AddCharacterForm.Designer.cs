
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
            this._chkIsClassic = new System.Windows.Forms.CheckBox();
            this._cbRating = new System.Windows.Forms.ComboBox();
            this._txtCharacterName = new System.Windows.Forms.TextBox();
            this._txtRunLength = new System.Windows.Forms.TextBox();
            this.Agility = new System.Windows.Forms.TextBox();
            this._txtBiography = new System.Windows.Forms.TextBox();
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
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Run Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Release Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Biography";
            // 
            // _chkIsClassic
            // 
            this._chkIsClassic.AutoSize = true;
            this._chkIsClassic.Location = new System.Drawing.Point(137, 304);
            this._chkIsClassic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._chkIsClassic.Name = "_chkIsClassic";
            this._chkIsClassic.Size = new System.Drawing.Size(96, 24);
            this._chkIsClassic.TabIndex = 8;
            this._chkIsClassic.Text = "Is Classic?";
            this._chkIsClassic.UseVisualStyleBackColor = true;
            // 
            // _cbRating
            // 
            this._cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbRating.FormattingEnabled = true;
            this._cbRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this._cbRating.Location = new System.Drawing.Point(137, 129);
            this._cbRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbRating.Name = "_cbRating";
            this._cbRating.Size = new System.Drawing.Size(138, 28);
            this._cbRating.TabIndex = 9;
            // 
            // _txtCharacterName
            // 
            this._txtCharacterName.Location = new System.Drawing.Point(137, 32);
            this._txtCharacterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtCharacterName.Name = "_txtCharacterName";
            this._txtCharacterName.Size = new System.Drawing.Size(114, 27);
            this._txtCharacterName.TabIndex = 10;
            // 
            // _txtRunLength
            // 
            this._txtRunLength.Location = new System.Drawing.Point(137, 69);
            this._txtRunLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtRunLength.Name = "_txtRunLength";
            this._txtRunLength.Size = new System.Drawing.Size(114, 27);
            this._txtRunLength.TabIndex = 11;
            // 
            // Agility
            // 
            this.Agility.Location = new System.Drawing.Point(137, 193);
            this.Agility.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(114, 27);
            this.Agility.TabIndex = 12;
            // 
            // _txtBiography
            // 
            this._txtBiography.Location = new System.Drawing.Point(137, 239);
            this._txtBiography.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtBiography.Name = "_txtBiography";
            this._txtBiography.Size = new System.Drawing.Size(114, 27);
            this._txtBiography.TabIndex = 13;
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 437);
            this.Controls.Add(this._txtBiography);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this._txtCharacterName);
            this.Controls.Add(this._cbRating);
            this.Controls.Add(this._chkIsClassic);
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
        private System.Windows.Forms.CheckBox _chkIsClassic;
        private System.Windows.Forms.ComboBox _cbRating;
        private System.Windows.Forms.TextBox _txtCharacterName;
        private System.Windows.Forms.TextBox _txtRunLength;
        private System.Windows.Forms.TextBox Agility;
        private System.Windows.Forms.TextBox _txtBiography;
    }
}