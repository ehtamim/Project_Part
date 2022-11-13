<html>
    <title>Register</title>
    <head><link href="css/mycss.css" rel="stylesheet" type="text/css"></head>
<body>
<h1>Registration</h1>
<form action="/register" method="post">
<?php echo e(csrf_field()); ?>

Your name is <input type="text" name="name">
<?php if($errors->has('name')): ?>
<b><?php echo e($errors->first('name')); ?></b>
<?php endif; ?>
<br><br>
Your ID is <input type="text" name="id" value="">
<?php if($errors->has('id')): ?>
<b><?php echo e($errors->first('id')); ?></b>
<?php endif; ?>
<br><br>
Your contact is <input type="text" name="contact" value="">
<?php if($errors->has('contact')): ?>
<b><?php echo e($errors->first('contact')); ?></b>
<?php endif; ?>
<br><br>
Your email is <input type="text" name="email" value="">
<?php if($errors->has('email')): ?>
<b><?php echo e($errors->first('email')); ?></b>
<?php endif; ?>
<br><br>
Your password is <input type="password" name="password" value="">
<?php if($errors->has('password')): ?>
<b><?php echo e($errors->first('password')); ?></b>
<?php endif; ?>
<br><br>
Your file is <input type="file" name="file" value=" ">
<?php if($errors->has('file')): ?>
<b><?php echo e($errors->first('file')); ?></b>
<?php endif; ?>
<br><br>

<input type="submit" value="Register"> <br> <br><br>
</form>
<a href="/login"> <input name="login" type="submit" value="Login Page"> </a>
</body>
</html>
<?php /**PATH C:\xampp\htdocs\apwt-mid\resources\views/register.blade.php ENDPATH**/ ?>