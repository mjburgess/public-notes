# 0.Example.OkBaking.py

import sys

def get_mixture(ingredients, amount=100):        
    mix = []
    for ingredient in ingredients:
        mix.append((ingredient, amount))

    return mix


def get_mixture_volume(mix):
    total = 0
    for ingredient, amount in mix:
        total += amount

    return total

def is_cookable(mix, vol, amount=100):
    MAX_INGREDIENTS = 3
    MAX_AMOUNT = MAX_INGREDIENTS * amount

    return len(mix) == MAX_INGREDIENTS and vol <= MAX_AMOUNT

def bake_time():
    baking_time = 0
    while True:
        cont = raw_input('Y|N? ')
        
        if cont == 'N':
            break
        
        baking_time += 1

    return baking_time


mix = get_mixture(ingredients=["eggs", "flour", "sugar"])
vol = get_mixture_volume(mix)

if is_cookable(mix, vol):
    time = bake_time()
    print "baking"
    print time, 's'
    print mix
else:
    print "too muhc to bake!"


    







