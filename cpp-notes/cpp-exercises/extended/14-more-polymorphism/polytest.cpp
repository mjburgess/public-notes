
//======================================================================
//
//  Filename:     polytest.cpp
//  Description:  Test harness to exercise polymorphism
//
//======================================================================

#include <iostream>                      // Stream class definition
#include <vector>							  // 
using namespace std;
#include "program.hpp"                   // programmer class definition
#include "fish.hpp"
#include "house.hpp"

void test1(const vector<person *> & crowd);
void test2(person *p);
void test3();

int main()
{
    /*
	vector<person *> crowd;
	student st("Brown", 19, "Extreme Ironing");   // Create a student object
    
    st.change_subject("Software Engineering");

	crowd.push_back(&st);

	employee emp("Bloggs", 35, 9, 15000);   // Create an employee object
    
    emp.gain_promotion(3);

	emp.set_policyInfo(100.00, "2013-10-10", "Professional Indemnity");
	crowd.push_back(&emp);

	programmer progger("Gill Bates", 40, 15, 25000);
    
    progger.add_skill("C++", 12);
    progger.add_skill("Visual Basic", 6);
    progger.gain_promotion(3);
	progger.set_policyInfo(75.00, "2015-10-10", "Language skills going out of date");

	crowd.push_back(&progger);
	
	test1(crowd);

	test2(crowd[1]);
	*/

	test3();

	return 0;
}

void test1(const vector<person *> & crowd)
{
	
	cout << "Displaying vector of person *'s " << endl;
	vector<person *>::const_iterator iter;
	for (iter = crowd.begin(); iter != crowd.end(); ++iter)
	{
		(*iter)->display();
	}
 
}

void test2(person * p)
{
	cout << "displaying an individual person " << endl;
	p->display();
}

void test3()
{
	   
	vector<iinsurable *> valueableItems;
	
	employee emp("Bloggs", 35, 9, 15000);   // Create an employee object
    
    emp.gain_promotion(3);

	emp.set_policyInfo(100.00, "2013-10-10", "Professional Indemnity");
	valueableItems.push_back(&emp);

	programmer progger("Gill Bates", 40, 15, 25000);
    
    progger.add_skill("C++", 12);
    progger.add_skill("Visual Basic", 6);
    progger.gain_promotion(3);
	progger.set_policyInfo(75.00, "2015-10-10", "Language skills going out of date");

	valueableItems.push_back(&progger);

	fish nemo("Nemo", "Cute Little Fish");
	nemo.set_policyInfo(4.50, "2013-10-14", "Accidental Death");
	valueableItems.push_back(&nemo);

	house localChipshop("1 Side Street, Hitchin, Herts", "HI5 1SH", house::terrace);
	localChipshop.set_policyInfo(1234, "2013-10-16", "Contents and Buildings");
	valueableItems.push_back(&localChipshop);

	vector<iinsurable *>::const_iterator iter;
	 //display insurance details
	cout << "Insurance details for the insurable items are:" << endl;
	for (iter = valueableItems.begin(); iter != valueableItems.end(); ++iter)
	{
			cout << (*iter)->get_policyInfo() << " costing $" << (*iter)->get_fee() << " per year" << endl;
	}



}