import sys
from PyQt5.QtWidgets import *
from Main_Gui import Excelseat
import math
import requests
import re
from bs4 import BeautifulSoup
from openpyxl import *

# 화면을 띄우는데 사용되는 Class 선언
class Myapp(QWidget):
    def __init__(self):
        super().__init__()

        self.Co = Excelseat()

        self.initui()
        self.initEvent()
        self.rowIndex = 0
        self.col = 0


    def Search(self):
        try:
            search = self.searchbar.text()
            Lpricecut = int(self.Lpricebar.text())
            Upricecut = int(self.Upricebar.text())
            url = "https://www.coupang.com/np/search?component=&q=" + search + "&channel=user"

            headers = {
                "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36"}
            res = requests.get(url, headers=headers)
            res.raise_for_status()
            soup = BeautifulSoup(res.text, "lxml")
            # print(res.text)

            items = soup.find_all("li", attrs={"class": re.compile("^search-product")})
            # price = soup.find_all("li", attrs={"class":re.compile("^search-product")})

            # 상품 불러오기
            i = 0
            information = []
            for item in items:
                # 이름 값
                name = item.find("div", attrs={"class": "name"}).get_text()
                # 가격 값
                price = item.find("strong", attrs={"class": "price-value"}).get_text()
                price = int(price.replace(',', ''))
                if (price > Upricecut or price < Lpricecut):
                    i -= 1
                    continue
                # 평점 값
                rate = item.find("em", attrs={"class": "rating"})
                if rate:
                    rate = rate.get_text()
                    rate = float(rate)
                    rate = math.ceil(int(rate))
                else:
                    rate = "평점 없음"
                # 평점 수 값
                rate_cnt = item.find("span", attrs={"class": "rating-total-count"})
                if rate_cnt:
                    rate_cnt = rate_cnt.get_text()
                else:
                    rate_cnt = "평점 없음"
                link = item.find("a", attrs={"class": "search-product-link"})['href']
                link = "https://www.coupang.com" + link
                # 정렬
                information.append([name, str(price), str(rate), rate_cnt, link])
            information.sort(key=lambda x: int(x[1]))
            self.Co.create(information)
        except Exception as e:
            print(e)


    def connect(self):
        try:
            rows = self.Co.loadrow()
            for row in rows:
                  self.qtable.setItem(self.rowIndex,0,QTableWidgetItem(row[0]))
                  self.qtable.setItem(self.rowIndex,1,QTableWidgetItem(row[1]))
                  self.qtable.setItem(self.rowIndex,2,QTableWidgetItem(row[2]))
                  self.qtable.setItem(self.rowIndex,3,QTableWidgetItem(row[3]))
                  self.qtable.setItem(self.rowIndex,4,QTableWidgetItem(row[4]))
                  self.rowIndex += 1
                  print(self.rowIndex)
        except Exception as s:
            print(s)

    def initEvent(self):
        self.search.clicked.connect(self.Search)
        self.look.clicked.connect(self.connect)

    def initui(self):
        self.qtable = QTableWidget(self)
        self.qtable.setRowCount(30)
        self.qtable.setColumnCount(5)
        self.qtable.move(50,50)
        self.qtable.setFixedSize(800,400)

        self.qtable.setHorizontalHeaderLabels(["제품명","가격","평점","평점 등록 수","구매링크"])
        self.qtable.horizontalHeader()\
            .setSectionResizeMode(QHeaderView.Stretch)

        self.searchtag = QLabel("상품 이름",self)
        self.searchtag.move(30,16)
        self.LPricecut = QLabel("최저가격대",self)
        self.LPricecut.move(275,16)
        self.UPricecut = QLabel("최고가격대",self)
        self.UPricecut.move(520,16)


        self.searchbar = QLineEdit(self)
        self.searchbar.move(100,12)
        self.Lpricebar = QLineEdit(self)
        self.Lpricebar.move(350,12)
        self.Upricebar = QLineEdit(self)
        self.Upricebar.move(600,12)


        self.search = QPushButton("검색",self)
        self.search.move(800,10)
        self.look = QPushButton("보기",self)
        self.look.move(900,10)


        self.setWindowTitle("쿠팡 탐색기")
        self.move(300, 300)
        self.resize(1000, 500)
        self.show()




if __name__ == "__main__":
    app = QApplication(sys.argv)
    myWindow = Myapp()
    app.exec_()