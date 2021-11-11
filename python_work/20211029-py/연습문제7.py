print("1번문제")
def main(a):
    if 0 <= a:
        print("입력한 값은 0이거나 0보다 큽니다.")
    elif 0 > a:
        print("입력한 값은 0보다 작습니다.")


a = input("정수를 입력하세요:")
main(eval(a))

print()
print("2번문제")
def main(b):
    if b < 0:
        print("입력한 값은 0보다 작습니다.")
    elif 0 <= b < 10:
        print("입력한 값은 0이상 10미만입니다.")
    elif 10 <= b < 20:
        print("입력한 값은 10이상 20미만 입니다")
    else:
        print("입력한 값은 20이상입니다.")


b = input("정수를 입력하세요:")
main(eval(b))


print()
print("3번문제")
def main(c):
    if c>=0:
        c*=c
        print(c)
    elif c<0:
        print("정수가 아닙니다.")

c = input("정수를 입력하세요: ")
main(eval(c))

