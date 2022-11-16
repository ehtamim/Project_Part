<?php
class db{
 
function OpenCon()
 {
 $dbhost = "localhost";
 $dbuser = "root";
 $dbpass = "";
 $db = "task";
 $conn = new mysqli($dbhost, $dbuser, $dbpass,$db) or die("Connect failed: %s\n". $conn -> error);
 
 return $conn;
 }
 
 function CheckUser($conn,$table,$username,$password)
 {
   $result = $conn->query("SELECT * FROM $table WHERE username='$username' AND password='$password'");
   return $result;
 }

 function CheckData($conn,$table,$id)
 {
   $result = $conn->query("SELECT * FROM $table WHERE id='$id'");
   return $result;
 }

 function CheckUique($conn,$table,$username)
 {
$result = $conn->query("SELECT * FROM  $table WHERE username='$username'");
 return $result;
 }

 function UserData($conn,$table,$username)
 {
$result = $conn->query("SELECT * FROM  $table WHERE username='$username'");
 return $result;
 }

 function UpdateUser($conn,$table,$name,$username,$contact,$password)
 {
  $result = $conn->query("UPDATE $table SET name='$name',contact='$contact',password='$password' WHERE username='$username'");
  return $result;
 }

 function UpdateData($conn,$table,$id,$income,$expense)
 {
  $result = $conn->query("UPDATE $table SET income='$income', expense='$expense' WHERE id='$id'");
  return $result;
 }

 function InsertUser($conn,$table,$name,$username,$contact,$password)
 {
  $result = $conn->query("INSERT INTO $table (name, username, contact, password) VALUES ('$name','$username', '$contact', '$password')");
  return $result;
 }

 function InsertData($conn,$table,$username,$date,$income,$expanse)
 {
  $result = $conn->query("INSERT INTO $table (username, date, income, expense) VALUES ('$username', '$date', '$income', '$expanse')");
  return $result;
 }

 function DeleteUser($conn,$table,$username)
 {
  $result = $conn->query("DELETE FROM $table WHERE username='$username'");
  return $result;
 }

 function DeleteData($conn,$table,$id)
 {
  $result = $conn->query("DELETE FROM $table WHERE id='$id'");
  return $result;
 }

 function ShowAll($conn,$table)
 {
$result = $conn->query("SELECT * FROM  $table");
 return $result;
 }

function CloseCon($conn)
 {
 $conn -> close();
 }
}
?>