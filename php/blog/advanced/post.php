<?php
include 'common.php';

ensure_login();

$sql = "INSERT INTO articles(title, body, author, category, date)
            VALUES(:title, :body, :author, :category, unix_timestamp())";


switch($_SERVER['REQUEST_METHOD']) {
  case 'GET':
    display_page('post');
    break;

  case 'POST':
    $stmt = $gPDO->prepare($sql);
    $stmt->execute($_POST + ['author' => 1]);

    header("Location: /article.php?id="  . $gPDO->lastInsertId());

    break;
}
