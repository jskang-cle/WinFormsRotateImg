namespace RotateImg
{
    partial class ImgRotationForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.textBoxRotationDegree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelImagePath = new System.Windows.Forms.Label();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxRotated = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonRotate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRotationDegree, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelImagePath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxImagePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowseImage, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRotate.Enabled = false;
            this.buttonRotate.Location = new System.Drawing.Point(671, 34);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(94, 25);
            this.buttonRotate.TabIndex = 5;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // textBoxRotationDegree
            // 
            this.textBoxRotationDegree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRotationDegree.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxRotationDegree.Location = new System.Drawing.Point(115, 36);
            this.textBoxRotationDegree.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRotationDegree.Name = "textBoxRotationDegree";
            this.textBoxRotationDegree.Size = new System.Drawing.Size(548, 21);
            this.textBoxRotationDegree.TabIndex = 3;
            this.textBoxRotationDegree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRotationDegree_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rotation Degree:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelImagePath
            // 
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImagePath.Location = new System.Drawing.Point(3, 0);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(104, 31);
            this.labelImagePath.TabIndex = 0;
            this.labelImagePath.Text = "Image Path:";
            this.labelImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImagePath.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxImagePath.Location = new System.Drawing.Point(115, 5);
            this.textBoxImagePath.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.ReadOnly = true;
            this.textBoxImagePath.Size = new System.Drawing.Size(548, 21);
            this.textBoxImagePath.TabIndex = 2;
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowseImage.Location = new System.Drawing.Point(671, 3);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(94, 25);
            this.buttonBrowseImage.TabIndex = 4;
            this.buttonBrowseImage.Text = "Browse...";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxRotated, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxOriginal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(768, 419);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(387, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rotated Image";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxRotated
            // 
            this.pictureBoxRotated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRotated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRotated.Location = new System.Drawing.Point(387, 33);
            this.pictureBoxRotated.Name = "pictureBoxRotated";
            this.pictureBoxRotated.Size = new System.Drawing.Size(378, 383);
            this.pictureBoxRotated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRotated.TabIndex = 1;
            this.pictureBoxRotated.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(3, 33);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(378, 383);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original Image";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ImgRotationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 511);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "ImgRotationForm";
            this.Text = "ImgRotationForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelImagePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.TextBox textBoxRotationDegree;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxRotated;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Label label2;
    }
}