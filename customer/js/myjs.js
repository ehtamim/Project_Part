var uniqueUserName="";

function validateVehicle()
{
  var veh=document.getElementById("vehiclename").value;
  if (veh == "") 
  {
    document.getElementById("vehError").innerHTML="Please enter a vehile name";
    return false;
  }
  if (veh !="car" && veh !="micro_bus" && veh !="bus")
  {
    document.getElementById("vehError").innerHTML="Give valid vehicle name.";
    return false;
  }
}

function AjaxLocation1()
{
  var checkLocation = document.getElementById("uploc1").value;
  var xhttp = new XMLHttpRequest();
  xhttp.onreadystatechange = function() 
  {
    if (this.readyState == 4 && this.status == 200) 
    {
      document.getElementById("locInfo").innerHTML = this.responseText;
    }
  };
  xhttp.open("POST", "/makemytrip.com/control/loc1Handle.php?checkLocation="+checkLocation, true);
  xhttp.send();
}

function MyAjaxFunc() 
{
  var checkUserName = document.getElementById("username").value;
  var xhttp = new XMLHttpRequest();
  xhttp.onreadystatechange = function() 
  {
    if (this.readyState == 4 && this.status == 200) 
    {
      document.getElementById("message").innerHTML = this.responseText;
    }
  uniqueUserName=document.getElementById("message").value;
  };
  xhttp.open("POST", "/customer/control/usernameHandle.php?checkUserName="+checkUserName, true);
  xhttp.send();
}

function hotels() 
{
  var checkCity = document.getElementById("city").value;
  var xhttp = new XMLHttpRequest();
  xhttp.onreadystatechange = function() 
  {
    if (this.readyState == 4 && this.status == 200) 
    {
      document.getElementById("herror").innerHTML = this.responseText;
    }
  };
  xhttp.open("POST", "/customer/control/formHandle.php?checkCity="+checkCity, true);
  xhttp.send();
}


function validateForm() 
{
  var username = document.getElementById("username").value;
  var password = document.getElementById("password").value;
  if (username == "") 
  {
    document.getElementById("error").innerHTML="Please enter username";
    return false;
  }
  if ( password== "") {
    document.getElementById("error").innerHTML="Please enter password";
    return false;
  }
}

function validateSignUpForm() 
{
  var name = document.getElementById("name").value;
  var regName = /^[a-zA-Z]+ [a-zA-Z]+$/
  var username = document.getElementById("username").value;
  var contact= document.getElementById("contact").value;
  var passw=  /(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}/;
  var password = document.getElementById("password").value;
  var email=document.getElementById("email").value;
  var x = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
  var fileInput = document.getElementById("document");
  var filePath = fileInput.value;
  var allowedExtensions = /(\.png|\.jpg)$/i;
  var getSelectedValue = document.querySelector( 'input[name="gender"]:checked');

  if (!(regName.test(name))) 
  {
    document.getElementById("jserror").innerHTML="Please enter name";
    return false;
  }
  if (username == "") 
  {
    document.getElementById("jserror").innerHTML="Please enter username";
    return false;
  }

  if (!(x.test(email)))
  {
    document.getElementById("jserror").innerHTML="Please enter valid email";
    return false;
  }
 if (!(contact.length==11 || contact.length==14)) 
  {
    document.getElementById("jserror").innerHTML="Please enter valid contact no";
    return false;
  }
  if (!(passw.test(password))) 
  {
    document.getElementById("jserror").innerHTML="Please enter valid password";
    return false;
  }
  if (getSelectedValue == null)
  {
    document.getElementById("jserror").innerHTML="Please select a Gender";
    return false;
  } 
  if (!allowedExtensions.exec(filePath)) 
  {
    document.getElementById("jserror").innerHTML="Please select a valid file";
    return false;
  }
}


function validateProfile() 
{
  var name = document.getElementById("name").value;
  var regName = /^[a-zA-Z]+ [a-zA-Z]+$/
  var contact= document.getElementById("contact").value;
  var passw=  /(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}/;
  var password = document.getElementById("password").value;
  var email=document.getElementById("email").value;
  var x = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
  var getSelectedValue = document.querySelector( 'input[name="gender"]:checked');

  if (!(regName.test(name))) 
  {
    document.getElementById("profileError").innerHTML="Please enter name";
    return false;
  }
  if (!(x.test(email)))
  {
    document.getElementById("profileError").innerHTML="Please enter valid email";
    return false;
  }
 if (!(contact.length==11 || contact.length==14)) 
  {
    document.getElementById("profileError").innerHTML="Please enter valid contact no";
    return false;
  }
  if (getSelectedValue == null)
  {
    document.getElementById("jserror").innerHTML="Please select a Gender";
    return false;
  } 
  if (!(passw.test(password))) 
  {
    document.getElementById("profileError").innerHTML="Please enter valid password";
    return false;
  } 
}

function deleteMsg()
{
  alert ("Account was deleted!");
}

function searchHotel()
{
    var city = document.getElementById("city").value;
  var date = document.getElementById("date").value;
  if (city == "") 
  {
    document.getElementById("herror").innerHTML="Please enter city";
    return false;
  }
  if ( date== "") {
    document.getElementById("herror").innerHTML="Please enter date";
    return false;
  }
} 

function AjaxLocation2()
{
  var checkLocation2 = document.getElementById("uploc2").value;
  var xhttp = new XMLHttpRequest();
  xhttp.onreadystatechange = function() 
  {
    if (this.readyState == 4 && this.status == 200) 
    {
      document.getElementById("locInfo").innerHTML = this.responseText;
    }
  };
  xhttp.open("POST", "/makemytrip.com/control/loc2Handle.php?checkLocation2="+checkLocation2, true);
  xhttp.send();
}
