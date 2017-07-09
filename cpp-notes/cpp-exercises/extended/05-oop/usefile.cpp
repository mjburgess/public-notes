
// Chapter:     Using Classes
// File:        usefile.cpp
// Description: Copy one file to another

#include <iostream>
#include <string>
#include "file.hpp"

using namespace std;

int main()
{
    file source, target;
 
    if (source.open_for_reading("source.txt") &&
       target.open_for_writing("target.txt"))
    {
        string line;

        while (source.read(line))
        {
            if (!line.empty())
            {
                line.insert(0, 8, ' ');

                if (line.size() > 48)
                {
                    line.resize(48);
                }
            }

            target.write(line);
        }

        cerr << "File copied successfully" << endl;
    }
    else
    {
        cerr << "There was an error opening one of the files" << endl;
    }

    source.close();
    target.close();

    return 0;
}
