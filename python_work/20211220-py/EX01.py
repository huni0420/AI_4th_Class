import cv2
import numpy as np


def doA(x):
    print(x, '이거 연결됨')
    r = cv2.getTrackbarPos('R', 'Image')
    g = cv2.getTrackbarPos('G', 'Image')
    b = cv2.getTrackbarPos('B', 'Image')
    img[:] = [b, g, r]
    cv2.imshow('Image', img)


# img = np.zeros((300, 200, 3), np.uint8)
img = np.full((300, 200, 3), 255, np.uint8)

cv2.namedWindow('Image')

cv2.createTrackbar('R', 'Image', 0, 255, doA)
cv2.createTrackbar('G', 'Image', 0, 255, doA)
cv2.createTrackbar('B', 'Image', 0, 255, doA)

cv2.imshow("Image", img)
cv2.waitKey(0)