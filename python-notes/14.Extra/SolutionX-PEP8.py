# CHAPTER:    PEP8
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Revise this file and apply PEP8 guidelines; do not change the logic. 
# TIME:       15m

class Person:
    def __init__(self, first_name):
        self.first_name = first_name

    def get_name(self):
        return self._format(self.firstname)

    def _format(self, string):
        return string.upper()


def people(message='Making People'):
    ''' Make a list of sherlocks and watsons -- each of type Person. '''
    sherlock = Person('Sherlock')
    watson = Person('Watson')

    print(message)

    return [
        sherlock, watson, sherlock, watson, sherlock, watson,
        sherlock, watson, sherlock, watson, sherlock, watson
    ]


list_of_people = Person()
for person in list_of_people:
    print(person.get_name())


''' OUTPUT (14.Extra/SolutionX-PEP8.py):

'''
