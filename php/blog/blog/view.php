<?php

include 'lib/common.php';
include 'lib/article_db.php';
include 'lib/user_db.php';

if(empty($_GET['id'])) {
    die('ERROR - NO ID!');
}


$article = article_read_id($gPDO, $_GET['id']);

include 'templates/view.phtml';
