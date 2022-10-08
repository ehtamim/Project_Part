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
  xhttp.open("POST", "/makemytrip.com/Control/formHandle.php?checkUserName="+checkUserName, true);
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
  var allowedExtensions = /(\.doc|\.pdf|\.docx)$/i;
  var car=document.getElementById("vehicle1").checked;
  var micro=document.getElementById("vehicle2").checked;
  var bus=document.getElementById("vehicle3").checked;

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
  if (!allowedExtensions.exec(filePath)) 
  {
    document.getElementById("jserror").innerHTML="Please select a valid file";
    fileInput.value = '';
    return false;
  }
  if (car==false && micro==false && bus==false)
  {
    document.getElementById("jserror").innerHTML="Please select a vehicle";
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

function validateLocation()
{
  var loc1 = document.getElementById("loc1").value;
  var loc2 = document.getElementById("drop_loc").value;
  var cost = document.getElementById("cost").value;
  var costx = /^(\$|)([1-9]\d{0,2}(\,\d{3})*|([1-9]\d*))(\.\d{2})?$/;
  var car=document.getElementById("car").checked;
  var micro_bus=document.getElementById("micro_bus").checked;
  var bus=document.getElementById("bus").checked;

  if (loc1 == "") 
  {
    document.getElementById("locError").innerHTML="Please enter pick up location";
    return false;
  }
  if (loc2 == "") 
  {
    document.getElementById("locError").innerHTML="Please enter dropping location";
    return false;
  }
  if (!(costx.test(cost))) 
  {
    document.getElementById("locError").innerHTML="Please enter valid cost";
    return false;
  }
  if(car==false && micro_bus==false && bus==false)
  {
    document.getElementById("locError").innerHTML="Please select vehicle type";
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
