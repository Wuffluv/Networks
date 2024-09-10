namespace WindowsForms_IPCalc
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
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_mask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_compressed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_expanded = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_prefix = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_range_a = new System.Windows.Forms.Label();
            this.label_range_b = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_subnet = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_divide = new System.Windows.Forms.Button();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.button_aggregate = new System.Windows.Forms.Button();
            this.richTextBox_networks = new System.Windows.Forms.RichTextBox();
            this.comboBox_prefix_subnets = new System.Windows.Forms.ComboBox();
            this.button_divide2 = new System.Windows.Forms.Button();
            this.textBox_network = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ip
            // 
            this.textBox_ip.BackColor = System.Drawing.Color.LightGray;
            this.textBox_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ip.ForeColor = System.Drawing.Color.Green;
            this.textBox_ip.Location = new System.Drawing.Point(61, 114);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(455, 34);
            this.textBox_ip.TabIndex = 2;
            this.textBox_ip.Text = "21:db8:58:74:1c60:2c18:125:2b5f";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.BackColor = System.Drawing.Color.Transparent;
            this.label_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ip.ForeColor = System.Drawing.Color.Green;
            this.label_ip.Location = new System.Drawing.Point(56, 62);
            this.label_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(142, 29);
            this.label_ip.TabIndex = 3;
            this.label_ip.Text = "IPv6 адрес";
            // 
            // label_mask
            // 
            this.label_mask.AutoSize = true;
            this.label_mask.BackColor = System.Drawing.Color.Transparent;
            this.label_mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mask.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_mask.Location = new System.Drawing.Point(564, 62);
            this.label_mask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mask.Name = "label_mask";
            this.label_mask.Size = new System.Drawing.Size(122, 29);
            this.label_mask.TabIndex = 4;
            this.label_mask.Text = "Префикс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(57, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сокращенный адрес";
            // 
            // label_compressed
            // 
            this.label_compressed.AutoSize = true;
            this.label_compressed.BackColor = System.Drawing.Color.Transparent;
            this.label_compressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_compressed.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_compressed.Location = new System.Drawing.Point(351, 190);
            this.label_compressed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_compressed.Name = "label_compressed";
            this.label_compressed.Size = new System.Drawing.Size(0, 29);
            this.label_compressed.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(57, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Полный адрес";
            // 
            // label_expanded
            // 
            this.label_expanded.AutoSize = true;
            this.label_expanded.BackColor = System.Drawing.Color.Transparent;
            this.label_expanded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_expanded.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_expanded.Location = new System.Drawing.Point(351, 256);
            this.label_expanded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_expanded.Name = "label_expanded";
            this.label_expanded.Size = new System.Drawing.Size(0, 29);
            this.label_expanded.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(57, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Маска префикса";
            // 
            // label_prefix
            // 
            this.label_prefix.AutoSize = true;
            this.label_prefix.BackColor = System.Drawing.Color.Transparent;
            this.label_prefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prefix.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_prefix.Location = new System.Drawing.Point(351, 320);
            this.label_prefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prefix.Name = "label_prefix";
            this.label_prefix.Size = new System.Drawing.Size(0, 29);
            this.label_prefix.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Green;
            this.comboBox1.Location = new System.Drawing.Point(569, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 37);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "24";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(692, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_status.Location = new System.Drawing.Point(56, 190);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 29);
            this.label_status.TabIndex = 17;
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(57, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Диапазон";
            // 
            // label_range_a
            // 
            this.label_range_a.AutoSize = true;
            this.label_range_a.BackColor = System.Drawing.Color.Transparent;
            this.label_range_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_range_a.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_range_a.Location = new System.Drawing.Point(351, 389);
            this.label_range_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_range_a.Name = "label_range_a";
            this.label_range_a.Size = new System.Drawing.Size(0, 29);
            this.label_range_a.TabIndex = 19;
            // 
            // label_range_b
            // 
            this.label_range_b.AutoSize = true;
            this.label_range_b.BackColor = System.Drawing.Color.Transparent;
            this.label_range_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_range_b.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_range_b.Location = new System.Drawing.Point(351, 453);
            this.label_range_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_range_b.Name = "label_range_b";
            this.label_range_b.Size = new System.Drawing.Size(0, 29);
            this.label_range_b.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(57, 510);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Количество адресов";
            // 
            // label_subnet
            // 
            this.label_subnet.AutoSize = true;
            this.label_subnet.BackColor = System.Drawing.Color.Transparent;
            this.label_subnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subnet.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_subnet.Location = new System.Drawing.Point(351, 510);
            this.label_subnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_subnet.Name = "label_subnet";
            this.label_subnet.Size = new System.Drawing.Size(0, 29);
            this.label_subnet.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(61, 708);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(596, 198);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.ForestGreen;
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_divide.Location = new System.Drawing.Point(451, 578);
            this.button_divide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(208, 38);
            this.button_divide.TabIndex = 25;
            this.button_divide.Text = "Разделить";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_count
            // 
            this.textBox_count.BackColor = System.Drawing.Color.LightGray;
            this.textBox_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_count.ForeColor = System.Drawing.Color.Green;
            this.textBox_count.Location = new System.Drawing.Point(339, 578);
            this.textBox_count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(80, 34);
            this.textBox_count.TabIndex = 26;
            this.textBox_count.Text = "2";
            // 
            // button_aggregate
            // 
            this.button_aggregate.BackColor = System.Drawing.Color.ForestGreen;
            this.button_aggregate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aggregate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_aggregate.Location = new System.Drawing.Point(1002, 320);
            this.button_aggregate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_aggregate.Name = "button_aggregate";
            this.button_aggregate.Size = new System.Drawing.Size(232, 38);
            this.button_aggregate.TabIndex = 28;
            this.button_aggregate.Text = "Аггрегация";
            this.button_aggregate.UseVisualStyleBackColor = false;
            this.button_aggregate.Click += new System.EventHandler(this.button_aggregate_Click);
            // 
            // richTextBox_networks
            // 
            this.richTextBox_networks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_networks.Location = new System.Drawing.Point(904, 87);
            this.richTextBox_networks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_networks.Name = "richTextBox_networks";
            this.richTextBox_networks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_networks.Size = new System.Drawing.Size(423, 198);
            this.richTextBox_networks.TabIndex = 27;
            this.richTextBox_networks.Text = "2001:DB8:1234:ABA2::/64\n2001:DB8:1234:ABC3::/64";
            // 
            // comboBox_prefix_subnets
            // 
            this.comboBox_prefix_subnets.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_prefix_subnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_prefix_subnets.ForeColor = System.Drawing.Color.Green;
            this.comboBox_prefix_subnets.Location = new System.Drawing.Point(339, 634);
            this.comboBox_prefix_subnets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_prefix_subnets.Name = "comboBox_prefix_subnets";
            this.comboBox_prefix_subnets.Size = new System.Drawing.Size(80, 37);
            this.comboBox_prefix_subnets.TabIndex = 29;
            this.comboBox_prefix_subnets.Text = "8";
            // 
            // button_divide2
            // 
            this.button_divide2.BackColor = System.Drawing.Color.ForestGreen;
            this.button_divide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_divide2.Location = new System.Drawing.Point(451, 635);
            this.button_divide2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_divide2.Name = "button_divide2";
            this.button_divide2.Size = new System.Drawing.Size(208, 38);
            this.button_divide2.TabIndex = 30;
            this.button_divide2.Text = "Разделить";
            this.button_divide2.UseVisualStyleBackColor = false;
            this.button_divide2.Click += new System.EventHandler(this.button_divide2_Click);
            // 
            // textBox_network
            // 
            this.textBox_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_network.Location = new System.Drawing.Point(799, 386);
            this.textBox_network.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_network.Name = "textBox_network";
            this.textBox_network.Size = new System.Drawing.Size(528, 34);
            this.textBox_network.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(57, 582);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "По количеству";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(57, 639);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "По префиксу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1355, 937);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_network);
            this.Controls.Add(this.button_divide2);
            this.Controls.Add(this.comboBox_prefix_subnets);
            this.Controls.Add(this.button_aggregate);
            this.Controls.Add(this.richTextBox_networks);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_subnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_range_b);
            this.Controls.Add(this.label_range_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_prefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_expanded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_compressed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_mask);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.textBox_ip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1594, 1220);
            this.MinimumSize = new System.Drawing.Size(1061, 974);
            this.Name = "Form1";
            this.Text = "IP калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_mask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_compressed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_expanded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_prefix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_status;
        protected internal System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_range_a;
        private System.Windows.Forms.Label label_range_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_subnet;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Button button_aggregate;
        private System.Windows.Forms.RichTextBox richTextBox_networks;
        protected internal System.Windows.Forms.ComboBox comboBox_prefix_subnets;
        private System.Windows.Forms.Button button_divide2;
        private System.Windows.Forms.TextBox textBox_network;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

