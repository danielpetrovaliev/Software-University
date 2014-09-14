<?php
$text = $_GET['text'];
$minFontSize = $_GET['minFontSize'];
$maxFontSize = $_GET['maxFontSize'];
$step = $_GET['step'];

$stroke = "text-decoration:line-through;";
$isIncremented = true;

$currSize = $minFontSize;
for ($i = 0; $i < strlen($text); $i++) {
	if (ord($text[$i]) % 2 == 0) {
        echo "<span style='font-size:$currSize;$stroke'>";
    }
    else{
        echo "<span style='font-size:$currSize;'>";
    }
    echo htmlspecialchars($text[$i]);
    echo "</span>";

    if (ctype_alpha($text[$i])) {
        if ($isIncremented) {
            $currSize += $step;
            if ($currSize >= $maxFontSize) {
                $isIncremented = false;
            }
            continue;
        }
        elseif(!$isIncremented){
            $currSize -= $step;
            if ($currSize <= $minFontSize) {
                $isIncremented = true;
            }
        }
    }
}