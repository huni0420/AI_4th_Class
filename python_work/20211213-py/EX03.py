import cv2

img_basic = cv2.imread('AA.jpg', cv2.IMREAD_COLOR)
cv2.imshow('basic', img_basic)
cv2.waitKey(0)
cv2.imwrite('AA_copy1.jpg', img_basic)

img_gray = cv2.cvtColor(img_basic, cv2.COLOR_RGB2GRAY)  # RGR2GRAY
cv2.imshow('gray', img_gray)
cv2.waitKey(0)
cv2.imwrite('AA_gray.jpg', img_gray)

print(img_gray[100, 100])
