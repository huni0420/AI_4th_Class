import cv2
import numpy as np
import sys
from PyQt5.QtWidgets import QApplication, QWidget
from PyQt5 import uic

form_class = uic.loadUiType('color.ui')[0]

class MyApp(QWidget, form_class):

    def __init__(self):
        super().__init__()
        self.initUI()
        self.img = np.full((300, 200, 3), 255, np.uint8)

        self.cv2.namedWindow('Image')

        self.horizontalSlider.valueChanged.connect(self.doA())
        self.horizontalSlider_2.valueChanged.connect(self.doA())
        self.horizontalSlider_3.valueChanged.connect(self.doA())

        self.PushButton..clicked.connect(self.doA())

        self.cv2.imshow("Image", self.img)

    def doA(x):
        r = self.horizontalSlider('R', 'Image')
        g = cv2.getTrackbarPos('G', 'Image')
        b = cv2.getTrackbarPos('B', 'Image')
        img[:] = [b, g, r]

    def initUI(self):
        self.setWindowTitle('First Application')
        # self.pushButton.clicked.connect(self.Dialog1)
        self.show()

if __name__ == '__main__':
   app = QApplication(sys.argv)
   ex = MyApp()
   sys.exit(app.exec_())