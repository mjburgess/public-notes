#define CATCH_CONFIG_MAIN  // This tells Catch to provide a main() - only do this in one cpp file
#include "catch.hpp"
#include "Calculator.hpp"

TEST_CASE( "should return zero with an empty string", "[calculator]" ) {
    Calculator *c = new Calculator();

    REQUIRE( c->add1("") == 0 );
}


TEST_CASE( "should return an integer version of itself", "[calculator]" ) {
    Calculator *c = new Calculator();

    REQUIRE( c->add2("7") == 7 );
}


TEST_CASE( "should return a sum of comma separated numbers", "[calculator]" ) {
    Calculator *c = new Calculator();

    REQUIRE( c->add3("7,16") == 7 + 16 );
}

TEST_CASE( "should return a sum of newline separated numbers", "[calculator]" ) {
    Calculator *c = new Calculator();

    REQUIRE( c->add4("7\n16") == 7 + 16 );
}

TEST_CASE( "should return a sum of all comma separated numbers", "[calculator]" ) {
    Calculator *c = new Calculator();

    REQUIRE( c->add5("7,16,33") == 7 + 16 + 33);
}



TEST_CASE( "should thrown an exception on negative input", "[calculator]" ) {
    Calculator *c = new Calculator();

    CHECK_THROWS( c->add6("-7,16,33") );
}



TEST_CASE( "should cap inputs at 1000", "[calculator]" ) {
    Calculator *c = new Calculator();

    REQUIRE( c->add7("1007,16") == 1000 + 16);
}


/* OUTPUT (samples/functional/Main.cpp):
===============================================================================
All tests passed (7 assertions in 7 test cases)


*/