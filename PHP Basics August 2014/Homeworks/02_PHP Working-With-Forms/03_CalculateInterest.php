<?php
if ($_SERVER['REQUEST_METHOD'] === "POST") {
    $amount = $_POST['amount'];
    $currency = $_POST['currency'];
    $percent = $_POST['percent'];
    $period = $_POST['period'];
    $finalSum = $amount * pow(( 1 + ($percent/100) / 12), ($period / 12 * 12) );
    $result = $currency . " " . round($finalSum, 2);
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Calculate Interest</title>
    <meta charset="UTF-8" />
</head>
<body>
<form method="post" action="">
    <label for="amount">Enter Amount</label>
    <input name="amount" id="amount" type="text"/>
    <br/>
    <input id="usd" name="currency" value="$" type="radio"/>
    <label for="usd">USD</label>
    <input id="eur" name="currency" value="€" type="radio"/>
    <label for="eur">EUR</label>
    <input type="radio" id="bgn" value="BGN" name="currency"/>
    <label for="bgn">BGN</label>
    <br/>
    <label for="percent">Compound Interest Amount</label>
    <input name="percent" type="text" id="percent"/>
    <br/>
    <select name="period">
        <option value="6" selected="selected">6 Months</option>
        <option value="12">1 Year</option>
        <option value="24">2 Years</option>
        <option value="60">5 Years</option>
    </select>
    <input value="Calculate" type="submit"/>

    <p><strong>Result:</strong>
        <?php
            if (isset($result)) {
                echo $result;
            }
        ?>
    </p>
</form>
</body>
</html>