print("1번문제")
st = []
st.append(1)
st.append(2)
st.append(3)
print(st)
st.remove(1)
st.remove(2)
st.remove(3)
print(st)

print()

print("2번문제")
st = []
st.append(1)
st.append(2)
st.append(3)
print(st)
st.pop(-1)
print(st)
st.pop(1)
print(st)
st.pop()
print(st)

print()
print("3번문제")
st = [1, 2, 3, 4]
st = []
print(st)

print()
print("4번문제")
st = []
for i in range(1, 11):
    st.append(i)
print(st)
for i in range(1, 11):
    st.remove(i)
print(st)
#
# print()
# print("5번문제")
# st =[]
# for i in range(1,11):
#     st.append(i)
# print(st)
# for i in range(1,11):
#     st.pop()
# print(st)

print()
print("6번문제")
st = [1,2]
st[2:] = [3,4,5]
print(st)