1.

def a(a, b):
    print(a / b)
    print(a % b)


a(3, 2)
a(1000, 4)

2.
def sum(a, b):
    su = 0
    for i in range(a + 1, b):
        su += i
    return su


print(sum(2, 5))
print(sum(1, 5))
