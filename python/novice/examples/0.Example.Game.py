# 0.Example.Game.py

import os

def make_row(size, square):
    row = []
    for i in range(0, size):
        row.append(square)

    return row


def make_grid(height, width, square):
    grid = []
    for i in range(0, height):
        grid.append(make_row(width, square))

    return grid


def print_grid(grid):
    print
    for row in grid:
        print
        for cell in row:
            print cell + ' ',
    print

def place_piece(grid, xy, piece):
    grid[xy[0]][xy[1]] = piece
    
    return grid # somewhat optional


def new_grid(height, width):
    g = make_grid(height, width, '.')
    g = place_piece(g, (0,0), 'P')
    g = place_piece(g, (height - 1, width - 1), 'E')

    return g

def move_location(position, move):
    return (player_position[0] + move[0], player_position[1] + move[1])


def is_won(player_position, grid):
    return player_position == (len(grid) - 1, len(grid) - 1)
    
    
def move_player(grid, position, move):
    place_piece(grid, player_position, '.')
    place_piece(grid, move_location(player_position, move), 'P')
    
    return move_location(player_position, move)
    


grid = new_grid(5,5)

moves = { 'a': (0,-1),
          'd': (0, 1),
          's': (1, 0),
          'w': (-1,0) }

player_position = (0,0)

while not is_won(player_position, grid):
    print_grid(grid)

    move = raw_input('move? ')

    player_position = move_player(grid, player_position, moves[move])

    os.system('cls')

    
print "You Won!"
