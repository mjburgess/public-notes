# CHAPTER:    String Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using string methods, analyse and display some quotes.
# TIME:       15 m

fictional_quote  = "What's this? What's this? I have possibly gone daffy? What's this?"
fictional_author = "- Jack Skellington"

political_quote = "History will be kind to me for I intend to write it."
political_author = "- Winston Churchill"

unknown_quote  = "  "
unknown_author = "  " 

quotables = "
    Oscar,Wilde
    Albert,Einstein
    William,Shakespeare
"

author = {
    name: 'Oscar Wilde',
    era: 'Victorian',
    type: 'Wit'
}

# Q. print out the author name, era and type

puts author[:name]
puts author[:era]
puts author[:type]

# Q. display the longest quote
if fictional_quote.length > political_quote.length
  puts fictional_quote
else
  puts political_quote
end

# Q. print 30 dashes
#... then the fictional_author and fictional_quote,
#... then 30 dashes
puts "-" * 30
puts fictional_author
puts fictional_quote
puts "-" * 30

# Q. define authors by splitting apart quotables
authors = quotables.split

# Q. print each on their own line
# HINT: puts
puts authors


# Q. if fictional_author ends with 'Skellington'
#... print the fictional_quote and the first name of the author
if fictional_author.end_with? 'Skellington'
  puts fictional_quote, fictional_author.split(' ')[1]
end

# Q. if the unknown_author is empty or just whitespace,
#... print 'Unknown Quote'
# HINT: strip
if unknown_author.strip.empty?
  puts "Unknown Quote"
end


# EXTRA

# Q. loop over the authors,
#... and print each with a space between their first and last names
# HINT: .sub
for a in authors
  puts a.sub(',', ' ')
end

# Q. use the range below
#... and  .chr to print the letters A to Z on one line
letters = 65...(65 + 26)

for l in letters
  print l.chr
end

# Q. now define letters using a character range and print again
for l in 'A'..'Z'
  print l
end

## REVIEW: What did we learn from this exercise?