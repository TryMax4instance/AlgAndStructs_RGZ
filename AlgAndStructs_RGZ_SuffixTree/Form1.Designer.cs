﻿namespace AlgAndStructs_RGZ_SuffixTree
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.create = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.seqCreateButton = new System.Windows.Forms.Button();
            this.seqLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seqFromTextBox = new System.Windows.Forms.TextBox();
            this.seqToTextBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.memUsetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultRTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(501, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(508, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 363);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(515, 444);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 2;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(643, 444);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 3;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(724, 446);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 4;
            // 
            // seqCreateButton
            // 
            this.seqCreateButton.Location = new System.Drawing.Point(508, 12);
            this.seqCreateButton.Name = "seqCreateButton";
            this.seqCreateButton.Size = new System.Drawing.Size(110, 23);
            this.seqCreateButton.TabIndex = 5;
            this.seqCreateButton.Text = "Генерация строки";
            this.seqCreateButton.UseVisualStyleBackColor = true;
            this.seqCreateButton.Click += new System.EventHandler(this.seqCreateButton_Click);
            // 
            // seqLengthTextBox
            // 
            this.seqLengthTextBox.Location = new System.Drawing.Point(624, 14);
            this.seqLengthTextBox.Name = "seqLengthTextBox";
            this.seqLengthTextBox.Size = new System.Drawing.Size(87, 20);
            this.seqLengthTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "От";
            // 
            // seqFromTextBox
            // 
            this.seqFromTextBox.Location = new System.Drawing.Point(771, 14);
            this.seqFromTextBox.Name = "seqFromTextBox";
            this.seqFromTextBox.Size = new System.Drawing.Size(29, 20);
            this.seqFromTextBox.TabIndex = 8;
            // 
            // seqToTextBox4
            // 
            this.seqToTextBox4.Location = new System.Drawing.Point(837, 14);
            this.seqToTextBox4.Name = "seqToTextBox4";
            this.seqToTextBox4.Size = new System.Drawing.Size(29, 20);
            this.seqToTextBox4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "До";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 446);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Общее время, мс";
            // 
            // memUsetextBox
            // 
            this.memUsetextBox.Location = new System.Drawing.Point(302, 446);
            this.memUsetextBox.Name = "memUsetextBox";
            this.memUsetextBox.ReadOnly = true;
            this.memUsetextBox.Size = new System.Drawing.Size(94, 20);
            this.memUsetextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Память, байт";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(966, 133);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(87, 20);
            this.SearchBox.TabIndex = 16;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(850, 131);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(110, 23);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Поиск подстроки";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultRTB
            // 
            this.ResultRTB.Location = new System.Drawing.Point(850, 160);
            this.ResultRTB.Name = "ResultRTB";
            this.ResultRTB.Size = new System.Drawing.Size(325, 177);
            this.ResultRTB.TabIndex = 19;
            this.ResultRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 483);
            this.Controls.Add(this.ResultRTB);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.memUsetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seqToTextBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seqFromTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seqLengthTextBox);
            this.Controls.Add(this.seqCreateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.create);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button seqCreateButton;
        private System.Windows.Forms.TextBox seqLengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seqFromTextBox;
        private System.Windows.Forms.TextBox seqToTextBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox memUsetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox ResultRTB;
    }
}

