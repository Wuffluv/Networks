using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

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
        int numberOfHosts = (1 << (32 - maskBits)) - 2;
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

    public bool IsReserved()
    {
        string ipAddress = ip;
        // Регулярное выражение для проверки IP-адреса
        Regex reservedPattern = new Regex(@"^(127\.(?:\d{1,3}\.){1,3}\d{1,3})|^(169\.254\.\d{1,3}\.\d{1,3})|^(192\.0\.2\.\d{1,3})");

        // Проверка соответствия IP-адреса регулярному выражению
        return reservedPattern.IsMatch(ipAddress);
    }
}