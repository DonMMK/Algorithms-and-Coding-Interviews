import numpy as np
import scipy as sp
import pandas as pd
import sklearn


ser = pd.Series()
print('{}\n'.format(ser))

ser = pd.Series(10)
print('{}\n'.format(ser))

ser = pd.Series([0, 10, 20, 30, 40, 50, 60, 70, 80, 90])
print('{}\n'.format(ser))

ser = pd.Series([20, 15.7, '10'])
print('{}\n'.format(ser))

# A series from a numpy array
arr = np.array([0, 10, 20, 30, 40, 50])
ser = pd.Series(arr, dtype = np.double)
print('{}\n'.format(ser))

ser = pd.Series([[15, 4], [89, 23.5], [21, 22]])
print('{}\n'.format(ser))