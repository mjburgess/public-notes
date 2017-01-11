<?php
include 'lib/common.php';
include 'lib/article_db.php';
include 'lib/user_db.php';

if(empty($_SESSION)) {
    header('Location: /blog/login.php');
    die();
}

if(empty($_POST)) {
    include 'templates/admin.phtml';
} else {
    $_POST['author_id'] = $_SESSION['id'];      //add the logged-in user's id to the form information 

    if(article_create($gPDO, $_POST)) {
        header('Location: /blog/index.php');
    } else {
        die("ERROR!");
    }
}
