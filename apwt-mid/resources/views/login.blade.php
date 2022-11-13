<html>
    <title>login</title>
    <head><link href="css/mycss.css" rel="stylesheet" type="text/css"></head>
<body>
    <form action="/login" method="post">
        {{csrf_field()}}
    <h1>LOGIN PAGE</h1> <br>
    @if (@isset($output))
        <b>{{$output}}</b>
@endif
    Your ID is <input type="text" name="id" value="">
<br><br>
    Your password is <input type="password" name="password" value="">
<br><br>
<input type="submit" value="Login"> <br> <br><br>
    </form>
    If you don't have a account register here, <a href="/register"> <input name="register" type="submit" value="Register"> </a> <br>
</body>
</html>
