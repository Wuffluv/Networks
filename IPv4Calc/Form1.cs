using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsForms_IPCalc
{
    public partial class Form1 : Form
    {
        bool isipv4;
        public Form1()
        {
            InitializeComponent();
            button_ipvMode.Enabled = false;
            isipv4 = true;
            // Добавляем элементы в ComboBox в цикле
            for (int i = 1; i < 33; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 23;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        static bool IsValidIPAddress(string ipAddress)
        {
            if (ipAddress.Length > 15) return false;
            IPAddress address;
            bool isValid = IPAddress.TryParse(ipAddress, out address);
            return isValid;
        }

        static bool IsValidIPv6Address(string ipv6Address)
        {
            IPAddress address;
            if (IPAddress.TryParse(ipv6Address, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool IsValidIPv6Mask(int mask)
        {
            if (mask >= 1 && mask <= 128)
                return true;
            else return false;
        }

        static bool IsValidMask(int mask)
        {
            if (mask >= 0 && mask <= 32)
                return true;
            else return false;
        }

        static string IsInRange(string ipAddress)
        {
            string[] ipParts = ipAddress.Split('.');
            string firstPart = ipParts[0];

            if (firstPart == "0")
                return "null";

            if (firstPart == "127")
                return "loopback";

            if (ipAddress == "255.255.255.255")
                return "brcast";

            return "regular";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (isipv4 == true)
                {
                    int count = 0;

                    textBox_ip.BackColor = Color.White;
                    comboBox1.BackColor = Color.White;

                    if (!IsValidIPAddress(textBox_ip.Text))
                    {
                        count++;
                        textBox_ip.BackColor = Color.LightCoral;
                    }
                    if (!IsValidMask(Int32.Parse(comboBox1.Text)))
                    {
                        count++;
                        comboBox1.BackColor = Color.LightCoral;
                    }

                    if (count == 0)
                    {
                        string str = IsInRange(textBox_ip.Text);

                        if (str == "regular")
                        {
                            label_submask.Visible = true;
                            label_net.Visible = true;
                            label_broad.Visible = true;
                            label_hosts.Visible = true;
                            label_class.Visible = true;
                            label_local.Visible = true;

                            label_submask_value.Visible = true;
                            label_net_value.Visible = true;
                            label_broad_value.Visible = true;
                            label_hosts_value.Visible = true;
                            label_class_value.Visible = true;
                            label_local_value.Visible = true;

                            label_status.Visible = false;

                            IPCalculator calculator = new IPCalculator(textBox_ip.Text, Int32.Parse(comboBox1.Text));

                            label_submask_value.Text = calculator.SubnetMask();
                            label_submask.Text = "Маска подсети";
                            label_net_value.Text = calculator.NetworkAddress();
                            label_net.Text = "IP адрес сети";
                            label_broad_value.Text = calculator.BroadcastAddress();
                            label_broad.Text = "Широковещательный адрес";
                            label_hosts_value.Text = calculator.NumberOfHosts().ToString();
                            label_hosts.Text = "Максимальное количество хостов";
                            label_class_value.Text = calculator.AddressClass().ToString();
                            label_class.Text = "Класс адреса";
                            label_local.Text = "Локальный/глобальный";
                            if (calculator.IsLocal())
                                label_local_value.Text = "Локальный";
                            else label_local_value.Text = "Глобальный";
                        }
                        else if (str == "null")
                        {
                            label_submask.Visible = false;
                            label_net.Visible = false;
                            label_broad.Visible = false;
                            label_hosts.Visible = false;
                            label_class.Visible = false;
                            label_local.Visible = false;

                            label_submask_value.Visible = false;
                            label_net_value.Visible = false;
                            label_broad_value.Visible = false;
                            label_hosts_value.Visible = false;
                            label_class_value.Visible = false;
                            label_local_value.Visible = false;

                            label_status.Visible = true;
                            label_status.Text = "Адрес " + textBox_ip.Text + "/" + comboBox1.Text + " является нулевым!";
                        }
                        else if (str == "loopback")
                        {
                            label_submask.Visible = false;
                            label_net.Visible = false;
                            label_broad.Visible = false;
                            label_hosts.Visible = false;
                            label_class.Visible = false;
                            label_local.Visible = false;

                            label_submask_value.Visible = false;
                            label_net_value.Visible = false;
                            label_broad_value.Visible = false;
                            label_hosts_value.Visible = false;
                            label_class_value.Visible = false;
                            label_local_value.Visible = false;

                            label_status.Visible = true;
                            label_status.Text = "Адрес " + textBox_ip.Text + "/" + comboBox1.Text + " является Loopback адресом!";
                        }
                        else if (str == "brcast")
                        {
                            label_submask.Visible = false;
                            label_net.Visible = false;
                            label_broad.Visible = false;
                            label_hosts.Visible = false;
                            label_class.Visible = false;
                            label_local.Visible = false;

                            label_submask_value.Visible = false;
                            label_net_value.Visible = false;
                            label_broad_value.Visible = false;
                            label_hosts_value.Visible = false;
                            label_class_value.Visible = false;
                            label_local_value.Visible = false;

                            label_status.Visible = true;
                            label_status.Text = "Адрес " + textBox_ip.Text + "/" + comboBox1.Text + " является широковещательным!";
                        }
                        count = 0;
                    }
                }
                else if (isipv4 == false)
                {
                    int count = 0;
                    textBox_ip.BackColor = Color.White;
                    comboBox1.BackColor = Color.White;

                    if (!IsValidIPv6Address(textBox_ip.Text))
                    {
                        count++;
                        textBox_ip.BackColor = Color.LightCoral;
                    }
                    if (!IsValidIPv6Mask(Int32.Parse(comboBox1.Text)))
                    {
                        count++;
                        comboBox1.BackColor = Color.LightCoral;
                    }

                    if (count == 0)
                    {
                        IPv6Calculator calculator = new IPv6Calculator(textBox_ip.Text, Int32.Parse(comboBox1.Text));

                        label_submask_value.Text = calculator.SubnetMask().ToLower();
                        label_submask.Text = "Маска префикса";
                        label_net_value.Text = calculator.NetworkAddress().ToLower();
                        label_net.Text = "IP адрес сети";
                        label_broad_value.Text = calculator.BroadcastAddress().ToLower();
                        label_broad.Text = "Широковещательный адрес";
                        label_hosts_value.Text = "";
                        label_hosts.Text = "";
                        label_class_value.Text = "";
                        label_class.Text = "";

                        label_local.Text = "";
                        label_local_value.Text = "";
                        //if (calculator.IsLocal())
                        //    label_local_value.Text = "Локальный";
                        //else label_local_value.Text = "Глобальный";
                    }
                }

            }

        }

        private void button_ipvMode_Click(object sender, EventArgs e)
        {
            isipv4 = true;
            comboBox1.Items.Clear();
            label_mask.Text = "Маска";
            // Добавляем элементы в ComboBox в цикле
            for (int i = 0; i < 33; i++)
            {
                comboBox1.Items.Add(i);
            }

            label_submask_value.Text = "";
            label_submask.Text = "Маска подсети";
            label_net_value.Text = "";
            label_net.Text = "IP адрес сети";
            label_broad_value.Text = "";
            label_broad.Text = "Широковещательный адрес";
            label_hosts_value.Text = "";
            label_hosts.Text = "Максимальное количество хостов";
            label_class_value.Text = "";
            label_class.Text = "Класс адреса";
            label_local.Text = "Локальный/глобальный";

                label_local_value.Text = "";

            //label_submask.Visible = true;
            //label_net.Visible = true;
            //label_broad.Visible = true;
            //label_hosts.Visible = true;
            //label_class.Visible = true;
            //label_local.Visible = true;

            //label_submask_value.Visible = true;
            //label_net_value.Visible = true;
            //label_broad_value.Visible = true;
            //label_hosts_value.Visible = true;
            //label_class_value.Visible = true;
            //label_local_value.Visible = true;

            label_ip.Text = "IPv4 адрес";
                button_ipvMode.Enabled = false;
                button_ipvMode6.Enabled = true;
        }

        private void button_ipvMode6_Click(object sender, EventArgs e)
        {
            //isipv4 = false;
            //comboBox1.Items.Clear();
            //// Добавляем элементы в ComboBox в цикле
            //for (int i = 1; i < 129; i++)
            //{
            //    comboBox1.Items.Add(i);
            //}
            //label_mask.Text = "Префикс";
            //label_submask_value.Text = "";
            //label_submask.Text = "Маска префикса";
            //label_net_value.Text = "";
            //label_net.Text = "IP адрес сети";
            //label_broad_value.Text = "";
            //label_broad.Text = "Широковещательный адрес";
            //label_hosts_value.Text = "";
            //label_hosts.Text = "";
            //label_class_value.Text = "";
            //label_class.Text = "";

            //label_local.Text = "";
            //label_local_value.Text = "";
            ////label_submask.Visible = false;
            ////label_net.Visible = false;
            ////label_broad.Visible = false;
            ////label_hosts.Visible = false;
            ////label_class.Visible = false;
            ////label_local.Visible = false;

            ////label_submask_value.Visible = false;
            ////label_net_value.Visible = false;
            ////label_broad_value.Visible = false;
            ////label_hosts_value.Visible = false;
            ////label_class_value.Visible = false;
            ////label_local_value.Visible = false;

            //label_ip.Text = "IPv6 адрес";
            //    button_ipvMode6.Enabled = false;
            //    button_ipvMode.Enabled = true;
        }

        private void button_subnetting_Click(object sender, EventArgs e)
        {
            // Получаем размеры подсетей из текстового поля
            string[] subnetSizesStr = textBox_sizes.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] subnetSizes = Array.ConvertAll(subnetSizesStr, int.Parse);

            // Сортируем массив subnetSizes по убыванию
            Array.Sort(subnetSizes);
            Array.Reverse(subnetSizes);
            // Создаем экземпляр класса IPCalculator
            IPCalculator calculator = new IPCalculator(textBox_ip.Text, Int32.Parse(comboBox1.Text));

            // Вызываем метод CalculateSubnets для расчета подсетей
            string subnetInfo = calculator.CalculateVLSM(subnetSizes);

            // Выводим результат в RichTextBox
            richTextBox1.Text = subnetInfo;
        }

        public string[] SplitIpAndMask(string ipmask)
        {
            // Разделяем строку по символу '/'
            string[] parts = ipmask.Split('/');

            // Проверяем, что строка разделилась на две части
            if (parts.Length != 2)
            {
                throw new ArgumentException("Неверный формат IP-адреса и маски.");
            }

            // Первая часть - IP-адрес, вторая - маска
            string ipAddress = parts[0];
            string mask = parts[1];

            return new string[] { ipAddress, mask };
        }


        public string NetworkAddress(string ipmask)
        {
            string[] ipmask_ = SplitIpAndMask(ipmask);
            string ipAddress = ipmask_[0];
            int maskBits = Convert.ToInt32(ipmask_[1]);
            int[] ipOctets = ipAddress.Split('.').Select(int.Parse).ToArray();

            int[] maskOctets = new int[4];
            for (int i = 0; i < maskBits; i++)
            {
                maskOctets[i / 8] |= 1 << (7 - (i % 8));
            }

            int[] networkAddressOctets = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int networkOctet = ipOctets[i] & maskOctets[i];
                networkAddressOctets[i] = networkOctet;
            }

            string networkAddress = string.Join(".", networkAddressOctets);
            return networkAddress;
        }
        private void button_aggregate_Click(object sender, EventArgs e)
        {
            string[] networks = richTextBox_networks.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            IPCalculator calculator = new IPCalculator(textBox_ip.Text, Int32.Parse(comboBox1.Text));

            //for(int i = 0; i < networks.Length; i++)
            //{  
            //    networks[i] = NetworkAddress(networks[i]);
            //}
            string supernet = calculator.AggregateNetworks(networks);
           
            textBox_network.Text = supernet;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
