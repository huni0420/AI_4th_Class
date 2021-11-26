import sys
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import *
from PyQt5 import uic
from PyQt5.QtGui import *
from window1 import Window1
form_class = uic.loadUiType('MainWindow.ui')[0]

class MainWindow(QMainWindow,form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.pushButton.clicked.connect(self.window1)


    def window1(self):
        self.ap = QtWidgets.QMainWindow()
        self.ui = Window1()
        self.ui.setupUi(self.ap)
        self.ap.show()



if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MainWindow()
    mywindow.show()
    sys.exit(app.exec_())