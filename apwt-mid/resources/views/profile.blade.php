<!DOCTYPE html>
<html>

<head>
    <title>Profile</title>
    <link href="css/mycss.css" rel="stylesheet" type="text/css">
</head>
<div>

    <body>
        <h1> USER PROFILE </h1>
        <form name="profileUpdate" action="/profileUpdate" method="post">
            <br>
            {{ csrf_field() }}
            Name : <input type="text" id="udname" name="udname" value="{{ $uname }}">
            @if ($errors->has('udname'))
                <b>{{ $errors->first('udname') }}</b>
            @endif
            <br><br>
            ID : {{ $uid }} <br>
            <br>
            Contact : <input type="text" id="udcontact" name="udcontact" value="{{ $ucontact }}">
            @if ($errors->has('udcontact'))
                <b>{{ $errors->first('udcontact') }}</b>
            @endif
            <br><br>
            Email : <input type="text" id="udemail" name="udemail" value="{{ $uemail }}">
            @if ($errors->has('udemail'))
                <b>{{ $errors->first('udemail') }}</b>
            @endif
            <br><br>
            Password : <input type="text" id="udpassword" name="udpassword" value="{{ $upassword }}">
            @if ($errors->has('udpassword'))
                <b>{{ $errors->first('udpassword') }}</b>
            @endif
            <br><br>
            <input type="submit" value="UPDATE"> <br><br>
        </form>
        <a href="/deleteProfile"><input name="delete" type="submit" value="DELETE">

            <br><br><br>
            <a href="/dashboard"> <input name="dashboard" type="submit" value="Home Page"> </a>
            
            <a href="/logout"> <input name="logOut" type="submit" value="LOG OUT"> </a>
</div>
</body>

</html>
