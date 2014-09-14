<?php
$table = $_GET['priceList'];
$pattern = "/<td>([\s\S\n ])([^<]+)/";
preg_match_all($pattern, $table, $tableList);
$jsonProducts = [];



for ($i = 0; $i < count($tableList[1]); $i+=4) {
    $price = htmlspecialchars_decode(trim($tableList[1][$i+2].$tableList[2][$i+2]));
    $product = htmlspecialchars_decode(trim($tableList[1][$i].$tableList[2][$i]));
    $currency = htmlspecialchars_decode(trim($tableList[1][$i+3].$tableList[2][$i+3]));
    $category = htmlspecialchars_decode(trim($tableList[1][$i+1].$tableList[2][$i+1]));

    if (array_key_exists($category, $jsonProducts)) {
        $newJson = [
            "product" => $product,
            "price" => $price,
            "currency" => $currency
        ];
        array_push($jsonProducts[$category], $newJson);
    }
    else{
        $jsonProducts[$category] =
              [
                [
                    "product" => $product,
                    "price" => $price,
                    "currency" => $currency
                ]
            ];

    }
}

/*$json = '{"CPU":[{"product":"AMD A10-5800K X4 3.8GHz, 4MB Cache","price":"186.00","currency":"BGN"}],"HDD":[{"product":"1TB Toshiba, SATA 6Gb\/s, 7200rpm, 32MB","price":"52.82","currency":"EUR"},{"product":"500GB Toshiba, SATA 6Gb\/s, 7200rpm, 32MB","price":"88.41","currency":"BGN"},{"product":"SSD 2.5\", 120GB, Corsair F120 LS, SATA3","price":"180.50","currency":"BGN"}],"RAM":[{"product":"16GB Micro SDHC, A-Data, Class10","price":"15.03","currency":"BGN"},{"product":"8GB DDR3L 1600 KINGSTON SODIMM","price":"87.00","currency":"USD"}],"motherboard":[{"product":"ASRock B75M-GL R2.0","price":"47.55","currency":"EUR"}]}';
var_dump (json_decode($json, true));*/
ksort($jsonProducts);

foreach ($jsonProducts as $key => $value) {
    sort($value);
    $jsonProducts[$key] = $value;
}


echo json_encode($jsonProducts);