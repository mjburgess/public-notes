<?php

include 'lib/common.php';
include 'lib/article_db.php';
include 'lib/user_db.php';

if(empty($_POST)) {
    include 'templates/login.phtml';
} else {
    $user = user_read($gPDO, $_POST['email']);

    if(password_verify($_POST['password'], $user['password'])) {

        $_SESSION = $user;

        header('Location: /blog/admin.php');
    } else {
        header('Location: /blog/register.php');
    }
}
