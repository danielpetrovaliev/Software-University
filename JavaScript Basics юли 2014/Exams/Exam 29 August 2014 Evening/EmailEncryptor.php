<?php
$recipient = htmlspecialchars(trim($_GET['recipient']));
$subject = htmlspecialchars(trim($_GET['subject']));
$body = htmlspecialchars(trim($_GET['body']));
$key = trim($_GET['key']);
$encryptedText = "";

$formatedMessage = "<p class='recipient'>$recipient</p>".
        "<p class='subject'>$subject</p>" .
        "<p class='message'>$body</p>";

$keyCounter = 0;
$maxKeyCounter = strlen($key)-1;

for ($i = 0; $i < strlen($formatedMessage); $i++) {
    $encryptedText .= "|";

    //Get ACII code of chars and make new hexdecimal code
    $keyChar = ord($key[$keyCounter]);
    $messageChar = ord($formatedMessage[$i]);
    $newChar = dechex($keyChar * $messageChar);


    $encryptedText .= $newChar;

    //Reset Counter
    if ($keyCounter == $maxKeyCounter) {
        $keyCounter = 0;
        continue;
    }
    $keyCounter++;




}
$encryptedText .= "|";
echo $encryptedText;