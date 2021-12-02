import urllib.request  # python 기본 라이브러리
from bs4 import BeautifulSoup
import requests  # 라이브러리 설치 필요


# print(html)
# html.parser = html번역기 .... xml.parser = xml 번역기... json.parser = json 번역

class Review:
    def __init__(self, comment, date, star, good, bad):
        self.comment = comment
        self.date = date
        self.star = star
        self.good = good
        self.bad = bad

    def __str__(self):
        return '내용  ' + self.comment + '  날짜' + self.date + '\n별점' + self.star + '  좋아요' + self.good + '  싫어요' + self.bad


url = 'https://movie.naver.com/movie/bi/mi/point.naver?code=182362'

'''
html = urllib.request.urlopen(url).read()
html = BeautifulSoup(html, 'html.parser')
print(html)


req = requests.get(url)
html = BeautifulSoup(req.text, 'html.parser')
print(html)'''

review_list = []

review_list.append(Review('이 영화 참 잘만듦', '20110101', '10', '400', '300'))
review_list.append(Review('이영화인간이만든게아님', '20110101', '9', '111', '70'))
review_list.append(Review('로멘스영화', '20110101', '8', '200', '30'))

for review in review_list:
    print(review)