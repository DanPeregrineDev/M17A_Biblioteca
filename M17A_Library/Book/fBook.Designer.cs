namespace M17A_Library.Book
{
    partial class fBook
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
            this.LB_01 = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.TB_Author = new System.Windows.Forms.TextBox();
            this.LB_02 = new System.Windows.Forms.Label();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.LB_03 = new System.Windows.Forms.Label();
            this.LB_05 = new System.Windows.Forms.Label();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.LB_06 = new System.Windows.Forms.Label();
            this.DTP_AquisitionDate = new System.Windows.Forms.DateTimePicker();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.LB_04 = new System.Windows.Forms.Label();
            this.LB_07 = new System.Windows.Forms.Label();
            this.PB_CoverImage = new System.Windows.Forms.PictureBox();
            this.B_OpenFile = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.LB_Feedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CoverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Location = new System.Drawing.Point(46, 72);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(65, 25);
            this.LB_01.TabIndex = 0;
            this.LB_01.Text = "Titulo";
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(213, 66);
            this.TB_Title.MaxLength = 50;
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(200, 31);
            this.TB_Title.TabIndex = 1;
            // 
            // TB_Author
            // 
            this.TB_Author.Location = new System.Drawing.Point(213, 115);
            this.TB_Author.MaxLength = 100;
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.Size = new System.Drawing.Size(200, 31);
            this.TB_Author.TabIndex = 3;
            // 
            // LB_02
            // 
            this.LB_02.AutoSize = true;
            this.LB_02.Location = new System.Drawing.Point(46, 121);
            this.LB_02.Name = "LB_02";
            this.LB_02.Size = new System.Drawing.Size(63, 25);
            this.LB_02.TabIndex = 2;
            this.LB_02.Text = "Autor";
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(213, 161);
            this.TB_ISBN.MaxLength = 13;
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.Size = new System.Drawing.Size(200, 31);
            this.TB_ISBN.TabIndex = 5;
            // 
            // LB_03
            // 
            this.LB_03.AutoSize = true;
            this.LB_03.Location = new System.Drawing.Point(46, 167);
            this.LB_03.Name = "LB_03";
            this.LB_03.Size = new System.Drawing.Size(60, 25);
            this.LB_03.TabIndex = 4;
            this.LB_03.Text = "ISBN";
            // 
            // LB_05
            // 
            this.LB_05.AutoSize = true;
            this.LB_05.Location = new System.Drawing.Point(46, 260);
            this.LB_05.Name = "LB_05";
            this.LB_05.Size = new System.Drawing.Size(155, 25);
            this.LB_05.TabIndex = 6;
            this.LB_05.Text = "Data aquisicao";
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(213, 308);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(200, 31);
            this.TB_Price.TabIndex = 9;
            // 
            // LB_06
            // 
            this.LB_06.AutoSize = true;
            this.LB_06.Location = new System.Drawing.Point(46, 312);
            this.LB_06.Name = "LB_06";
            this.LB_06.Size = new System.Drawing.Size(68, 25);
            this.LB_06.TabIndex = 8;
            this.LB_06.Text = "Preco";
            // 
            // DTP_AquisitionDate
            // 
            this.DTP_AquisitionDate.Location = new System.Drawing.Point(213, 259);
            this.DTP_AquisitionDate.Name = "DTP_AquisitionDate";
            this.DTP_AquisitionDate.Size = new System.Drawing.Size(200, 31);
            this.DTP_AquisitionDate.TabIndex = 10;
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(213, 210);
            this.TB_Year.MaxLength = 4;
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(200, 31);
            this.TB_Year.TabIndex = 12;
            // 
            // LB_04
            // 
            this.LB_04.AutoSize = true;
            this.LB_04.Location = new System.Drawing.Point(46, 216);
            this.LB_04.Name = "LB_04";
            this.LB_04.Size = new System.Drawing.Size(50, 25);
            this.LB_04.TabIndex = 11;
            this.LB_04.Text = "Ano";
            // 
            // LB_07
            // 
            this.LB_07.AutoSize = true;
            this.LB_07.Location = new System.Drawing.Point(46, 357);
            this.LB_07.Name = "LB_07";
            this.LB_07.Size = new System.Drawing.Size(63, 25);
            this.LB_07.TabIndex = 13;
            this.LB_07.Text = "Capa";
            // 
            // PB_CoverImage
            // 
            this.PB_CoverImage.Location = new System.Drawing.Point(213, 357);
            this.PB_CoverImage.Name = "PB_CoverImage";
            this.PB_CoverImage.Size = new System.Drawing.Size(200, 165);
            this.PB_CoverImage.TabIndex = 14;
            this.PB_CoverImage.TabStop = false;
            // 
            // B_OpenFile
            // 
            this.B_OpenFile.Location = new System.Drawing.Point(213, 538);
            this.B_OpenFile.Name = "B_OpenFile";
            this.B_OpenFile.Size = new System.Drawing.Size(200, 53);
            this.B_OpenFile.TabIndex = 15;
            this.B_OpenFile.Text = "Open file";
            this.B_OpenFile.UseVisualStyleBackColor = true;
            this.B_OpenFile.Click += new System.EventHandler(this.B_OpenFile_Click_1);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(62, 692);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(351, 71);
            this.B_Save.TabIndex = 16;
            this.B_Save.Text = "Guardar";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // LB_Feedback
            // 
            this.LB_Feedback.AutoSize = true;
            this.LB_Feedback.Location = new System.Drawing.Point(46, 646);
            this.LB_Feedback.Name = "LB_Feedback";
            this.LB_Feedback.Size = new System.Drawing.Size(0, 25);
            this.LB_Feedback.TabIndex = 17;
            // 
            // fBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 818);
            this.Controls.Add(this.LB_Feedback);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_OpenFile);
            this.Controls.Add(this.PB_CoverImage);
            this.Controls.Add(this.LB_07);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.LB_04);
            this.Controls.Add(this.DTP_AquisitionDate);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.LB_06);
            this.Controls.Add(this.LB_05);
            this.Controls.Add(this.TB_ISBN);
            this.Controls.Add(this.LB_03);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.LB_02);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.LB_01);
            this.Name = "fBook";
            this.Text = "fBook";
            ((System.ComponentModel.ISupportInitialize)(this.PB_CoverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.TextBox TB_Author;
        private System.Windows.Forms.Label LB_02;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.Label LB_03;
        private System.Windows.Forms.Label LB_05;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label LB_06;
        private System.Windows.Forms.DateTimePicker DTP_AquisitionDate;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.Label LB_04;
        private System.Windows.Forms.Label LB_07;
        private System.Windows.Forms.PictureBox PB_CoverImage;
        private System.Windows.Forms.Button B_OpenFile;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label LB_Feedback;
    }
}