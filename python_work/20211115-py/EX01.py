import sys
from PyQt5.QtWidgets import *


class MyApp(QWidget):
    def __init__(self):
        super().__init__()

        self.row = 0
        self.col = 0
        self.value = 1

        self.initUi()
        self.signalfn()

    # excel 저장... 화면에도 뿌려준다...
    def mybtn(self):
        self.tableW.setItem(self.row, self.col, QTableWidgetItem(str(self.value)))
        print("누름")
        self.value += 1
        # self.row +=1
        self.col += 1
        if (self.col == 5):
            self.row += 1
            self.col = 0
            if self.row > 9:
                self.tableW.setRowCount(self.row + 1)

        print("self.row = ", self.row)

    # control 이벤트 다는 곳...
    def signalfn(self):
        self.btn1.clicked.connect(self.mybtn)

    # 디자인 하는 곳...
    def initUi(self):
        self.btn1 = QPushButton('누름', self)
        self.btn1.move(10, 10)

        self.tableW = QTableWidget(self)  # 테이블 생성 후 Qwidget에 붙이기
        self.tableW.move(100, 10)  # 테이블 x좌표로 100 y좌표로 10에서 그리기
        self.tableW.setRowCount(10)  # 행갯수 10개 지정
        self.tableW.setColumnCount(4)  # 컬럼개수 4개로 지정
        self.tableW.setFixedSize(420, 500)  # 테이블 크기

        self.setWindowTitle('First App')
        self.move(300, 300)
        self.resize(800, 600)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
