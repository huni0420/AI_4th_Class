import sys
from PyQt5.QtWidgets import *
from PyQt5 import uic
from PyQt5.QtGui import *

form_class = uic.loadUiType('window2.ui')[0]

class Window2(QMainWindow,form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = Window2()
    mywindow.show()
    sys.exit(app.exec_())