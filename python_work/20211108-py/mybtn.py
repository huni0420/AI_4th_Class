import sys
from PyQt5.QtWidgets import QApplication, QWidget, QPushButton, QVBoxLayout

import chapter5
from random import randint

'''
    lineEdit -> input 태그 한줄쓰고...
    button excel 파일저장
'''
# import ex04


class MyApp(QWidget):

    def __init__(self):
        super().__init__()
        self.initUI()

    def initUI(self):
        btn1 = QPushButton('&Button1', self)
        btn1.setCheckable(True)
        btn1.toggle()

        btn2 = QPushButton(self)
        btn2.setText('Button&2')

        btn3 = QPushButton('Button3', self)
        btn3.setEnabled(False)

        vbox = QVBoxLayout()
        vbox.addWidget(btn1)
        vbox.addWidget(btn2)
        vbox.addWidget(btn3)

        btn1.clicked.connect(self.btn1clickd)
        btn2.clicked.connect(self.btn2clickd)

        self.setLayout(vbox)
        self.setWindowTitle('QButton')
        self.setGeometry(300, 300, 300, 200)
        self.show()

    def btn1clickd(self):
        print("누름")

    def btn2clickd(self):
        chapter5.dxlsx(str(randint(0,100)))


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
