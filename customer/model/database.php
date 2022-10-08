<?php
class db{
 
function OpenCon()
 {
 $dbhost = "localhost";
 $dbuser = "root";
 $dbpass = "";
 $db = "data";
 $conn = new mysqli($dbhost, $dbuser, $dbpass,$db) or die("Connect failed: %s\n". $conn -> error);
 
 return $conn;
 }
 
 function CheckUser($conn,$table,$username,$password)
 {
   $result = $conn->query("SELECT * FROM $table WHERE username='$username' AND password='$password'");
   return $result;
 }

 function CheckUique($conn,$table,$username)
 {
$result = $conn->query("SELECT * FROM  $table WHERE username='$username'");
 return $result;
 }

 function UpdateUser($conn,$table,$name,$username,$email,$contact,$gender,$password)
 {
  $result = $conn->query("UPDATE $table SET name='$name',email='$email',contact='$contact',gender='$gender',password='$password' WHERE username='$username'");
  return $result;
 }

 function InsertUser($conn,$table,$name,$username,$email,$contact,$gender,$password)
 {
  $result = $conn->query("INSERT INTO $table (name, username, email, contact, gender, password) VALUES ('$name','$username', '$email', '$contact', '$gender', '$password')");
  return $result;
 }

 function InsertVehicle($conn,$table,$username,$vehicle1,$vehicle2,$vehicle3)
 {
  $result = $conn->query("INSERT INTO $table (username, car, micro_bus, bus) VALUES ('$username', '$vehicle1', '$vehicle2', '$vehicle3')");
  return $result;
 }

 function SearchVehicle($conn,$table,$username)
 {
    $result = $conn->query("SELECT * FROM  $table WHERE username='$username'");
    return $result;
 }

 function SearchService($conn,$table,$usernam,$veh)
 {
    $result = $conn->query("SELECT * FROM  $table WHERE username='$usernam' AND vehicle='$veh'");
    return $result;
 }

 function DeleteUser($conn,$table,$username)
 {
  $result = $conn->query("DELETE FROM $table WHERE username='$username'");
  return $result;
 }

 function ShowAll($conn,$table)
 {
$result = $conn->query("SELECT * FROM  $table");
 return $result;
 }

 function InsertService($conn,$table,$username,$vehicle,$loc1,$drop_loc,$cost)
 {
  $result = $conn->query("INSERT INTO $table (username, vehicle, pick, destination, cost) VALUES ('$username','$vehicle', '$loc1', '$drop_loc', '$cost')");
  return $result;
 }

 function UpdateVehicle($conn,$table,$username,$input)
 {
  $result = $conn->query("UPDATE $table SET $input='Yes' WHERE username='$username'");
  return $result;
 }

 function DeleteVehicle($conn,$table,$username,$input)
 {
  $result = $conn->query("UPDATE $table SET $input='No' WHERE username='$username'");
  return $result;
 }

 function CheckCity($conn,$table,$city)
 {
  $result = $conn->query("SELECT * FROM  $table WHERE city LIKE '%$city%' ");
  return $result;
 }
 function CheckLoc2($conn,$table,$username,$loc)
 {
  $result = $conn->query("SELECT * FROM  $table WHERE username='$username' AND destination LIKE '%$loc%' ");
  return $result;
 }

 function BookRoom($conn,$table,$username,$hotel,$room)
 {
  $result = $conn->query("UPDATE $table SET status='Booked' , user='$username' WHERE name='$hotel' AND room='$room'");
  return $result;
 }

 function DeleteCosting($conn,$table,$username,$vehicle,$pickup,$drop)
 {
  $result = $conn->query("DELETE FROM $table WHERE username='$username' AND vehicle='$vehicle' AND pick='$pickup' AND destination='$drop' ");
  return $result;
 }

 function ShowTravel($conn,$table,$user)
 {
$result = $conn->query("SELECT * FROM  $table WHERE serviceprovider='$user'");
 return $result;
 }


function CloseCon($conn)
 {
 $conn -> close();
 }
}
?>