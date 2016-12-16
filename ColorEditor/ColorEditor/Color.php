<?php
if (file_exists('../../../wp-config.php' ))
{
    include_once('../../../wp-config.php' );
}
else if (file_exists('./wp-config.php'))
{
    include_once('./wp-config.php');
}
class Color {
    public $colorName;
    public $hexValue;
    public function __construct($colorName, $hexValue)
    {
        $this->colorName = $colorName;
        $this->hexValue = $hexValue;
    }
    public function insert($table_name)
    {
        global $wpdb;
        $insert = "insert into " . $table_name . "(colorName, hexValue)" .
            "values ( " .
            "'" . $this->colorName . "'," .
            "'" . $this->hexValue . "'," .
            ")" .
            ";";
        $wpdb->query($insert);
    }
    public static function delete($table_name, $id)
    {
        global $wpdb;
        $delete = "delete from " . $table_name . " " .
            "where id=" . $id.
            ";";
        echo $delete;
        $wpdb->query($delete);
    }
    public function update($table_name, $id)
    {
        global $wpdb;
        $update = "update " . $table_name . " " .
            "set " .
            "name = '" . $this->colorName . "', " .
            "description = '" . $this->hexValue . "', " .
            "where id = " . $id.
            ";";
        echo $update;
        $wpdb->query($update);
    }

}