#include <string>

struct Person {
    std::string name;
    int age;
};

void person_init(Person &p, std::string name, int age);
void person_print(Person &p);

