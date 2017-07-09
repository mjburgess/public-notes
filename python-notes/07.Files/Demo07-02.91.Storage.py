# STORAGE 

## PICKLE (SIMPLE PERSISTANCE)
class Dog:
    NUM_LEGS = 4


import pickle

data = {
    'key': 'value',
    'missing': None,
    'present': True,
    'height': 1.81,
    'location': (10, 20),
    'pet': Dog()
}

serial = pickle.dumps(data)
print(pickle.loads(serial))

## COMPRESSION
import gzip

with gzip.open('file.gz', 'wb') as f:
    pickle.dump(data, f)

## SQL

import sqlite3

db = sqlite3.connect('sample.db')
cursor = db.cursor()

cursor.execute('CREATE TABLE users( username TEXT );')
cursor.execute('INSERT INTO users VALUES ("Sherlock"), ("Watson");')
cursor.execute('SELECT * FROM users')

for row in cursor.fetchall():
    print(row)


## BINARY REPRESENTATION

import struct

bin_rep = struct.pack('!LL', 10, 20)
py_rep = struct.unpack('!LL', bin_rep)

print()
print("LL")
print(list(map(int, bin_rep)))
print(py_rep)

print()
print("iid7s")
bin_rep = struct.pack('!iid7s', 8, 8, 1.8, b'Michael')
py_rep = struct.unpack('!iid7s', bin_rep)

print(list(map(int, bin_rep)))
print(py_rep)

print(' '.join([hex(byte)[2:] for byte in bin_rep]))

# CLEAN UP
import os

os.unlink('file.gz')
os.unlink('sample.db')


''' OUTPUT (07.Files/Demo07-02.91.Storage.py):
{'height': 1.81, 'missing': None, 'key': 'value', 'location': (10, 20), 'present': True, 'pet': <__main__.Dog object at 0x101fdbf98>}
('Sherlock',)
('Watson',)

LL
[0, 0, 0, 10, 0, 0, 0, 20]
(10, 20)

iid7s
[0, 0, 0, 8, 0, 0, 0, 8, 63, 252, 204, 204, 204, 204, 204, 205, 77, 105, 99, 104, 97, 101, 108]
(8, 8, 1.8, b'Michael')
0 0 0 8 0 0 0 8 3f fc cc cc cc cc cc cd 4d 69 63 68 61 65 6c

'''
