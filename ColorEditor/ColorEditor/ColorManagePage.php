<div id="divManageColors" ?>

    <hr>
    <form action="../wp-content/plugins/ColorEditor/InsertColor.php" method="post">
        <div>
            <h3>Color Name:</h3>
            <input type='text' name='colorName'>
            <h3>Color Hex Value:</h3>
            <input type='text' name = 'hexValue'>
            <input type="submit" value="Insert New Color">
        </div>
    </form>
    <hr>
    <form action="../wp-content/plugins/ColorEditor/DeleteColor.php" method="post">
        <h3>Delete Color by ID</h3>
        <input type='text' name='id'>
        <input type="submit" value="Delete Color">
    </form>
    <hr>
    <form action="../wp-content/plugins/ColorEditor/UpdateSite.php" method="post">
        <h3>Update Website Colors by ID</h3>
        Header Color: <input type='text' name='headerColor'> <br>
        Body Color: <input type='text' name='bodyColor'> <br>
        Footer Color: <input type='text' name='footerColor'>
        <input type="submit" value="Update Colors">
    </form>
    <hr>
</div>