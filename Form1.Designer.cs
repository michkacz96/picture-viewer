namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CloseBtn = new Button();
            SetColorBtn = new Button();
            ClearPictureBtn = new Button();
            ShowPictureBtn = new Button();
            pictureBox1 = new PictureBox();
            StreachImageCheckBox = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ShowPictureBtn);
            flowLayoutPanel1.Controls.Add(ClearPictureBtn);
            flowLayoutPanel1.Controls.Add(SetColorBtn);
            flowLayoutPanel1.Controls.Add(CloseBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(123, 413);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(674, 40);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Location = new Point(229, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 25);
            CloseBtn.TabIndex = 3;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SetColorBtn
            // 
            SetColorBtn.AutoSize = true;
            SetColorBtn.Location = new Point(310, 3);
            SetColorBtn.Name = "SetColorBtn";
            SetColorBtn.Size = new Size(150, 25);
            SetColorBtn.TabIndex = 2;
            SetColorBtn.Text = "Set the background color";
            SetColorBtn.UseVisualStyleBackColor = true;
            SetColorBtn.Click += SetColorBtn_Click;
            // 
            // ClearPictureBtn
            // 
            ClearPictureBtn.AutoSize = true;
            ClearPictureBtn.Location = new Point(466, 3);
            ClearPictureBtn.Name = "ClearPictureBtn";
            ClearPictureBtn.Size = new Size(104, 25);
            ClearPictureBtn.TabIndex = 1;
            ClearPictureBtn.Text = "Clear the picture";
            ClearPictureBtn.UseVisualStyleBackColor = true;
            ClearPictureBtn.Click += ClearPictureBtn_Click;
            // 
            // ShowPictureBtn
            // 
            ShowPictureBtn.AutoSize = true;
            ShowPictureBtn.Location = new Point(576, 3);
            ShowPictureBtn.Name = "ShowPictureBtn";
            ShowPictureBtn.Size = new Size(95, 25);
            ShowPictureBtn.TabIndex = 0;
            ShowPictureBtn.Text = "Show a picture";
            ShowPictureBtn.UseVisualStyleBackColor = true;
            ShowPictureBtn.Click += ShowPictureBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(123, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(674, 404);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StreachImageCheckBox
            // 
            StreachImageCheckBox.AutoSize = true;
            StreachImageCheckBox.Dock = DockStyle.Fill;
            StreachImageCheckBox.Location = new Point(3, 413);
            StreachImageCheckBox.Name = "StreachImageCheckBox";
            StreachImageCheckBox.Size = new Size(114, 40);
            StreachImageCheckBox.TabIndex = 1;
            StreachImageCheckBox.Text = "Streach image";
            StreachImageCheckBox.UseVisualStyleBackColor = true;
            StreachImageCheckBox.CheckedChanged += StreachImageCheckBox_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(StreachImageCheckBox, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 456);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Picture Viewer";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ShowPictureBtn;
        private Button ClearPictureBtn;
        private Button SetColorBtn;
        private Button CloseBtn;
        private PictureBox pictureBox1;
        private CheckBox StreachImageCheckBox;
        private TableLayoutPanel tableLayoutPanel1;
    }
}