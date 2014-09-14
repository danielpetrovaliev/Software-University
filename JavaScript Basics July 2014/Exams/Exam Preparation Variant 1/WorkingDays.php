<?php

$dateOne = $_GET['dateOne'];
$dateTwo = $_GET['dateTwo'];
$holidays = $_GET['holidays'];
$holidaysList = preg_split("/\s+/", $holidays);
$workingDays = [];

$dateOneObject = date_create($dateOne, timezone_open('Europe/Sofia'));
$dateTwoObject = date_create($dateTwo, timezone_open('Europe/Sofia'));

/*$startDate = ($dateOneObject < $dateTwoObject) ? $dateOneObject : $dateTwoObject;
$endDate = ($dateOneObject == $startDate) ? $dateTwoObject : $dateOneObject;*/


$currdate = $dateOneObject;

while ($currdate <= $dateTwoObject) {
    $currDay = date_format($currdate, "w");
    $today = date_format($currdate, "d-m-Y");

    if ($currDay == 0 || $currDay == 6) {
        date_add($currdate, date_interval_create_from_date_string('1 day'));
        continue;
    }
    if(in_array($today, $holidaysList)){
        date_add($currdate, date_interval_create_from_date_string('1 day'));
        continue;
    }

    $workingDays[] = $today;

    date_add($currdate, date_interval_create_from_date_string('1 day'));
}
if (empty($workingDays)) {
    die("<h2>No workdays</h2>");
}
else{
    echo "<ol>";
        foreach ($workingDays as $day) {
            echo "<li>$day</li>";
        }

    echo "</ol>";
}