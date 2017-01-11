<?php

include 'lib/common.php';
include 'lib/article_db.php';
include 'lib/user_db.php';


if(empty($_POST)) {
    include 'templates/register.phtml';
} else {
    // if $_POST['password'] != $_POST['confirm'] ...

    unset($_POST['password_confirm']); //remove the confirm field,
                              // because user_create won't accept

    if(user_create($gPDO, $_POST)) {
        header('Location: /blog/login.php');
    } else {
        die("ERROR!");
    }
}
