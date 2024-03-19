import server

# Задаем URL сервера
url = 'http://localhost:8080'

# Пример GET-запроса
response = server.get(url)
print(f"Ответ сервера:\n{response.text}")
