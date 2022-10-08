<?php
/* session_start(); 
if(empty($_SESSION[""])) 
{
header("Location: ../view/Admin.php");
} */
include "../Model/database.php";
        $connection=new db();
        $conobj=$connection->OpenCon();

        $showall=$connection->ShowAll($conobj,"user");

        if ($showall->num_rows > 0) {
        
            while($row = $showall->fetch_assoc()) {

                  $name= $row['name'];
                  $username=$row['username'];
                  $email=$row['email']; 
                  $password=$row['password'];
             

            
              echo "  Email : ".$name."<br>";
              echo " Password : ".$username."<br>";
              echo "first name: ".$email."<br>";
              echo " last name : ".$password."<br>";
            

           }
    }

    ?>