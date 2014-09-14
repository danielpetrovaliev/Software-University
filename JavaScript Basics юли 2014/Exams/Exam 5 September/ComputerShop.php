<?php
$list = $_GET['list'];
$minPrice = $_GET['minPrice'];
$maxPrice = $_GET['maxPrice'];
$filter = $_GET['filter'];
$order = $_GET['order'];

$productsList = [];
$output = "";
$products = preg_split("/[\r\n]+/", $list, -1, PREG_SPLIT_NO_EMPTY);
$id = 1;
foreach ($products as $product) {

    $product = preg_split("/\s*[|]\s*/", $product, -1, PREG_SPLIT_NO_EMPTY);
    $model = $product[0];
    $type = $product[1];
    $components = preg_split("/\s*[,]\s*/",$product[2]);
    $price = $product[3];

    $productsList[$model] = [
        "id"=>$id,
        "type"=>$type,
        "components"=>$components,
        "price" =>$price
    ];
    array_push($productsList[$model], $price);
    $id++;
}


foreach ($productsList as $key => $prod) {
    usort($prod, function($a, $b) {
        $b = next($productsList);
        return $a['price'] - $b['price'];
    });
    $categories[$key] = $prod;

}
var_dump($productsList);

foreach ($productsList as $name => $item) {

    if ($item["type"] == $filter || $item['type'] == "all") {
        if ($item["price"] <= $maxPrice && $item["price"] >= $minPrice) {
            $output .= '<div class="product" id="product'. $item["id"] .'"><h2>'. $name .'</h2><ul>';

            foreach ($item["components"] as $component) {
                $output.= "<li class=\"component\">" . $component . "</li>";
            }


           $output .= '</ul><span>'. $item["price"] .'</span>';
        }
    }
}



echo $output;
