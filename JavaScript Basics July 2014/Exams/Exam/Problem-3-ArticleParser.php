<?php
$text = $_GET['text'];
$pattern = "/^\s*([\w\s\-]+)\s*\%\s*([\w\s\.\-]+)\s*;\s*[\d]{2}\-([\d]{2})\-[\d]{4}\s*-\s*(.{0,100})/m";
preg_match_all($pattern, $text, $matches);
$articles = [];

for ($i = 0; $i < count($matches[0]); $i++) {
	$topic = htmlspecialchars(trim($matches[1][$i]));
    $author = htmlspecialchars(trim($matches[2][$i]));
    $month = htmlentities(trim($matches[3][$i]));
    $summary = htmlspecialchars(trim($matches[4][$i]));

    $articles[] = "<div>\n" .
        "<b>Topic:</b> " . "<span>" . $topic . "</span>\n".
        "<b>Author:</b> " . "<span>" . $author . "</span>\n".
        "<b>When:</b> " . "<span>" . when($month) . "</span>\n".
        "<b>Summary:</b> " . "<span>" . $summary . "..." . "</span>\n".
        "</div>";

}

$output = implode("\n", $articles);
echo $output;

function when($month){
    switch($month){
        case "01": $month = "January";
            break;
        case "02": $month = "February";
            break;
        case "03": $month = "March";
            break;
        case "04": $month = "April";
            break;
        case "05": $month = "May";
            break;
        case "06": $month = "June";
            break;
        case "07": $month = "July";
            break;
        case "08": $month = "August";
            break;
        case "09": $month = "September";
            break;
        case "10"; $month = "October";
            break;
        case "11": $month = "November";
            break;
        case "12": $month = "December";
            break;
        default: "No";
    }

    return $month;
}

