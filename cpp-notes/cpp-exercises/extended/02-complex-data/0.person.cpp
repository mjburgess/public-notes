#include <iostream>
#include <string>

using namespace std;

typedef string job;     // Why? Information hiding.

struct date
{
    int day, month, year;
};

struct person
{
    string name;
    job    role;
    date   dob;
};

int main()
{
    const string month_name[] =
    {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    };

    // query person's details
    person someone;

    string first, last;
    cout << "Please enter person's first and last name: ";
    cin >> first >> last;
    someone.name = first + " " + last;
    
	cout << "Please enter their date of birth (dd mm yyyy): ";
    cin >> someone.dob.day >> someone.dob.month >> someone.dob.year;
    
	cout << "Please enter their gender: ";
    cin >> someone.sex;

    // report details
    cout << someone.name      << " was born "
         << someone.dob.day   << ' '
         << month_name[someone.dob.month - 1] << ' '
         << someone.dob.year  << " and is "
         << someone.sex       << endl;

    return 0;
}
