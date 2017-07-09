# REGEX 


""" NOVICE ASIDE:

Why do we use regex?

    sort documents into two piles (maching, not-matching)
    extract info from documents (grouping)
    replace info in documents   (substitution)

"""

# 0. summary of principles

"""
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
16. ^example.com    means THE FIRST CHARACTER IS e THEN x THEN a.. 
17. example.com$    means THE LAST CHARACTER IS m AFTER o AFTER c... 
18. (\w+)  REMEMBERS matched text
19. in replacement expressions, \1 refers to the first group matched, \2 the second, etc.

\w+\s+=\s+"[^"]*"  matches    user_name = "Michael"
"""

# 1. regular expressions

# regular expressions are a language for specifying patterns of interest in text
# finding regularities, such as dates/names/postcodes/etc. in a large number of input documents
# is a very common problem

# let's explore the regular expressions language



# --- ignore this for now... we'll come back to it ---
import re


def show_match(pattern, text):
    m = re.search(pattern, text)

    print()
    print('REGEX: ', pattern)
    print('INPUT: ', text)

    if not m:
        print("MATCH:  NONE!")
        return

    arrow = ' ' * m.start() + '^' + '.' * (m.end() - m.start())
    print('WHERE:', arrow + '^')
    print('MATCH:', text[slice(m.start(), m.end())])
    print('SPAN:', '{0}-{1}'.format(m.start(), m.end()))

    if m.groups():
        print('GROUP:', ', '.join(['{0}: {1}'.format(i, v) for i, v in enumerate(m.groups())]))


# --- /ignore ---




# let's explore the regular expression language first, then the python lib.

# the show match function takes, as its first parameter, a string using the regular expresion language
# and its second parameter is a line of text to be searched for the pattern specified


# symbols without any significance

# any symbol without "special significance" in the regex lanugage is take literally

show_match('a', 'a')  # this says match the *first occurance*  of an 'a' in the input`
show_match('a', 'aaabbbccc')

show_match('b', 'aaabbbccc')

show_match('quick', 'the quick brown fox')
show_match('quick brown', 'the quick brown fox')
show_match('the quick', 'the quick brown fox')
show_match('fox', 'the quick brown fox')

show_match('~', '~/my/directory')
show_match('$', 'the price was $r200')

# .

# . means "any single character (ie. symbol)"

show_match('.', 'a')  # first occurance of any symbol
show_match('.', 'ab')

show_match('..', 'ab')  # the first occurance of two symbols

show_match('Mr. Holmes', 'Mr. Holmes')
show_match('Mr. Holmes', 'Mr# Holmes')  # gotchas

# character classes


show_match('[abc]', 'a')  # match the first occurance of a single character which is eitehr a, b or c
show_match('[abc]', 'db')
show_match('[abc]', 'ccc')

# ranges in character classes

show_match('[0-9]', '0')  # match the first occurance of a single character
show_match('[0-9]', 'a')  # in the range 0 to 9, ie. either 0123456789
show_match('[0-9]', 'a12b')  # in the range 0 to 9, ie. either 0123456789

show_match('[a-z]', 'the QUICK brown FOX')  # in the range a,b,c,d,..
show_match('[A-Z]', 'the QUICK brown FOX')  # in the range A,B,C
show_match('[a-zA-Z]', 'the QUICK brown FOX')  # in the range a,b,c,d,..,A,B,C...
show_match('[a-zA-Z]', '1 QUICK brown FOX')  # in the range a,b,c,d,..,A,B,C...

# inverse classes

# with a ^ at the begining of a character class any single symbol NOT in that class is selected

show_match('[^0-9]', '0')
show_match('[^0-9]', 'a')
show_match('[^0-9]', 'a12b')

# so [^0-9] is every non-digit
# [^a-zA-Z] is every non-alphabetical character
# [^0-9a-zA-Z] is every non-alphanumeric character (ie., mosly punctuation/space symbols, eg. $%!"$%)
# [^\n] is not a newline
# [^\n ] is not a newline or a space



# thus far the expressions have meant "match the first occurance of ... at any position"
# we can force the regular expression engine to match only at the start or the end of the input

show_match('^Mr. Holmes', 'Mr. Holmes')  # Match M at the start of the input
show_match('^Mr. Holmes', 'Thank you, Mr. Holmes')

# above the ^ (hat, caret) character means the pattern immediately following it must occur at the begining of the input


# the $ means it must occur at the end...


show_match('Holmes$', 'Mr. Holmes')  # Match s at the start of the input
show_match('Holmes$', 'Mr. Holmes, your letter has arrived!')

# note that ^ and $ do not map to any characters themsleves..
# they are instructions which indicate where to look for characters



# quantifers

# quantifers tell you the quantity (amount of repetiton) of a particular pattern

show_match('OK{1, 2}', 'OK')  # Match *at least* 1 K,  at most 2 K
show_match('OK{1, 2}', 'OKK')  # Match *at least* 1 K,  at most 2 K
show_match('OK{1, 2}', 'OKKK')  # Match *at least* 1 K,  at most 2 K

# the syntax is   P{l, m}
# P = pattern,  l = least number of Ps,  m = most number of Ps

# if you omit the second parameter, m, the pattern will match to infinity

show_match('OK{1,}', 'OKKKKKK!!')  # Match *at least* 1 K up to any number

# you can use 0 to indicate that it need not occur
show_match('OK{0, 1}', 'O!!')
show_match('OK{0, 1}', 'OK!!')

# above then, K is optional


# there are some predefined characters that map to the common ranges:
# P{0,}  == any number of P == P*
# P{1,}  == at least one P  == P+
# P{0,1}  == no P or one P == P is optional == P?

show_match('100%?', '100')
show_match('100%?', '100%')  # % is matched, if it is there

show_match('100.0*', '100.000000')
show_match('100.0*', '100.')  # any number of 0 is matched

show_match('100.0+', '100.0000')
show_match('100.0+', '100.0')
show_match('100.0+', '100.')  # at least one 0 is required

# the grouping operator ()


# you may group several patters (eg. characters) into one with parentheses:


show_match('it was (very)* good', 'it was very very good!')  # the * applies to (very)

show_match('(OK )+', 'BAD ')
show_match('(OK )+', 'OK ')
show_match('(OK )+', 'OK OK OK ')

# a pipe | may be used to select alternatives in parentheses


show_match('(OK|GOOD)', 'OK')
show_match('(OK|GOOD)', 'GOOD')
show_match('(OK|GOOD)', 'BAD')

# predefined ranges


# the digraphs (two characters)  \w \d \s   related to some special character classes

# \w = [a-zA-Z0-9_] = all lower case, all uppercase, all digits and underscore characters
# \d = [0-9]  = all digits
# \s = [\t\n\r\f ] = all whitespace

show_match('\w+', 'the amount was $10')  # the first occurance of \w repeated one or more times
show_match('\w+', '$10, the amount was $10')

show_match('\d+', 'the amount was $10')
show_match('\d+', '$10, the amount was $10')

show_match('\s+', 'the      amount was $10')
show_match('\s+', '   $10, the amount was $10')

# \W \D \S  all refer to  [^\w]  [^\d] [^\s]


show_match('\W+', 'the amount was $10')  # the first occurance of \w repeated one or more times
show_match('\W+', '$10, the amount was $10')

show_match('\D+', 'the amount was $10')
show_match('\D+', '$10, the amount was $10')

show_match('\S+', 'the      amount was $10')
show_match('\S+', '   $10, the amount was $10')

# examples


# extracting

show_match('example.com(/[a-z]+)*', 'http://example.com/path/to/folder')

show_match(r'(\d+)-(\d+)-(\d+)', '11-12-10')
show_match(r'(\d+)-(\d+)-(\d+)', '11-12-2010')
show_match(r'(\d+-?)*', '11-12-2010')

show_match('play(ing|er)', 'playing')
show_match('play(ing|er)', 'player')
show_match('play(ing|er)', 'playful')

# ... more examples...
show_match('[0-9]+-[0-9]+-[0-9]+', 'date: bb-10-2010')
show_match('[0-9]+-[0-9]+-[0-9]+', 'date: 10-10-2010')

show_match('example.com', 'http://example.com/path/to/folder')
show_match('^example.com', 'http://example.com/path/to/folder')
show_match('example.com$', 'http://example.com/path/to/folder')

show_match('example.com(/[a-z]+)*', 'http://example.com/path/to/folder')

show_match('example.com(/[a-z]+)*', 'http://example.com/path/to/folder')
show_match('example.com/[a-z]+', 'http://example.com/path/to/folder')

show_match('example.com/[a-zA-Z0-9]+', 'http://example.com/Path1/TO/f343older')

show_match(r'\w+\s+=\s+"[^"]+"', ' name = "Michael" ')

show_match('\$? 5.00', '5.00')
show_match('\$? 5.00', '$ 5.00')

show_match('5.(00)+', '5.00')
show_match('5.(00)+', '5.0000')
show_match('(5).(?:00)+', '5.000000')

# SUBSTITUTION
re.sub(r'(\w+)@(\w+).co.uk', r'\2-\1@\2.co.uk', 'michael.burgess@qa.com')

# IP ADDRESS
re.search(r'[0-9]+.[0-9]+.[0-9]+.[0-9]+', 'localhost 127.0.0.1')

# parsing CSV
csv = 'mjburgess, michael.burrgess@qa.com, 27, 1.81'
csv = csv.rstrip(',') + ','
P = '([^,],)'

int(re.search('(?:[^,]+,){2}([^,]+),(?:[^,]+,)*', csv).groups()[0].strip())


''' OUTPUT (06.Regex/Demo06-06.R.Regex.py):

REGEX:  a
INPUT:  a
WHERE: ^^
MATCH: a
SPAN: 0-1

REGEX:  a
INPUT:  aaabbbccc
WHERE: ^^
MATCH: a
SPAN: 0-1

REGEX:  b
INPUT:  aaabbbccc
WHERE:    ^^
MATCH: b
SPAN: 3-4

REGEX:  quick
INPUT:  the quick brown fox
WHERE:     ^^
MATCH: quick
SPAN: 4-9

REGEX:  quick brown
INPUT:  the quick brown fox
WHERE:     ^^
MATCH: quick brown
SPAN: 4-15

REGEX:  the quick
INPUT:  the quick brown fox
WHERE: ^^
MATCH: the quick
SPAN: 0-9

REGEX:  fox
INPUT:  the quick brown fox
WHERE:                 ^^
MATCH: fox
SPAN: 16-19

REGEX:  ~
INPUT:  ~/my/directory
WHERE: ^^
MATCH: ~
SPAN: 0-1

REGEX:  $
INPUT:  the price was $r200
WHERE:                    ^^
MATCH: 
SPAN: 19-19

REGEX:  .
INPUT:  a
WHERE: ^^
MATCH: a
SPAN: 0-1

REGEX:  .
INPUT:  ab
WHERE: ^^
MATCH: a
SPAN: 0-1

REGEX:  ..
INPUT:  ab
WHERE: ^^
MATCH: ab
SPAN: 0-2

REGEX:  Mr. Holmes
INPUT:  Mr. Holmes
WHERE: ^^
MATCH: Mr. Holmes
SPAN: 0-10

REGEX:  Mr. Holmes
INPUT:  Mr# Holmes
WHERE: ^^
MATCH: Mr# Holmes
SPAN: 0-10

REGEX:  [abc]
INPUT:  a
WHERE: ^^
MATCH: a
SPAN: 0-1

REGEX:  [abc]
INPUT:  db
WHERE:  ^^
MATCH: b
SPAN: 1-2

REGEX:  [abc]
INPUT:  ccc
WHERE: ^^
MATCH: c
SPAN: 0-1

REGEX:  [0-9]
INPUT:  0
WHERE: ^^
MATCH: 0
SPAN: 0-1

REGEX:  [0-9]
INPUT:  a
MATCH:  NONE!

REGEX:  [0-9]
INPUT:  a12b
WHERE:  ^^
MATCH: 1
SPAN: 1-2

REGEX:  [a-z]
INPUT:  the QUICK brown FOX
WHERE: ^^
MATCH: t
SPAN: 0-1

REGEX:  [A-Z]
INPUT:  the QUICK brown FOX
WHERE:     ^^
MATCH: Q
SPAN: 4-5

REGEX:  [a-zA-Z]
INPUT:  the QUICK brown FOX
WHERE: ^^
MATCH: t
SPAN: 0-1

REGEX:  [a-zA-Z]
INPUT:  1 QUICK brown FOX
WHERE:   ^^
MATCH: Q
SPAN: 2-3

REGEX:  [^0-9]
INPUT:  0
MATCH:  NONE!

REGEX:  [^0-9]
INPUT:  a
WHERE: ^^
MATCH: a
SPAN: 0-1

REGEX:  [^0-9]
INPUT:  a12b
WHERE: ^^
MATCH: a
SPAN: 0-1

REGEX:  ^Mr. Holmes
INPUT:  Mr. Holmes
WHERE: ^^
MATCH: Mr. Holmes
SPAN: 0-10

REGEX:  ^Mr. Holmes
INPUT:  Thank you, Mr. Holmes
MATCH:  NONE!

REGEX:  Holmes$
INPUT:  Mr. Holmes
WHERE:     ^^
MATCH: Holmes
SPAN: 4-10

REGEX:  Holmes$
INPUT:  Mr. Holmes, your letter has arrived!
MATCH:  NONE!

REGEX:  OK{1, 2}
INPUT:  OK
MATCH:  NONE!

REGEX:  OK{1, 2}
INPUT:  OKK
MATCH:  NONE!

REGEX:  OK{1, 2}
INPUT:  OKKK
MATCH:  NONE!

REGEX:  OK{1,}
INPUT:  OKKKKKK!!
WHERE: ^^
MATCH: OKKKKKK
SPAN: 0-7

REGEX:  OK{0, 1}
INPUT:  O!!
MATCH:  NONE!

REGEX:  OK{0, 1}
INPUT:  OK!!
MATCH:  NONE!

REGEX:  100%?
INPUT:  100
WHERE: ^^
MATCH: 100
SPAN: 0-3

REGEX:  100%?
INPUT:  100%
WHERE: ^^
MATCH: 100%
SPAN: 0-4

REGEX:  100.0*
INPUT:  100.000000
WHERE: ^^
MATCH: 100.000000
SPAN: 0-10

REGEX:  100.0*
INPUT:  100.
WHERE: ^^
MATCH: 100.
SPAN: 0-4

REGEX:  100.0+
INPUT:  100.0000
WHERE: ^^
MATCH: 100.0000
SPAN: 0-8

REGEX:  100.0+
INPUT:  100.0
WHERE: ^^
MATCH: 100.0
SPAN: 0-5

REGEX:  100.0+
INPUT:  100.
MATCH:  NONE!

REGEX:  it was (very)* good
INPUT:  it was very very good!
MATCH:  NONE!

REGEX:  (OK )+
INPUT:  BAD 
MATCH:  NONE!

REGEX:  (OK )+
INPUT:  OK 
WHERE: ^^
MATCH: OK 
SPAN: 0-3
GROUP: 0: OK 

REGEX:  (OK )+
INPUT:  OK OK OK 
WHERE: ^^
MATCH: OK OK OK 
SPAN: 0-9
GROUP: 0: OK 

REGEX:  (OK|GOOD)
INPUT:  OK
WHERE: ^^
MATCH: OK
SPAN: 0-2
GROUP: 0: OK

REGEX:  (OK|GOOD)
INPUT:  GOOD
WHERE: ^^
MATCH: GOOD
SPAN: 0-4
GROUP: 0: GOOD

REGEX:  (OK|GOOD)
INPUT:  BAD
MATCH:  NONE!

REGEX:  \w+
INPUT:  the amount was $10
WHERE: ^^
MATCH: the
SPAN: 0-3

REGEX:  \w+
INPUT:  $10, the amount was $10
WHERE:  ^^
MATCH: 10
SPAN: 1-3

REGEX:  \d+
INPUT:  the amount was $10
WHERE:                 ^^
MATCH: 10
SPAN: 16-18

REGEX:  \d+
INPUT:  $10, the amount was $10
WHERE:  ^^
MATCH: 10
SPAN: 1-3

REGEX:  \s+
INPUT:  the      amount was $10
WHERE:    ^^
MATCH:       
SPAN: 3-9

REGEX:  \s+
INPUT:     $10, the amount was $10
WHERE: ^^
MATCH:    
SPAN: 0-3

REGEX:  \W+
INPUT:  the amount was $10
WHERE:    ^^
MATCH:  
SPAN: 3-4

REGEX:  \W+
INPUT:  $10, the amount was $10
WHERE: ^^
MATCH: $
SPAN: 0-1

REGEX:  \D+
INPUT:  the amount was $10
WHERE: ^^
MATCH: the amount was $
SPAN: 0-16

REGEX:  \D+
INPUT:  $10, the amount was $10
WHERE: ^^
MATCH: $
SPAN: 0-1

REGEX:  \S+
INPUT:  the      amount was $10
WHERE: ^^
MATCH: the
SPAN: 0-3

REGEX:  \S+
INPUT:     $10, the amount was $10
WHERE:    ^^
MATCH: $10,
SPAN: 3-7

REGEX:  example.com(/[a-z]+)*
INPUT:  http://example.com/path/to/folder
WHERE:        ^^
MATCH: example.com/path/to/folder
SPAN: 7-33
GROUP: 0: /folder

REGEX:  (\d+)-(\d+)-(\d+)
INPUT:  11-12-10
WHERE: ^^
MATCH: 11-12-10
SPAN: 0-8
GROUP: 0: 11, 1: 12, 2: 10

REGEX:  (\d+)-(\d+)-(\d+)
INPUT:  11-12-2010
WHERE: ^^
MATCH: 11-12-2010
SPAN: 0-10
GROUP: 0: 11, 1: 12, 2: 2010

REGEX:  (\d+-?)*
INPUT:  11-12-2010
WHERE: ^^
MATCH: 11-12-2010
SPAN: 0-10
GROUP: 0: 2010

REGEX:  play(ing|er)
INPUT:  playing
WHERE: ^^
MATCH: playing
SPAN: 0-7
GROUP: 0: ing

REGEX:  play(ing|er)
INPUT:  player
WHERE: ^^
MATCH: player
SPAN: 0-6
GROUP: 0: er

REGEX:  play(ing|er)
INPUT:  playful
MATCH:  NONE!

REGEX:  [0-9]+-[0-9]+-[0-9]+
INPUT:  date: bb-10-2010
MATCH:  NONE!

REGEX:  [0-9]+-[0-9]+-[0-9]+
INPUT:  date: 10-10-2010
WHERE:       ^^
MATCH: 10-10-2010
SPAN: 6-16

REGEX:  example.com
INPUT:  http://example.com/path/to/folder
WHERE:        ^^
MATCH: example.com
SPAN: 7-18

REGEX:  ^example.com
INPUT:  http://example.com/path/to/folder
MATCH:  NONE!

REGEX:  example.com$
INPUT:  http://example.com/path/to/folder
MATCH:  NONE!

REGEX:  example.com(/[a-z]+)*
INPUT:  http://example.com/path/to/folder
WHERE:        ^^
MATCH: example.com/path/to/folder
SPAN: 7-33
GROUP: 0: /folder

REGEX:  example.com(/[a-z]+)*
INPUT:  http://example.com/path/to/folder
WHERE:        ^^
MATCH: example.com/path/to/folder
SPAN: 7-33
GROUP: 0: /folder

REGEX:  example.com/[a-z]+
INPUT:  http://example.com/path/to/folder
WHERE:        ^^
MATCH: example.com/path
SPAN: 7-23

REGEX:  example.com/[a-zA-Z0-9]+
INPUT:  http://example.com/Path1/TO/f343older
WHERE:        ^^
MATCH: example.com/Path1
SPAN: 7-24

REGEX:  \w+\s+=\s+"[^"]+"
INPUT:   name = "Michael" 
WHERE:  ^^
MATCH: name = "Michael"
SPAN: 1-17

REGEX:  \$? 5.00
INPUT:  5.00
MATCH:  NONE!

REGEX:  \$? 5.00
INPUT:  $ 5.00
WHERE: ^^
MATCH: $ 5.00
SPAN: 0-6

REGEX:  5.(00)+
INPUT:  5.00
WHERE: ^^
MATCH: 5.00
SPAN: 0-4
GROUP: 0: 00

REGEX:  5.(00)+
INPUT:  5.0000
WHERE: ^^
MATCH: 5.0000
SPAN: 0-6
GROUP: 0: 00

REGEX:  (5).(?:00)+
INPUT:  5.000000
WHERE: ^^
MATCH: 5.000000
SPAN: 0-8
GROUP: 0: 5

'''
