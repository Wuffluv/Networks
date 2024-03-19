from http.server import SimpleHTTPRequestHandler, HTTPServer

# Создаем простой обработчик запросов
class MyHandler(SimpleHTTPRequestHandler):
    pass

# Задаем адрес и порт сервера
host = 'localhost'
port = 8080

# Создаем сервер
server = HTTPServer((host, port), MyHandler)

print(f"Сервер слушает на http://{host}:{port}")

# Запускаем сервер
server.serve_forever()
