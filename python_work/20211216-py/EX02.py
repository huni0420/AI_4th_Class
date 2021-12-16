import cv2

img = cv2.imread('hid.jpg')

print(img.shape)


w = img.shape[0] / 2
h = img.shape[1] / 2


M = cv2.getRotationMatrix2D(center=(w, h), angle=-30, scale=0.5)
dst = cv2.warpAffine(img, M, (323, 299))
cv2.imshow('title', dst)
cv2.waitKey(0)
