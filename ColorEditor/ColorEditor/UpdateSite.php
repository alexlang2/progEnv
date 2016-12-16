<?php
include_once('Color.php');
foreach(array_keys($_POST) as $key)
    echo "<p>" . $key . " => " . $_POST[$key] . "</p>";
$Product = new Color($_POST['color'], $_POST['hexValue']);


    $this->headerColor = $headerColor;
    $this->bodyColor = $bodyColor;
    $this->footerColor = $footerColor;

echo '<style type="text/css">
        header{
            color = headerColor;
        }
        body{
        color = bodyColor;
        }
        footer{
        color = footerColor;
        }
        </style>';
