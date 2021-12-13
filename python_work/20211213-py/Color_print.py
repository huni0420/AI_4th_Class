import sys
from PyQt5 import uic
from PyQt5.QtWidgets import *
from PyQt5 import QtGui
import cv2

form_class = uic.loadUiType('색변경.ui')[0]


class MainWindow(QMainWindow, form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.label.setPixmap(QtGui.QPixmap("AA.jpg"))
        self.pushButton.clicked.connect(self.Extract)
        self.pushButton_2.clicked.connect(self.Del_red)
        self.pushButton_3.clicked.connect(self.All_red)
        self.pushButton_4.clicked.connect(self.All_gray)

    def Extract(self):
        img = cv2.imread('AA.jpg')
        roi = img[150:300, 200:400]
        img[250:400, 300:500] = roi
        cv2.imwrite('Extract_img.jpg', img)
        self.label.setPixmap(QtGui.QPixmap("Extract_img.jpg"))

    def Del_red(self):
        img = cv2.imread('AA.jpg')
        img[:, :, 2] = 0
        cv2.imwrite('AA_Del_red.jpg', img)
        self.label.setPixmap(QtGui.QPixmap("AA_Del_red.jpg"))

    def All_red(self):
        img = cv2.imread('AA.jpg')
        img[:, :, 2] = 255
        cv2.imwrite('AA_All_red.jpg', img)
        self.label.setPixmap(QtGui.QPixmap("AA_All_red.jpg"))

    def All_gray(self):
        img_basic = cv2.imread('AA.jpg', cv2.IMREAD_COLOR)
        img_gray = cv2.cvtColor(img_basic, cv2.COLOR_RGB2GRAY)  # RGR2GRAY
        cv2.imwrite('AA_gray.jpg', img_gray)
        self.label.setPixmap(QtGui.QPixmap("AA_gray.jpg"))


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MainWindow()
    mywindow.show()
    sys.exit(app.exec_())
