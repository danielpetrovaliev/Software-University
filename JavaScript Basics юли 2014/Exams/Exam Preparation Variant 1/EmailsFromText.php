<?php
$text = $_GET['text'];
$blacklist = $_GET['blacklist'];

preg_match_all("/[0-9-A-zZ-a+_-]+@[0-9-A-zZ-a-]+\.[0-9-A-zZ-a-.]+/", $text, $allEmails);

$domains = preg_split("/[*\s]+/", $blacklist, -1, PREG_SPLIT_NO_EMPTY);

foreach ($domains as $domain) {
    foreach ($allEmails[0] as $email) {
        if (endsWith($email, $domain)) {
            $asteriks =  str_repeat("*", strlen($email));
            $text = str_replace($email, $asteriks, $text);
        } elseif($email == $domain){
            $asteriks =  str_repeat("*", strlen($email));
            $text = str_replace($email, $asteriks, $text);
        }
    }

}

preg_match_all("/[0-9-A-zZ-a+_-]+@[0-9-A-zZ-a-]+\.[0-9-A-zZ-a-.]+/", $text, $leftEmails);

//make anchor for all lefts emails
foreach ($leftEmails[0] as $email) {
    $link = '<a href="mailto:'. $email .'">' . $email .'</a>';
    $text = str_replace($email, $link, $text);
}


function endsWith($haystack, $needle)
{
    $length = strlen($needle);
    if ($length == 0) {
        return true;
    }

    return (substr($haystack, -$length) === $needle);
}
echo "<p>";
echo $text;
echo "</p>";