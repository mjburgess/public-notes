# CHAPTER:    File Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using the Dir and IO modules, create and analyse astronomical data files.
# TIME:       15m

# QUESTIONS

messier = 
"M40   Winnecke 4                        Double star             Ursa Major
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
M58                                     Spiral galaxy           Virgo"

# Q. write the messier text to a file called data.txt 
IO.write('data.txt', messier)   # , OR, open() etc.

# Q. open your data file and read it line-by-line 
#... for each line,
#... use a slice to print the messier number
#... and title of those lines with titles
# HINT: line[0..3]  line[6..20] 

info = {}
open('data.txt').each { |line|
  info[line[0..3]] = line[6..20]

  print line[0..3], line[6..20]
}

# Q. modify the above loop to record the messier numbers and titles in a hash 

# Q. write this hash, as yaml, to data.yaml 
require 'yaml'

IO.write('data.yaml', info.to_yaml) # , OR, open() etc.

# Q. read this yaml file and display the data 
YAML.load(IO.read('data.yaml')).each { |num, title|
  puts num, title
}


# EXTRA
# Q. delete data.yaml and data.txt
# HINT: use the File library

File.unlink('data.yaml')
File.unlink('data.txt') 		# or, .delete



## REVIEW: What did we learn from this exercise?