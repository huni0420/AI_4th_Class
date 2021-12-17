import cv2

cat_img = cv2.imread('cat.jpg', cv2.IMREAD_GRAYSCALE)

print(cat_img[0, 0])
print(cat_img[0, 1])
print(cat_img[0, 2])
print(cat_img[0, 3])
print(cat_img[0, 4])
print(cat_img[0, 5])


cv2.imshow('cat_img', cat_img)
cv2.waitKey(0)

# tresh_img[0:40,0:30] = 255

ret, tresh_img = cv2.threshold(cat_img,75,255,cv2.THRESH_BINARY)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(cat_img,75,255,cv2.THRESH_BINARY_INV)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(cat_img,75,255,cv2.THRESH_TRUNC)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(cat_img,75,255,cv2.THRESH_TOZERO)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(cat_img,75,255,cv2.THRESH_TOZERO_INV)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)