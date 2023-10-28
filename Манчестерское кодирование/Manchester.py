import matplotlib.pyplot as plt

# Функция для кодирования байта по Манчестерскому коду
def manchester_encode_byte(byte):
    encoded = []
    timestamps = []  # Список для хранения временных меток
    t = 0  # Инициализация временной метки

    for i in range(7, -1, -1):
        # Кодирование данных
        if (byte >> i) & 1:
            # Если текущий бит равен 1, то добавляем переход от низкого к высокому уровню
            encoded.extend([True, False])
        else:
            # Если текущий бит равен 0, то добавляем переход от высокого к низкому уровню
            encoded.extend([False, True])

        # Обновляем временную метку для каждого бита
        timestamps.extend([t, t + 0.5])
        t += 1  # Увеличиваем временную метку

    return encoded, timestamps

# Фраза, которую мы хотим закодировать
message = "hello world"

# Кодирование фразы
encoded_message = []
timestamps_message = []
t = 0  # Инициализация временной метки

for c in message:
    encoded_byte, timestamps_byte = manchester_encode_byte(ord(c))
    encoded_message.extend(encoded_byte)
    timestamps_message.extend([t + t_byte for t_byte in timestamps_byte])
    t += len(encoded_byte)  # Обновляем временную метку

# Вывод закодированной последовательности в консоли
for bit in encoded_message:
    print("01" if bit else "10", end="")
print()

# Построение графика
plt.figure(figsize=(10, 2))
plt.step(timestamps_message, [int(bit) for bit in encoded_message], where='post', color='b')
plt.xlabel('Время')
plt.ylabel('Сигнал (0/1)')
plt.title('Manchester Encoding')
plt.grid(True)
plt.show()
