import time

import pyautogui

# pyautogui.PAUSE = 1

# for i in range(5):
#     pyautogui.move(100,100)
#
#
# img = pyautogui.screenshot()
# img.save('a.png')


for i in range(5):
    time.sleep(1)
    x, y = pyautogui.position()
    pi = pyautogui.pixel(x, y)
    print('r g b', pi)
