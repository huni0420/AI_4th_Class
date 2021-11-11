alist = []
for i in range(1, 11, 1):
    alist.append(i)
print(alist)

for i in range(9, -1, -1):
    print("alist.pop(", i, ")", alist.pop(i))
print("alist = ", alist)
