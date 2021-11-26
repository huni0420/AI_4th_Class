import sys
from PyQt5.QtWidgets import *
from PyQt5 import uic
from PyQt5.QtGui import *
form_class = uic.loadUiType('window1.ui')[0]

class Window1(QMainWindow,form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.pushButton.clicked.connect(self.customer)

    def customer(self):
        self.
        print(self.text1)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = Window1()
    mywindow.show()
    sys.exit(app.exec_())