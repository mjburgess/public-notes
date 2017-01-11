<?php
include 'common.php';

ensure_login();

if(empty($_GET) || empty($_GET['action'])) {
  display_page('admin', [
    'articles' =>  $gPDO->query("SELECT * FROM articles")->fetchAll(),
    'users' => $gPDO->query("SELECT * FROM users")->fetchAll()
  ]);

  exit();
}


$nusql = "INSERT INTO users(username, password, role) VALUES(:username, :password, :role)";
$dusql = "DELETE FROM users WHERE id = :id";
$dasql = "DELETE FROM articles WHERE id = :id";

switch($_GET['action']) {
  case 'newuser':
    $stmt = $gPDO->prepare($nusql);
    $stmt->execute(['password' => password_hash($_POST['password'], PASSWORD_DEFAULT)] + $_POST);
  break;

  case 'deluser':
    $stmt = $gPDO->prepare($dusql);
    $stmt->execute(['id' => $_GET['id']]);
  break;

  case 'delarticle';
    $stmt = $gPDO->prepare($dasql);
    $stmt->execute(['id' => $_GET['id']]);
  break;

  default:
    throw new Exception('Unknown Action!');
}
