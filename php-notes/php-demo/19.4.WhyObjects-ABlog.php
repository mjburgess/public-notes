<?php

// program design always begins with a problem statement:
// what questions are we trying to answer with our program? what problems are we trying to solve?

// then, when designing programs in an object oriented manner the second question we ask is:
// what kinds of relevant objects are there?

// suppose we were trying to model a shopping situation:
// what objects are there? baskets, customers, items, etc...

// previously we had divided each of these into two aspects:
// associative arrays to represent their data, and functions to represent this data changing

// now we combine the data and functions into singular objects...
// so we have $item objects with $item->name and $item->price
// and $basket objects that can $basket->addItem($item)

// let's turn to the design of a blog:
// what essential "objects" are there in a blog?
// well a blog is minimually, just a collection of articles written by authors...

// so we have two kinds of object Article objects and Author objects

// for each kind of object we create a class, ie. a blueprint that 'new' uses to make our objects:


class Article {
    //what data (properties) does every article object have?
    private $title;
    private $text;
    private $author;

    // how do we make article objects?
    public function __construct($author, $title, $text) {    // they're made from a title, text & authors
        $this->title = $title;   // $this == the object being made
        $this->text = $text;    // thef. give the object being made its name
        $this->author = $author;
    }

    public function getPage() {
        return $this->title . PHP_EOL . $this->text . PHP_EOL;
    }

    public function getAuthor() {
        return $this->author;
    }
}


// traditional object oriented design advocates data be held privately wherever possible
// so that *only the objects methods* can see it

// if only the object itself can modify its own data, then its data should always have sensible values
// ie., not mistakely changed by something else that doesnt know how the object works
// the object's methods should, in principle, know how the objects data changes


// above the getPage() function is the only way we can see an article object's data
// so the getPage() heavily controls how we see article objects...

//we can't go rummiaging around and getting only their title or text
//in this way the object can keep itself sane

// (this is incidentally the major selling point of OO:
// objects control their own change of state
// so that state change, in principle, becomes predicable and controlled).

//( in procedural programs any old function could operate on our data )


// now let's create the other essential blueprint:

class Author {
    private $name;
    private $email;

    public function __construct($name, $email) {
        $this->name = $name;
        $this->email = $email;
    }

    // name is private, so the only way to see it is through this function
    // this ensures name cannot be changed from the outside, only seen
    public function getName() {
        return $this->name;
    }
}

// above we have not "done" anything
// we have merely *defined* what objects are going to look-like

// now we're going to create them

$me = new Author('Michael', 'michael.burgess@qa.com');

$philosophyArticle = new Article($me,               // recall: whitespace doesnt matter

'The Metaphysics of Beauty',

'Given a set of objective criteria evolved under and
dependent upon subjective states of mind,
any work may be evaluated objectively to be an
exemplar of that criteria (good) or not (bad)'
);

$programmingArticle = new Article($me,

'High Cohesion and Loose Coupling',

'Programs should contain highly resolved, clear, compartmentalized
defintions of functions and classes.

If they are specialized and specific to one purpose, they are said to be cohesive.

Programs should contain, where possible, free-standing functions and classes,
whose dependence on other functions and classes is minmized to the extent possible -- but no greater.

Defintions which have few dependences on other defintions are said to be loosely coupled.'
);


echo $philosophyArticle->getPage();
echo ' -- ' . $philosophyArticle->getAuthor()->getName(); //getAuthor() returns an author object
                                                          // which has a getName()
echo PHP_EOL;
echo PHP_EOL;

echo $programmingArticle->getPage();
echo ' -- ' . $programmingArticle->getAuthor()->getName();




// here we have only been defining *models* -- objects which are nothing much more than their data

// the view object, ie. the object concerned with how these models are displayed would contain the few echo lines above
// ie. we're doing the view objects job above in a somewhat procedural fashion


// we could define a view:

class ArticleView {
    private $article;
    private $header;

    public function __construct($header, $article) {
        $this->article = $article;
        $this->header = $header;
    }

    public function display() {
        echo PHP_EOL;
        echo PHP_EOL;
        echo $this->header . PHP_EOL;
        echo '----------------';
        echo PHP_EOL;
        echo $this->article->getPage();
        echo ' -- ';
        echo $this->article->getAuthor()->getName();
    }
}


$diaryViewer = new ArticleView('My Diary', $programmingArticle);
$diaryViewer->display();
