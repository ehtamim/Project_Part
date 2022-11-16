<?php
include('../control/loginControl.php');

if(isset($_SESSION['username']))
{
header("location:dashboard.php");
}
?>
<!DOCTYPE html>
<html>
<head>
<title>login</title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body class="container"> 
<h2>Login</h2> 
<form name="myForm" action="" method="post">
Your Username: <input type="text" id="username" name="username" placeholder="Enter your username" > <?php echo $errorName; ?> <br> <br>
Your Password: <input type="password" id="password" name="password" placeholder="Enter your password" > <?php echo $errorPass; ?> <br> <br>  
<input name="submit" type="submit" value="LOGIN">
</form>
<br>
<?php echo $error; ?> <br>

If you don't have a account <a href="registration.php">Registration Here</a>
<br> <br>
</body>
</html>