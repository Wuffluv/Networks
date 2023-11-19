def ip_to_binary(ip_address):
    # Преобразование каждого октета IP-адреса в двоичную строку
    binary_octets = [bin(int(octet))[2:].zfill(8) for octet in ip_address.split('.')]
    return ''.join(binary_octets)

def calculate_network(ip_address, subnet_mask):
    try:
        # Преобразование IP-адреса и маски подсети в двоичную форму
        ip_binary = ip_to_binary(ip_address)
        mask_binary = ip_to_binary(subnet_mask)

        # Вычисление сетевого адреса в двоичной форме
        network_binary = ''.join([str(int(ip_bit) & int(mask_bit)) for ip_bit, mask_bit in zip(ip_binary, mask_binary)])

        # Преобразование двоичной формы сетевого адреса в десятичную форму
        network_decimal = '.'.join([str(int(network_binary[i:i+8], 2)) for i in range(0, 32, 8)])

        return network_decimal

    except ValueError:
        raise ValueError("Неверный формат IP-адреса или маски подсети")

def ip_calculator(ip_address, subnet_mask):
    try:
        # Вычисление сетевого адреса
        network_address = calculate_network(ip_address, subnet_mask)

        # Вывод информации о подсети
        print(f"IP адрес: {ip_address}")
        print(f"Маска подсети: {subnet_mask}")
        print(f"Сетевой адрес: {network_address}")
        # Другие вычисления могут быть добавлены по аналогии

    except ValueError as e:
        print(f"Ошибка: {e}")

# Введите IP-адрес и маску подсети
ip_address = input("Введите IP-адрес: ")
subnet_mask = input("Введите маску подсети: ")

# Вызов функции и вывод результатов
ip_calculator(ip_address, subnet_mask)
