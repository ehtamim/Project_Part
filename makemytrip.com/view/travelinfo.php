<?php include('../Control/travelinfoControl.php'); 
if(!isset($_SESSION['username']))
{
  header("location: login.php");
}
?>

<!DOCTYPE html>
<html>
<head>
<script src="../js/myjs.js"> </script>
<link rel="stylesheet" type="text/css" href="../css/mycss.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
</head>

<body>
<div class="content2"> 
<button id="sh">ADD VEHICLE</button> 
<script>  $("#sh").click(function(){
    $("#plus").toggle();

  });
</script>
<button id="sho">UPDATE OR DELETE VEHICLE</button>
<script>  $("#sho").click(function(){
    $("#updel").toggle();

  });
  </script>

  <h3 id="locError"> </h3>
  <!-- insert -->
  <div1 id="plus">
<form action="" onsubmit="return validateLocation()" method="post" enctype="multipart/form-data" >
<h3> ADDING SERVICE </h3>
Add Pick Up Location &emsp;&emsp;&emsp;
Add Dropping Location &emsp;&emsp;&emsp;&emsp;
Enter Cost
<br>
<input type="text" id="loc1" name="loc1" placeholder="Enter location" > <?php echo $loc1Error; ?> &emsp; 
<input type="text" id="drop_loc" name="drop_loc" placeholder="Enter Location" > <?php echo $loc2Error; ?>
&emsp; <input type="text" id="cost" name="cost" placeholder="Enter cost" > <?php echo $costError; ?>
<br>
Select Vehicle: 
  <input type="radio" id="car" name="vehicle" value="car">
  <label for="car">CAR</label>
  <input type="radio" id="micro_bus" name="vehicle" value="micro_bus">
  <label for="micro_bus">MICRO BUS</label>
  <input type="radio" id="bus" name="vehicle" value="bus">
  <label for="bus">BUS</label>
  <?php echo $vehicleError; ?>
<br><br>
<input name="add" type="submit" id="click" onclick="return validateLocation()" value="ADD LOCATION">
<br><br>
</form>
</div1>
<br>
<?php echo $error; ?>

<!-- Update Delete -->
<div2 id="updel">
<form action="" onsubmit="" method="post" enctype="multipart/form-data" >
<h3> UPDATE COST OR DELETE LOCATION </h3>
Select Vehicle Type
&emsp;&emsp; Select Pick Up Location &emsp;&emsp;
Select Dropping Location &emsp;&emsp;&emsp;&emsp;
Enter Cost
<br>
<select  id="upvehicle" name="upvehicle">
<option value="Select Vehicle">SELECT VEHICLE</option>
<option value="car">CAR</option>
<option value="micro_bus">MICRO BUS</option>
<option value="bus">BUS</option>
</select>
&emsp; <input type="text" id="uploc1" name="uploc1" placeholder="Enter location" onkeyup="AjaxLocation1()" >
&emsp; <input type="text" id="uploc2" name="uploc2" placeholder="Enter location" onkeyup="AjaxLocation2()" > 
&emsp; <input type="text" id="upcost" name="upcost" placeholder="Enter cost" > 
<br>
<p id="locInfo"> </p>
<input name="update" type="submit" id="click" onclick="" value="UPDATE COST">
<input name="delete" type="submit" id="click" onclick="" value="DELETE LOCATION">
<br><br>
</form>
</div2>
<br>
<?php echo $uperror; ?>

<br>
<a href="admin.php"> <input name="homePage" type="submit" id="click" value="HOME PAGE"> </a>

<br><br><br>
<?php echo $va; ?>
</div>
</body>
</html>