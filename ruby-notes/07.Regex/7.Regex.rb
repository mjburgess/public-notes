# CHAPTER 7:  Regex

## WHY IS THIS IMPORTANT?: 
## 
## 


# part two is noted before part one
# as part one is an extended discussion
# two serves better as a reference
# part one should be read first


# PART 2 -- RUBY REGEX

# REGEX OBJECTS
find_the = /the/

word = 'the'
find_word = /#{word}/

find_slash = %x{ /12/ }

from_string = Regexp.new "\d\d"


# MATCHING
s = 'I come to bury Ceasar, not to praise him.'

if s =~ /C[ea][ea]s[ea]r/     # match operator
  puts 'Julius is here'
end


s = 'I come to bury Ceasar, not to praise him.'
r = /C[ea][ea]s[ea]r/

if r.match(s)
  puts 'Julius is here'
end


# SUBSTITUTION
line = 'Ruby for Ruby Programmers'

p line.sub('Ruby', 'Scala')
p line.gsub('Ruby', 'Scala')

p line # not altered

line.sub!('Ruby', 'Haskell')

p line # altered


# OPTIONS
txt = "rohn\njames"

txt =~ /^j\w+/im

p txt.match(/^j\w+/, Regexp::IGNORECASE|Regexp::MULTILINE)

# also x Regexp::VERBOSE
# ( whitespace is ignored, allow comments )




# GROUPING: MATCH DATA
serv = 'http   80/tcp   www www-http    # WorldWideWeb HTTP'

serv =~ /\s\d+\/tcp\s/
puts "$`: #{$`}"      # pre-match
puts "$&: #{$&}"      # match
puts "$': #{$'}"      # post-match

serv =~ /(\w+)\s+(\d+)\/(\w+)\s+([^#]*)(#.*)?/
puts "service: %s\nport  : %d\nprotocol: %s" % [$1, $2, $3]


re = /(\w+)\s+(\d+)\/(\w+)\s+([^#]*)(#.*)?/
m = re.match(serv)

service, port, proto, names, comment = m.captures

puts "service : %s\nport    : %s\nprotocol: %s" % m[1..3]


# scan

ln = '<h3>London</h3><ul><li><a href="/london/cannon...'

re = /href=\"(.+?)\">(.+?)<\/a>/

ln.scan(re){ |href, name|
  puts "%s %s" % [href, name]
}

# match object reference

# begin(n)
# start position of match n

# captures
# array of all captures

# end(n)
# end position of match n

# offset(n)
# array of start and end positions

# post_match
# The string to the right of the match (as $')

# pre_match
# The string to the left of the match (as $`)





# PART 1 -- REGEX




#0. summary of principles

=begin
0. A regex means: find the 1st occurance of... 
1. Any character without a special meaning is literal
2. abc 123 - / etc. have no special meaning
3. . means ANY single character
4. ANY means 0 or more
5. SOME means 1 or more
6. [abc]  means match ONE character EITHER a b c 
7. [a-z]  means match ONE character in the RANGE a to z 
8. [^abc] means match ONE character NOT  a b c 
9. play(ing|er|able)  means play then EITHER ing OR er OR able
10. x{1, 4} means AT LEAST 1 x and AT MOST 4 x
11. x{0, 1} means x is optional (AT LEAST 0, AT MOST 1)
12. x{0,} means ANY amount of x  (AT LEAST 0, AT MOST infinite)
13. x{1,} means SOME amount of x (AT LEAST 1, AT MOST infinite)
14. x? means x{0,1}       x* means x{0,}        x+   means x{1,}
15. \s means [ \n\t\r]   \w means [a-bA-Z0-9_]  \d   means [0-9]
16. ^example.com    means THERE IS NOTHING BEFORE e , e is first
17. example.com$    means THERE IS NOTHING AFTER m  , m is last
18. (\w+)  REMEMBERS matched text
19. in replacement expressions, \1 refers to the first group matched, \2 the second, etc.

\w+\s+=\s+"[^"]*"  matches    user_name = "Michael"
=end

#1. regular expressions

# regular expressions are a language for specifying patterns of interest in text
# finding regularities, such as dates/names/postcodes/etc. in a large number of input documents
# is a very common problem

# let's explore the regular expressions language

# RUBY . matches 1 char


# --- ignore this for now... we'll come back to it ---
def show_match(pattern, text)
    match = pattern.match(text)
    puts
    puts "REGEX: #{pattern.inspect}"
    puts "INPUT: #{text}"

    if !match
        puts "MATCH: NONE!"
        return 
    end 

    range = match.begin(0)..(match.end(0) - 1) 
    
    puts "WHERE: #{' ' * range.begin}^#{'.' * (range.end - range.begin)}^"
    puts "MATCH: #{text[range]}"

    if !match.captures[0].nil?
        print 'GROUP: '
        print match.captures.map.with_index { |v, i| "#{i}: #{v}" }.join(', ')
    end 
    puts
end
# --- /ignore ---




# let's explore the regular expression language first, then the python lib.

# the show match function takes, as its first parameter, a string using the regular expresion language
# and its second parameter is a line of text to be searched for the pattern specified


# symbols without any significance

# any symbol without "special significance" in the regex lanugage is take literally

show_match %r(a), 'a' # this says match the *first occurance*  of an 'a' in the input`
show_match %r(a), 'aaabbbccc'



show_match %r(b), 'aaabbbccc'

show_match %r(quick), 'the quick brown fox'
show_match %r(quick brown), 'the quick brown fox'
show_match %r(the quick), 'the quick brown fox'
show_match %r(fox), 'the quick brown fox'



show_match %r(~), '~/my/directory'
show_match %r($), 'the price was $r200'



# .

# . means "any single character (ie. symbol)"

show_match %r(.), 'a' # first occurance of any symbol
show_match %r(.), 'ab'

show_match %r(..), 'ab' # the first occurance of two symbols

show_match %r(Mr. Holmes), 'Mr. Holmes'
show_match %r(Mr. Holmes), 'Mr# Holmes' #gotchas

#character classes


show_match %r([abc]), 'a'   # match the first occurance of a single character which is eitehr a, b or c
show_match %r([abc]), 'db'
show_match %r([abc]), 'ccc'


# ranges in character classes

show_match %r([0-9]), '0' # match the first occurance of a single character
show_match %r([0-9]), 'a' # in the range 0 to 9, ie. either 0123456789
show_match %r([0-9]), 'a12b' # in the range 0 to 9, ie. either 0123456789



show_match %r([a-z]), 'the QUICK brown FOX' # in the range a,b,c,d,..
show_match %r([A-Z]), 'the QUICK brown FOX' # in the range A,B,C
show_match %r([a-zA-Z]), 'the QUICK brown FOX' # in the range a,b,c,d,..,A,B,C...
show_match %r([a-zA-Z]), '1 QUICK brown FOX' # in the range a,b,c,d,..,A,B,C...


# inverse classes

# with a ^ at the begining of a character class any single symbol NOT in that class is selected

show_match %r([^0-9]), '0'
show_match %r([^0-9]), 'a'
show_match %r([^0-9]), 'a12b'

# so [^0-9] is every non-digit
# [^a-zA-Z] is every non-alphabetical character
# [^0-9a-zA-Z] is every non-alphanumeric character (ie., mosly punctuation/space symbols, eg. $%!"$%)
# [^\n] is not a newline
# [^\n ] is not a newline or a space



# thus far the expressions have meant "match the first occurance of ... at any position"
# we can force the regular expression engine to match only at the start or the end of the input

show_match %r(^Mr. Holmes), 'Mr. Holmes' # Match M at the start of the input
show_match %r(^Mr. Holmes), 'Thank you, Mr. Holmes'

# above the ^ (hat, caret) character means the pattern immediately following it must occur at the begining of the input


# the $ means it must occur at the end...


show_match %r(Holmes$), 'Mr. Holmes' # Match s at the start of the input
show_match %r(Holmes$), 'Mr. Holmes, your letter has arrived!'


# note that ^ and $ do not map to any characters themsleves..
# they are instructions which indicate where to look for characters



# quantifers

# quantifers tell you the quantity (amount of repetiton) of a particular pattern

show_match %r(OK{1, 2}), 'OK' # Match *at least* 1 K,  at most 2 K
show_match %r(OK{1, 2}), 'OKK' # Match *at least* 1 K,  at most 2 K
show_match %r(OK{1, 2}), 'OKKK' # Match *at least* 1 K,  at most 2 K

# the syntax is   P{l, m}
# P = pattern,  l = least number of Ps,  m = most number of Ps

# if you omit the second parameter, m, the pattern will match to infinity

show_match %r(OK{1,}), 'OKKKKKK!!' # Match *at least* 1 K up to any number


# you can use 0 to indicate that it need not occur
show_match %r(OK{0, 1}), 'O!!'
show_match %r(OK{0, 1}), 'OK!!'

# above then, K is optional


# there are some predefined characters that map to the common ranges:
# P{0,}  == any number of P == P*
# P{1,}  == at least one P  == P+
# P{0,1}  == no P or one P == P is optional == P?

show_match %r(100%?), '100'
show_match %r(100%?), '100%'  #% is matched, if it is there


show_match %r(100.0*), '100.000000'
show_match %r(100.0*), '100.'    # any number of 0 is matched


show_match %r(100.0+), '100.0000'
show_match %r(100.0+), '100.0'
show_match %r(100.0+), '100.'   # at least one 0 is required



# the grouping operator ()


# you may group several patters (eg. characters) into one with parentheses:


show_match %r(it was (very)* good), 'it was very very good!' # the * applies to (very)

show_match %r((OK )+), 'BAD '
show_match %r((OK )+), 'OK '
show_match %r((OK )+), 'OK OK OK '



# a pipe | may be used to select alternatives in parentheses


show_match %r((OK|GOOD)), 'OK'
show_match %r((OK|GOOD)), 'GOOD'
show_match %r((OK|GOOD)), 'BAD'


# predefined ranges


# the digraphs (two characters)  \w \d \s   related to some special character classes

# \w = [a-zA-Z0-9_] = all lower case, all uppercase, all digits and underscore characters
# \d = [0-9]  = all digits
# \s = [\t\n\r\f ] = all whitespace

show_match %r(\w+), 'the amount was $10' # the first occurance of \w repeated one or more times
show_match %r(\w+), '$10, the amount was $10'


show_match %r(\d+), 'the amount was $10'
show_match %r(\d+), '$10, the amount was $10'


show_match %r(\s+), 'the      amount was $10'
show_match %r(\s+), '   $10, the amount was $10'



# \W \D \S  all refer to  [^\w]  [^\d] [^\s]


show_match %r(\W+), 'the amount was $10' # the first occurance of \w repeated one or more times
show_match %r(\W+), '$10, the amount was $10'


show_match %r(\D+), 'the amount was $10'
show_match %r(\D+), '$10, the amount was $10'


show_match %r(\S+), 'the      amount was $10'
show_match %r(\S+), '   $10, the amount was $10'


#examples


# extracting

show_match %r(example.com(/[a-z]+)*), 'http://example.com/path/to/folder'

show_match %r((\d+)-(\d+)-(\d+)), '11-12-10'
show_match %r((\d+)-(\d+)-(\d+)), '11-12-2010'
show_match %r((\d+-?)*), '11-12-2010'

show_match %r(play(ing|er)), 'playing'
show_match %r(play(ing|er)), 'player'
show_match %r(play(ing|er)), 'playful'


#... more examples...
show_match %r([0-9]+-[0-9]+-[0-9]+), 'date: bb-10-2010'
show_match %r([0-9]+-[0-9]+-[0-9]+), 'date: 10-10-2010'

show_match %r(example.com), 'http://example.com/path/to/folder'
show_match %r(^example.com), 'http://example.com/path/to/folder'
show_match %r(example.com$), 'http://example.com/path/to/folder'



show_match %r(example.com(/[a-z]+)*), 'http://example.com/path/to/folder'


show_match %r(example.com(/[a-z]+)*), 'http://example.com/path/to/folder'
show_match %r(example.com/[a-z]+), 'http://example.com/path/to/folder'

show_match %r(example.com/[a-zA-Z0-9]+), 'http://example.com/Path1/TO/f343older'

show_match %r(\w+\s+=\s+"[^"]+"), ' name = "Michael" '

show_match %r(\$? 5.00), '5.00'
show_match %r(\$? 5.00), '$ 5.00'


show_match %r(5.(00)+), '5.00'
show_match %r(5.(00)+), '5.0000'
show_match %r((5).(?:00)+), '5.000000'




