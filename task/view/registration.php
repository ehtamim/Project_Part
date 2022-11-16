<?php
include('../control/registrationControl.php');

if(isset($_SESSION['username'])){
header("location: login.php");
}
?>
<!DOCTYPE html>
<html>
<head>
<title>registration</title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

</head>
<body class="container">
<h1>Sign Up</h1> <br> 
<form action="<?php echo $_SERVER["PHP_SELF"];?>" method="post" enctype="multipart/form-data">

Full Name: <input type="text" id="name" name="name" placeholder="Enter your name" > <?php echo $errorName; ?> <br><br>   
User Name: <input type="text" id="username" name="username" placeholder="Enter your username"> <?php echo $errorUserName; ?> <br><br>
Contact No:<input type="text" id="contact" name="contact" placeholder="Enter your contact no" > <?php echo $errorContact; ?> <br><br>
Password: <input type="password" id="password" name="password" placeholder="Enter your password"> <?php echo $errorPass; ?> <br><br>
<input name="submit" type="submit" value="SIGN UP"><br><br>
</form>

<?php echo $error; ?> <br>
<a href="login.php"> <input name="login" type="submit" value="LOG IN"> </a>
</body>
</html>