<?php echo e(csrf_field()); ?>

<?php if(session()->has('id')): ?> 
<!DOCTYPE html>
<html>
<head>
<title>Dashboard</title>
</head>
<body>

<h1> WELCOME TO OUR WEBSITE </h1> 
<h2>Service Provider Dashboard</h2> <br> 

<a href="profile"> <input name="profile" type="submit" value="PROFILE"> </a>
<br> <br>

<a href="services.php"> <input name="services" type="submit" id="click" value="SERVICES"> </a>
<br> <br>
<a href="providedservice.php"> <input name="services" type="submit" id="click" value="SERVICE INFORMATION"> </a>
<br> <br>
<a href="travelinfo.php"> <input name="travelinfo" type="submit" id="click" value="UPDATE INFORMATION"> </a>
<br> <br>

<a href="travelLog.php"> <input name="travelLog" type="submit" id="click" value="TRAVEL  LOG"> </a>
<br> <br>

<a href="../Control/Logout.php"> <input name="logOut" type="submit" id="click" value="LOG OUT"> </a>
<br>
<br>
</div>
</body>
</html>

<?php endif; ?><?php /**PATH C:\xampp\htdocs\insertdb\resources\views/dashboard.blade.php ENDPATH**/ ?>