using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;


public class IPv6Calculator
{
    private string ip; // адрес
    private int prefix;// префикс

    // проверка на корректность с помощью регулярного выражения
    public static bool IsValidIPv6Address(string address)
    {
        if (address == null)
        {
            //errmsg = "e0";
            return false;
        }

        address = address.Trim();
        string s = address;

        int nDC = 0;
        int nC = 0;

        /* 0. Error: Empty */
        if (s == "")
        {
            //errmsg = "e0";
            return false;
        }

        /* 1. Error: Unspecified '::' */
        if (s == "::")
        {
            //errmsg = "e1";
            return false;
        }

        /* 2. Error: Triple or more colons entered */
        if ((s.Length <= 1) || (s.Contains(":::")))
        {
            //errmsg = "e2";
            return false;
        }

        /* 3. Error: Not valid hex */
        if (Regex.Matches(s, "^[0-9A-Fa-f:]+$").Count == 0)
        {
            //errmsg = "e3";
            return false;
        }

        /* 4. Error: Cannot start or end with ':' */
        if (s[0] == ':' && s[1] != ':')
        {
            //errmsg = "e4";
            return false;
        }
        if (s[s.Length - 1] == ':' && s[s.Length - 2] != ':')
        {
            //errmsg = "e4";
            return false;
        }

        /* 5. Error: More than 2 Bytes */
        s = address;
        string[] sa = s.Split(':');
        for (int j = 0; j < sa.Length; j++)
        {
            if (sa[j].Length > 4)
            {
                //errmsg = "e5";
                return false;
            }
        }

        /* 6. Error: Number of double-colon and colon */
        s = address;
        nDC = Regex.Matches(s, "::").Count;
        s = s.Replace("::", "**");
        nC = Regex.Matches(s, ":").Count;

        /* 6.Error: Case I. double-colon '::' can only appear once in an address - RFC4291 */
        if (nDC > 1)
        {
            //errmsg = "e6_1";
            return false;
        }

        /* 6.Error: Case II. No double-colon means there must be 7 colons */
        if (nDC == 0 && nC != 7)
        {
            //errmsg = "e6_2";
            return false;
        }

        /* 6.Error: Case III. If double-colon is at the start or end, max. colons must be 6 or less */
        s = address;
        int sL = s.Length;
        if ((s[0] == ':' && s[1] == ':')
             ||
             (s[sL - 1] == ':' && s[sL - 2] == ':')
           )
        {
            if (nDC == 1 && nC > 6)
            {
                //errmsg = "e6_3";
                return false;
            }
        }

        /* 6.Error: Case IV. If double-colon is in the middle, max. colons must be 5 or less */
        else if (nDC == 1 && nC > 5)
        {
            //errmsg = "e6_4";
            return false;
        }

        //errmsg = "e_ok";
        return true;
    }

    // конструктор
    public IPv6Calculator(string ip, int prefix)
    {
        if (!IsValidIPv6Address(ip))
        {
            throw new ArgumentException("Invalid IPv6 address format.");
        }

        this.ip = ip;
        this.prefix = prefix;
    }

    // сокращенный адрес 
    public string CompressedIPv6Address()
    {
        // разделение по :
        string[] ipSegments = ip.Split(':');
        for (int i = 0; i < ipSegments.Length; i++)
        {
            // если 0 незначащий, то удаляем его
            ipSegments[i] = ipSegments[i].TrimStart('0');
            if (ipSegments[i] == "")
            {
                ipSegments[i] = "0";
            }
        }// соединение по :
        string compressedAddress = string.Join(":", ipSegments);
        return compressedAddress;
    }

    public string CompressedIPv6Address(string ip)
    {
        // разделение по :
        string[] ipSegments = ip.Split(':');
        for (int i = 0; i < ipSegments.Length; i++)
        {
            // если 0 незначащий, то удаляем его
            ipSegments[i] = ipSegments[i].TrimStart('0');
            if (ipSegments[i] == "")
            {
                ipSegments[i] = "0";
            }
        }// соединение по :
        string compressedAddress = string.Join(":", ipSegments);
        return compressedAddress;
    }

    // полный адрес
    public string ExpandedIPv6Address()
    {
        ip = ip.Trim(); // Убираем лишние пробелы по краям

        // Разбиваем адрес на группы
        string[] groups = ip.Split(':');

        // Проверяем, является ли адрес сокращенным
        bool isShortened = ip.Contains("::");

        // Обработка сокращенного адреса
        if (isShortened)
        {
            // Ищем позицию сокращения
            int index = Array.IndexOf(groups, "");

            // Восстанавливаем отсутствующие группы
            List<string> expandedGroups = new List<string>();
            for (int i = 0; i < groups.Length; i++)
            {
                // Пропускаем пустую группу, если она находится на позиции сокращения
                if (i == index)
                {
                    int count = 8 - (groups.Length - 1); // Количество групп, которые нужно добавить
                    expandedGroups.AddRange(Enumerable.Repeat("0000", count));
                }
                else
                {
                    expandedGroups.Add(groups[i].PadLeft(4, '0')); // Дополняем группы до 4 символов
                }
            }

            // Объединяем группы с двоеточием
            return string.Join(":", expandedGroups);
        }
        // Обработка полного адреса
        else
        {
            // Дополняем каждую группу до 4 символов
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = groups[i].PadLeft(4, '0');
            }

            // Объединяем группы с двоеточием
            return string.Join(":", groups);
        }
    }



    // префикс в 16-м виде
    // полный адрес
    public string ExpandedIPv6Address(string ip)
    {
        ip = ip.Trim(); // Убираем лишние пробелы по краям

        // Разбиваем адрес на группы
        string[] groups = ip.Split(':');

        // Проверяем, является ли адрес сокращенным
        bool isShortened = ip.Contains("::");

        // Обработка сокращенного адреса
        if (isShortened)
        {
            // Ищем позицию сокращения
            int index = Array.IndexOf(groups, "");

            // Восстанавливаем отсутствующие группы
            List<string> expandedGroups = new List<string>();
            for (int i = 0; i < groups.Length; i++)
            {
                // Пропускаем пустую группу, если она находится на позиции сокращения
                if (i == index)
                {
                    int count = 8 - (groups.Length - 1); // Количество групп, которые нужно добавить
                    expandedGroups.AddRange(Enumerable.Repeat("0000", count));
                }
                else
                {
                    expandedGroups.Add(groups[i].PadLeft(4, '0')); // Дополняем группы до 4 символов
                }
            }

            // Объединяем группы с двоеточием
            return string.Join(":", expandedGroups);
        }
        // Обработка полного адреса
        else
        {
            // Дополняем каждую группу до 4 символов
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = groups[i].PadLeft(4, '0');
            }

            // Объединяем группы с двоеточием
            return string.Join(":", groups);
        }
    }
    public string HexSubnetMask()
    {
        // для хранения 16-битных значений каждого сегмента маски
        int[] maskSegments = new int[8];
        // В цикле проходим по всем битам префикса и устанавливаем 1.3
        for (int i = 0; i < prefix; i++)
        {
            // [i / 16] - в какой сегмент нужно установить бит
            // 1 << (15 - (i % 16)) - побитовый сдвиг 1 влево на количество позиций, равное разности 15 и остатку от деления i на 16
            maskSegments[i / 16] |= 1 << (15 - (i % 16));
        }

        string[] subnetMaskSegments = new string[8];
        // заполнение subnetMaskSegments сегменты 16-ричной системе счисления
        for (int i = 0; i < 8; i++)
        {
            subnetMaskSegments[i] = maskSegments[i].ToString("X");
        }
        // объединяем все сегменты маски в строку
        string subnetMask = string.Join(":", subnetMaskSegments);

        //subnetMask = subnetMask.ToLower();
        return subnetMask;
    }

    // адрес сети
    public string NetworkAddress()
    {
        string ipAddress = ExpandedIPv6Address(); 
        int maskBits = prefix;
        string[] ipSegments = ipAddress.Split(':'); // разбиение IP-адреса на сегменты
        int[] ipValues = new int[ipSegments.Length]; // массив для хранения числовых значений сегментов IP-адреса

        // преобразование каждого сегмента IP-адреса в числовое значение и сохранение в массиве ipValues
        for (int i = 0; i < ipSegments.Length; i++)
        {
            ipValues[i] = Convert.ToInt32(ipSegments[i], 16); // преобразование из шестнадцатеричной строки в целое число
        }

        // массив для хранения бит маски подсети
        int[] maskSegments = new int[8];

        // установка битов маски подсети
        for (int i = 0; i < maskBits; i++)
        {
            maskSegments[i / 16] |= 1 << (15 - (i % 16)); // установка соответствующего бита маски подсети в зависимости от позиции
        }

        // массив для хранения сегментов сетевого адреса
        int[] networkSegments = new int[8];

        // вычисление сетевого адреса путем применения маски к IP-адресу побитово
        for (int i = 0; i < 8; i++)
        {
            int networkSegment = ipValues[i] & maskSegments[i]; 
            networkSegments[i] = networkSegment; // сохранение сетевого сегмента
        }

        // преобразование сегментов сетевого адреса в строку
        string[] networkAddressSegments = new string[8];
        for (int i = 0; i < 8; i++)
        {
            networkAddressSegments[i] = networkSegments[i].ToString("X"); // преобразование числового значения в шестнадцатеричную строку
        }

        // объединение через :
        string networkAddress = string.Join(":", networkAddressSegments);
        return networkAddress;

    }

    public string SubnetMask()
    {
        // массива для хранения сегментов маски подсети
        int[] maskSegments = new int[8];

        // Вычисление битов маски подсети
        for (int i = 0; i < prefix; i++)
        {
            maskSegments[i / 16] |= 1 << (15 - (i % 16)); // Установка соответствующего бита маски подсети
        }

        // Инициализация массива для хранения строковых представлений сегментов маски подсети
        string[] subnetMaskSegments = new string[8];

        // Преобразование числовых значений сегментов маски подсети в шестнадцатеричные строки
        for (int i = 0; i < 8; i++)
        {
            subnetMaskSegments[i] = maskSegments[i].ToString("X"); // Преобразование в шестнадцатеричную строку
        }

        // Объединение строковых представлений сегментов маски подсети через двоеточие
        string subnetMask = string.Join(":", subnetMaskSegments);

        // Возврат результата
        return subnetMask;

    }

    public string BroadcastAddress()
    {
        string ipAddress = ExpandedIPv6Address();
        int maskBits = prefix;
        string[] ipSegments = ipAddress.Split(':');
        int[] ipValues = new int[ipSegments.Length];

        // преобразование шестнадцатеричных сегментов IP-адреса в числовые значения
        for (int i = 0; i < ipSegments.Length; i++)
        {
            ipValues[i] = Convert.ToInt32(ipSegments[i], 16);
        }

        int[] maskSegments = new int[8];
        for (int i = 0; i < maskBits; i++)
        {
            maskSegments[i / 16] |= 1 << (15 - (i % 16));
        }

        // инициализация массива для хранения инвертированных сегментов маски подсети и вычисление их значений
        int[] invertedMaskSegments = new int[8];
        for (int i = 0; i < 8; i++)
        {
            int invertedSegment = ~maskSegments[i] & 0xFFFF;
            invertedMaskSegments[i] = invertedSegment;
        }

        // Инициализация массива для хранения сегментов широковещательного адреса и вычисление их значений
        int[] broadcastSegments = new int[8];
        for (int i = 0; i < 8; i++)
        {
            int broadcastSegment = ipValues[i] | invertedMaskSegments[i];
            broadcastSegments[i] = broadcastSegment;
        }

        // Преобразование числовых значений сегментов широковещательного адреса в шестнадцатеричные строки
        string[] broadcastAddressSegments = new string[8];
        for (int i = 0; i < 8; i++)
        {
            broadcastAddressSegments[i] = broadcastSegments[i].ToString("X");
        }

        // Объединение шестнадцатеричных строк сегментов широковещательного адреса через двоеточие
        string broadcastAddress = string.Join(":", broadcastAddressSegments);

        // Возврат результата
        return broadcastAddress;

    }

    // количество адресов
    public string NumberOfHostsFormatted()
    {
        // длина маски подсети
        int maskBits = prefix;

        // количество хостов
        BigInteger numberOfHosts = BigInteger.Pow(2, 128 - maskBits);

        // вывод в строку
        string hostsString = numberOfHosts.ToString();

        // разбиение на группы по три цифры справа налево
        string formattedNumber = "";
        int groupCount = 0;
        for (int i = hostsString.Length - 1; i >= 0; i--)
        {
            formattedNumber = hostsString[i] + formattedNumber;
            groupCount++;
            if (groupCount == 3 && i > 0)
            {
                formattedNumber = "," + formattedNumber; 
                groupCount = 0; 
            }
        }
        return formattedNumber;
    }


    public string GenerateSubnets(int subnetPrefix)
    {
        // Проверка входных данных
        if (subnetPrefix < prefix || subnetPrefix > 128 || prefix < 0 || prefix > 128)
        {
            return "Неверные значения префикса подсети или IP-адреса";
        }
        else if (subnetPrefix == prefix)
        {
            return this.ip;
        }
        string ip = ExpandedIPv6Address();
        // Разделение IP-адреса на части
        string[] parts = ip.Split(':');
        List<string> subnetsList = new List<string>();

        // Преобразование шестнадцатеричных значений в двоичное представление
        StringBuilder binaryIp = new StringBuilder();
        foreach (string part in parts)
        {
            binaryIp.Append(Convert.ToString(Convert.ToInt32(part, 16), 2).PadLeft(16, '0'));
        }

        // Определение начального и конечного адреса подсети
        string startSubnet = binaryIp.ToString().Substring(0, prefix);
        string endSubnet = binaryIp.ToString().Substring(0, subnetPrefix);

        // Вычисление количества подсетей
        int numberOfSubnets = 1 << (subnetPrefix - prefix);

        // Разбиение на подсети
        for (int i = 0; i < numberOfSubnets; i++)
        {
            // Определение начального и конечного адреса каждой подсети
            string startAddress = startSubnet.PadRight(128, '0');
            string endAddress = endSubnet.PadRight(128, '1');

            // Преобразование обратно в шестнадцатеричное представление
            StringBuilder hexStart = new StringBuilder();
            StringBuilder hexEnd = new StringBuilder();
            for (int j = 0; j < 128; j += 16)
            {
                string binaryStartPart = startAddress.Substring(j, 16);
                string binaryEndPart = endAddress.Substring(j, 16);
                hexStart.Append(Convert.ToString(Convert.ToInt32(binaryStartPart, 2), 16) + ":");
                hexEnd.Append(Convert.ToString(Convert.ToInt32(binaryEndPart, 2), 16) + ":");
            }

            // Удаление последнего двоеточия
            hexStart.Remove(hexStart.Length - 1, 1);
            hexEnd.Remove(hexEnd.Length - 1, 1);

            // Добавление подсети в список
            subnetsList.Add(hexStart + "/" + subnetPrefix);

            // Разделение начального адреса на две части
            string firstPart = startAddress.Substring(0, prefix);
            string secondPart = startAddress.Substring(prefix);
            // Объединение двух частей с префиксом        
            secondPart = IncrementBinary(secondPart);
            startSubnet = firstPart + secondPart;

            // Разделение начального адреса на две части
            firstPart = endAddress.Substring(0, prefix);
            secondPart = endAddress.Substring(prefix);
            // Объединение двух частей с префиксом
            secondPart = IncrementBinary(secondPart);
            endSubnet = firstPart + secondPart;
        }

        // Сортировка списка подсетей
        subnetsList.Sort();

        // Преобразование списка в строку StringBuilder
        StringBuilder result = new StringBuilder();
        foreach (string subnet in subnetsList)
        {
            result.AppendLine(subnet);
        }

        return result.ToString();
    }

    // Функция для увеличения бинарного числа на 1
    private string IncrementBinary(string binary)
    {
        char[] binaryArray = binary.ToCharArray();
        int index = 0;

        while (index < binaryArray.Length && binaryArray[index] == '1')
        {
            binaryArray[index] = '0';
            index++;
        }

        if (index < binaryArray.Length)
        {
            binaryArray[index] = '1';
        }

        return new string(binaryArray);
    }


    public string AggregateNetworks(string[] networks)
    {
        if (networks.Length < 2)
        {
            return string.Join("", networks); // Если в массиве менее двух префиксов, возвращаем их как есть
        }

        for (int i = 0; i < networks.Length; i++)
        {
            networks[i] = ExpandedIPv6Address(networks[i]);
        }

        List<string> summarizedPrefixes = new List<string>(networks);

        for (int i = 0; i < summarizedPrefixes.Count; i++)
        {
            for (int j = i + 1; j < summarizedPrefixes.Count; j++)
            {
                string summarized = Summarize(ExpandedIPv6Address(summarizedPrefixes[i]), ExpandedIPv6Address(summarizedPrefixes[j]));
                summarizedPrefixes[i] = summarized;
                summarizedPrefixes.RemoveAt(j);
                j--;
            }
        }

        //return CompressedIPv6Address(string.Join("", summarizedPrefixes));
        return ExpandedIPv6Address(string.Join("", summarizedPrefixes));
    }

    private string Summarize(string prefix1, string prefix2)
    {
        string[] parts1 = prefix1.Split(':');
        string[] parts2 = prefix2.Split(':');
        int commonBlocks = 0;
        for (int i = 0; i < 3; i++)
        {
            if (parts1[i] != parts2[i])
            {
                break;
            }
            commonBlocks++;
        }
        string lastBlock1 = Convert.ToString(Convert.ToInt32(parts1[3], 16), 2).PadLeft(16, '0');
        string lastBlock2 = Convert.ToString(Convert.ToInt32(parts2[3], 16), 2).PadLeft(16, '0');
        int matchingBits = 0;
        for (int i = 0; i < 16; i++)
        {
            if (lastBlock1[i] != lastBlock2[i])
            {
                break;
            }
            matchingBits++;
        }
        string summarizedBlock = lastBlock1.Substring(0, matchingBits).PadRight(16, '0');
        string summarizedHex = Convert.ToInt32(summarizedBlock, 2).ToString("X");
        string summarizedPrefix = $"{string.Join(":", parts1, 0, commonBlocks)}:{summarizedHex}::/{commonBlocks * 16 + matchingBits}";
        return summarizedPrefix;
    }


    
    public static byte[] ParseIPv6Address(string ipAddressString)
    {
        string[] addressParts = ipAddressString.Split(':');
        if (addressParts.Length != 8)
        {
            return null;
        }

        byte[] ipAddressBytes = new byte[16];
        for (int i = 0; i < 8; i++)
        {
            ushort partValue;
            if (!ushort.TryParse(addressParts[i], System.Globalization.NumberStyles.HexNumber, null, out partValue))
            {
                return null;
            }

            ipAddressBytes[i * 2] = (byte)(partValue >> 8);
            ipAddressBytes[i * 2 + 1] = (byte)partValue;
        }

        return ipAddressBytes;
    }

}
