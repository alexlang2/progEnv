<?php
   /*
   Plugin Name: Doodle Pad
   Plugin URI: http://plugin.onulang.com and http://plugin.thebemus.com
   Description: A simple drawing canvas for your website.
   Version: 1.0
   Author: Nathan Bemus and Alex Lang
   Author URI: http://author.onulang.com and http://author.thebemus.com
   License: GPL3
   */

add_filter( 'the_content', 'drawCanvas' );


function drawCanvas($content){
    
    $keyWord = $content;
    if (strpos($keyWord, "drawCanvas")){
    $keyWord= str_replace('drawCanvas',replaceWord(), $keyWord);
    }
    return $keyWord;
    
    
}
// set all that echo bullshit as a variable $key for example, 

function replaceWord(){
    
    echo "<html>";
    echo "<svg width=400, height=180>";
    echo "<rect x=50 y=20 rx=20 ry=20 width=150 height=150
  style=fill:white;stroke:black;stroke-width:5;opacity:0.5 />";
    echo "</svg>";
    echo "</html>";
}


        
?>