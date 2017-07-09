# CHAPTER:    File Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Analyse some astronomical data.  
# TIME:       15m

messier = """
M40   Winnecke 4                        Double star             Ursa Major
M42   Great Orion Nebula                Starforming nebula      Orion
M43   De Mairan's Nebula                Starforming nebula      Orion
M44   Beehive Cluster                   Open cluster            Cancer
M45   Pleiades                          Open cluster            Taurus
M49                                     Elliptical galaxy       Virgo
M50                                     Open cluster            Monoceros
M51   Whirlpool Galaxy                  Spiral galaxy           Canes Venatici
M52                                     Open cluster            Cassiopeia
M53                                     Globular cluster        Coma Berenices
M54                                     Globular cluster        Sagittarius
M56                                     Globular cluster        Lyra
M57   Ring Nebula                       Planetary nebula        Lyra
M58                                     Spiral galaxy           Virgo
"""

# Q. write the messier text to a file called data.txt 
data = open('data.txt', 'w')
data.write(messier)
data.close()

# Q. open your data file and read it line-by-line 
# ... for each line, split it into parts and print the messier number and title of those lines with titles  
    # HINT: line[0:3]  line[6:24] .isspace()
data_read = open('data.txt')

for line in data_read:
    number = line[0:3]
    title = line[6:24]

    if not number.isspace() and not title.isspace():
        print(number.strip(), 'is the number for', title.strip())

data_read.close()

import os

os.remove('data.txt')  # delete the file to clean up 
""" REVIEW

What did we learn from this exercise?

open() 
r w  modes 
line at a time from iterating (for-looping) over file objects 
.write()
.close()

"""


''' OUTPUT (07.Files/Solution07-FilesA-ReadWrite.py):
M40 is the number for Winnecke 4    
M42 is the number for Great Orion Ne
M43 is the number for De Mairan's Ne
M44 is the number for Beehive Cluste
M45 is the number for Pleiades      
M51 is the number for Whirlpool Gala
M57 is the number for Ring Nebula   

'''
