<?php
include 'common.php';

$sql = "SELECT * FROM users WHERE username = :username";

switch($_SERVER['REQUEST_METHOD']) {
  case 'GET':
    display_page('login');
    break;

  case 'POST':
    $stmt = $gPDO->prepare($sql);
    $stmt->execute(['username' => $_POST['username']]);

    perform_login($stmt->fetch());
    break;
}

if(isset($_GET['logout'])) {
  session_destroy();
}
