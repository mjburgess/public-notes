# ADVANCED SUPPLEMENTAL 

# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Complete the defintions of the given classes.
# TIME:       20 m

class Piece:
    pass


class Path(Piece):
    def __str__(self):
        return '.'


class Player(Piece):
    def __str__(self):
        return 'P'


class Monster(Piece):
    def __str__(self):
        return 'M'


class Board:
    def __init__(self):
        self.pieces = [Player()] + [Path(), Monster(), Path()] * 3

    def __iter__(self):
        return iter(self.pieces)


# Q. without running the code, 
# what does the following print?
my_board = Board()
for item in my_board:
    print(item)

# EXTRA


# Q. define a class Frame, every frame should have a Board()
# when an object of type Frame is printed (ie., converted to string)
# it should ouput every piece on the Board() separated by a space

class Frame:
    def __init__(self):
        self.board = Board()

    def __str__(self):
        return ' '.join(map(str, self.board))


print(Frame())


''' OUTPUT (11.OO/Solution11-OOF-Specials.py):
P
.
M
.
.
M
.
.
M
.
P . M . . M . . M .

'''
