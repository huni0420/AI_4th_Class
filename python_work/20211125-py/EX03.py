import pyperclip
import pyautogui

pyautogui.sleep(1)
pyautogui.write('1234')
pyautogui.sleep(1)
pyautogui.write('abcdefg', interval=0.25)


pyautogui.sleep(1)
pyperclip.copy('한글')


