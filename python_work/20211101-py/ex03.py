# 여러개를 return 할 수 있다.(only tuple에서만)
def doA():
    return (10, 20)


a, b = doA()
print("a = ", a, "b = ", b)
