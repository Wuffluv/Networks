using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

public class IPv6Calculator
{
    private string ip;
    private int mask;

    public IPv6Calculator(string ip, int mask)
    {
        this.ip = ip;
        this.mask = mask;
    }

    public string NetworkAddress()
    {
        string ipAddress = ip;
        int maskBits = mask;
        string[] ipSegments = ipAddress.Split(':');
        int[] ipValues = new int[ipSegments.Length];

        for (int i = 0; i < ipSegments.Length; i++)
        {
            ipValues[i] = Convert.ToInt32(ipSegments[i], 16);
        }

        int[] maskSegments = new int[8];
        for (int i = 0; i < maskBits; i++)
        {
            maskSegments[i / 16] |= 1 << (15 - (i % 16));
        }

        int[] networkSegments = new int[8];
        for (int i = 0; i < 8; i++)
        {
            int networkSegment = ipValues[i] & maskSegments[i];
            networkSegments[i] = networkSegment;
        }

        string[] networkAddressSegments = new string[8];
        for (int i = 0; i < 8; i++)
        {
            networkAddressSegments[i] = networkSegments[i].ToString("X");
        }

        string networkAddress = string.Join(":", networkAddressSegments);
        return networkAddress;
    }

    public string SubnetMask()
    {
        int[] maskSegments = new int[8];

        for (int i = 0; i < mask; i++)
        {
            maskSegments[i / 16] |= 1 << (15 - (i % 16));
        }

        string[] subnetMaskSegments = new string[8];
        for (int i = 0; i < 8; i++)
        {
            subnetMaskSegments[i] = maskSegments[i].ToString("X");
        }

        string subnetMask = string.Join(":", subnetMaskSegments);
        return subnetMask;
    }

    public string BroadcastAddress()
    {
        string ipAddress = ip;
        int maskBits = mask;
        string[] ipSegments = ipAddress.Split(':');
        int[] ipValues = new int[ipSegments.Length];

        for (int i = 0; i < ipSegments.Length; i++)
        {
            ipValues[i] = Convert.ToInt32(ipSegments[i], 16);
        }

        int[] maskSegments = new int[8];
        for (int i = 0; i < maskBits; i++)
        {
            maskSegments[i / 16] |= 1 << (15 - (i % 16));
        }

        int[] invertedMaskSegments = new int[8];
        for (int i = 0; i < 8; i++)
        {
            int invertedSegment = ~maskSegments[i] & 0xFFFF;
            invertedMaskSegments[i] = invertedSegment;
        }

        int[] broadcastSegments = new int[8];
        for (int i = 0; i < 8; i++)
        {
            int broadcastSegment = ipValues[i] | invertedMaskSegments[i];
            broadcastSegments[i] = broadcastSegment;
        }

        string[] broadcastAddressSegments = new string[8];
        for (int i = 0; i < 8; i++)
        {
            broadcastAddressSegments[i] = broadcastSegments[i].ToString("X");
        }

        string broadcastAddress = string.Join(":", broadcastAddressSegments);
        return broadcastAddress;
    }

    public BigInteger NumberOfHosts()
    {
        int maskBits = mask;
        BigInteger numberOfHosts = BigInteger.Pow(2, 128 - maskBits) - 2;
        return numberOfHosts;
    }

    public bool IsLinkLocal()
    {
        string ipAddress = ip;
        // Проверка диапазона локальных IPv6-адресов
        return ipAddress.StartsWith("FE80:");
    }

    public bool IsSiteLocal()
    {
        string ipAddress = ip;
        // Проверка диапазона сайтовых локальных IPv6-адресов
        return ipAddress.StartsWith("FEC0:");
    }

    public bool IsMulticast()
    {
        string ipAddress = ip;
        // Проверка многоадресного IPv6-адреса
        return ipAddress.StartsWith("FF");
    }

    public bool IsIPv4Mapped()
    {
        string ipAddress = ip;
        // Проверка наличия префикса "::FFFF:"
        return ipAddress.StartsWith("::FFFF:");
    }
}