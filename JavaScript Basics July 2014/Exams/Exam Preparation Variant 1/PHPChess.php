<?php
$board = $_GET['board'];
$rows = explode("/", $board);
$cels = [];
//Get all Cells
foreach ($rows as $row) {
    $cels[] = preg_split('/-+/', $row);
}
$allcells = preg_split('/[-\/]+/', $board);


//Validation
if (count($rows) < 8) {
    die('<h1>Invalid chess board</h1>');
} if (count($allcells) < 64) {
    die('<h1>Invalid chess board</h1>');
}
for ($i = 0; $i < count($cels); $i++) {
    if (count($cels[$i]) < 8) {
        die('<h1>Invalid chess board</h1>');
    }
}

for ($i = 0; $i < count($allcells); $i++) {
	if (strlen($allcells[$i]) > 1) {
        die('<h1>Invalid chess board</h1>');
    }
    if ($allcells[$i] != "B" && $allcells[$i] != "P"
        && $allcells[$i] != "K" && $allcells[$i] != "Q"
        && $allcells[$i] != "R" && $allcells[$i] != "H"
        && $allcells[$i] != " ") {

        die('<h1>Invalid chess board</h1>');
    }
}



$json = [];

//fill json
foreach ($allcells as $cell) {
    if ($cell == "B") {
        if (isset($json["Bishop"])) {
            $json["Bishop"]++;
        }
        else{
            $json["Bishop"] = 1;
        }
    }
    elseif ($cell == "H") {
        if (isset($json["Horseman"])) {
            $json["Horseman"]++;
        }
        else{
            $json["Horseman"] = 1;
        }
    }
    elseif ($cell == "K") {
        if (isset($json["King"])) {
            $json["King"]++;
        }
        else{
            $json["King"] = 1;
        }
    }
    elseif ($cell == "P") {
        if (isset($json["Pawn"])) {
            $json["Pawn"]++;
        }
        else{
            $json["Pawn"] = 1;
        }
    }
    elseif ($cell == "Q") {
        if (isset($json["Queen"])) {
            $json["Queen"]++;
        }
        else{
            $json["Queen"] = 1;
        }
    }
    elseif ($cell == "R") {
        if (isset($json["Rook"])) {
            $json["Rook"]++;
        }
        else{
            $json["Rook"] = 1;
        }
    }

}
ksort($json);

//Print

echo "<table>";
for ($i = 0; $i < count($cels); $i++) {
    echo "<tr>";
	for ($j = 0; $j < count($cels[$i]); $j++) {
        echo "<td>".$cels[$i][$j]."</td>";
	}
    echo "</tr>";
}
echo "</table>";

echo json_encode($json);
