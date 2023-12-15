class IPAddressCalculator:
    def __init__(self, ip, subnet_mask):
        self.ip = ip
        self.subnet_mask = subnet_mask
        self.network_address = None
        self.broadcast_address = None
        self.is_local = None  # Новое свойство для определения, является ли IP локальным
        self.ip_class = None  # Новое свойство для определения класса IP

    def validate_ip(self):
        # Проверка корректности введенного IP-адреса
        octets = self.ip.split('.')
        if len(octets) != 4 or not all(0 <= int(octet) <= 255 for octet in octets):
            raise ValueError("Некорректный формат IP-адреса")

    def validate_subnet_mask(self):
        # Проверка корректности введенной маски подсети
        try:
            # Пытаемся преобразовать введенную маску в число
            subnet_mask_value = int(self.subnet_mask)

            # Проверяем, что значение находится в допустимом диапазоне
            if 0 <= subnet_mask_value <= 32:
                self.subnet_mask = subnet_mask_value
            else:
                raise ValueError("Недопустимая маска подсети")
        except ValueError:
            raise ValueError("Некорректный формат маски подсети")

    def calculate_network(self):
        # Расчет сетевого адреса и широковещательного адреса
        ip_octets = [int(octet) for octet in self.ip.split('.')]
        mask_octets = [0] * 4

        # Заполняем первые self.subnet_mask бит маски
        for i in range(self.subnet_mask):
            mask_octets[i // 8] |= (1 << (7 - i % 8))

        # Выполняем поразрядное И для определения сетевого адреса
        network_octets = [ip_octet & mask_octet for ip_octet, mask_octet in zip(ip_octets, mask_octets)]
        self.network_address = '.'.join(map(str, network_octets))

        # Определение широковещательного адреса (поразрядное ИЛИ)
        inverted_mask_octets = [255 - mask_octet for mask_octet in mask_octets]
        broadcast_octets = [network_octet | inverted_mask_octet for network_octet, inverted_mask_octet in zip(network_octets, inverted_mask_octets)]
        self.broadcast_address = '.'.join(map(str, broadcast_octets))

        # Определяем, является ли IP локальным
        self.is_local = self.is_local_ip()

        # Определяем класс IP
        self.ip_class = self.get_ip_class()

    def is_local_ip(self):
        """
        Проверка, является ли IP-адрес локальным.
        """
        octets = self.ip.split('.')
        first_octet = int(octets[0])

        # Проверяем, принадлежит ли IP к одной из локальных подсетей
        return (first_octet == 10) or (first_octet == 172 and 16 <= int(octets[1]) <= 31) or (first_octet == 192 and int(octets[1]) == 168)

    def get_ip_class(self):
        """
        Определение класса IP-адреса.
        """
        first_octet = int(self.ip.split('.')[0])

        if self.ip == '127.0.0.1':
            return 'Loopback'

        if 1 <= first_octet <= 126:
            return 'A'
        elif 128 <= first_octet <= 191:
            return 'B'
        elif 192 <= first_octet <= 223:
            return 'C'
        elif 224 <= first_octet <= 239:
            return 'D (Multicast)'
        elif 240 <= first_octet <= 255:
            return 'E (Reserved for experimental use)'
        else:
            return 'Unknown or invalid IP class'


def main():
    try:
        # Получаем ввод от пользователя
        ip_address = input("Введите IP-адрес: ")
        subnet_mask = input("Введите маску подсети: ")

        # Создаем экземпляр класса IPAddressCalculator
        calculator = IPAddressCalculator(ip_address, subnet_mask)

        # Проверяем корректность введенных данных
        calculator.validate_ip()
        calculator.validate_subnet_mask()

        # Рассчитываем и выводим результаты
        calculator.calculate_network()
        print(f"Сетевой адрес: {calculator.network_address}")
        print(f"Широковещательный адрес: {calculator.broadcast_address}")
        print(f"Класс IP: {calculator.ip_class}")

        # Определяем и выводим, является ли IP локальным
        if calculator.is_local:
            print("IP-адрес является локальным.")
        elif calculator.ip == '127.0.0.1':
            print("IP-адрес является loopback.")
        else:
            print("IP-адрес является глобальным.")

    except ValueError as e:
        print(f"Ошибка: {e}")
    except KeyboardInterrupt:
        print("\nПрограмма завершена пользователем.")

if __name__ == "__main__":
    main()
