import time

import pyautogui

aa = pyautogui.locateOnScreen('AA.png', confidence=0.8)
print(aa)
time.sleep(2)
pyautogui.click(aa)