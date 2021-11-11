def add1(a):
    for i in range(0,5):
        a[i]+=1
    a.remove(6)
    return a

st1 = [1, 2, 3, 4, 5]
add1(st1)
print(st1)
