
// Chapter:     Using Classes
// File:        file.hpp
// Description: Class definition for file handling

#ifndef FILE_INCLUDED
#define FILE_INCLUDED

#include <fstream>
#include <string>

using namespace std;

// definition of file class

class file
{
public:

    bool open_for_reading(const string & file_name);
        // returns true if successfully opened file_name for reading

    bool open_for_writing(const string & file_name);
        // returns true if successfully opened file_name for writing

    void close();
        // closes file if open (i.e. does nothing if file is aleady
        // closed), and should be called when I/O is completed

    bool read(string & input);
        // returns true if successfully read a line into input,
        // otherwise false, e.g. at the end of the file

    bool write(const string & output);
        // returns true if successfully wrote output as a line

    bool end_of_file() const;
        // returns true if reached the end of the file

private: // state

    fstream io;

};

#endif
