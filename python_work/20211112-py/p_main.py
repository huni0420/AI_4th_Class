import sys
from PyQt5.QtWidgets import *
from PyQt5 import uic
from p_MyExcel import MExcel

form_class = uic.loadUiType("a.ui")[0]


class MyApp(QMainWindow, form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.mex = MExcel()
        pm = QPixmap()
        self.savebtn.clicked.connect(self.savefn)
        self.loadbtn.clicked.connect(self.loadfn)
        self.createbtn.clicked.connect(self.createfn)

    def savefn(self):
        try:
            ko = self.koedit.text()
            eng = self.engedit.text()
            math = self.mathedit.text()
            tot = int(ko) + int(eng) + int(math)
            avg = tot / 3
            print('tot = ', tot)
            print('avg = ', avg)
            self.mex.savefn(ko, eng, math, tot, avg)
        except Exception as e:
            print(e)
    def loadfn(self):
        self.mex.loadfn()

    def createfn(self):
        self.mex.createfn()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MyApp()
    mywindow.show()
    sys.exit(app.exec_())