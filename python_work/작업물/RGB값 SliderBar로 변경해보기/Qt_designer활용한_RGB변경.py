import sys
from PyQt5 import uic
from PyQt5.QtWidgets import *

form_class = uic.loadUiType('color.ui')[0]

class MainWindow(QMainWindow, form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)

        # 기본 라벨텍스트 설정
        self.label.setText("R: 0")
        self.label_2.setText("G: 0")
        self.label_3.setText("B: 0")

        # 기본 라벨텍스트 글자색
        self.label.setStyleSheet("color: red")
        self.label_2.setStyleSheet("color: green")
        self.label_3.setStyleSheet("color: blue")

        # 색깔 나타낼 라벨 기본바탕색
        self.label_4.setStyleSheet("background-color: black")

        # 수평바 최대 범위
        self.horizontalSlider.setMaximum(255)
        self.horizontalSlider_2.setMaximum(255)
        self.horizontalSlider_3.setMaximum(255)

        # 수평바 값변화에 따른 라벨 값 주기
        self.horizontalSlider.valueChanged.connect(self.Label)
        self.horizontalSlider_2.valueChanged.connect(self.Label)
        self.horizontalSlider_3.valueChanged.connect(self.Label)

        # 색깔 나타낼 바벨 RGB값 주는 버튼
        self.pushButton.clicked.connect(self.doA)

    # 바탕색 주는 메서드
    def doA(self):
        r= str(self.horizontalSlider.value())
        g= str(self.horizontalSlider_2.value())
        b= str(self.horizontalSlider_3.value())
        self.label_4.setStyleSheet("background-color: rgb("+r+","+g+","+b+")")

    # 라벨에 현재 RGB값 나타내주는 메서드
    def Label(self):
        self.label.setText("R: "+str(self.horizontalSlider.value()))
        self.label_2.setText("G: "+str(self.horizontalSlider_2.value()))
        self.label_3.setText("B: "+str(self.horizontalSlider_3.value()))

if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MainWindow()
    mywindow.show()
    sys.exit(app.exec_())