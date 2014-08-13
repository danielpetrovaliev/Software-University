<?php

$currDate = date("d-m-Y G:i:s");
$daysInYear = 365;

if (date("L") == 1) {
    $daysInYear = 366;
}

$leftDaysOfYear = $daysInYear - date("z");
$leftHoursOfYear = ($leftDaysOfYear * 24)  - (date("G")+1);
$leftMinutesOfYear = ($leftHoursOfYear * 60) - date("i");
$leftSecondsOfYear = ($leftMinutesOfYear * 60) - date("s");



echo "Hours until new year : $leftHoursOfYear <br />
        Minutes until new year : $leftMinutesOfYear <br />
        Seconds until new year : $leftSecondsOfYear <br />
        Days : Hours : Minutes : Seconds " .
        ( $leftHoursOfYear == 0 ? $leftDaysOfYear : $leftDaysOfYear -1). ":" .
        ((($leftHoursOfYear % 24) < 10 ) ? ("0".($leftHoursOfYear % 24)) : ($leftHoursOfYear % 24)). ":" .
        ((($leftMinutesOfYear % 60) < 10 ) ? ("0".($leftMinutesOfYear % 60)) : ($leftMinutesOfYear % 60)) . ":" .
        (($leftSecondsOfYear % 60) < 10 ? ("0" . ($leftSecondsOfYear % 60)) : ($leftSecondsOfYear % 60));
