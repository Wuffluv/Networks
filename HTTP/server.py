from http.server import BaseHTTPRequestHandler, HTTPServer
from urllib.parse import urlparse, parse_qs

# Обработчик HTTP-запросов
class SimpleHTTPRequestHandler(BaseHTTPRequestHandler):
    def do_GET(self):
        # Разбираем URL для получения пути и параметров запроса
        parsed_path = urlparse(self.path)
        query_params = parse_qs(parsed_path.query)

        # Отправляем успешный HTTP-ответ с данными в формате JSON
        self.send_response(200)
        self.send_header('Content-type', 'application/json')
        self.end_headers()

        # Формируем ответное тело
        response_body = {
            'path': parsed_path.path,
            'params': query_params
        }
        self.wfile.write(bytes(str(response_body), 'utf-8'))

# Функция для запуска сервера
def run_server(server_class=HTTPServer, handler_class=SimpleHTTPRequestHandler, port=8000):
    server_address = ('', port)
    httpd = server_class(server_address, handler_class)
    print(f'Starting server on port {port}...')
    httpd.serve_forever()

# Запуск сервера
if __name__ == '__main__':
    run_server()
