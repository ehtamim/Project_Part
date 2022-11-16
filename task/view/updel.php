<?php  
include('../control/updelControl.php');
?>
<!DOCTYPE html>
<html>
</head>
<body>
<h3>UPDATE OR DELETE</h3><br>
<form name="" action="" method="post">
<?php echo $updelError; ?>
Income: <input type="text" id="upincome" name="upincome" value="<?php echo $incVal;?>"> <br> <br>
Expense: <input type="text" id="upexpense" name="upexpense" value="<?php echo $expVal;?>"> <br> <br>  
<input name="up" type="submit" value="UPDATE">
<input name="del" type="submit" value="DELETE">
</form>

</body>
</html>