<?php
// in general, PHP should be separated out from HTML as much as possible
// with only simple echo statements embeded within HTML

// that is, you move all of the PHP which calculates the value of variables
// off into another file and use *include* to bring the files together

// this separates logic: code to do with displaying info. vs. code calculating which to display
// mixing these kinds of code together makes it very hard to see what a program is doing
// therefore makes it diffuclt to change, and increases the likelyhood of making mistakes

//for now however, let's combine them...
//though keeping each as separated out from the other as possible

// let's define some variables for the page

$title = 'HTML & PHP';
$heading = 'A Page about HTML and PHP';

$topics = ['photography', 'philosophy', 'programming'];

// below, I echo out these variables using a handy short-cut
// <?=   means <?php echo
?>

<!DOCTYPE>
<html>
<head>
    <title><?= $title; ?></title>
</head>
<body>
    <!-- THIS IS AN HTML COMMENT -->

<!--

it stars and ends with different symbols compared with PHP comments

... and spans multiple lines ...
 -->


<h1><?= $heading; ?></h1>

<!-- where possible, HTML should be *outside* of PHP -->

<ul>
    <?php foreach($topics as $topic) { ?>
        <li><?= $topic; ?></li>
    <?php } ?>
</ul>


<!-- PHP has an alternative syntax for control flow statements... --->

<ul>
    <?php foreach($topics as $topic): ?>
        <li><?= $topic; ?></li>
    <?php endforeach; ?>
</ul>

<!-- using endforeach instead of }   and a colon instead of {
    can be clearer when mixing PHP with HTML
    as {}  can be hard to find
-->
</body>
</html>
