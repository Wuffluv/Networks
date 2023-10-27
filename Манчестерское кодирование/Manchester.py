# Функция для кодирования байта по Манчестерскому коду
def manchester_encode_byte(byte):
    encoded = []
    for i in range(7, -1, -1):
        # Кодирование данных
        if (byte >> i) & 1:
            # Если текущий бит равен 1, то добавляем переход от низкого к высокому уровню
            encoded.extend([True, False])
        else:
            # Если текущий бит равен 0, то добавляем переход от высокого к низкому уровню
            encoded.extend([False, True])
    return encoded

# Фраза, которую мы хотим закодировать
message = "hello world"

# Кодирование фразы
encoded_message = []
for c in message:
    encoded_byte = manchester_encode_byte(ord(c))
    encoded_message.extend(encoded_byte)

# Вывод закодированной последовательности в консоли
for bit in encoded_message:
    print("01" if bit else "10", end="")
print()
