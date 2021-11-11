# while루프 사용

# 홀수만 출력하면서 continue를 사용해야 합니다
# 100보다 큰 홀수 일때는 break
# 1,3,5,7,9,11,13


i = 1
sum = 0
while True:
    sum = sum + i
    if sum % 2 == 0:
        continue
    if sum > 100:
        break
    print(sum, end=' ')
