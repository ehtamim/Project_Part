<html>
    <title>Register</title>
    <head><link href="css/mycss.css" rel="stylesheet" type="text/css"></head>
<body>
<h1>Registration</h1>
<form action="/register" method="post">
{{csrf_field()}}
Your name is <input type="text" name="name">
@if ($errors->has('name'))
<b>{{$errors->first('name')}}</b>
@endif
<br><br>
Your ID is <input type="text" name="id" value="">
@if ($errors->has('id'))
<b>{{$errors->first('id')}}</b>
@endif
<br><br>
Your contact is <input type="text" name="contact" value="">
@if ($errors->has('contact'))
<b>{{$errors->first('contact')}}</b>
@endif
<br><br>
Your email is <input type="text" name="email" value="">
@if ($errors->has('email'))
<b>{{$errors->first('email')}}</b>
@endif
<br><br>
Your password is <input type="password" name="password" value="">
@if ($errors->has('password'))
<b>{{$errors->first('password')}}</b>
@endif
<br><br>
Your file is <input type="file" name="file" value=" ">
@if ($errors->has('file'))
<b>{{$errors->first('file')}}</b>
@endif
<br><br>

<input type="submit" value="Register"> <br> <br><br>
</form>
<a href="/login"> <input name="login" type="submit" value="Login Page"> </a>
</body>
</html>
