import requests

# URL сервера
server_url = 'http://localhost:8000'

# Выполнение GET-запроса с параметрами
response = requests.get(server_url + '/example_path?param1=value1&param2=value2')

# Вывод ответа
print('Response Status Code:', response.status_code)
print('Response Body:', response.text)
