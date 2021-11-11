print("1번문제>>>")
i = 0
while i < 10:
    print(i)
    i += 1
    if i == 10:
        break
print("2번문제>>>")
i = 10
while i > -1:
    i -= 1
    print(i)
    if i == 0:
        break

print("3번문제>>>")
num = 0
while 3 * (num / 2) < 64:
    num += 1
print(num)

print("4번문제>>>")
lcm = 1
while not bool(45 * lcm == 0 and 45 * lcm % 45 == 0):
    lcm += 1
    if bool(45 * lcm % 6 == 0 and 45 * lcm % 45 == 0):
        break
print('lcm = ', 45*lcm)

print("5번문제")
gcm = 43
gc = []
while gcm > 0:
    gcm -= 1
    if gcm == 0:
        break
    elif bool(42 % gcm == 0 and 120 % gcm == 0):
        gc += str(gcm)
        continue
print('gcm = ', int(max(gc)))

print("6번문제>>>")
for i in range(1, 10):
    if 7 * i % 2 == 0:
        print(7 * i, end=' ')

print()
print("7번문제>>>")
i = 2
while i < 100:
    i += 1
    if i % 2 == 0 and i % 3 == 0:
        print(i)
        continue
