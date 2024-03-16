namespace rikunov._16._03
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            labelVendor = new Label();
            labelName = new Label();
            labelProductType = new Label();
            labelWorker = new Label();
            labelNumberFactory = new Label();
            labelPrice = new Label();
            labelWriteUp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 83);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelVendor
            // 
            labelVendor.AutoSize = true;
            labelVendor.Location = new Point(117, 38);
            labelVendor.Name = "labelVendor";
            labelVendor.Size = new Size(69, 15);
            labelVendor.TabIndex = 1;
            labelVendor.Text = "labelVendor";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(236, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 15);
            labelName.TabIndex = 2;
            labelName.Text = "labelName";
            // 
            // labelProductType
            // 
            labelProductType.AutoSize = true;
            labelProductType.Location = new Point(345, 38);
            labelProductType.Name = "labelProductType";
            labelProductType.Size = new Size(98, 15);
            labelProductType.TabIndex = 3;
            labelProductType.Text = "labelProductType";
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Location = new Point(478, 38);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(70, 15);
            labelWorker.TabIndex = 4;
            labelWorker.Text = "labelWorker";
            labelWorker.Click += labelWorker_Click;
            // 
            // labelNumberFactory
            // 
            labelNumberFactory.AutoSize = true;
            labelNumberFactory.Location = new Point(595, 38);
            labelNumberFactory.Name = "labelNumberFactory";
            labelNumberFactory.Size = new Size(115, 15);
            labelNumberFactory.TabIndex = 5;
            labelNumberFactory.Text = "labelNumberFactory";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(734, 38);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(58, 15);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "labelPrice";
            // 
            // labelWriteUp
            // 
            labelWriteUp.AutoSize = true;
            labelWriteUp.Location = new Point(850, 38);
            labelWriteUp.Name = "labelWriteUp";
            labelWriteUp.Size = new Size(75, 15);
            labelWriteUp.TabIndex = 7;
            labelWriteUp.Text = "labelWriteUp";
            labelWriteUp.Click += label1_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelWriteUp);
            Controls.Add(labelPrice);
            Controls.Add(labelNumberFactory);
            Controls.Add(labelWorker);
            Controls.Add(labelProductType);
            Controls.Add(labelName);
            Controls.Add(labelVendor);
            Controls.Add(pictureBox1);
            Name = "UserControl1";
            Size = new Size(947, 97);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelVendor;
        private Label labelName;
        private Label labelProductType;
        private Label labelWorker;
        private Label labelNumberFactory;
        private Label labelPrice;
        private Label labelWriteUp;
    }
}
