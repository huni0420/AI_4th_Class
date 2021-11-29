import sys
from PyQt5 import QtWidgets
from PyQt5 import uic

import xlsx
from xlsx import Customer_Email
from PyQt5.QtWidgets import *

class Dialog1(QDialog):
    def __init__(self,parent):
        super(Dialog1, self).__init__(parent)
        Email_ui = './dialog1.ui'
        uic.loadUi(Email_ui,self)
        self.xl = xlsx.Customer_Email()
        self.pushButton.clicked.connect(self.EmailPush)
        # self.pushButton_2.clicked.connect(self.Email)
        self.show()

    def EmailPush(self):#라인텍스트 안글자가 출력
        try:
            print('일로오나')
            self.email = self.lineEdit.text()
            self.xl.SaveEmail(self.email)
            # print(self.lineEdit_2.text())
        except Exception as e:
            print(e)