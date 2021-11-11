1
st = [1, 2, 3, 4, 5]
st[1:4] = [3]

print(st)

2
st = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
nt = st[0:10:2]
print(nt)

3
st = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
nt = st[1:10:2]
print(nt)

4

def sum_all(a):
    st = 0
    for i in range(5):
        st += a[i]
    return st


result = sum_all([1, 2, 3, 4, 5])
print(result)

5

def show_reverse(a):
    a.reverse()
    return a

result = show_reverse([1, 2, 3, 4, 5])
print(result)

result = show_reverse("ABCDEF")
print(result)