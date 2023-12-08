class IPAddressCalculator:
    def __init__(self, ip, subnet_mask):
        self.ip = ip
        self.subnet_mask = subnet_mask
        self.network_address = None
        self.broadcast_address = None
        self.is_local = None

    def validate_ip(self):
        """
        Проверка корректности введенного IP-адреса.
        """
        octets = self.ip.split('.')
        if len(octets) != 4:
            raise ValueError("Некорректный формат IP-адреса")

        for octet in octets:
            if not (0 <= int(octet) <= 255):
                raise ValueError("Некорректный формат IP-адреса")

    def validate_subnet_mask(self):
        """
        Проверка корректности введенной маски подсети.
        """
        octets = self.subnet_mask.split('.')
        if len(octets) != 4:
            raise ValueError("Некорректный формат маски подсети")

        binary_mask = ''.join(format(int(octet), '08b') for octet in octets)
        if '01' in binary_mask:
            raise ValueError("Некорректная маска подсети")

    def calculate_network(self):
        """
        Расчет сетевого адреса и широковещательного адреса.
        """
        network_address = '.'.join(str(int(ip_octet) & int(mask_octet)) for ip_octet, mask_octet in zip(self.ip.split('.'), self.subnet_mask.split('.')))
        broadcast_address = '.'.join(str(int(network_octet) | int(~int(mask_octet) & 255)) for network_octet, mask_octet in zip(network_address.split('.'), self.subnet_mask.split('.')))

        self.network_address = network_address
        self.broadcast_address = broadcast_address

        # Определяем, является ли IP локальным
        self.is_local = self.is_local_ip()

    def is_local_ip(self):
        """
        Проверка, является ли IP-адрес локальным.
        """
        octets = self.ip.split('.')
        first_octet = int(octets[0])

        # Проверяем, принадлежит ли IP к одной из локальных подсетей
        if (first_octet == 10) or (first_octet == 172 and 16 <= int(octets[1]) <= 31) or (first_octet == 192 and int(octets[1]) == 168):
            return True
        else:
            return False

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

         # Определяем и выводим, является ли IP локальным
        if calculator.is_local:
            print("IP-адрес является локальным.")
        else:
            print("IP-адрес является глобальным.")

    except ValueError as e:
        print(f"Ошибка: {e}")
    except KeyboardInterrupt:
        print("\nПрограмма завершена пользователем.")



main()
