from sklearn.linear_model import LinearRegression

x = [[0, 1], [0, 2], [0, 3]]
y = [2, 4, 6]
lr = LinearRegression()
lr.fit(x, y)

pre_y = lr.predict([[0, 4],[0,5],[0,6]])
print(pre_y)

'''
import cv2

img = cv2.imread('hid.jpg')
cv2.imshow('imasdf', img)
cv2.waitKey(2000)

expand = cv2.resize(img, None, fx=2.0, fy=2.0, interpolation=cv2.INTER_CUBIC)
cv2.imshow('expand', expand)
cv2.imwrite('hid_expand.jpg', expand)
cv2.waitKey(2000)

small = cv2.resize(img, None, fx=0.5, fy=0.5, interpolation=cv2.INTER_AREA)
cv2.imshow('small', small)
cv2.imwrite('hid_samll.jpg', small)
cv2.waitKey(2000)

print(img.shape)
print(expand.shape)
print(small.shape)
'''
