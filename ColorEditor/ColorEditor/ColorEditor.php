<?php
/*
Plugin Name: Color Editor
Plugin URI:  http://URI_Of_Page_Describing_Plugin_and_Updates
Description: Users may add colors of their choosing and can edit site colors.
Version:     1.0
Author:      Alex Lang
Author URI:  http://onulang.com
License:     GPL2
License URI: https://www.gnu.org/licenses/gpl-2.0.html
Domain Path: /languages
Text Domain: Color-Editor
*/
#region Regions
#region Administrative Page for NAS-Shopper
add_action( 'admin_menu', 'color_menu' );
function color_menu() {
    add_menu_page( 'Color Editor', 'Color Editor', 'manage_options', 'color_menu', 'manageColor_options' );
    add_submenu_page( 'color_menu', "Color Options", "Color Menu", 'manage_options', 'color_sub_menu', 'color_options' );
}
/**
 *
 */
function manageColor_options() {
    if ( !current_user_can( 'manage_options' ) )  {
        wp_die( __( 'You do not have sufficient permissions to access this page.' ) );
    }
    include( __DIR__ . '/ColorOptionPage.php' );
}
function color_options()
{
    if ( !current_user_can( 'manage_options' ) )  {
        wp_die( __( 'You do not have sufficient permissions to access this page.' ) );
    }
    include( __DIR__ . '/ColorManagePage.php' );
}
#endregion
#region Activation code for NAS-Shopper
register_activation_hook( __FILE__, ColorEdit_Activate );
$color_prefix = 'ce_';
function ColorEdit_Activate(){
    global $color_prefix;
    $color_prefix = 'ce_';
    CreateDBTables();
}
function CreateDBTables()
{
    CreateSiteColorTable();
    CreateColorValuesTable();
}
function CreateSiteColorTable() {
    global $color_prefix;
    $schema = "id int NOT NULL AUTO_INCREMENT,
               HeaderColor tinytext NOT NULL,
               BodyColor text,
               FooterColor text,
               PRIMARY KEY (id)";
    CreateTable($color_prefix.'SiteColors', $schema);
}
function CreateColorValuesTable() {
    global $color_prefix;
    $schema = "id int NOT NULL AUTO_INCREMENT,
               colorName tinytext NOT NULL,
               hexValue text,
               PRIMARY KEY (id)";
    CreateTable($color_prefix.'ColorValues', $schema);
}

/*
 dbDelta was not acceptable.  $wpdb->query($sql) works just fine and is not picky about the structure of $sql
*/
function CreateTable($table_name, $schema){
    global $wpdb;
    $charset_collate = $wpdb->get_charset_collate();
    $sql = "CREATE TABLE $table_name (" . $schema . ") $charset_collate;";
    $wpdb->query($sql);
}
#endregion
#endregion