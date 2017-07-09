#include <iostream>
#include <vector>
using namespace std;


class Basket {
    public:
        Basket(vector<string> cart) : items(cart) {}

        vector<string> getItems() const { return items; }
        
        //useful for container types
        string operator[](int index) const { return items[index]; }
        
        //probably better to name this method: adding baskets is a strange req. 
        Basket operator+(Basket &r) const {
            vector<string> total = r.getItems();
            total.insert(total.end(), items.begin(), items.end());  //join my-items to their-items

            return Basket { total }; 
        }
        
        //useful -- recall: identity & equality conditions establish facts
        bool operator==(const Basket &r) const {
            return items == r.getItems();           // '==' is overloaded for vectors
        }

    private:
        vector<string> items;
};

// stream output operator: useful to overload -- must be gloabl. why? what type is the LHS?
ostream &operator<<(ostream &out, const Basket &basket) {
    for(string item : basket.getItems()) {
        out << item << endl;
    }

    return out;
}

int main(void) {
    Basket myBasket    { vector<string> { "Cherries", "Lemonade" } };
    Basket yourBasket  { vector<string> { "Cherries", "Lemonade" } };
    Basket theirBasket { vector<string> { "Milk", "Eggs" } };

    cout << "my basket: " << endl;
    cout << myBasket << endl;

    cout << "your basket: " << endl;
    cout << yourBasket << endl;

    cout << "their basket: " << endl;
    cout << theirBasket << endl;

    cout << boolalpha;

    cout << "my basket == your basket?  " << (myBasket == yourBasket) << endl;
    cout << "my basket == their basket?  " << (myBasket == theirBasket) << endl;
    
    cout << "the first item in my basket is  " << myBasket[0] << endl;
    cout << "the first item in their basket is  " << theirBasket[0] << endl; 
     
    return 0; 
}


//NB. if you look closely Basket is basically just an alias for vector<string>
//would it be better to have a typedef?