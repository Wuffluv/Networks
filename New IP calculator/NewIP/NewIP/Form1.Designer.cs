﻿namespace NewIP
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
            this.ip = new System.Windows.Forms.TextBox();
            this.mask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countNode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.SlateGray;
            this.ip.Location = new System.Drawing.Point(710, 76);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(270, 22);
            this.ip.TabIndex = 0;
            // 
            // mask
            // 
            this.mask.BackColor = System.Drawing.Color.SlateGray;
            this.mask.Location = new System.Drawing.Point(710, 191);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(270, 22);
            this.mask.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(707, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Изначальная сеть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(707, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Маска подсети";
            // 
            // countNode
            // 
            this.countNode.BackColor = System.Drawing.Color.SlateGray;
            this.countNode.Location = new System.Drawing.Point(710, 298);
            this.countNode.Name = "countNode";
            this.countNode.Size = new System.Drawing.Size(270, 22);
            this.countNode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(710, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество узлов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Location = new System.Drawing.Point(23, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 405);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(794, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1028, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countNode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.ip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox mask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

