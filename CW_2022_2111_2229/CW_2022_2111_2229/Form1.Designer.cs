namespace CW_2022_2111_2229
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Open = new System.Windows.Forms.Button();
            this.groupBox_Begin = new System.Windows.Forms.GroupBox();
            this.radioButton_Extract = new System.Windows.Forms.RadioButton();
            this.radioButton_Hide = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Hide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_Extract = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_Hide = new System.Windows.Forms.RichTextBox();
            this.button_Extract = new System.Windows.Forms.Button();
            this.groupBox_Extract = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Analysis = new System.Windows.Forms.Button();
            this.groupBox_Method = new System.Windows.Forms.GroupBox();
            this.radioButton_BMYY = new System.Windows.Forms.RadioButton();
            this.radioButton_DCT = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Hide = new System.Windows.Forms.GroupBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_Begin.SuspendLayout();
            this.groupBox_Extract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Method.SuspendLayout();
            this.groupBox_Hide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Open
            // 
            this.button_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Open.Location = new System.Drawing.Point(12, 19);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(268, 39);
            this.button_Open.TabIndex = 15;
            this.button_Open.Text = "Загрузить изображение";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // groupBox_Begin
            // 
            this.groupBox_Begin.Controls.Add(this.radioButton_Extract);
            this.groupBox_Begin.Controls.Add(this.radioButton_Hide);
            this.groupBox_Begin.Controls.Add(this.label7);
            this.groupBox_Begin.Controls.Add(this.button_Open);
            this.groupBox_Begin.Location = new System.Drawing.Point(2, 3);
            this.groupBox_Begin.Name = "groupBox_Begin";
            this.groupBox_Begin.Size = new System.Drawing.Size(290, 158);
            this.groupBox_Begin.TabIndex = 14;
            this.groupBox_Begin.TabStop = false;
            // 
            // radioButton_Extract
            // 
            this.radioButton_Extract.AutoSize = true;
            this.radioButton_Extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Extract.Location = new System.Drawing.Point(31, 128);
            this.radioButton_Extract.Name = "radioButton_Extract";
            this.radioButton_Extract.Size = new System.Drawing.Size(157, 20);
            this.radioButton_Extract.TabIndex = 30;
            this.radioButton_Extract.TabStop = true;
            this.radioButton_Extract.Text = "Извлечение данных";
            this.radioButton_Extract.UseVisualStyleBackColor = true;
            this.radioButton_Extract.Click += new System.EventHandler(this.radioButton_Extract_Click);
            // 
            // radioButton_Hide
            // 
            this.radioButton_Hide.AutoSize = true;
            this.radioButton_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Hide.Location = new System.Drawing.Point(31, 102);
            this.radioButton_Hide.Name = "radioButton_Hide";
            this.radioButton_Hide.Size = new System.Drawing.Size(131, 20);
            this.radioButton_Hide.TabIndex = 29;
            this.radioButton_Hide.TabStop = true;
            this.radioButton_Hide.Text = "Скрытие данных";
            this.radioButton_Hide.UseVisualStyleBackColor = true;
            this.radioButton_Hide.Click += new System.EventHandler(this.radioButton_Hide_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(19, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Режим работы:";
            // 
            // button_Hide
            // 
            this.button_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Hide.Location = new System.Drawing.Point(23, 183);
            this.button_Hide.Name = "button_Hide";
            this.button_Hide.Size = new System.Drawing.Size(241, 46);
            this.button_Hide.TabIndex = 31;
            this.button_Hide.Text = "Скрыть";
            this.button_Hide.UseVisualStyleBackColor = true;
            this.button_Hide.Click += new System.EventHandler(this.button_Hide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Сообщение:";
            // 
            // richTextBox_Extract
            // 
            this.richTextBox_Extract.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Extract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Extract.Location = new System.Drawing.Point(14, 106);
            this.richTextBox_Extract.Name = "richTextBox_Extract";
            this.richTextBox_Extract.ReadOnly = true;
            this.richTextBox_Extract.Size = new System.Drawing.Size(268, 91);
            this.richTextBox_Extract.TabIndex = 16;
            this.richTextBox_Extract.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Раскодированное сообщение:";
            // 
            // richTextBox_Hide
            // 
            this.richTextBox_Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Hide.Location = new System.Drawing.Point(14, 54);
            this.richTextBox_Hide.Name = "richTextBox_Hide";
            this.richTextBox_Hide.Size = new System.Drawing.Size(268, 91);
            this.richTextBox_Hide.TabIndex = 32;
            this.richTextBox_Hide.Text = "";
            this.richTextBox_Hide.TextChanged += new System.EventHandler(this.richTextBox_Hide_TextChanged);
            // 
            // button_Extract
            // 
            this.button_Extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Extract.Location = new System.Drawing.Point(24, 29);
            this.button_Extract.Name = "button_Extract";
            this.button_Extract.Size = new System.Drawing.Size(241, 46);
            this.button_Extract.TabIndex = 14;
            this.button_Extract.Text = "Извлечь";
            this.button_Extract.UseVisualStyleBackColor = true;
            this.button_Extract.Click += new System.EventHandler(this.button_Extract_Click);
            // 
            // groupBox_Extract
            // 
            this.groupBox_Extract.Controls.Add(this.richTextBox_Extract);
            this.groupBox_Extract.Controls.Add(this.label5);
            this.groupBox_Extract.Controls.Add(this.button_Extract);
            this.groupBox_Extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Extract.Location = new System.Drawing.Point(3, 306);
            this.groupBox_Extract.Name = "groupBox_Extract";
            this.groupBox_Extract.Size = new System.Drawing.Size(290, 227);
            this.groupBox_Extract.TabIndex = 16;
            this.groupBox_Extract.TabStop = false;
            this.groupBox_Extract.Text = "Извлечение";
            this.groupBox_Extract.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 837);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.button_Analysis);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Method);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Begin);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Hide);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Extract);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 837);
            this.splitContainer1.SplitterDistance = 880;
            this.splitContainer1.TabIndex = 3;
            // 
            // button_Analysis
            // 
            this.button_Analysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Analysis.Location = new System.Drawing.Point(27, 767);
            this.button_Analysis.Name = "button_Analysis";
            this.button_Analysis.Size = new System.Drawing.Size(241, 46);
            this.button_Analysis.TabIndex = 35;
            this.button_Analysis.Text = "Анализ изображения";
            this.button_Analysis.UseVisualStyleBackColor = true;
            this.button_Analysis.Visible = false;
            this.button_Analysis.Click += new System.EventHandler(this.button_Analysis_Click);
            // 
            // groupBox_Method
            // 
            this.groupBox_Method.Controls.Add(this.radioButton_BMYY);
            this.groupBox_Method.Controls.Add(this.radioButton_DCT);
            this.groupBox_Method.Controls.Add(this.label4);
            this.groupBox_Method.Controls.Add(this.label2);
            this.groupBox_Method.Controls.Add(this.label1);
            this.groupBox_Method.Location = new System.Drawing.Point(3, 157);
            this.groupBox_Method.Name = "groupBox_Method";
            this.groupBox_Method.Size = new System.Drawing.Size(289, 145);
            this.groupBox_Method.TabIndex = 16;
            this.groupBox_Method.TabStop = false;
            // 
            // radioButton_BMYY
            // 
            this.radioButton_BMYY.AutoSize = true;
            this.radioButton_BMYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_BMYY.Location = new System.Drawing.Point(30, 79);
            this.radioButton_BMYY.Name = "radioButton_BMYY";
            this.radioButton_BMYY.Size = new System.Drawing.Size(241, 20);
            this.radioButton_BMYY.TabIndex = 40;
            this.radioButton_BMYY.TabStop = true;
            this.radioButton_BMYY.Text = "Метод Бенгама-Мемона-Эо-Юнга";
            this.radioButton_BMYY.UseVisualStyleBackColor = true;
            this.radioButton_BMYY.CheckedChanged += new System.EventHandler(this.radioButton_BMYY_CheckedChanged);
            // 
            // radioButton_DCT
            // 
            this.radioButton_DCT.AutoSize = true;
            this.radioButton_DCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_DCT.Location = new System.Drawing.Point(32, 53);
            this.radioButton_DCT.Name = "radioButton_DCT";
            this.radioButton_DCT.Size = new System.Drawing.Size(97, 20);
            this.radioButton_DCT.TabIndex = 38;
            this.radioButton_DCT.TabStop = true;
            this.radioButton_DCT.Text = "Метод ДКП";
            this.radioButton_DCT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Метод скрытия сообщения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(229, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Максимальная длина сообщения:";
            // 
            // groupBox_Hide
            // 
            this.groupBox_Hide.Controls.Add(this.button_Save);
            this.groupBox_Hide.Controls.Add(this.label6);
            this.groupBox_Hide.Controls.Add(this.richTextBox_Hide);
            this.groupBox_Hide.Controls.Add(this.button_Hide);
            this.groupBox_Hide.Controls.Add(this.label3);
            this.groupBox_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Hide.Location = new System.Drawing.Point(3, 305);
            this.groupBox_Hide.Name = "groupBox_Hide";
            this.groupBox_Hide.Size = new System.Drawing.Size(290, 308);
            this.groupBox_Hide.TabIndex = 15;
            this.groupBox_Hide.TabStop = false;
            this.groupBox_Hide.Text = "Скрытие";
            this.groupBox_Hide.Visible = false;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(23, 237);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(241, 46);
            this.button_Save.TabIndex = 34;
            this.button_Save.Text = "Сохранить изображение";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(187, 148);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.bmp;*.jpg;*.png";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Images|*.bmp;*.jpg;*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Begin.ResumeLayout(false);
            this.groupBox_Begin.PerformLayout();
            this.groupBox_Extract.ResumeLayout(false);
            this.groupBox_Extract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Method.ResumeLayout(false);
            this.groupBox_Method.PerformLayout();
            this.groupBox_Hide.ResumeLayout(false);
            this.groupBox_Hide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.GroupBox groupBox_Begin;
        private System.Windows.Forms.Button button_Hide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_Extract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_Hide;
        private System.Windows.Forms.Button button_Extract;
        private System.Windows.Forms.GroupBox groupBox_Extract;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_Hide;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton radioButton_Hide;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_Extract;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.GroupBox groupBox_Method;
        private System.Windows.Forms.RadioButton radioButton_BMYY;
        private System.Windows.Forms.RadioButton radioButton_DCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_Analysis;
    }
}

