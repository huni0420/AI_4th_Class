#1+2+3+4+5
# 함수 파라메타의 기본값을 지정하는 문법
def main(a=5): #함수의 정의
    sum = 0
    for i in range(1, a+1):
        sum = sum + i
    print("sum = ", sum, end='')


main(10)