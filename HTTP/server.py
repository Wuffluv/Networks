from http.server import BaseHTTPRequestHandler, HTTPServer
import os

# Обработчик HTTP-запросов
class SimpleHTTPRequestHandler(BaseHTTPRequestHandler):
    def do_POST(self):
        # Получаем длину тела запроса
        content_length = int(self.headers['Content-Length'])
        # Получаем имя файла из заголовка запроса
        file_name = os.path.basename(self.path)

        # Читаем данные файла из тела запроса
        file_data = self.rfile.read(content_length)

        # Записываем данные файла в новый файл
        with open(file_name, 'wb') as new_file:
            new_file.write(file_data)

        # Отправляем ответ о успешной загрузке файла
        self.send_response(200)
        self.send_header('Content-type', 'text/plain')
        self.end_headers()
        self.wfile.write(b'File uploaded successfully!')

# Функция для запуска сервера
def run_server(server_class=HTTPServer, handler_class=SimpleHTTPRequestHandler, port=8000):
    server_address = ('', port)
    httpd = server_class(server_address, handler_class)
    print(f'Starting server on port {port}...')
    httpd.serve_forever()

# Запуск сервера
if __name__ == '__main__':
    run_server()
