<?php

class Aritlce {
    private $authorName;
    private $title;
    private $text;

    public function __construct($authorName, $title, $text) {
        $this->authorName = $authorName;
        $this->title = $title;
        $this->text = $text;
    }

    public function getAuthor() { return $this->authorName; }
    public function getTitle() { return $this->title; }
    public function getText() { return $this->text; }
}

class ArticleView {
    private $article;
    private $title;

    public function __construct($blogTitle, $article) {
        $this->title = $blogTitle;
        $this->article = $article;
    }

    public function display() {
        return implode(PHP_EOL, [$this->title,
                                 $this->article->getTitle(),
                                 $this->article->getName(),
                                 $this->article->getAuthor()]);
    }
}

class ArticleController {
    public function createArticle($post) {
        $article = new Article($post['name'], $post['title'], $post['text']);

        return new ArticleView('My Blog', $article);
    }
}
?>

<html><head><title>My Blog</title></head>
<body>
    <form action="" method="post">
        <label> Author: <input type="text" name="name" /></label>
        <label> Title: <input type="text" name="title" /></label>
        <label> Text: <input type="text" name="text" /></label>
    </form>

<?php
    // now let's use the defintions above

    if(!empty($_POST)) {
        $controller = new ArticleController();
        $view = $controller->createArticle($_POST);

        echo '<pre>' . $view->display() . '</pre>';
    }

?>
</body>
</html>
