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
            this.label_submask = new System.Windows.Forms.Label();
            this.label_submask_value = new System.Windows.Forms.Label();
            this.label_net = new System.Windows.Forms.Label();
            this.label_net_value = new System.Windows.Forms.Label();
            this.label_broad = new System.Windows.Forms.Label();
            this.label_broad_value = new System.Windows.Forms.Label();
            this.label_hosts = new System.Windows.Forms.Label();
            this.label_hosts_value = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_class_value = new System.Windows.Forms.Label();
            this.label_local = new System.Windows.Forms.Label();
            this.label_local_value = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ipvMode = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.button_ipvMode6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox_sizes = new System.Windows.Forms.TextBox();
            this.button_subnetting = new System.Windows.Forms.Button();
            this.richTextBox_networks = new System.Windows.Forms.RichTextBox();
            this.button_aggregate = new System.Windows.Forms.Button();
            this.textBox_network = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_ip
            // 
            this.textBox_ip.BackColor = System.Drawing.Color.LightGray;
            this.textBox_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ip.ForeColor = System.Drawing.Color.Green;
            this.textBox_ip.Location = new System.Drawing.Point(92, 106);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(455, 34);
            this.textBox_ip.TabIndex = 2;
            this.textBox_ip.Text = "51.159.210.136";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.BackColor = System.Drawing.Color.Transparent;
            this.label_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ip.ForeColor = System.Drawing.Color.Green;
            this.label_ip.Location = new System.Drawing.Point(87, 53);
            this.label_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(142, 29);
            this.label_ip.TabIndex = 3;
            this.label_ip.Text = "IPv4 адрес";
            // 
            // label_mask
            // 
            this.label_mask.AutoSize = true;
            this.label_mask.BackColor = System.Drawing.Color.Transparent;
            this.label_mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mask.ForeColor = System.Drawing.Color.Green;
            this.label_mask.Location = new System.Drawing.Point(595, 53);
            this.label_mask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mask.Name = "label_mask";
            this.label_mask.Size = new System.Drawing.Size(88, 29);
            this.label_mask.TabIndex = 4;
            this.label_mask.Text = "Маска";
            // 
            // label_submask
            // 
            this.label_submask.AutoSize = true;
            this.label_submask.BackColor = System.Drawing.Color.Transparent;
            this.label_submask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_submask.ForeColor = System.Drawing.Color.Green;
            this.label_submask.Location = new System.Drawing.Point(88, 181);
            this.label_submask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_submask.Name = "label_submask";
            this.label_submask.Size = new System.Drawing.Size(185, 29);
            this.label_submask.TabIndex = 5;
            this.label_submask.Text = "Маска подсети";
            // 
            // label_submask_value
            // 
            this.label_submask_value.AutoSize = true;
            this.label_submask_value.BackColor = System.Drawing.Color.Transparent;
            this.label_submask_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_submask_value.ForeColor = System.Drawing.Color.Ivory;
            this.label_submask_value.Location = new System.Drawing.Point(595, 181);
            this.label_submask_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_submask_value.Name = "label_submask_value";
            this.label_submask_value.Size = new System.Drawing.Size(161, 29);
            this.label_submask_value.TabIndex = 6;
            this.label_submask_value.Text = "255.255.255.0";
            // 
            // label_net
            // 
            this.label_net.AutoSize = true;
            this.label_net.BackColor = System.Drawing.Color.Transparent;
            this.label_net.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_net.ForeColor = System.Drawing.Color.Green;
            this.label_net.Location = new System.Drawing.Point(88, 247);
            this.label_net.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_net.Name = "label_net";
            this.label_net.Size = new System.Drawing.Size(167, 29);
            this.label_net.TabIndex = 7;
            this.label_net.Text = "IP адрес сети";
            // 
            // label_net_value
            // 
            this.label_net_value.AutoSize = true;
            this.label_net_value.BackColor = System.Drawing.Color.Transparent;
            this.label_net_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_net_value.ForeColor = System.Drawing.Color.Transparent;
            this.label_net_value.Location = new System.Drawing.Point(595, 247);
            this.label_net_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_net_value.Name = "label_net_value";
            this.label_net_value.Size = new System.Drawing.Size(135, 29);
            this.label_net_value.TabIndex = 8;
            this.label_net_value.Text = "95.189.76.0";
            // 
            // label_broad
            // 
            this.label_broad.AutoSize = true;
            this.label_broad.BackColor = System.Drawing.Color.Transparent;
            this.label_broad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_broad.ForeColor = System.Drawing.Color.Green;
            this.label_broad.Location = new System.Drawing.Point(88, 311);
            this.label_broad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_broad.Name = "label_broad";
            this.label_broad.Size = new System.Drawing.Size(336, 29);
            this.label_broad.TabIndex = 9;
            this.label_broad.Text = "Широковещательный адрес";
            // 
            // label_broad_value
            // 
            this.label_broad_value.AutoSize = true;
            this.label_broad_value.BackColor = System.Drawing.Color.Transparent;
            this.label_broad_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_broad_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_broad_value.Location = new System.Drawing.Point(595, 311);
            this.label_broad_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_broad_value.Name = "label_broad_value";
            this.label_broad_value.Size = new System.Drawing.Size(161, 29);
            this.label_broad_value.TabIndex = 10;
            this.label_broad_value.Text = "95.189.76.255";
            // 
            // label_hosts
            // 
            this.label_hosts.AutoSize = true;
            this.label_hosts.BackColor = System.Drawing.Color.Transparent;
            this.label_hosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hosts.ForeColor = System.Drawing.Color.Green;
            this.label_hosts.Location = new System.Drawing.Point(87, 377);
            this.label_hosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hosts.Name = "label_hosts";
            this.label_hosts.Size = new System.Drawing.Size(410, 29);
            this.label_hosts.TabIndex = 11;
            this.label_hosts.Text = "Максимальное количество хостов";
            // 
            // label_hosts_value
            // 
            this.label_hosts_value.AutoSize = true;
            this.label_hosts_value.BackColor = System.Drawing.Color.Transparent;
            this.label_hosts_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hosts_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_hosts_value.Location = new System.Drawing.Point(595, 377);
            this.label_hosts_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hosts_value.Name = "label_hosts_value";
            this.label_hosts_value.Size = new System.Drawing.Size(52, 29);
            this.label_hosts_value.TabIndex = 12;
            this.label_hosts_value.Text = "254";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.BackColor = System.Drawing.Color.Transparent;
            this.label_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_class.ForeColor = System.Drawing.Color.Green;
            this.label_class.Location = new System.Drawing.Point(88, 442);
            this.label_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(167, 29);
            this.label_class.TabIndex = 13;
            this.label_class.Text = "Класс адреса";
            // 
            // label_class_value
            // 
            this.label_class_value.AutoSize = true;
            this.label_class_value.BackColor = System.Drawing.Color.Transparent;
            this.label_class_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_class_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_class_value.Location = new System.Drawing.Point(595, 442);
            this.label_class_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_class_value.Name = "label_class_value";
            this.label_class_value.Size = new System.Drawing.Size(28, 29);
            this.label_class_value.TabIndex = 14;
            this.label_class_value.Text = "A";
            // 
            // label_local
            // 
            this.label_local.AutoSize = true;
            this.label_local.BackColor = System.Drawing.Color.Transparent;
            this.label_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_local.ForeColor = System.Drawing.Color.Green;
            this.label_local.Location = new System.Drawing.Point(88, 507);
            this.label_local.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_local.Name = "label_local";
            this.label_local.Size = new System.Drawing.Size(291, 29);
            this.label_local.TabIndex = 15;
            this.label_local.Text = "Локальный/глобальный";
            // 
            // label_local_value
            // 
            this.label_local_value.AutoSize = true;
            this.label_local_value.BackColor = System.Drawing.Color.Transparent;
            this.label_local_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_local_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_local_value.Location = new System.Drawing.Point(595, 507);
            this.label_local_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_local_value.Name = "label_local_value";
            this.label_local_value.Size = new System.Drawing.Size(158, 29);
            this.label_local_value.TabIndex = 16;
            this.label_local_value.Text = "Глобальный";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.DisplayMember = "24";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Green;
            this.comboBox1.Location = new System.Drawing.Point(600, 106);
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
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(741, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ipvMode
            // 
            this.button_ipvMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ipvMode.ForeColor = System.Drawing.Color.Green;
            this.button_ipvMode.Location = new System.Drawing.Point(741, 48);
            this.button_ipvMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ipvMode.Name = "button_ipvMode";
            this.button_ipvMode.Size = new System.Drawing.Size(93, 38);
            this.button_ipvMode.TabIndex = 5;
            this.button_ipvMode.Text = "IPv4";
            this.button_ipvMode.UseVisualStyleBackColor = true;
            this.button_ipvMode.Click += new System.EventHandler(this.button_ipvMode_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_status.Location = new System.Drawing.Point(87, 181);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 29);
            this.label_status.TabIndex = 17;
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ipvMode6
            // 
            this.button_ipvMode6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ipvMode6.ForeColor = System.Drawing.Color.Green;
            this.button_ipvMode6.Location = new System.Drawing.Point(852, 48);
            this.button_ipvMode6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ipvMode6.Name = "button_ipvMode6";
            this.button_ipvMode6.Size = new System.Drawing.Size(93, 38);
            this.button_ipvMode6.TabIndex = 18;
            this.button_ipvMode6.Text = "IPv6";
            this.button_ipvMode6.UseVisualStyleBackColor = true;
            this.button_ipvMode6.Click += new System.EventHandler(this.button_ipvMode6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(92, 642);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(711, 280);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(780, 181);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(10, 10);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // textBox_sizes
            // 
            this.textBox_sizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sizes.Location = new System.Drawing.Point(93, 577);
            this.textBox_sizes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_sizes.Name = "textBox_sizes";
            this.textBox_sizes.Size = new System.Drawing.Size(455, 34);
            this.textBox_sizes.TabIndex = 21;
            // 
            // button_subnetting
            // 
            this.button_subnetting.BackColor = System.Drawing.Color.ForestGreen;
            this.button_subnetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subnetting.ForeColor = System.Drawing.Color.White;
            this.button_subnetting.Location = new System.Drawing.Point(600, 575);
            this.button_subnetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_subnetting.Name = "button_subnetting";
            this.button_subnetting.Size = new System.Drawing.Size(204, 38);
            this.button_subnetting.TabIndex = 22;
            this.button_subnetting.Text = "Рассчитать";
            this.button_subnetting.UseVisualStyleBackColor = false;
            this.button_subnetting.Click += new System.EventHandler(this.button_subnetting_Click);
            // 
            // richTextBox_networks
            // 
            this.richTextBox_networks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_networks.Location = new System.Drawing.Point(970, 29);
            this.richTextBox_networks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_networks.Name = "richTextBox_networks";
            this.richTextBox_networks.Size = new System.Drawing.Size(433, 280);
            this.richTextBox_networks.TabIndex = 23;
            this.richTextBox_networks.Text = "192.168.2.5/23\n192.168.128.6/16\n192.168.2.1/23\n192.168.128.6/10\n\n";
            // 
            // button_aggregate
            // 
            this.button_aggregate.BackColor = System.Drawing.Color.ForestGreen;
            this.button_aggregate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aggregate.ForeColor = System.Drawing.Color.White;
            this.button_aggregate.Location = new System.Drawing.Point(1084, 340);
            this.button_aggregate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_aggregate.Name = "button_aggregate";
            this.button_aggregate.Size = new System.Drawing.Size(204, 38);
            this.button_aggregate.TabIndex = 24;
            this.button_aggregate.Text = "Рассчитать";
            this.button_aggregate.UseVisualStyleBackColor = false;
            this.button_aggregate.Click += new System.EventHandler(this.button_aggregate_Click);
            // 
            // textBox_network
            // 
            this.textBox_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_network.Location = new System.Drawing.Point(970, 414);
            this.textBox_network.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_network.Name = "textBox_network";
            this.textBox_network.Size = new System.Drawing.Size(433, 34);
            this.textBox_network.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1474, 965);
            this.Controls.Add(this.textBox_network);
            this.Controls.Add(this.button_aggregate);
            this.Controls.Add(this.richTextBox_networks);
            this.Controls.Add(this.button_subnetting);
            this.Controls.Add(this.textBox_sizes);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_ipvMode6);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_ipvMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_local_value);
            this.Controls.Add(this.label_local);
            this.Controls.Add(this.label_class_value);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_hosts_value);
            this.Controls.Add(this.label_hosts);
            this.Controls.Add(this.label_broad_value);
            this.Controls.Add(this.label_broad);
            this.Controls.Add(this.label_net_value);
            this.Controls.Add(this.label_net);
            this.Controls.Add(this.label_submask_value);
            this.Controls.Add(this.label_submask);
            this.Controls.Add(this.label_mask);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.textBox_ip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1594, 1220);
            this.MinimumSize = new System.Drawing.Size(1061, 635);
            this.Name = "Form1";
            this.Text = "IP калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_mask;
        private System.Windows.Forms.Label label_submask;
        private System.Windows.Forms.Label label_submask_value;
        private System.Windows.Forms.Label label_net;
        private System.Windows.Forms.Label label_net_value;
        private System.Windows.Forms.Label label_broad;
        private System.Windows.Forms.Label label_broad_value;
        private System.Windows.Forms.Label label_hosts;
        private System.Windows.Forms.Label label_hosts_value;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_class_value;
        private System.Windows.Forms.Label label_local;
        private System.Windows.Forms.Label label_local_value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ipvMode;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_ipvMode6;
        protected internal System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox_sizes;
        private System.Windows.Forms.Button button_subnetting;
        private System.Windows.Forms.RichTextBox richTextBox_networks;
        private System.Windows.Forms.Button button_aggregate;
        private System.Windows.Forms.TextBox textBox_network;
    }
}

