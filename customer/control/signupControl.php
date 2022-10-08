<?php
include('../model/database.php');
$error=$error1=$errorName=$errorUserName=$errorPass=$errorEmail=$errorGender=$errorContact=$errorCheckBox=$errorFile=$userNameTaken="";
$forChecking="YES VALID";

if (isset($_POST['submit']))
{
    if (!(empty($_POST['username'])))
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->CheckUique($conobj,"customer",$_POST['username']);
        if ($userQuery->num_rows > 0)
        {
            $userNameTaken="yes";
        }
    }
}

// store session data
if (isset($_POST['submit'])) 
{
    if (empty($_POST["name"])) 
    {
        $errorName = "Name is required";
    } 
      else 
      {
        $name = $_POST["name"];
        if (!preg_match("/^[a-zA-Z-' ]*$/",$name)) 
        {
            $errorName = "Only letters and white space allowed";
        }
    }
    if (empty($_POST['username']))
    {
        $errorUserName = "Invalid username was Provided";
    }
    if($userNameTaken != "")
    {
        $errorUserName = "Username was taken already";
    }
    if (empty($_POST["email"])) 
    {
        $errorEmail = "Email is required";
    } 
    else 
    {
        $email = $_POST["email"];
        if (!filter_var($email, FILTER_VALIDATE_EMAIL)) 
        {
            $errorEmail = "Invalid email format";
        }
    }
    if (empty($_POST['contact'])) 
    {
        $errorContact = "Contact is required";
    }
    else
    {
        $contact = $_POST["contact"];
        if (strlen($contact)!=11 && strlen($contact)!=14)
        {
            $errorContact = "Invalid contact format";
        }
    }
    if (empty($_POST['password'])) 
    {
        $errorPass = "Password is required";
    }
    else
    {
        $password=$_POST['password'];
        if (!preg_match("#.*^(?=.{8,20})(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*\W).*$#", $password))
        {
            $errorPass = "Invalid Password was Provided";
        }
    }
    if(!isset($_REQUEST["gender"]))
    {
       $errorGender="Please Select Your Gender";
    }

if ($errorName=="" && $errorUserName=="" && $errorPass=="" && $errorEmail=="" && $errorContact=="" && $errorGender=="" )
{
$name=$_POST['name'];
$username=$_POST['username'];
$email=$_POST['email'];
$contact=$_POST['contact'];
$password=$_POST['password'];
$gender=$_REQUEST["gender"];

$connection = new db();
$conobj=$connection->OpenCon();
$userQuery=$connection->InsertUser($conobj,"customer",$name,$username,$email,$contact,$gender,$password);
if ($userQuery===TRUE) 
{
   $error = "User Data inserted";
}
else 
{
   $error = "User Data not inserted";
}
$connection->CloseCon($conobj);
}
}

?>