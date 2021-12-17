import cv2
import numpy as np
import matplotlib.pyplot as plt


catimg = cv2.imread('cat_resize.jpg')
rabbitimg = cv2.imread('rabbit.jpg')


sumimg = cv2.add(catimg,rabbitimg)
plt.imshow(cv2.cvtColor(sumimg,cv2.COLOR_RGB2GRAY))
plt.show()

# sumimg = np.add(catimg,rabbitimg)
# plt.imshow('sumnpimg',cv2.COLOR_RGB2GRAY)
# plt.show()

sumnpimg = np.add(catimg,rabbitimg)
plt.imshow(cv2.cvtColor(sumnpimg,cv2.COLOR_RGB2GRAY))
plt.show()