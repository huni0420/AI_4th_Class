import pyautogui

#현재 좌표에서 100,100좌표로 이동
# pyautogui.move(100, 100, duration=2)

pos = pyautogui.position()
print(pos)

# #절대 좌표에서 100,100좌표로 이동
# pyautogui.moveTo(100, 100, duration=2)
#
# pos = pyautogui.position()
# print(pos)

pyautogui.click(10,1061,duration=1)
pyautogui.click(373,498,duration=3)