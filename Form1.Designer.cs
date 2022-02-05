namespace Enigma
{
    partial class Form1
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
            this.target_folder_btn = new System.Windows.Forms.Button();
            this.destination_folder_btn = new System.Windows.Forms.Button();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.target_label = new System.Windows.Forms.Label();
            this.destination_label = new System.Windows.Forms.Label();
            this.encrypt_label = new System.Windows.Forms.Label();
            this.decrypt_label = new System.Windows.Forms.Label();
            this.file_system_watcher_btn = new System.Windows.Forms.Button();
            this.FSW_label = new System.Windows.Forms.Label();
            this.target_folder_textbox = new System.Windows.Forms.TextBox();
            this.encrypt_textbox = new System.Windows.Forms.TextBox();
            this.destination_folder_textbox = new System.Windows.Forms.TextBox();
            this.decrypt_textbox = new System.Windows.Forms.TextBox();
            this.browse_target_folder_btn = new System.Windows.Forms.Button();
            this.browse_encrypt_files_btn = new System.Windows.Forms.Button();
            this.browse_destination_folder_btn = new System.Windows.Forms.Button();
            this.browse_decrypt_file_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dest_textbox = new System.Windows.Forms.TextBox();
            this.browse_destination_for_decrypted_file_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enigma_btn = new System.Windows.Forms.Button();
            this.XTEA_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // target_folder_btn
            // 
            this.target_folder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.target_folder_btn.Location = new System.Drawing.Point(10, 105);
            this.target_folder_btn.Name = "target_folder_btn";
            this.target_folder_btn.Size = new System.Drawing.Size(135, 25);
            this.target_folder_btn.TabIndex = 0;
            this.target_folder_btn.Text = "Save target folder";
            this.target_folder_btn.UseVisualStyleBackColor = true;
            this.target_folder_btn.Click += new System.EventHandler(this.target_folder_btn_Click);
            // 
            // destination_folder_btn
            // 
            this.destination_folder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destination_folder_btn.Location = new System.Drawing.Point(310, 105);
            this.destination_folder_btn.Name = "destination_folder_btn";
            this.destination_folder_btn.Size = new System.Drawing.Size(135, 25);
            this.destination_folder_btn.TabIndex = 1;
            this.destination_folder_btn.Text = "Save destination folder";
            this.destination_folder_btn.UseVisualStyleBackColor = true;
            this.destination_folder_btn.Click += new System.EventHandler(this.destination_folder_btn_Click);
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encrypt_btn.Location = new System.Drawing.Point(10, 127);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(75, 30);
            this.encrypt_btn.TabIndex = 2;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decrypt_btn.Location = new System.Drawing.Point(376, 217);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(75, 30);
            this.decrypt_btn.TabIndex = 3;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // target_label
            // 
            this.target_label.AutoSize = true;
            this.target_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.target_label.Location = new System.Drawing.Point(6, 46);
            this.target_label.MinimumSize = new System.Drawing.Size(100, 20);
            this.target_label.Name = "target_label";
            this.target_label.Size = new System.Drawing.Size(103, 20);
            this.target_label.TabIndex = 4;
            this.target_label.Text = "Target folder:";
            // 
            // destination_label
            // 
            this.destination_label.AutoSize = true;
            this.destination_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destination_label.Location = new System.Drawing.Point(307, 46);
            this.destination_label.Name = "destination_label";
            this.destination_label.Size = new System.Drawing.Size(138, 20);
            this.destination_label.TabIndex = 5;
            this.destination_label.Text = "Destination folder:";
            // 
            // encrypt_label
            // 
            this.encrypt_label.AutoSize = true;
            this.encrypt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encrypt_label.Location = new System.Drawing.Point(6, 39);
            this.encrypt_label.Name = "encrypt_label";
            this.encrypt_label.Size = new System.Drawing.Size(99, 20);
            this.encrypt_label.TabIndex = 6;
            this.encrypt_label.Text = "Encrypt files:";
            // 
            // decrypt_label
            // 
            this.decrypt_label.AutoSize = true;
            this.decrypt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decrypt_label.Location = new System.Drawing.Point(372, 39);
            this.decrypt_label.Name = "decrypt_label";
            this.decrypt_label.Size = new System.Drawing.Size(92, 20);
            this.decrypt_label.TabIndex = 7;
            this.decrypt_label.Text = "Decrypt file:";
            // 
            // file_system_watcher_btn
            // 
            this.file_system_watcher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.file_system_watcher_btn.Location = new System.Drawing.Point(623, 158);
            this.file_system_watcher_btn.Name = "file_system_watcher_btn";
            this.file_system_watcher_btn.Size = new System.Drawing.Size(135, 30);
            this.file_system_watcher_btn.TabIndex = 8;
            this.file_system_watcher_btn.Text = "Turn on/off";
            this.file_system_watcher_btn.UseVisualStyleBackColor = true;
            this.file_system_watcher_btn.Click += new System.EventHandler(this.file_system_watcher_btn_Click);
            // 
            // FSW_label
            // 
            this.FSW_label.AutoSize = true;
            this.FSW_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FSW_label.Location = new System.Drawing.Point(607, 133);
            this.FSW_label.Name = "FSW_label";
            this.FSW_label.Size = new System.Drawing.Size(175, 22);
            this.FSW_label.TabIndex = 9;
            this.FSW_label.Text = "File System Watcher";
            // 
            // target_folder_textbox
            // 
            this.target_folder_textbox.Location = new System.Drawing.Point(10, 69);
            this.target_folder_textbox.MinimumSize = new System.Drawing.Size(100, 20);
            this.target_folder_textbox.Multiline = true;
            this.target_folder_textbox.Name = "target_folder_textbox";
            this.target_folder_textbox.Size = new System.Drawing.Size(185, 30);
            this.target_folder_textbox.TabIndex = 10;
            // 
            // encrypt_textbox
            // 
            this.encrypt_textbox.Location = new System.Drawing.Point(10, 71);
            this.encrypt_textbox.Multiline = true;
            this.encrypt_textbox.Name = "encrypt_textbox";
            this.encrypt_textbox.Size = new System.Drawing.Size(185, 30);
            this.encrypt_textbox.TabIndex = 11;
            // 
            // destination_folder_textbox
            // 
            this.destination_folder_textbox.Location = new System.Drawing.Point(310, 69);
            this.destination_folder_textbox.Multiline = true;
            this.destination_folder_textbox.Name = "destination_folder_textbox";
            this.destination_folder_textbox.Size = new System.Drawing.Size(185, 30);
            this.destination_folder_textbox.TabIndex = 12;
            // 
            // decrypt_textbox
            // 
            this.decrypt_textbox.Location = new System.Drawing.Point(376, 71);
            this.decrypt_textbox.Multiline = true;
            this.decrypt_textbox.Name = "decrypt_textbox";
            this.decrypt_textbox.Size = new System.Drawing.Size(185, 30);
            this.decrypt_textbox.TabIndex = 13;
            // 
            // browse_target_folder_btn
            // 
            this.browse_target_folder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browse_target_folder_btn.Location = new System.Drawing.Point(201, 69);
            this.browse_target_folder_btn.Name = "browse_target_folder_btn";
            this.browse_target_folder_btn.Size = new System.Drawing.Size(60, 30);
            this.browse_target_folder_btn.TabIndex = 14;
            this.browse_target_folder_btn.Text = "browse";
            this.browse_target_folder_btn.UseVisualStyleBackColor = true;
            this.browse_target_folder_btn.Click += new System.EventHandler(this.browse_target_folder_btn_Click);
            // 
            // browse_encrypt_files_btn
            // 
            this.browse_encrypt_files_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browse_encrypt_files_btn.Location = new System.Drawing.Point(222, 71);
            this.browse_encrypt_files_btn.Name = "browse_encrypt_files_btn";
            this.browse_encrypt_files_btn.Size = new System.Drawing.Size(60, 30);
            this.browse_encrypt_files_btn.TabIndex = 15;
            this.browse_encrypt_files_btn.Text = "browse";
            this.browse_encrypt_files_btn.UseVisualStyleBackColor = true;
            this.browse_encrypt_files_btn.Click += new System.EventHandler(this.browse_encrypt_files_btn_Click);
            // 
            // browse_destination_folder_btn
            // 
            this.browse_destination_folder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browse_destination_folder_btn.Location = new System.Drawing.Point(501, 69);
            this.browse_destination_folder_btn.Name = "browse_destination_folder_btn";
            this.browse_destination_folder_btn.Size = new System.Drawing.Size(60, 30);
            this.browse_destination_folder_btn.TabIndex = 16;
            this.browse_destination_folder_btn.Text = "browse";
            this.browse_destination_folder_btn.UseVisualStyleBackColor = true;
            this.browse_destination_folder_btn.Click += new System.EventHandler(this.browse_destination_folder_btn_Click);
            // 
            // browse_decrypt_file_btn
            // 
            this.browse_decrypt_file_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browse_decrypt_file_btn.Location = new System.Drawing.Point(592, 71);
            this.browse_decrypt_file_btn.Name = "browse_decrypt_file_btn";
            this.browse_decrypt_file_btn.Size = new System.Drawing.Size(60, 30);
            this.browse_decrypt_file_btn.TabIndex = 17;
            this.browse_decrypt_file_btn.Text = "browse";
            this.browse_decrypt_file_btn.UseVisualStyleBackColor = true;
            this.browse_decrypt_file_btn.Click += new System.EventHandler(this.browse_decrypt_file_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(372, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Destination folder:";
            // 
            // dest_textbox
            // 
            this.dest_textbox.Location = new System.Drawing.Point(376, 162);
            this.dest_textbox.Multiline = true;
            this.dest_textbox.Name = "dest_textbox";
            this.dest_textbox.Size = new System.Drawing.Size(185, 30);
            this.dest_textbox.TabIndex = 19;
            // 
            // browse_destination_for_decrypted_file_btn
            // 
            this.browse_destination_for_decrypted_file_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browse_destination_for_decrypted_file_btn.Location = new System.Drawing.Point(592, 162);
            this.browse_destination_for_decrypted_file_btn.Name = "browse_destination_for_decrypted_file_btn";
            this.browse_destination_for_decrypted_file_btn.Size = new System.Drawing.Size(60, 30);
            this.browse_destination_for_decrypted_file_btn.TabIndex = 20;
            this.browse_destination_for_decrypted_file_btn.Text = "browse";
            this.browse_destination_for_decrypted_file_btn.UseVisualStyleBackColor = true;
            this.browse_destination_for_decrypted_file_btn.Click += new System.EventHandler(this.browse_destination_for_decrypted_file_btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.target_folder_btn);
            this.groupBox1.Controls.Add(this.target_folder_textbox);
            this.groupBox1.Controls.Add(this.browse_target_folder_btn);
            this.groupBox1.Controls.Add(this.target_label);
            this.groupBox1.Controls.Add(this.destination_folder_textbox);
            this.groupBox1.Controls.Add(this.browse_destination_folder_btn);
            this.groupBox1.Controls.Add(this.destination_folder_btn);
            this.groupBox1.Controls.Add(this.destination_label);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 153);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatic coding with file watcher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.decrypt_label);
            this.groupBox2.Controls.Add(this.encrypt_label);
            this.groupBox2.Controls.Add(this.browse_encrypt_files_btn);
            this.groupBox2.Controls.Add(this.browse_destination_for_decrypted_file_btn);
            this.groupBox2.Controls.Add(this.encrypt_textbox);
            this.groupBox2.Controls.Add(this.browse_decrypt_file_btn);
            this.groupBox2.Controls.Add(this.dest_textbox);
            this.groupBox2.Controls.Add(this.decrypt_textbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.encrypt_btn);
            this.groupBox2.Controls.Add(this.decrypt_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 260);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Code and decode";
            // 
            // enigma_btn
            // 
            this.enigma_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enigma_btn.Location = new System.Drawing.Point(382, 35);
            this.enigma_btn.Name = "enigma_btn";
            this.enigma_btn.Size = new System.Drawing.Size(75, 25);
            this.enigma_btn.TabIndex = 23;
            this.enigma_btn.Text = "Enigma";
            this.enigma_btn.UseVisualStyleBackColor = true;
            this.enigma_btn.Click += new System.EventHandler(this.enigma_btn_Click);
            // 
            // XTEA_btn
            // 
            this.XTEA_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XTEA_btn.Location = new System.Drawing.Point(485, 35);
            this.XTEA_btn.Name = "XTEA_btn";
            this.XTEA_btn.Size = new System.Drawing.Size(75, 25);
            this.XTEA_btn.TabIndex = 24;
            this.XTEA_btn.Text = "XTEA";
            this.XTEA_btn.UseVisualStyleBackColor = true;
            this.XTEA_btn.Click += new System.EventHandler(this.XTEA_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "First select an encryption algorithm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XTEA_btn);
            this.Controls.Add(this.enigma_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FSW_label);
            this.Controls.Add(this.file_system_watcher_btn);
            this.Name = "Form1";
            this.Text = "Encrypting/Decrypting Machine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button target_folder_btn;
        private System.Windows.Forms.Button destination_folder_btn;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label target_label;
        private System.Windows.Forms.Label destination_label;
        private System.Windows.Forms.Label encrypt_label;
        private System.Windows.Forms.Label decrypt_label;
        private System.Windows.Forms.Button file_system_watcher_btn;
        private System.Windows.Forms.Label FSW_label;
        private System.Windows.Forms.TextBox target_folder_textbox;
        private System.Windows.Forms.TextBox encrypt_textbox;
        private System.Windows.Forms.TextBox destination_folder_textbox;
        private System.Windows.Forms.TextBox decrypt_textbox;
        private System.Windows.Forms.Button browse_target_folder_btn;
        private System.Windows.Forms.Button browse_encrypt_files_btn;
        private System.Windows.Forms.Button browse_destination_folder_btn;
        private System.Windows.Forms.Button browse_decrypt_file_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dest_textbox;
        private System.Windows.Forms.Button browse_destination_for_decrypted_file_btn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button enigma_btn;
        private System.Windows.Forms.Button XTEA_btn;
        private System.Windows.Forms.Label label2;
    }
}

