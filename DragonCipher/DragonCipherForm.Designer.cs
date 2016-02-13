namespace DragonCipher
{
    partial class cipherForm
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
            this.inputKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.inputPlainText = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.inputEncryptedText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.dlgPlainFileLoad = new System.Windows.Forms.OpenFileDialog();
            this.lblIV = new System.Windows.Forms.Label();
            this.inputIV = new System.Windows.Forms.TextBox();
            this.btnPlainLoad = new System.Windows.Forms.Button();
            this.btnPlainSave = new System.Windows.Forms.Button();
            this.btnEncryptedSave = new System.Windows.Forms.Button();
            this.btnEncryptedLoad = new System.Windows.Forms.Button();
            this.dlgEncryptedFileLoad = new System.Windows.Forms.OpenFileDialog();
            this.dlgPlainFileSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgEncryptedFileSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // inputKey
            // 
            this.inputKey.Location = new System.Drawing.Point(34, 32);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(483, 20);
            this.inputKey.TabIndex = 0;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(34, 13);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key";
            // 
            // inputPlainText
            // 
            this.inputPlainText.Location = new System.Drawing.Point(33, 124);
            this.inputPlainText.Multiline = true;
            this.inputPlainText.Name = "inputPlainText";
            this.inputPlainText.Size = new System.Drawing.Size(199, 138);
            this.inputPlainText.TabIndex = 2;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(30, 105);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(50, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Plain text";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(317, 105);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(79, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Encrypted data";
            // 
            // inputEncryptedText
            // 
            this.inputEncryptedText.Location = new System.Drawing.Point(320, 124);
            this.inputEncryptedText.Multiline = true;
            this.inputEncryptedText.Name = "inputEncryptedText";
            this.inputEncryptedText.ReadOnly = true;
            this.inputEncryptedText.Size = new System.Drawing.Size(197, 138);
            this.inputEncryptedText.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(241, 159);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(73, 23);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt =>";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(241, 202);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(73, 23);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "<= Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // dlgPlainFileLoad
            // 
            this.dlgPlainFileLoad.Filter = "Plain text|*.txt";
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Location = new System.Drawing.Point(34, 58);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(94, 13);
            this.lblIV.TabIndex = 11;
            this.lblIV.Text = "Initialisation vector";
            // 
            // inputIV
            // 
            this.inputIV.Location = new System.Drawing.Point(34, 77);
            this.inputIV.Name = "inputIV";
            this.inputIV.Size = new System.Drawing.Size(483, 20);
            this.inputIV.TabIndex = 1;
            // 
            // btnPlainLoad
            // 
            this.btnPlainLoad.Location = new System.Drawing.Point(147, 100);
            this.btnPlainLoad.Name = "btnPlainLoad";
            this.btnPlainLoad.Size = new System.Drawing.Size(42, 23);
            this.btnPlainLoad.TabIndex = 12;
            this.btnPlainLoad.Text = "Load";
            this.btnPlainLoad.UseVisualStyleBackColor = true;
            this.btnPlainLoad.Click += new System.EventHandler(this.btnPlainLoad_Click);
            // 
            // btnPlainSave
            // 
            this.btnPlainSave.Location = new System.Drawing.Point(190, 100);
            this.btnPlainSave.Name = "btnPlainSave";
            this.btnPlainSave.Size = new System.Drawing.Size(42, 23);
            this.btnPlainSave.TabIndex = 13;
            this.btnPlainSave.Text = "Save";
            this.btnPlainSave.UseVisualStyleBackColor = true;
            this.btnPlainSave.Click += new System.EventHandler(this.btnPlainSave_Click);
            // 
            // btnEncryptedSave
            // 
            this.btnEncryptedSave.Location = new System.Drawing.Point(475, 100);
            this.btnEncryptedSave.Name = "btnEncryptedSave";
            this.btnEncryptedSave.Size = new System.Drawing.Size(42, 23);
            this.btnEncryptedSave.TabIndex = 15;
            this.btnEncryptedSave.Text = "Save";
            this.btnEncryptedSave.UseVisualStyleBackColor = true;
            this.btnEncryptedSave.Click += new System.EventHandler(this.btnEncryptedSave_Click);
            // 
            // btnEncryptedLoad
            // 
            this.btnEncryptedLoad.Location = new System.Drawing.Point(432, 100);
            this.btnEncryptedLoad.Name = "btnEncryptedLoad";
            this.btnEncryptedLoad.Size = new System.Drawing.Size(42, 23);
            this.btnEncryptedLoad.TabIndex = 14;
            this.btnEncryptedLoad.Text = "Load";
            this.btnEncryptedLoad.UseVisualStyleBackColor = true;
            this.btnEncryptedLoad.Click += new System.EventHandler(this.btnEncryptedLoad_Click);
            // 
            // dlgEncryptedFileLoad
            // 
            this.dlgEncryptedFileLoad.Filter = "Ecrypted files|*.dat";
            // 
            // dlgPlainFileSave
            // 
            this.dlgPlainFileSave.Filter = "Plain text|*.txt";
            // 
            // dlgEncryptedFileSave
            // 
            this.dlgEncryptedFileSave.Filter = "Encrypted data|*.dat";
            // 
            // cipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 282);
            this.Controls.Add(this.btnEncryptedSave);
            this.Controls.Add(this.btnEncryptedLoad);
            this.Controls.Add(this.btnPlainSave);
            this.Controls.Add(this.btnPlainLoad);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.inputIV);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.inputEncryptedText);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.inputPlainText);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.inputKey);
            this.Name = "cipherForm";
            this.Text = "Dragon (Stream cipher)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox inputPlainText;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox inputEncryptedText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.OpenFileDialog dlgPlainFileLoad;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.TextBox inputIV;
        private System.Windows.Forms.Button btnPlainLoad;
        private System.Windows.Forms.Button btnPlainSave;
        private System.Windows.Forms.Button btnEncryptedSave;
        private System.Windows.Forms.Button btnEncryptedLoad;
        private System.Windows.Forms.OpenFileDialog dlgEncryptedFileLoad;
        private System.Windows.Forms.SaveFileDialog dlgPlainFileSave;
        private System.Windows.Forms.SaveFileDialog dlgEncryptedFileSave;
    }
}

