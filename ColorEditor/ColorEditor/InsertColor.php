<?php
include_once('Color.php');
foreach(array_keys($_POST) as $key)
    echo "<p>" . $key . " => " . $_POST[$key] . "</p>";
$Product = new Color($_POST['colorName'], $_POST['hexValue']);
$Product->insert('ce_ColorValues');
?>