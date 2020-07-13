namespace beta
{
    partial class uploadForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.fileChoseBtn = new System.Windows.Forms.Button();
            this.previousImage = new System.Windows.Forms.Button();
            this.nextImage = new System.Windows.Forms.Button();
            this.imageName = new System.Windows.Forms.Label();
            this.folderBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.imageNumber = new System.Windows.Forms.Label();
            this.pdfBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1254, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.White;
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewBox.Location = new System.Drawing.Point(698, 62);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(309, 460);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 3;
            this.previewBox.TabStop = false;
            // 
            // fileChoseBtn
            // 
            this.fileChoseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.fileChoseBtn.FlatAppearance.BorderSize = 0;
            this.fileChoseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.fileChoseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.fileChoseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileChoseBtn.ForeColor = System.Drawing.Color.White;
            this.fileChoseBtn.Location = new System.Drawing.Point(105, 62);
            this.fileChoseBtn.Name = "fileChoseBtn";
            this.fileChoseBtn.Size = new System.Drawing.Size(210, 50);
            this.fileChoseBtn.TabIndex = 4;
            this.fileChoseBtn.Text = "Selectionner un document";
            this.fileChoseBtn.UseVisualStyleBackColor = false;
            this.fileChoseBtn.Click += new System.EventHandler(this.fileChoseBtn_Click);
            // 
            // previousImage
            // 
            this.previousImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.previousImage.FlatAppearance.BorderSize = 0;
            this.previousImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.previousImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.previousImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousImage.ForeColor = System.Drawing.Color.White;
            this.previousImage.Location = new System.Drawing.Point(698, 558);
            this.previousImage.Name = "previousImage";
            this.previousImage.Size = new System.Drawing.Size(151, 30);
            this.previousImage.TabIndex = 5;
            this.previousImage.Text = "Document précédent";
            this.previousImage.UseVisualStyleBackColor = false;
            this.previousImage.Click += new System.EventHandler(this.previousImage_Click);
            // 
            // nextImage
            // 
            this.nextImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.nextImage.FlatAppearance.BorderSize = 0;
            this.nextImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.nextImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.nextImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextImage.ForeColor = System.Drawing.Color.White;
            this.nextImage.Location = new System.Drawing.Point(855, 558);
            this.nextImage.Name = "nextImage";
            this.nextImage.Size = new System.Drawing.Size(152, 30);
            this.nextImage.TabIndex = 6;
            this.nextImage.Text = "Document suivant";
            this.nextImage.UseVisualStyleBackColor = false;
            this.nextImage.Click += new System.EventHandler(this.nextImage_Click);
            // 
            // imageName
            // 
            this.imageName.AutoSize = true;
            this.imageName.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageName.Location = new System.Drawing.Point(707, 20);
            this.imageName.MaximumSize = new System.Drawing.Size(300, 20);
            this.imageName.MinimumSize = new System.Drawing.Size(300, 20);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(300, 20);
            this.imageName.TabIndex = 7;
            this.imageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderBtn
            // 
            this.folderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.folderBtn.FlatAppearance.BorderSize = 0;
            this.folderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.folderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.folderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderBtn.ForeColor = System.Drawing.Color.White;
            this.folderBtn.Location = new System.Drawing.Point(105, 251);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(210, 50);
            this.folderBtn.TabIndex = 8;
            this.folderBtn.Text = "Selectionner un dossier";
            this.folderBtn.UseVisualStyleBackColor = false;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(222)))), ((int)(((byte)(151)))));
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.uploadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(218)))), ((int)(((byte)(173)))));
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(105, 538);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(210, 50);
            this.uploadBtn.TabIndex = 9;
            this.uploadBtn.Text = "Téléverser les fichiers";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // imageNumber
            // 
            this.imageNumber.AutoSize = true;
            this.imageNumber.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageNumber.Location = new System.Drawing.Point(774, 525);
            this.imageNumber.MaximumSize = new System.Drawing.Size(150, 0);
            this.imageNumber.MinimumSize = new System.Drawing.Size(150, 0);
            this.imageNumber.Name = "imageNumber";
            this.imageNumber.Size = new System.Drawing.Size(150, 22);
            this.imageNumber.TabIndex = 10;
            this.imageNumber.Text = "0 / 0";
            this.imageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdfBtn
            // 
            this.pdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.pdfBtn.FlatAppearance.BorderSize = 0;
            this.pdfBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.pdfBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.pdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfBtn.ForeColor = System.Drawing.Color.White;
            this.pdfBtn.Location = new System.Drawing.Point(105, 159);
            this.pdfBtn.Name = "pdfBtn";
            this.pdfBtn.Size = new System.Drawing.Size(210, 50);
            this.pdfBtn.TabIndex = 11;
            this.pdfBtn.Text = "Selectionner un PDF";
            this.pdfBtn.UseVisualStyleBackColor = false;
            this.pdfBtn.Click += new System.EventHandler(this.pdfBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Scanner";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // uploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pdfBtn);
            this.Controls.Add(this.imageNumber);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.nextImage);
            this.Controls.Add(this.previousImage);
            this.Controls.Add(this.fileChoseBtn);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uploadForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " ";
            this.Load += new System.EventHandler(this.uploadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button fileChoseBtn;
        private System.Windows.Forms.Button previousImage;
        private System.Windows.Forms.Button nextImage;
        private System.Windows.Forms.Label imageName;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label imageNumber;
        private System.Windows.Forms.Button pdfBtn;
        private System.Windows.Forms.Button button1;
    }
}