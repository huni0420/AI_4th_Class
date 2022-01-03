import pandas as pd
import numpy as np
df = pd.read_csv('https://bit.ly/perch_csv_data')
perch_full = df.to_numpy()

print(perch_full[:5])
print(perch_full.shape)
