<?php
include('../control/bookhotelControl.php');
?>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" type="text/css" href="../css/mycss.css">
<script src="../js/myjs.js"></script>
</head>

<body> 
<div>
<h2 id=h2>BOOK HOTEL</h2>
<p id="herror"></p> 
<form name="myForm" action="" onsubmit="return searchHotel()" method="post">
<input type="text" id="city" name="city" onkeyup="hotels()" placeholder="Enter city name" > <?php echo $errorCity; ?> <br> <br> 
<input name="search" type="submit" value="SEARCH HOTEL" id="green">
<table border="1">
        <br><br>
      <caption> HOTELS
      	<th>Name</th>
          <th>City</th>
          <th>Location</th>
          <th>Room</th>
          <th>Bed</th>
          <th>Cost</th>
<?php  
     foreach ($hotel as $h) 
          {
               echo "<tr>";
               echo "<td>" .$h["name"]. "</td>";
               echo "<td>" .$h["city"]. "</td>";
               echo "<td>" .$h["location"]. "</td>";
               echo "<td>" .$h["room"]. "</td>";
               echo "<td>" .$h["bed"]. "</td>";
               echo "<td>" .$h["cost"]. "</td>";
               echo "<td><a href='../control/bookRoom.php?hotelName=".$h["name"]."&roomno=".$h["room"]."'>Book</a></td>";
               echo "</tr>";
          }
?>
</form>

<a href="customer.php"> <input name="customer" type="submit" id="click" value="HOME PAGE"> </a>
<br><br>
</div>
</body>
</html>