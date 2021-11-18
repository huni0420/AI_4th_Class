import sys
from PyQt5.QtWidgets import *
from studentExcel import StudentExcel


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        #
        # self.se = StudentExcel()
        # self.rowIndex = 0
        #
        self.initUI()
        # self.initEvent()
        #
        # self.loadfile()
    #
    #
    # def loadfile(self):
    #     rows = self.se.loadrow()
    #     for row in rows:
    #         self.qtable.setItem(self.rowIndex, 0, QTableWidgetItem(row[0]))
    #         self.qtable.setItem(self.rowIndex, 1, QTableWidgetItem(row[1]))
    #         self.qtable.setItem(self.rowIndex, 2, QTableWidgetItem(row[2]))
    #         self.qtable.setItem(self.rowIndex, 3, QTableWidgetItem(row[3]))
    #         self.qtable.setItem(self.rowIndex, 4, QTableWidgetItem(row[4]))
    #         self.rowIndex += 1
    #
    # def append(self):
    #
    #     try:
    #         kor = self.kor_edit.text()
    #         eng = self.eng_edit.text()
    #         math = self.math_edit.text()
    #
    #         tot = int(kor) + int(eng) + int(math)
    #         avg = int(((tot / 3) * 100)) / 100
    #
    #         self.qtable.setItem(self.rowIndex, 0, QTableWidgetItem(kor))
    #         self.qtable.setItem(self.rowIndex, 1, QTableWidgetItem(eng))
    #         self.qtable.setItem(self.rowIndex, 2, QTableWidgetItem(math))
    #         self.qtable.setItem(self.rowIndex, 3, QTableWidgetItem(str(tot)))
    #         self.qtable.setItem(self.rowIndex, 4, QTableWidgetItem(str(avg)))
    #
    #         self.se.appendrow(kor, eng, math, str(tot), str(avg))
    #
    #         self.rowIndex += 1
    #     except Exception as e:
    #         print(e)
    #
    # def delete(self):
    #     self.qtable.setItem(self.rowIndex-1, 0, QTableWidgetItem(''))
    #     self.qtable.setItem(self.rowIndex-1, 1, QTableWidgetItem(''))
    #     self.qtable.setItem(self.rowIndex-1, 2, QTableWidgetItem(''))
    #     self.qtable.setItem(self.rowIndex-1, 3, QTableWidgetItem(''))
    #     self.qtable.setItem(self.rowIndex-1, 4, QTableWidgetItem(''))
    #
    #     self.se.deleterow(self.rowIndex)
    #     self.rowIndex -=1
    #
    # def create(self):
    #     self.se.createfile()
    #
    # def initEvent(self):
    #     self.add_btn.clicked.connect(self.append)
    #     self.del_btn.clicked.connect(self.delete)
    #     self.create_btn.clicked.connect(self.create)

    def initUI(self):
        self.qtable = QTableWidget(self)

        self.qtable.setRowCount(10)
        self.qtable.setColumnCount(7)

        self.qtable.setHorizontalHeaderLabels(['학번','출석','퀴즈1','퀴즈2','중간고사','기말고사','프로젝트'])
        self.qtable.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)

        self.qtable.move(90, 170)
        self.qtable.setFixedSize(500, 250)

        num_label = QLabel("학번", self)
        num_label.move(40, 20)
        adc_label = QLabel("출석", self)
        adc_label.move(40, 41)
        que1_label = QLabel("퀴즈1", self)
        que1_label.move(40, 64)
        que2_label = QLabel("퀴즈2", self)
        que2_label.move(40, 86)
        middle_label = QLabel("중간고사", self)
        middle_label.move(40, 108)
        las_label = QLabel("기말고사", self)
        las_label.move(40, 130)
        pro_label = QLabel("프로젝트", self)
        pro_label.move(40, 151)

        self.num_edit = QLineEdit("", self)
        self.num_edit.move(100, 15)
        self.adc_edit = QLineEdit("",self)
        self.adc_edit.move(100, 37)
        self.que1_edit = QLineEdit("", self)
        self.que1_edit.move(100, 59)
        self.que2_edit = QLineEdit("", self)
        self.que2_edit.move(100, 81)
        self.mid_edit = QLineEdit("", self)
        self.mid_edit.move(100, 103)
        self.las_edit = QLineEdit("", self)
        self.las_edit.move(100, 125)
        self.pro_edit = QLineEdit("",self)
        self.pro_edit.move(100, 147)


        self.add_btn = QPushButton("추가", self)
        self.add_btn.move(400, 30)
        self.del_btn = QPushButton("수정", self)
        self.del_btn.move(400, 55)
        self.del_btn = QPushButton("삭제", self)
        self.del_btn.move(400, 80)
        self.create_btn = QPushButton("파일생성", self)
        self.create_btn.move(400, 105)

        self.setWindowTitle("student_score pg")
        self.move(300, 300)
        self.resize(700, 500)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())