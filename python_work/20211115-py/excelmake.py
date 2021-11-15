from openpyxl import *

class Excemake:
    wb = Workbook()
    ws = wb.active

    wb.save("Excel.xlsx")
    wb.close()