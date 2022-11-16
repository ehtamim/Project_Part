<?php include('../control/profileControl.php'); ?>
<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>profile</title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body class="container">
<h1> USER PROFILE </h1>
<form name="profile" class="" action="" method="post">
<br>
Name : <input type="text" id="name" name="name" value="<?php echo $nameOfUser; ?>"> <br><br>
Username : <?php echo $unameOfUser; ?> <br><br>
Contact : <input type="text" id="contact" name="contact" value="<?php echo $contactOfUser; ?>"> <br><br>
Password : <input type="text" id="password" name="password" value="<?php echo $passOfUser; ?>"> <br><br>
<?php echo $error; ?>
<input name="update" type="submit" value="UPDATE">
<input name="delete" type="submit" value="DELETE">
<br><br>
</form>

<?php echo $errorPrf ; ?>

<br><br><br> 
<a href="../view/dashboard.php"> <input name="logOut" type="submit" value="Home Page"> </a> <br>
<a href="../control/logout.php"> <input name="logOut" type="submit" value="LOG OUT"> </a>
</div>
</body>
</html>