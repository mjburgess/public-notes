<!DOCTYPE html>
<html>
<head>
    <title>Hello!</title>
</head>
<body>
    <form method="post" action="index.php">
        <input type="text" name="username" />
        <input type="password" name="password" />
        <button type="submit">Send!</button>
    </form>
</body>
</html>

<?php
//for every element in $_POST, ie. every form input
// get the key $key, and value $value
// $key == input's name
// $value == input's value

foreach($_POST as $key => $value) {
    echo "<p>$key: $value</p>";
}
