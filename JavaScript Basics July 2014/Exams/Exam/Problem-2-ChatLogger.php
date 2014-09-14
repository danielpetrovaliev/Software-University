<?php
date_default_timezone_set("Europe/Sofia");
$currDate = $_GET['currentDate'];
$messages = $_GET['messages'];





$chat = explode("\n", $messages);

for ($i = 0; $i < count($chat); $i++) {
    $message = preg_split("/\s+\/\s+/", $chat[$i]);
    $text = $message[0];
    $dateMessage = trim($message[1]);
    $sorterMessages["$dateMessage"] = trim($text);
}


uksort($sorterMessages, "isBigger");
foreach ($sorterMessages as $key => $value) {
    echo "<div>";
    echo htmlentities($value);
    echo "</div>\n";
}
$lastMesage = end(array_keys($sorterMessages));

$firstDate = $currDate;
$lastDate = $lastMesage;

$currDate = date("U", strtotime($currDate));
$lastMesage = date("U", strtotime($lastMesage));

$seconds = $currDate - $lastMesage;
$min = floor($seconds/60);
$hours = floor($min/60);
$days = floor($hours/24);

if($days > 1){
    echo "<p>Last active: <time>" . htmlspecialchars(date("d-m-Y", strtotime($lastDate))) . "</time></p>";
}

elseif($min <= 59 && $min > 0){
    echo "<p>Last active: <time>" . htmlspecialchars($min) . " minute(s) ago</time></p>";
}
elseif ($days == 1 || ($lastDate[0] . $lastDate[1]) != ($firstDate[0] . $firstDate[1])) {
    echo "<p>Last active: <time>yesterday</time></p>";
}
elseif($seconds <= 59){
    echo "<p>Last active: <time>a few moments ago</time></p>";
}
elseif($hours <= 24 && $hours > 0){
    echo "<p>Last active: <time>" . htmlspecialchars($hours) . " hour(s) ago</time></p>";
}

function isBigger($a, $b){
    return date("U", strtotime($a)) - date("U", strtotime($b));
}






