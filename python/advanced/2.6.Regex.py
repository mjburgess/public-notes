# 2.6.Regex.py

#1. regular expressions

# regular expressions are a language for specifying patterns of interest in text
# finding regularities, such as dates/names/postcodes/etc. in a large number of input documents
# is a very common problem

# let's explore the regular expressions language



# --- ignore this for now... we'll come back to it ---
import re

def show_match(pattern, text):
    match = re.search(pattern, text)

    print
    print 'REGEX: ', pattern
    print 'INPUT: ', text

    if match:
        print 'WHERE: ' + (' ' * match.span()[0]) + '^' + ('.' * (match.span()[1] - match.span()[0])) + '^'
        print 'MATCH: ', text[slice(*match.span())]
        print 'SPAN : ', '-'.join(map(str, match.span()))
    else:
        print "MATCH:  NONE!"

    if match and match.groups():
        print 'GROUPS: ', ',  '.join(['g{0}: {1}'.format(i, v) for i,v in enumerate(match.groups())])


# --- /ignore ---




# let's explore the regular expression language first, then the python lib.

# the show match function takes, as its first parameter, a string using the regular expresion language
# and its second parameter is a line of text to be searched for the pattern specified


# symbols without any significance

# any symbol without "special significance" in the regex lanugage is take literally

show_match('a', 'a') # this says match the *first occurance*  of an 'a' in the input`
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

show_match('.', 'a') # first occurance of any symbol
show_match('.', 'ab')

show_match('..', 'ab') # the first occurance of two symbols

show_match('Mr. Holmes', 'Mr. Holmes')
show_match('Mr. Holmes', 'Mr# Holmes') #gotchas

#character classes


show_match('[abc]', 'a')   # match the first occurance of a single character which is eitehr a, b or c
show_match('[abc]', 'db')
show_match('[abc]', 'ccc')


# ranges in character classes

show_match('[0-9]', '0') # match the first occurance of a single character
show_match('[0-9]', 'a') # in the range 0 to 9, ie. either 0123456789
show_match('[0-9]', 'a12b') # in the range 0 to 9, ie. either 0123456789



show_match('[a-z]', 'the QUICK brown FOX') # in the range a,b,c,d,..
show_match('[A-Z]', 'the QUICK brown FOX') # in the range A,B,C
show_match('[a-zA-Z]', 'the QUICK brown FOX') # in the range a,b,c,d,..,A,B,C...
show_match('[a-zA-Z]', '1 QUICK brown FOX') # in the range a,b,c,d,..,A,B,C...


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

show_match('^Mr. Holmes', 'Mr. Holmes') # Match M at the start of the input
show_match('^Mr. Holmes', 'Thank you, Mr. Holmes')

# above the ^ (hat, caret) character means the pattern immediately following it must occur at the begining of the input


# the $ means it must occur at the end...


show_match('Holmes$', 'Mr. Holmes') # Match s at the start of the input
show_match('Holmes$', 'Mr. Holmes, your letter has arrived!')


# note that ^ and $ do not map to any characters themsleves..
# they are instructions which indicate where to look for characters



# quantifers

# quantifers tell you the quantity (amount of repetiton) of a particular pattern

show_match('OK{1, 2}', 'OK') # Match *at least* 1 K,  at most 2 K
show_match('OK{1, 2}', 'OKK') # Match *at least* 1 K,  at most 2 K
show_match('OK{1, 2}', 'OKKK') # Match *at least* 1 K,  at most 2 K

# the syntax is   P{l, m}
# P = pattern,  l = least number of Ps,  m = most number of Ps

# if you omit the second parameter, m, the pattern will match to infinity

show_match('OK{1,}', 'OKKKKKK!!') # Match *at least* 1 K up to any number


# you can use 0 to indicate that it need not occur
show_match('OK{0, 1}', 'O!!')
show_match('OK{0, 1}', 'OK!!')

# above then, K is optional


# there are some predefined characters that map to the common ranges:
# P{0,}  == any number of P == P*
# P{1,}  == at least one P  == P+
# P{0,1}  == no P or one P == P is optional == P?

show_match('100%?', '100')
show_match('100%?', '100%')  #% is matched, if it is there


show_match('100.0*', '100.000000')
show_match('100.0*', '100.')    # any number of 0 is matched


show_match('100.0+', '100.0000')
show_match('100.0+', '100.0')
show_match('100.0+', '100.')   # at least one 0 is required



# the grouping operator ()


# you may group several patters (eg. characters) into one with parentheses:


show_match('it was (very)* good', 'it was very very good!') # the * applies to (very)

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

show_match('\w+', 'the amount was $10') # the first occurance of \w repeated one or more times
show_match('\w+', '$10, the amount was $10')


show_match('\d+', 'the amount was $10')
show_match('\d+', '$10, the amount was $10')


show_match('\s+', 'the      amount was $10')
show_match('\s+', '   $10, the amount was $10')



# \W \D \S  all refer to  [^\w]  [^\d] [^\s]


show_match('\W+', 'the amount was $10') # the first occurance of \w repeated one or more times
show_match('\W+', '$10, the amount was $10')


show_match('\D+', 'the amount was $10')
show_match('\D+', '$10, the amount was $10')


show_match('\S+', 'the      amount was $10')
show_match('\S+', '   $10, the amount was $10')


#examples


# extracting

show_match('example.com(/[a-z]+)*', 'http://example.com/path/to/folder')

show_match(r'(\d+)-(\d+)-(\d+)', '11-12-10')
show_match(r'(\d+)-(\d+)-(\d+)', '11-12-2010')
show_match(r'(\d+-?)*', '11-12-2010')

show_match('play(ing|er)', 'playing')
show_match('play(ing|er)', 'player')
show_match('play(ing|er)', 'playful')


#... more examples...
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
