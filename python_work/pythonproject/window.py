import sys
from PyQt5 import uic
from PyQt5.QtWidgets import *
import Dialog1
import Dialog2
from xlsx import Customer_Email

form_class = uic.loadUiType('MainWindow.ui')[0]


class MainWindow(QMainWindow, form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.le =None
        self.xl = Customer_Email()
        self.pushButton.clicked.connect(self.Dialog1)
        self.pushButton_3.clicked.connect(self.Dialog2)
        self.pushButton_5.clicked.connect(self.makexl)

    def Dialog1(self):  # 버튼으로 아이디 입력창 호출
        try:
            Dialog1.Dialog1(self)
        except Exception as e:
            print(e)

    def Dialog2(self):
        try:
            Dialog2.Dialog2(self)
        except Exception as e:
            print(e)
    def makexl(self):
        self.xl.CreateEmail_xl()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MainWindow()
    mywindow.show()
    sys.exit(app.exec_())