<?php
$word = trim($_GET['text']);

$red = dechex($_GET['red']);
$green = dechex($_GET['green']);
$blue = dechex($_GET['blue']);

$nth = $_GET['nth'];

if (strlen($red) == 1) {
    $red = "0". $red;
}
if (strlen($green) == 1) {
    $green = "0" . $green;
}
if (strlen($blue) == 1) {
    $blue = "0" . $blue;
}

$red = strtolower($red);
$green = strtolower($green);
$blue = strtolower($blue);



$rgbColor = "#" . $red . $green . $blue;
echo "<p>";
for ($i = 0; $i < strlen($word); $i++) {
    if ($nth == 1 && strlen($word) == 1) {
        echo '<span style="color: ' . htmlspecialchars($rgbColor) . '">' . htmlspecialchars($word[$i]) . "</span>";
        break;
    }
    if ($nth == 1) {
        echo '<span style="color: ' . htmlspecialchars($rgbColor) . '">' . htmlspecialchars($word[$i]) . "</span>";
    }

    else{
        if ($i == 0) {
            echo htmlspecialchars($word[$i]);
            continue;
        }
        if (($i+1) % $nth == 0) {
            echo '<span style="color: ' . htmlspecialchars($rgbColor) . '">' . htmlspecialchars($word[$i]) . "</span>";
        } else {
            echo htmlspecialchars($word[$i]);
        }
    }

}
echo "</p>";