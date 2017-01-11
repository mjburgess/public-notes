# 0.Example.BadBaking.py

ing = ["eggs", "flour", "sugar"]
m = []
for i in ing:
    print i
    m.append((i, 100))

t = 0
for i,a in m:
    t += a
    
if len(m) == 3 and t <= 3*100:
    print "baking"
    bake = True

baked = 0
while bake:
    cont = raw_input('Y|N? ')
    if cont == 'N':
        bake = False
    else:
        baked += 1


print baked, "s"
print m







