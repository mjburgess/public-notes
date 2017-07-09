# CHAPTER:    File Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Store python representations of country data. 
# TIME:       15m


countries = """
East Timor,1019252,Dili,?,Asia,1975,US Dollar,Catholicism,Tetu,Portuguese,Indonesian,English
Ecuador,13212742,Quito,1994318,Latin America,1822,US Dollar,Catholicism,Spanish,Quechua
Egypt,76117421,Cairo,15452000,Africa,1922,Egyptian Pound,Sunni Muslim,Arabic
El Salvador,6587541,San Salvador,2100000,Latin America,1821,US Dollar,Catholicism,Spanish,Nahua
England,50093800,London,11219000,Europe,1066,British Pound,Anglican;Catholisicm;Other,English
Equatorial Guinea,523051,Malabo,?,Africa,1967,CFA Franc,Catholisism,Spanish,French
Eritrea,4561599,Asmara,?,Africa,1993,Nakfa,Muslim;Catholisism,Tigrina,Arabic,English
Estonia,1341664,Tallinn,?,Europe,1991,Kroon,Lutheran;Orthodox,Estonian,Russian,Finish
Ethiopia,67617000,Addis Ababa,1495266,Africa,-1000,Birr,Muslim;Orthodox,Amharic,Tigrina
"""

# Q. using a with-as statement, save countries to a file called countries.txt

# Q. import pickle and gzip

# Q. read countries.txt line-by-line, add each to a countries_database 
# ... the key should be the country name and the value the rest of the data

# Q. use gzip to create a countries.dbz compressed file 
# HINT: you will need to use the wb mode

# Q. pickle dump into this output file

# Q. and then close it


# Q. use a with-as statement to gzip open countries.dbz 
# ... pickle load it and print out the data


''' OUTPUT (07.Files/Exercise07-FilesC-Storing.py):

'''
