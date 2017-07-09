# NAMESPACES 

""" NOVICE ASIDE:

Why do we use namespaces?

To group the names of related data(, functions, classes, etc.). 
To stop names leaking out into unexpected reigions.
"""

# python holds the name of each variable and its value in memory
# the set of names and their values is known as a "namespace", a space for names
# in python these are available as dictionaries


print(locals())  # the local namespace dictionary

print(dir())  # just the names

new_name = 100

print(dir())  # you'll see new_name has been added!

# 2. scopes
# a reigion of code where variable names are "local" is called a scope
# for example below there are *two* variables,  result at file-scope and result in the function f's scope

result = 1


def f():
    result = 2
    print(locals())  # shows only f's result


f()


# python keeps track of variables in each scope with namespaces    


# if a variable isnt defined inside a namespace
# python will read from the *parent* or enclosing namespace above

def g():
    print(locals())  # empty!
    print(result)  # reads from the file's namespace, so shows 1
    print(globals())  # lists all the names *readable* from this location
    # ie., the names in the parent namespace


g()


# you cannot write to a parent namespace however
# python understands assignment to "shadow" the name in a parent namespace
# in the function f above f's "result" shadows the file's "result" so that each is a different variable

# if you wish to modify which object a parent's name refers to, 
# ie. make the assignment operation (=) work on the parent's variable then you need the global keyword


def z():
    global result
    result = 200


z()
print(result)  # 200 -- z() has changed it!

# 3. granularity

x = 0  # "module" or file-scope

print(locals())  # this is the module's namespace (ie. everything in file scope)


# MODULE
def k():  # k is define in the module's namespace         # MODULE
    x = 2  # x is define in k's namespace                   # k
    y = 1  # k
    print(locals())  # k

    # k
    def g():  # g is defined in k's namespace                   # k
        x = 3  # x is define in g's                            # g
        print(locals())  # g

        # g
        def h():  # h is defined in g's                          # g
            x = 4  # x is defined in h's                            # h
            print(locals())  # h
            # g

        h()  # g
        print(locals())  # g
        # k

    g()  # k
    print(locals())  # k
    # MODULE


print(locals())  # MODULE

k()


# you can think of a namespace as a box inside another box
# h is inside g is inside k is inside the module (this file)
# h reads from g reads from k reads from the module (... reads from the builtins module)


''' OUTPUT (08.Functions/Demo08-03.3.Namespaces.py):
{'__loader__': <_frozen_importlib_external.SourceFileLoader object at 0x10bdb8828>, '__spec__': None, '__builtins__': <module 'builtins' (built-in)>, '__cached__': None, '__file__': '08.Functions/Demo08-03.3.Namespaces.py', '__name__': '__main__', '__package__': None, '__doc__': ' NOVICE ASIDE:\n\nWhy do we use namespaces?\n\nTo group the names of related data(, functions, classes, etc.). \nTo stop names leaking out into unexpected reigions.\n'}
['__builtins__', '__cached__', '__doc__', '__file__', '__loader__', '__name__', '__package__', '__spec__']
['__builtins__', '__cached__', '__doc__', '__file__', '__loader__', '__name__', '__package__', '__spec__', 'new_name']
{'result': 2}
{}
1
{'__name__': '__main__', 'new_name': 100, '__spec__': None, '__cached__': None, '__file__': '08.Functions/Demo08-03.3.Namespaces.py', 'f': <function f at 0x10beeb0d0>, 'g': <function g at 0x10beeb158>, '__loader__': <_frozen_importlib_external.SourceFileLoader object at 0x10bdb8828>, '__builtins__': <module 'builtins' (built-in)>, '__package__': None, 'result': 1, '__doc__': ' NOVICE ASIDE:\n\nWhy do we use namespaces?\n\nTo group the names of related data(, functions, classes, etc.). \nTo stop names leaking out into unexpected reigions.\n'}
200
{'__name__': '__main__', 'new_name': 100, 'x': 0, '__spec__': None, '__cached__': None, '__file__': '08.Functions/Demo08-03.3.Namespaces.py', 'f': <function f at 0x10beeb0d0>, 'g': <function g at 0x10beeb158>, '__loader__': <_frozen_importlib_external.SourceFileLoader object at 0x10bdb8828>, '__builtins__': <module 'builtins' (built-in)>, '__package__': None, 'result': 200, 'z': <function z at 0x10beeb1e0>, '__doc__': ' NOVICE ASIDE:\n\nWhy do we use namespaces?\n\nTo group the names of related data(, functions, classes, etc.). \nTo stop names leaking out into unexpected reigions.\n'}
{'__name__': '__main__', 'new_name': 100, 'x': 0, '__spec__': None, 'k': <function k at 0x10beeb268>, '__cached__': None, '__file__': '08.Functions/Demo08-03.3.Namespaces.py', 'f': <function f at 0x10beeb0d0>, 'g': <function g at 0x10beeb158>, '__loader__': <_frozen_importlib_external.SourceFileLoader object at 0x10bdb8828>, '__builtins__': <module 'builtins' (built-in)>, '__package__': None, 'result': 200, 'z': <function z at 0x10beeb1e0>, '__doc__': ' NOVICE ASIDE:\n\nWhy do we use namespaces?\n\nTo group the names of related data(, functions, classes, etc.). \nTo stop names leaking out into unexpected reigions.\n'}
{'y': 1, 'x': 2}
{'x': 3}
{'x': 4}
{'h': <function k.<locals>.g.<locals>.h at 0x10beeb378>, 'x': 3}
{'g': <function k.<locals>.g at 0x10beeb2f0>, 'y': 1, 'x': 2}

'''
