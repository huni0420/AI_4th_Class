import sys
from PyQt5.QtWidgets import *
import exexcel as bbb


class MyApp(QWidget):

    def __init__(self):
        super().__init__()
        self.initUI()

    def makefile(self):
        bbb.makebasic()

    def manjumfn(self):
        bbb.dmanjum()
        QMessageBox.information(self, 'title', '10점으로 다 바꿈')

    def initUI(self):
        self.filebtn = QPushButton("파일 만들기")
        self.manjumbtn = QPushButton("퀴즈2 만점만들기")
        self.총점버튼 = QPushButton("총점 버튼")
        self.성적버튼 = QPushButton("성적 버튼")

        # 가로로된 레이아웃 만들기
        self.hbox = QHBoxLayout()

        # 가로로된 레이아웃에 버튼 넣기
        self.hbox.addStretch(1)
        self.hbox.addWidget(self.filebtn)
        self.hbox.addWidget(self.manjumbtn)
        # self.hbox.addWidget(self.총점버튼)
        # self.hbox.addWidget(self.성적버튼)
        self.hbox.addStretch(1)

        self.hbox2 = QHBoxLayout()

        self.hbox2.addStretch(1)
        self.hbox2.addWidget(self.총점버튼)
        self.hbox2.addWidget(self.성적버튼)
        self.hbox2.addStretch(1)

        # 세로로된 레이아웃 만들기
        self.vbox = QVBoxLayout()

        # 세로로된 레이아웃에 버튼 넣기
        self.vbox.addStretch(3)
        self.vbox.addLayout(self.hbox)
        self.vbox.addLayout(self.hbox2)
        self.vbox.addStretch(1)

        self.setLayout(self.vbox)
        self.setWindowTitle('First Application')
        self.move(300, 300)
        self.resize(200, 200)
        self.show()

        # 버튼에 이벤트 달기
        self.filebtn.clicked.connect(self.makefile)
        self.manjumbtn.clicked.connect(self.manjumfn)
        self.총점버튼.clicked.connect(bbb.총점)
        self.성적버튼.clicked.connect(bbb.성적)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
