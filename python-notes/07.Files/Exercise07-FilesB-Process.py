# SUPPLEMENTAL ADVANCED

# CHAPTER:    File Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Sanitize a file: replace bad-words for good-words. 
# TIME:       15m

search_words = ['bad', 'awful', 'terrible', 'ugly']
replace_words = ['nice', 'wonderful', 'lovely', 'pretty']

message = """
    The world is bad. 
    People are awful. 
    Everyone is terrible. 
    And nature is ugly.
"""

# Q. use the 'with-as' syntax to write the above message to a file called document.txt

# Q. ask the user if they want to add a keyword to the list above
# ... if so, ask them what keyword and what replacement word and append to the relevant lists 
# ... keep asking until they type 'DONE'

# Q. ask the user for a file to save the final message to & create it 


# Q. loop over the document file line by line
# ... in this loop, move through the keywords list and the replacements list *together*
# ... use line.replace() to replace the keyword for the replacement word
# ... print the cleand line and write the cleaned line to an output file 
# HINT: zip(keywords, replacements)
# HINT: line = line.replace(search, replace)


# Q. remember to close the output file connection


''' OUTPUT (07.Files/Exercise07-FilesB-Process.py):

'''
