import http.client
import os

# Просьба пользователя ввести путь к файлу
file_path = input("Введите название файла: ")

# Проверяем, существует ли файл по указанному пути
if not os.path.isfile(file_path):
    print("Файл не найден.")
    exit()

# Открываем файл для чтения в бинарном режиме
with open(file_path, 'rb') as file:
    # Читаем данные файла
    file_data = file.read()

    # Устанавливаем соединение с сервером
    conn = http.client.HTTPConnection("localhost", 8000)

    # Отправляем POST-запрос с данными файла
    conn.request("POST", "/upload_file", body=file_data)

    # Получаем ответ от сервера
    response = conn.getresponse()

    # Выводим ответ сервера
    print('Статус ответа:', response.status)
    print('Ответ:', response.read().decode())

    # Закрываем соединение
    conn.close()
