
// Chapter:     Using Classes
// File:        file.cpp
// Description: Member definitions for file class

#include "file.hpp"

bool file::open_for_reading(const string & file_name)
{
    close();
    io.open(file_name.c_str(), ios::in);
    return io.is_open() ? true : false;
}


bool file::open_for_writing(const string & file_name)
{
    close();
    io.open(file_name.c_str(), ios::out);
    return io.is_open() ? true : false;
}


void file::close()
{
    if (io.is_open())
    {
        io.close();
    }
}


bool file::read(string & input)
{
	input.clear();
	char c;
	while (((c = io.get()) != EOF) && c != '\n')
		input += c;
	
	return input != "" || c != EOF;
}


bool file::write(const string & output)
{
    io << output << endl;
    return io.good() ? true : false;
}


bool file::end_of_file() const
{
    return io.eof() ? true : false;
}
