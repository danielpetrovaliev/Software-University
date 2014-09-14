<?php
$name = $_GET['name'];
$gender = $_GET['gender'];
$pin = $_GET['pin'];
$checkSum = 0;
$names = preg_split("/\s/",$name);
$multiples = [2,4,8,5,10,9,7,3,6];

for ($i = 0; $i < count($multiples); $i++) {
	$checkSum += intval($pin[$i]) * $multiples[$i];
}

$remainder = $checkSum % 11;

//Check "checksum"
if ($remainder == 10) {
    $remainder = 0;
}
if ($remainder != $pin[9]) {
    die('<h2>Incorrect data</h2>');
}

/*Check for gender*/
if ($gender == "male" && intval($pin[8])%2 != 0) {
    die('<h2>Incorrect data</h2>');
}
elseif ($gender == "female" && intval($pin[8])%2 == 0) {
    die('<h2>Incorrect data</h2>');
}

/*Check Names*/
if (count($names) < 2) {
    die('<h2>Incorrect data</h2>');
}
if (ctype_lower($names[0][0]) || ctype_lower($names[1][0])) {
    die('<h2>Incorrect data</h2>');
}

$information = [
    "name" => $name,
    "gender" => $gender,
    "pin" => $pin
];

echo json_encode($information);