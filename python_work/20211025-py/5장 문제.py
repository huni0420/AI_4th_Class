1
st = [1, 2, 3, 4]
print(st[0], st[1], st[2], st[3])

2
st = [1, 2, 3, 4]
print(st[-1], st[-2], st[-3], st[-4])

3
st = [1, 2, 3, 4]
st1 = [0, 0, 0, 0]
st1[0] = st[0]+1
st1[1] = st[1]+1
st1[2] = st[2]+1
st1[3] = st[3]+1
st=st1
print(st)
4
st = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
st1 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
for i in range(10):
    st1[i] = st[i] + 1
st = st1
print(st)

5
st = [1, 2, 3, 4, 5, 6]
st1 = [0, 0, 0, 0, 0, 0]
st1[0] = st[5]
st1[5] = st[0]
st1[1:5] = st[1:5]
st = st1
print(st)

