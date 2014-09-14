<?php
$today = "27/07/2014";
$invoices = ["11/05/2013 | Sopharma | Paracetamol | 20.54 lv"];
$datePieces = explode("/", $today);

$today = strtotime($datePieces[1] . "/" . $datePieces[0] . "/" . $datePieces[2]);
$delivers = array();

foreach ($invoices as $invoice) {
    $tempInvoice = preg_split('/\s*\|\s*/', $invoices);

    $currDate = $tempInvoice[0];
    $tempDatePieces = explode("/", $currDate);
    $currDate = strtotime($tempDatePieces[1] . '/' . $tempDatePieces[0] . '/' . $tempDatePieces[2]);

    $currCompany = $tempInvoice[1];
    $currMedicine = $tempInvoice[2];
    $currPrice = (string)$tempInvoice[3];

    if ($currDate >= strtotime('-5 years', $today)) {
        if (array_key_exists($currDate, $delivers)) {
            $delivers[$currDate][$currCompany][$currPrice][] = array();
            var_dump($delivers);
        }
    }


}


var_dump($datePieces);
var_dump($today);