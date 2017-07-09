# CHAPTER:    Libraries
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Using MiniTest and JSON, create a tested json processing class.
# TIME:       20 m


# QUESTIONS

# PART 1 -- MINITEST
# Q. write the class Person so that this test passes

require 'minitest/autorun'

class TestPerson < MiniTest::Test
  def test_consume
    weight = 100
    drank = 1
    eaten = 1

    me = Person.new(weight)
    me.eat(eaten)
    me.drink(drank)

    assert me.weight == (weight + eaten + drank)
  end
end




# PART 2 -- Test Driven JSON
# in this exercise you will write a unit test before writing
# a service class.

# the service class will parse the json provided and
# produce an array of User objects (class provided)

$user_json = '{"users": [
  {"name": "michael",  "location": "UK"},
  {"name": "sherlock", "location": "FR"}
]}'


class User
  def initialize(name, location)
    @name = name
    @location = location
  end

  def describe
    puts "
      NAME: #{@name}
      LOCATION: #{@location}
    "
  end
end


# Q. require the libraries for json and autorunning minitests

# Q. write a test for a json processing class (JProcess)
#... the processing class should have a method called users
#... the method accepts the json above
#... and produces an array of user objects
# HINT: the assertion should compare two arrays


# Q. define the class for processing json
#... the users method should return an array of user objects
# HINT: .map will simplify the implementation



# EXTRA

# Q. using NET & JSON, parse http://jsonplaceholder.typicode.com/users
#... into an array of User objects
#... ask each to describe


## REVIEW: What did we learn from this exercise?