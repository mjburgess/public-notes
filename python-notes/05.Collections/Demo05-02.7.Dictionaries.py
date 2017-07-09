# DICTIONARIES 

# WHAT IS A DICTIONARY?

association = {}
association['key1'] = 'value1'
association['key2'] = 'value2'

# can be thought of as two lists..
for key in list(association.keys()):
    print(key)

for value in list(association.values()):
    print(value)

# PLUS.. an easy way to look up a value for a known key..

print(association['key1'])

# OR...
for key in list(association.keys()):
    print(association[key])

# OR...

for key in association:
    print(association[key])

## MUST DO: CALL AND RESPONSE ON DICTIONARY LOOPING  !


# 'keys', 'pop', 'popitem', 'setdefault', 'update', 'values',


hosts = {
    '192.168.0.1': 'pets.local',
    '192.168.0.2': 'football.local',
    '192.168.0.3': 'music.local',
}

print(list(hosts.keys()))
print(list(hosts.values()))
print(hosts.pop('192.168.0.1'))

hosts.update({
    '192.168.0.1': 'paint.local',
    '192.168.0.5': 'paint.local',

})

print(hosts)

for ip, host in hosts.items():
    print(ip, host)

for ip in hosts:
    print(ip, hosts[ip])

cart = ['eggs', 'milk']
prices = [3, 4]

basket = dict(list(zip(cart, prices)))
print(basket)


''' OUTPUT (05.Collections/Demo05-02.7.Dictionaries.py):
key2
key1
value2
value1
value1
value2
value1
value2
value1
['192.168.0.3', '192.168.0.2', '192.168.0.1']
['music.local', 'football.local', 'pets.local']
pets.local
{'192.168.0.3': 'music.local', '192.168.0.2': 'football.local', '192.168.0.5': 'paint.local', '192.168.0.1': 'paint.local'}
192.168.0.3 music.local
192.168.0.2 football.local
192.168.0.5 paint.local
192.168.0.1 paint.local
192.168.0.3 music.local
192.168.0.2 football.local
192.168.0.5 paint.local
192.168.0.1 paint.local
{'milk': 4, 'eggs': 3}

'''
