<?php include('../control/servicesView.php'); ?>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" type="text/css" href="../css/mycss.css">
<script src="../js/myjs.js"></script>
</head>
<body>
<div class="contentser" >
<br>

<img src="../css/images/<?php echo $pic1; ?>.jpg" >
<img src="../css/images/<?php echo $pic2; ?>.jpg" >
<img src="../css/images/<?php echo $pic3; ?>.jpg" >
<br>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
car
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
micro_bus
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
bus

<h4 id="vehError"> </h4>
<form action="" onsubmit="return validateVehicle()" method="post" enctype="multipart/form-data">
<br>
<input type="text" id="vehiclename" name="vehiclename" placeholder="Enter vehicle name">
<input name="update" type="submit" id="click" value="UPDATE">
<input name="delete" type="submit" id="click" value="DELETE">
<br><br>
</form>
<br>
<?php echo $serviceError; ?> 
<?php echo $dataError; ?>

<br> <br> <br>

<a href="admin.php"> <input name="homePage" type="submit" id="green" value="HOME PAGE"> </a>
</div>
</body>
</html>