# 1
#
#
# def int_div(a, b):
#     print("나머지는:", int(a % b))
#     print("몫은: ", int(a / b))
#
#
# int_div(5, 2)

2


def bet_sum(a, b):
    st = [0, 1, 2, 3, 4, 5, 6, 7, 8]
    sum = 0
    for i in st:
        if a < i < b:
            sum += i
    print(sum)


bet_sum(2, 5)
bet_sum(1, 5)
