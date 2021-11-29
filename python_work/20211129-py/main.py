import sys
from PyQt5.QtWidgets import *
from selenium import webdriver


class Main(QWidget):
    def __init__(self):
        super().__init__()
        self.initui()

    def initui(self):
        self.qbtn = QPushButton("시작", self)
        self.qbtn.clicked.connerct()

        self.tableWidget = QTableWidget()
        self.tableWidget.setRowCount(20)
        self.tableWidget.setColumnCount(4)
        self.tableWidget.setHorizontalHeaderLabels(["선택", "이름", "아이디", "비번"])

        self.tableWidget.horizontalHeader() \
            .setSectionResizeMode(QHeaderView.Stretch)

        # item = QTableWidgetItem()

        for row in range(10):
            self.tableWidget.setCellWidget(row, 0, QCheckBox())

        self.tableWidget.setItem()

        hbox = QVBoxLayout()
        hbox.addWidget(self.qbtn)
        hbox.addWidget(self.tableWidget)

        self.setLayout(hbox)

        self.setWindowTitle("자동접속")
        self.move(300, 300)
        self.resize(400, 200)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = Main()
    mywindow.show()
    sys.exit(app.exec_())
