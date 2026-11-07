namespace LabExer501
{
    partial class FrmStudentRecord
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
            lvShowText = new ListView();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            openFileDialog1 = new OpenFileDialog();
            hScrollBar2 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Alignment = ListViewAlignment.Default;
            lvShowText.Anchor = AnchorStyles.None;
            lvShowText.BackColor = SystemColors.ControlLightLight;
            lvShowText.BorderStyle = BorderStyle.FixedSingle;
            lvShowText.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvShowText.Location = new Point(0, 26);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(531, 288);
            lvShowText.TabIndex = 1;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.Silver;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.Silver;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Tahoma", 9F);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(-6, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(71, 22);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Ṟegister";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.Anchor = AnchorStyles.None;
            btnFind.BackColor = Color.Silver;
            btnFind.Cursor = Cursors.Hand;
            btnFind.FlatAppearance.BorderColor = Color.Silver;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Tahoma", 9F);
            btnFind.ForeColor = Color.Black;
            btnFind.Location = new Point(56, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(40, 22);
            btnFind.TabIndex = 3;
            btnFind.Text = "F̲ind";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.None;
            btnUpload.BackColor = Color.Silver;
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatAppearance.BorderColor = Color.Silver;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Tahoma", 9F);
            btnUpload.ForeColor = Color.Black;
            btnUpload.Location = new Point(95, 2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(59, 22);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "U̲pload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // hScrollBar2
            // 
            hScrollBar2.Location = new Point(0, 311);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(544, 17);
            hScrollBar2.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(527, 26);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 288);
            vScrollBar1.TabIndex = 7;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(543, 329);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar2);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(lvShowText);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmStudentRecord";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Forms.exe";
            Load += FrmStudentRecord_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListView lvShowText;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
        private OpenFileDialog openFileDialog1;
        private HScrollBar hScrollBar2;
        private VScrollBar vScrollBar1;
    }
}