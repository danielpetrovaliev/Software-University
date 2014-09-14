<?php
$list = $_GET['list'];
$maxSize = $_GET['maxSize'];

$lines = explode("\n", $list);
$unorderedList = [];

//Trim and delete empty elements
foreach ($lines as $key => $value) {
    $lines[$key] = trim($value);
    if ($lines[$key] == "" || $lines[$key] == " ") {
        unset($lines[$key]);
    }
}

//Match max size of line and put in new array
foreach ($lines as $line) {
    $pattern = "|(.){0,". $maxSize ."}|";
    preg_match($pattern, $line, $match);
    if (strlen($line) > $maxSize) {
        $match[0] .= "...";
    }
    $unorderedList[] = htmlspecialchars($match[0]);
}


echo "<ul>";

foreach ($unorderedList as $li) {
    echo "<li>$li</li>";
}

echo "</ul>";
