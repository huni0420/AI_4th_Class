import sys
from PyQt5.QtWidgets import *
from PyQt5 import uic
from p_MyExcel import MExcel
from PyQt5.QtGui import * #라벨써서 배경넣을때

form_class = uic.loadUiType("a.ui")[0]


class MyApp(QMainWindow, form_class):
    def __init__(self):
        super().__init__()
        self.initUI()
        self.setupUi(self)
        self.mex = MExcel()
        self.savebtn.clicked.connect(self.savefn)
        self.loadbtn.clicked.connect(self.loadfn)
        self.createbtn.clicked.connect(self.createfn)

        self.tableW = QTableWidget(self)  # 테이블 생성 후 Qwidget에 붙이기
        self.tableW.move(10, 200)  # 테이블 x좌표로 100 y좌표로 10에서 그리기
        self.tableW.setRowCount(10)  # 행갯수 10개 지정
        self.tableW.setColumnCount(5)  # 컬럼개수 4개로 지정
        self.tableW.setFixedSize(676, 300)  # 테이블 크기

    def savefn(self):
        ko = self.koedit.text()
        eng = self.engedit.text()
        math = self.mathedit.text()

        for self.col in range(1, 4):
            if self.col == 1:
                self.tableW.setItem(self.row, self.col, QTableWidgetItem(ko))
            if self.col == 2:
                self.tableW.setItem(self.row, self.col, QTableWidgetItem(eng))
            if self.col == 3:
                self.tableW.setItem(self.row, self.col, QTableWidgetItem(math))
        if self.col == 3:
            self.row += 1
        self.col = 0
        tot = int(ko) + int(eng) + int(math)
        avg = tot / 3
        # print('tot = ', tot)
        # print('avg = ', avg)
        self.mex.savefn(ko, eng, math, tot, avg)

    def loadfn(self):
        self.mex.loadfn()

    def createfn(self):
        self.mex.createfn()

    def initUI(self):
        #라벨써서 배경 넣을때≫≫≫≫
        self.lbl = QLabel(self)
        self.lbl.resize(676, 600)
        pixmap = QPixmap("음악짤.png")
        self.lbl.setPixmap(QPixmap(pixmap))
        self.resize(676, 600)
        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MyApp()
    mywindow.show()
    sys.exit(app.exec_())
