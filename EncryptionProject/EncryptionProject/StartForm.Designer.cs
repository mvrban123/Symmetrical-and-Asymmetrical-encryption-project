namespace EncryptionProject
{
    partial class StartForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.signatureStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.digitalSignatureStatusLabel = new System.Windows.Forms.Label();
            this.decryptedDataTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptedDataTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptFileButton = new System.Windows.Forms.Button();
            this.decryptionFilePathButton = new System.Windows.Forms.Button();
            this.decryptionFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptFileButton = new System.Windows.Forms.Button();
            this.filePickerButton = new System.Windows.Forms.Button();
            this.encryptionFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.symmetricDencDataTextBox = new System.Windows.Forms.RichTextBox();
            this.symmetricEncDataTextBox = new System.Windows.Forms.RichTextBox();
            this.symmetricDencFileButton = new System.Windows.Forms.Button();
            this.symmetricDencDataPicker = new System.Windows.Forms.Button();
            this.symmetricDencFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.symmetricEncFileButton = new System.Windows.Forms.Button();
            this.symmetricEncDataPicker = new System.Windows.Forms.Button();
            this.symmetricEncFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // signatureStatusLabel
            // 
            this.signatureStatusLabel.AutoSize = true;
            this.signatureStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.signatureStatusLabel.Location = new System.Drawing.Point(17, 425);
            this.signatureStatusLabel.Name = "signatureStatusLabel";
            this.signatureStatusLabel.Size = new System.Drawing.Size(0, 20);
            this.signatureStatusLabel.TabIndex = 10;
            this.signatureStatusLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.digitalSignatureStatusLabel);
            this.groupBox1.Controls.Add(this.decryptedDataTextBox);
            this.groupBox1.Controls.Add(this.encryptedDataTextBox);
            this.groupBox1.Controls.Add(this.decryptFileButton);
            this.groupBox1.Controls.Add(this.decryptionFilePathButton);
            this.groupBox1.Controls.Add(this.decryptionFilePathTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.encryptFileButton);
            this.groupBox1.Controls.Add(this.filePickerButton);
            this.groupBox1.Controls.Add(this.encryptionFilePathTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(33, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 836);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asimetrična Kriptografija";
            // 
            // digitalSignatureStatusLabel
            // 
            this.digitalSignatureStatusLabel.AutoSize = true;
            this.digitalSignatureStatusLabel.Location = new System.Drawing.Point(42, 753);
            this.digitalSignatureStatusLabel.Name = "digitalSignatureStatusLabel";
            this.digitalSignatureStatusLabel.Size = new System.Drawing.Size(232, 20);
            this.digitalSignatureStatusLabel.TabIndex = 20;
            this.digitalSignatureStatusLabel.Text = "digitalSignatureStatusLabel";
            // 
            // decryptedDataTextBox
            // 
            this.decryptedDataTextBox.Location = new System.Drawing.Point(372, 285);
            this.decryptedDataTextBox.Name = "decryptedDataTextBox";
            this.decryptedDataTextBox.Size = new System.Drawing.Size(320, 455);
            this.decryptedDataTextBox.TabIndex = 19;
            this.decryptedDataTextBox.Text = "";
            // 
            // encryptedDataTextBox
            // 
            this.encryptedDataTextBox.Location = new System.Drawing.Point(37, 285);
            this.encryptedDataTextBox.Name = "encryptedDataTextBox";
            this.encryptedDataTextBox.Size = new System.Drawing.Size(329, 455);
            this.encryptedDataTextBox.TabIndex = 18;
            this.encryptedDataTextBox.Text = "";
            // 
            // decryptFileButton
            // 
            this.decryptFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.decryptFileButton.Location = new System.Drawing.Point(36, 241);
            this.decryptFileButton.Name = "decryptFileButton";
            this.decryptFileButton.Size = new System.Drawing.Size(140, 37);
            this.decryptFileButton.TabIndex = 17;
            this.decryptFileButton.Text = "Dekriptiraj";
            this.decryptFileButton.UseVisualStyleBackColor = true;
            this.decryptFileButton.Click += new System.EventHandler(this.decryptFileButton_Click_1);
            // 
            // decryptionFilePathButton
            // 
            this.decryptionFilePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decryptionFilePathButton.Location = new System.Drawing.Point(659, 202);
            this.decryptionFilePathButton.Name = "decryptionFilePathButton";
            this.decryptionFilePathButton.Size = new System.Drawing.Size(33, 24);
            this.decryptionFilePathButton.TabIndex = 16;
            this.decryptionFilePathButton.Text = "...";
            this.decryptionFilePathButton.UseVisualStyleBackColor = true;
            this.decryptionFilePathButton.Click += new System.EventHandler(this.decryptionFilePathButton_Click_1);
            // 
            // decryptionFilePathTextBox
            // 
            this.decryptionFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.decryptionFilePathTextBox.Location = new System.Drawing.Point(36, 202);
            this.decryptionFilePathTextBox.Name = "decryptionFilePathTextBox";
            this.decryptionFilePathTextBox.Size = new System.Drawing.Size(617, 24);
            this.decryptionFilePathTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Odaberite datoteku za dekriptiranje:";
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.encryptFileButton.Location = new System.Drawing.Point(36, 108);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Size = new System.Drawing.Size(140, 37);
            this.encryptFileButton.TabIndex = 13;
            this.encryptFileButton.Text = "Kriptiraj";
            this.encryptFileButton.UseVisualStyleBackColor = true;
            this.encryptFileButton.Click += new System.EventHandler(this.encryptFileButton_Click_1);
            // 
            // filePickerButton
            // 
            this.filePickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filePickerButton.Location = new System.Drawing.Point(659, 69);
            this.filePickerButton.Name = "filePickerButton";
            this.filePickerButton.Size = new System.Drawing.Size(33, 24);
            this.filePickerButton.TabIndex = 12;
            this.filePickerButton.Text = "...";
            this.filePickerButton.UseVisualStyleBackColor = true;
            this.filePickerButton.Click += new System.EventHandler(this.filePickerButton_Click_1);
            // 
            // encryptionFilePathTextBox
            // 
            this.encryptionFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.encryptionFilePathTextBox.Location = new System.Drawing.Point(36, 69);
            this.encryptionFilePathTextBox.Name = "encryptionFilePathTextBox";
            this.encryptionFilePathTextBox.Size = new System.Drawing.Size(617, 24);
            this.encryptionFilePathTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Odaberite datoteku za kriptiranje:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.symmetricDencDataTextBox);
            this.groupBox2.Controls.Add(this.symmetricEncDataTextBox);
            this.groupBox2.Controls.Add(this.symmetricDencFileButton);
            this.groupBox2.Controls.Add(this.symmetricDencDataPicker);
            this.groupBox2.Controls.Add(this.symmetricDencFilePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.symmetricEncFileButton);
            this.groupBox2.Controls.Add(this.symmetricEncDataPicker);
            this.groupBox2.Controls.Add(this.symmetricEncFilePath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(835, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 836);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simetrična Kriptografija";
            // 
            // symmetricDencDataTextBox
            // 
            this.symmetricDencDataTextBox.Location = new System.Drawing.Point(372, 285);
            this.symmetricDencDataTextBox.Name = "symmetricDencDataTextBox";
            this.symmetricDencDataTextBox.Size = new System.Drawing.Size(320, 455);
            this.symmetricDencDataTextBox.TabIndex = 19;
            this.symmetricDencDataTextBox.Text = "";
            // 
            // symmetricEncDataTextBox
            // 
            this.symmetricEncDataTextBox.Location = new System.Drawing.Point(37, 285);
            this.symmetricEncDataTextBox.Name = "symmetricEncDataTextBox";
            this.symmetricEncDataTextBox.Size = new System.Drawing.Size(329, 455);
            this.symmetricEncDataTextBox.TabIndex = 18;
            this.symmetricEncDataTextBox.Text = "";
            // 
            // symmetricDencFileButton
            // 
            this.symmetricDencFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.symmetricDencFileButton.Location = new System.Drawing.Point(36, 241);
            this.symmetricDencFileButton.Name = "symmetricDencFileButton";
            this.symmetricDencFileButton.Size = new System.Drawing.Size(140, 37);
            this.symmetricDencFileButton.TabIndex = 17;
            this.symmetricDencFileButton.Text = "Dekriptiraj";
            this.symmetricDencFileButton.UseVisualStyleBackColor = true;
            this.symmetricDencFileButton.Click += new System.EventHandler(this.symmetricDencFileButton_Click);
            // 
            // symmetricDencDataPicker
            // 
            this.symmetricDencDataPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.symmetricDencDataPicker.Location = new System.Drawing.Point(659, 202);
            this.symmetricDencDataPicker.Name = "symmetricDencDataPicker";
            this.symmetricDencDataPicker.Size = new System.Drawing.Size(33, 24);
            this.symmetricDencDataPicker.TabIndex = 16;
            this.symmetricDencDataPicker.Text = "...";
            this.symmetricDencDataPicker.UseVisualStyleBackColor = true;
            this.symmetricDencDataPicker.Click += new System.EventHandler(this.symmetricDencDataPicker_Click);
            // 
            // symmetricDencFilePath
            // 
            this.symmetricDencFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.symmetricDencFilePath.Location = new System.Drawing.Point(36, 202);
            this.symmetricDencFilePath.Name = "symmetricDencFilePath";
            this.symmetricDencFilePath.Size = new System.Drawing.Size(617, 24);
            this.symmetricDencFilePath.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(33, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Odaberite datoteku za dekriptiranje:";
            // 
            // symmetricEncFileButton
            // 
            this.symmetricEncFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.symmetricEncFileButton.Location = new System.Drawing.Point(36, 108);
            this.symmetricEncFileButton.Name = "symmetricEncFileButton";
            this.symmetricEncFileButton.Size = new System.Drawing.Size(140, 37);
            this.symmetricEncFileButton.TabIndex = 13;
            this.symmetricEncFileButton.Text = "Kriptiraj";
            this.symmetricEncFileButton.UseVisualStyleBackColor = true;
            this.symmetricEncFileButton.Click += new System.EventHandler(this.symmetricEncFileButton_Click);
            // 
            // symmetricEncDataPicker
            // 
            this.symmetricEncDataPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.symmetricEncDataPicker.Location = new System.Drawing.Point(659, 69);
            this.symmetricEncDataPicker.Name = "symmetricEncDataPicker";
            this.symmetricEncDataPicker.Size = new System.Drawing.Size(33, 24);
            this.symmetricEncDataPicker.TabIndex = 12;
            this.symmetricEncDataPicker.Text = "...";
            this.symmetricEncDataPicker.UseVisualStyleBackColor = true;
            this.symmetricEncDataPicker.Click += new System.EventHandler(this.symmetricEncDataPicker_Click);
            // 
            // symmetricEncFilePath
            // 
            this.symmetricEncFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.symmetricEncFilePath.Location = new System.Drawing.Point(36, 69);
            this.symmetricEncFilePath.Name = "symmetricEncFilePath";
            this.symmetricEncFilePath.Size = new System.Drawing.Size(617, 24);
            this.symmetricEncFilePath.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(33, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Odaberite datoteku za kriptiranje:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 861);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.signatureStatusLabel);
            this.Name = "StartForm";
            this.Text = "Encryption Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label signatureStatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox decryptedDataTextBox;
        private System.Windows.Forms.RichTextBox encryptedDataTextBox;
        private System.Windows.Forms.Button decryptFileButton;
        private System.Windows.Forms.Button decryptionFilePathButton;
        private System.Windows.Forms.TextBox decryptionFilePathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encryptFileButton;
        private System.Windows.Forms.Button filePickerButton;
        private System.Windows.Forms.TextBox encryptionFilePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label digitalSignatureStatusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox symmetricDencDataTextBox;
        private System.Windows.Forms.RichTextBox symmetricEncDataTextBox;
        private System.Windows.Forms.Button symmetricDencFileButton;
        private System.Windows.Forms.Button symmetricDencDataPicker;
        private System.Windows.Forms.TextBox symmetricDencFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button symmetricEncFileButton;
        private System.Windows.Forms.Button symmetricEncDataPicker;
        private System.Windows.Forms.TextBox symmetricEncFilePath;
        private System.Windows.Forms.Label label5;
    }
}

