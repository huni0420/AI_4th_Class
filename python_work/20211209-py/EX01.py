import requests

html = requests.get('http://localhost:8080/aa/a.jsp')
print(html.text)
