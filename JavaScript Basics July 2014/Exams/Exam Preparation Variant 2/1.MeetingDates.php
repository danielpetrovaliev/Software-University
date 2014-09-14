<?php

$firstDate = $_GET['dateOne'];
$secondDate = $_GET['dateTwo'];

$dateOneObject = date_create($firstDate, timezone_open('Europe/Sofia'));
$dateTwoObject = date_create($secondDate, timezone_open('Europe/Sofia'));
$allThursdays = [];

$startDate = ($dateOneObject < $dateTwoObject) ? $dateOneObject : $dateTwoObject;
$endDate = ($dateOneObject == $startDate) ? $dateTwoObject : $dateOneObject;


$currdate = $startDate;

while ($currdate <= $endDate) {
    $weekDay = date_format($currdate, "w");

    if ($weekDay == "4") {
        $allThursdays[] = date_format($currdate, "d-m-Y");
    }
    date_add($currdate, date_interval_create_from_date_string('1 day'));
}


if (empty($allThursdays)) {
    die("<h2>No Thursdays</h2>");
} else{
    echo"<ol>";
    foreach ($allThursdays as $thursday) {
        echo"<li>$thursday</li>";
    }
    echo "</ol>";
}