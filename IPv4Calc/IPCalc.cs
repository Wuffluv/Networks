using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Collections.Generic; 


class Subnet
{
    public string Name { get; set; }
    public int Hosts { get; set; }
}

class IPCalculator
{
    private string ip;
    private int mask;

    public IPCalculator(string ip, int mask)
    {
        this.ip = ip;
        this.mask = mask;
    }

    private string DecimalToBinary(int decimalNumber)
    {
        string binary = string.Empty;
        while (decimalNumber > 0)
        {
            binary = (decimalNumber % 2) + binary;
            decimalNumber /= 2;
        }
        return binary;
    }



    public string NetworkAddress()
    {
        string ipAddress = ip;
        int maskBits = mask;
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

    public string SubnetMask()
    {
        int[] subnetMaskOctets = new int[4];

        for (int i = 0; i < mask; i++)
        {
            subnetMaskOctets[i / 8] |= 1 << (7 - (i % 8));
        }

        string subnetMask = string.Join(".", subnetMaskOctets);
        return subnetMask;
    }

    public string BroadcastAddress()
    {
        string ipAddress = ip;
        int maskBits = mask;
        int[] ipOctets = ipAddress.Split('.').Select(int.Parse).ToArray();

        int[] maskOctets = new int[4];
        for (int i = 0; i < maskBits; i++)
        {
            maskOctets[i / 8] |= 1 << (7 - (i % 8));
        }

        int[] invertedMaskOctets = new int[4];
        for (int i = 0; i < 4; i++)
        {
            int invertedOctet = ~maskOctets[i] & 0xFF;
            invertedMaskOctets[i] = invertedOctet;
        }

        int[] broadcastAddressOctets = new int[4];
        for (int i = 0; i < 4; i++)
        {
            int broadcastOctet = ipOctets[i] | invertedMaskOctets[i];
            broadcastAddressOctets[i] = broadcastOctet;
        }

        string broadcastAddress = string.Join(".", broadcastAddressOctets);
        return broadcastAddress;
    }

    public int NumberOfHosts()
    {
        int maskBits = mask;
        int numberOfHosts;
        if (maskBits < 31)
            numberOfHosts = (1 << (32 - maskBits)) - 2;
        else numberOfHosts = 0;
        return numberOfHosts;
    }

    public char AddressClass()
    {
        string ipAddress = ip;
        int firstOctet = int.Parse(ipAddress.Substring(0, ipAddress.IndexOf('.')));

        if (firstOctet >= 1 && firstOctet <= 126)
        {
            return 'A';
        }
        else if (firstOctet >= 128 && firstOctet <= 191)
        {
            return 'B';
        }
        else if (firstOctet >= 192 && firstOctet <= 223)
        {
            return 'C';
        }
        else if (firstOctet >= 224 && firstOctet <= 239)
        {
            return 'D';
        }
        else
        {
            return 'E';
        }
    }

    public bool IsLocal()
    {
        string ipAddress = ip;
        // Проверка диапазонов локальных IP-адресов
        if (ipAddress.StartsWith("10.") ||
            ipAddress.StartsWith("192.") ||
            (ipAddress.StartsWith("172.") && ipAddress[4] >= '6' && ipAddress[4] <= '9'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string IpToBinary(string ip)
    {
        // Разделение IP адреса на октеты
        string[] octets = ip.Split('.');

        // Преобразование каждого октета в двоичное представление и объединение их в строку
        string binaryIp = string.Join(".", octets
            .Select(octet => Convert.ToString(int.Parse(octet), 2).PadLeft(8, '0')));

        return binaryIp;
    }


    public string SubnetMaskToBinary(string mask)
    {
        // Разделение маски подсети на октеты
        string[] octets = mask.Split('.');

        // Проверка каждого октета на допустимое значение
        foreach (string octet in octets)
        {
            if (!int.TryParse(octet, out int value) || value < 0 || value > 255)
            {
                throw new ArgumentException("Недопустимое значение маски подсети.");
            }
        }

        // Преобразование каждого октета в двоичное представление и объединение их в строку
        string binarySubnetMask = string.Join(".", octets
            .Select(octet => Convert.ToString(int.Parse(octet), 2).PadLeft(8, '0')));

        return binarySubnetMask;
    }


    public string CalculateNetworkAddress(string ip, string mask)
    {
        // Разделение IP адреса и маски подсети на отдельные части
        string[] ipParts = ip.Split('.');
        string[] subnetParts = mask.Split('.');

        // Вычисление сетевого адреса
        int[] networkAddressParts = new int[4];
        for (int i = 0; i < 4; i++)
        {
            networkAddressParts[i] = int.Parse(ipParts[i]) & int.Parse(subnetParts[i]);
        }

        // Преобразование массива чисел в строку IP адреса
        string networkAddress = string.Join(".", networkAddressParts);

        return networkAddress;
    }

    public string CalculateBroadcastAddress(string ip, string mask)
    {
        // Разделение IP адреса и маски подсети на отдельные части
        string[] ipParts = ip.Split('.');
        string[] subnetParts = mask.Split('.');

        // Вычисление широковещательного адреса
        int[] broadcastAddressParts = new int[4];
        for (int i = 0; i < 4; i++)
        {
            broadcastAddressParts[i] = int.Parse(ipParts[i]) | (int.Parse(subnetParts[i]) ^ 255);
        }

        // Преобразование массива чисел в строку IP адреса
        string broadcastAddress = string.Join(".", broadcastAddressParts);

        return broadcastAddress;
    }

    public int CalculateAvailableHosts(string ip, string mask)
    {
        // Проверка на маску подсети 255.255.255.255
        if (mask == "255.255.255.255")
        {
            return 0;
        }

        // Разделение маски подсети на отдельные части
        string[] subnetParts = mask.Split('.');

        // Вычисление числа единиц в обратной маске подсети
        int numOnes = 0;
        foreach (string part in subnetParts)
        {
            string binaryPart = Convert.ToString(int.Parse(part), 2);
            numOnes += binaryPart.Split('1').Length - 1;
        }

        // Вычисление числа доступных хостов
        int availableHosts = (int)Math.Pow(2, 32 - numOnes) - 2;

        return availableHosts;
    }

    public string CalculateMinimumHost(string ip, string mask)
    {
        // Разделение сетевого адреса на отдельные части
        string[] networkParts = CalculateNetworkAddress(ip, mask).Split('.');

        // Увеличение последнего октета сетевого адреса на 1
        networkParts[3] = (int.Parse(networkParts[3]) + 1).ToString();

        // Преобразование массива чисел в строку IP адреса
        string minHost = string.Join(".", networkParts);

        return minHost;
    }

    public string CalculateMaximumHost(string ip, string mask)
    {
        // Разделение широковещательного адреса на отдельные части
        string[] broadcastParts = CalculateBroadcastAddress(ip, mask).Split('.');

        // Уменьшение последнего октета широковещательного адреса на 1
        broadcastParts[3] = (int.Parse(broadcastParts[3]) - 1).ToString();

        // Преобразование массива чисел в строку IP адреса
        string maxHost = string.Join(".", broadcastParts);

        return maxHost;
    }

    public int nextNumPow2(int num)
    {
        if (num <= 0) return 1;

        int result = 1;
        while (result < num)
        {
            result *= 2;
        }
        return result;
    }


    public string CalculateVLSM(int[] subnets)
    {
        string mask = SubnetMask();
        // Разбиваем доступные хосты на подсети
        int remainingHosts = CalculateAvailableHosts(ip, SubnetMask()) + 2; // +2 для сетевого и широковещательного адреса
        string[] currentAddress = CalculateNetworkAddress(ip, mask).Split('.');
        string subnetInfo = "Информация о подсетях:" + Environment.NewLine;

        int hostSum = 0;
        foreach (var subnet in subnets)
        {
            hostSum += nextNumPow2(subnet + 2);
        }
        int maxHosts = (int)Math.Pow(2, 32 - this.mask) - 2;
        if (hostSum > maxHosts) return "Не хватает адресов";

        int n = 0;
        foreach (var subnet in subnets)
        {
            n++;
            int subnetHosts = subnet + 2; // +2 для сетевого и широковещательного адреса
                                          // Проверяем, не превышает ли количество хостов в данной подсети оставшееся количество доступных хостов
            //if (subnetHosts > remainingHosts)
            //{
            //    throw new Exception($"Недостаточно хостов для подсети '{subnet}'");
            //}

            int subnetMask = 32 - (int)Math.Ceiling(Math.Log(subnetHosts, 2));
            string subnetMaskBinary = string.Join(".", Enumerable.Range(0, 4)
                .Select(i => string.Concat(Enumerable.Repeat('1', Math.Min(subnetMask - i * 8, 8)))
                    .PadRight(8, '0')));

            currentAddress[3] = Convert.ToString(Convert.ToInt32(currentAddress[3]) + 1);
            // Рассчитываем сетевой адрес для новой подсети
            string networkAddress = string.Join(".", currentAddress); // Используем текущий адрес в качестве адреса сети

            // Рассчитываем диапазон подсети, исключая сетевой и широковещательный адреса
            string[] subnetStart = currentAddress.ToArray();
            subnetStart[3] = n == 1 ? "1" : (int.Parse(subnetStart[3]) + 1).ToString(); // Адрес начинается сразу после сетевого адреса
            string[] subnetEnd = subnetStart.ToArray();
            subnetEnd[3] = (int.Parse(subnetEnd[3]) + (int)Math.Pow(2, 8 - (subnetMask % 8)) - 3).ToString(); // Диапазон на 2 меньше
            string usableRange = $"{string.Join(".", subnetStart)} - {string.Join(".", subnetEnd)}";

            // Рассчитываем адрес следующей подсети
            string[] nextSubnetAddress = subnetEnd.ToArray();
            nextSubnetAddress[3] = (int.Parse(nextSubnetAddress[3]) + 1).ToString();

            // Рассчитываем широковещательный адрес
            string[] broadcastAddress = subnetEnd.ToArray();
            broadcastAddress[3] = (int.Parse(broadcastAddress[3]) + 1).ToString();

            // Добавляем информацию о подсети
            subnetInfo += "Требуемый размер : " + subnet + "+2" + Environment.NewLine;
            subnetInfo += "Выделено адресов : " + nextNumPow2(subnet + 2) + Environment.NewLine;
            subnetInfo += "Адрес подсети: " + networkAddress + Environment.NewLine;
            subnetInfo += "Префикс маски: " + subnetMask + Environment.NewLine;
            subnetInfo += "Диапазон адресов " + usableRange + Environment.NewLine;
            subnetInfo += "Широковещательный адрес: " + string.Join(".", broadcastAddress) + Environment.NewLine;

            // Обновляем текущий адрес для следующей подсети
            currentAddress = nextSubnetAddress;
            // Обновляем количество оставшихся хостов
            remainingHosts -= subnetHosts;
            subnetInfo += Environment.NewLine;
        }
        
        return subnetInfo;
    }

    public string AggregateNetworks(string[] networks)
    {
        if (networks == null || networks.Length == 0)
            return "";

        // преобразование IP-адреса и маски в двоичный формат
        string ToBinary(string ip)
        {
            return string.Join("", ip.Split('.').Select(part => Convert.ToString(byte.Parse(part), 2).PadLeft(8, '0')));
        }

        // преобразование адресов в двоичное представление
        string[] binaryStrings = networks.Select(network =>
        {
            string[] octets_ = network.Split('/');
            if (octets_.Length != 2)
                throw new ArgumentException("Invalid network address: " + network);

            return ToBinary(octets_[0]).Substring(0, int.Parse(octets_[1]));
        }).ToArray();

        // Нахождение наибольшего общего префикса
        int prefixLength = 0;
        for (int i = 0; i < binaryStrings[0].Length; i++)
        {
            char currentBit = binaryStrings[0][i];
            bool allSame = binaryStrings.All(binary => i < binary.Length && binary[i] == currentBit); // Добавлено условие i < binary.Length
            if (allSame)
                prefixLength++;
            else
                break;
        }


        // Формирование суммированного адреса
        string summarizedNetwork = binaryStrings[0].Substring(0, prefixLength).PadRight(32, '0');
        int[] octets = Enumerable.Range(0, 4)
            .Select(i => Convert.ToInt32(summarizedNetwork.Substring(i * 8, 8), 2))
            .ToArray();
        string aggregatedNetwork = string.Join(".", octets) + "/" + prefixLength;

        return aggregatedNetwork;
    }

    // Преобразование IP-адреса в целое число
    private static long IPAddressToInt(string ipAddress)
    {
        var ipParts = ipAddress.Split('.');
        return (long.Parse(ipParts[0]) << 24) +
               (long.Parse(ipParts[1]) << 16) +
               (long.Parse(ipParts[2]) << 8) +
               long.Parse(ipParts[3]);
    }

    public bool IsReserved()
    {
        string ipAddress = ip;
        // Регулярное выражение для проверки IP-адреса
        Regex reservedPattern = new Regex(@"^(127\.(?:\d{1,3}\.){1,3}\d{1,3})|^(169\.254\.\d{1,3}\.\d{1,3})|^(192\.0\.2\.\d{1,3})");

        // Проверка соответствия IP-адреса регулярному выражению
        return reservedPattern.IsMatch(ipAddress);
    }
}