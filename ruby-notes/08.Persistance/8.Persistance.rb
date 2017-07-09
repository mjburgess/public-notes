# CHAPTER 8:  Persistance

## WHY IS THIS IMPORTANT?: 
## 
## 


# STREAMS 
$stderr.puts  "error message"
STDERR.puts   "error message"
$stderr.print "error message\n"
STDERR.write  "error message\n"

prefix = 'GREETING'
message = 'Hello World!'

STDOUT << prefix << ": " << message << $\

# ARGF 

# p ARGF

# ARGF can be used like any other IO object
# Treats files specified in ARGV as one huge concatenated file

pattern = ARGV.shift
ARGF.each do |line|
  if line =~ /#{pattern}/
    print ARGF.filename, ": "
    puts line
  end
end

# KERNAL IO METHODS
p gets
p readline

print '5 Apples'
printf '%d %s' % [5, 'Apples']


p test('e', "8.Persistance.rb") # existence test
                                # check ri for full list


# WRITING FILES 

fout = open('message.txt', 'w')
fout.puts('Good Morning!', 'Good Afternoon!', 'Good Evening!')

IO.write('message.txt', "Morning Vicar!\nAfternoon Maam!\nEvening Curate!")

# READING FILES 
foo = open('message.txt')
while line = foo.gets
  puts line
end
foo.close

open('message.txt').each { |line| 
    puts line
}

open('message.txt') do |file|
  file.each_line { |line|
    printf "%03d: %s" % [$., line]
  }
end

p IO.read('message.txt')

lines = IO.readlines('message.txt')

p "Number of lines:     #{lines.length}"
p "First line:          #{lines[0]}"


# RANDOM ACCESS 

index = {}
file = open('message.txt', 'rb')
file.each do |line|
  words = line.split
  index[words[0]] = file.tell - line.length # index on first word
end


first = 'Morning'
file.seek(index[first])    # get line using first word
print file.gets

# BINARY FILES

# using String#unpack, pack using Array#pack


data  = IO.binread('bindata', 1024)
clean = data.unpack('iida80')
tidy  = clean[-1].chomp(0.chr)

# {    int a;    int b; double c; char name[80]; } 

# THE FILE CLASS 

Dir.glob('*.rb').each do |filename|
  stat  = File.stat(filename)
  perms = stat.mode & 07777
  size  = File.size(filename) 
  time  = File.ctime(filename).asctime

  case 
  when File.symlink?(filename)
    mode = 'l'
    filename = "%s -> %s" % [filename, File.readlink(filename)]
  when File.file?(filename)
    mode = '-'
  when File.directory?(filename)
    mode = 'd'
  else
    mode = '?'
  end
  print "%c %04o %6d %s %-s\n" % [mode, perms, size, time, filename]
end


# MARSHAL
open('index.rm', 'wb') {|fo| Marshal.dump(index, fo)}
index = Marshal.load(open('index.rm', 'rb'))
IO.binwrite('indexb.rm', Marshal.dump(index))
index = Marshal.load(IO.binread('indexb.rm'))

# YAML 
require 'yaml'
data = {
    name: 'Fido',
    owner: 'John'
}
IO.write('index.yaml', data.to_yaml)
index = YAML.load(IO.read('index.yaml'))



# FILE DATA

while line = DATA.gets
  puts line
end

__END__
Test data 1
The quick brown fox
1 2 3 4
