import sys

from PyQt5.QtWidgets import *
from studentExcel import StudentExcel


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.se = StudentExcel()
        self.rowIndex = 0
        self.initUI()
        self.initEvent()
        self.loadfile()

    def loadfile(self):
        rows = self.se.loadrow()
        for row in rows:
            self.qtable.setItem(self.rowIndex, 0, QTableWidgetItem(row[0]))
            self.qtable.setItem(self.rowIndex, 1, QTableWidgetItem(row[1]))
            self.qtable.setItem(self.rowIndex, 2, QTableWidgetItem(row[2]))
            self.qtable.setItem(self.rowIndex, 3, QTableWidgetItem(row[3]))
            self.qtable.setItem(self.rowIndex, 4, QTableWidgetItem(row[4]))
            self.qtable.setItem(self.rowIndex, 5, QTableWidgetItem(row[5]))
            self.qtable.setItem(self.rowIndex, 6, QTableWidgetItem(row[6]))
            self.qtable.setItem(self.rowIndex, 7, QTableWidgetItem(row[7]))
            self.qtable.setItem(self.rowIndex, 8, QTableWidgetItem(row[8]))
            self.rowIndex += 1

    def append(self):

        try:
            num = self.num_edit.text()
            adc = self.adc_edit.text()
            que1 = self.que1_edit.text()
            que2 = self.que2_edit.text()
            mid = self.mid_edit.text()
            las = self.las_edit.text()
            pro = self.pro_edit.text()

            tot = int(adc) + int(que1) + int(que2) + int(mid) + int(las) + int(pro)
            b = int(num) - 1
            self.qtable.setItem(b, 0, QTableWidgetItem(num))
            self.qtable.setItem(b, 1, QTableWidgetItem(adc))
            self.qtable.setItem(b, 2, QTableWidgetItem(que1))
            self.qtable.setItem(b, 3, QTableWidgetItem(que2))
            self.qtable.setItem(b, 4, QTableWidgetItem(mid))
            self.qtable.setItem(b, 5, QTableWidgetItem(las))
            self.qtable.setItem(b, 6, QTableWidgetItem(pro))
            self.qtable.setItem(b, 7, QTableWidgetItem(str(tot)))
            a = int(adc)
            if a > 4:
                if tot > 90:
                    self.qtable.setItem(b, 8, QTableWidgetItem("A"))
                elif tot > 80:
                    self.qtable.setItem(b, 8, QTableWidgetItem("B"))
                elif tot > 70:
                    self.qtable.setItem(b, 8, QTableWidgetItem("C"))
                elif tot <= 70:
                    self.qtable.setItem(b, 8, QTableWidgetItem("D"))
            elif a <= 4:
                self.qtable.setItem(b, 8, QTableWidgetItem("F"))
        except Exception as e:
            print(e)

        self.se.appendrow(num, adc, que1, que2, mid, las, pro, tot)

    def correction(self):
        num = self.num_edit.text()
        adc = self.adc_edit.text()
        que1 = self.que1_edit.text()
        que2 = self.que2_edit.text()
        mid = self.mid_edit.text()
        las = self.las_edit.text()
        pro = self.pro_edit.text()

        tot = int(adc) + int(que1) + int(que2) + int(mid) + int(las) + int(pro)

        b = int(num) - 1
        self.qtable.setItem(b, 0, QTableWidgetItem(num))
        self.qtable.setItem(b, 1, QTableWidgetItem(adc))
        self.qtable.setItem(b, 2, QTableWidgetItem(que1))
        self.qtable.setItem(b, 3, QTableWidgetItem(que2))
        self.qtable.setItem(b, 4, QTableWidgetItem(mid))
        self.qtable.setItem(b, 5, QTableWidgetItem(las))
        self.qtable.setItem(b, 6, QTableWidgetItem(pro))
        self.qtable.setItem(b, 7, QTableWidgetItem(str(tot)))
        a = int(adc)
        if a > 4:
            if tot > 90:
                self.qtable.setItem(b, 8, QTableWidgetItem("A"))
                self.c = "A"
                return self.c
            elif tot > 80:
                self.qtable.setItem(b, 8, QTableWidgetItem("B"))
                self.c = "B"
                return self.c
            elif tot > 70:
                self.qtable.setItem(b, 8, QTableWidgetItem("C"))
                self.c = "C"
                return self.c
            elif tot <= 70:
                self.qtable.setItem(b, 8, QTableWidgetItem("D"))
                self.c = "D"
                return self.c
        elif a <= 4:
            self.qtable.setItem(b, 8, QTableWidgetItem("F"))
            self.c = "F"
            return self.c
        self.se.correction(num, adc, que1, que2, mid, las, pro, tot, self.c)

    def delete(self):
        num = self.num_edit.text()

        b = int(num) - 1
        self.qtable.setItem(b, 0, QTableWidgetItem(""))
        self.qtable.setItem(b, 1, QTableWidgetItem(""))
        self.qtable.setItem(b, 2, QTableWidgetItem(""))
        self.qtable.setItem(b, 3, QTableWidgetItem(""))
        self.qtable.setItem(b, 4, QTableWidgetItem(""))
        self.qtable.setItem(b, 5, QTableWidgetItem(""))
        self.qtable.setItem(b, 6, QTableWidgetItem(""))
        self.qtable.setItem(b, 7, QTableWidgetItem(""))
        self.qtable.setItem(b, 8, QTableWidgetItem(""))
        self.se.delete(num)
    def create(self):
        self.se.createfile()

    def initEvent(self):
        self.add_btn.clicked.connect(self.append)
        self.cor_btn.clicked.connect(self.correction)
        self.del_btn.clicked.connect(self.delete)
        self.create_btn.clicked.connect(self.create)

    def initUI(self):
        self.qtable = QTableWidget(self)

        self.qtable.setRowCount(10)
        self.qtable.setColumnCount(9)

        self.qtable.setHorizontalHeaderLabels(['학번', '출석', '퀴즈1', '퀴즈2', '중간고사', '기말고사', '프로젝트', '총점', '학점'])
        self.qtable.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)

        self.qtable.move(10, 190)
        self.qtable.setFixedSize(700, 250)

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
        self.adc_edit = QLineEdit("", self)
        self.adc_edit.move(100, 37)
        self.que1_edit = QLineEdit("", self)
        self.que1_edit.move(100, 59)
        self.que2_edit = QLineEdit("", self)
        self.que2_edit.move(100, 81)
        self.mid_edit = QLineEdit("", self)
        self.mid_edit.move(100, 103)
        self.las_edit = QLineEdit("", self)
        self.las_edit.move(100, 125)
        self.pro_edit = QLineEdit("", self)
        self.pro_edit.move(100, 147)

        self.add_btn = QPushButton("추가", self)
        self.add_btn.move(400, 30)
        self.cor_btn = QPushButton("수정", self)
        self.cor_btn.move(400, 55)
        self.del_btn = QPushButton("삭제", self)
        self.del_btn.move(400, 80)
        self.create_btn = QPushButton("파일생성", self)
        self.create_btn.move(400, 105)

        self.setWindowTitle("student_score pg")
        self.move(300, 300)
        self.resize(730, 500)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
