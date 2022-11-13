<html>
    <title>login</title>
<body>
    <form action="/login" method="post">
        <?php echo e(csrf_field()); ?>

    <h1>LOGIN PAGE</h1> <br>
    <?php if(@isset($output)): ?>
        <b><?php echo e($output); ?></b>
<?php endif; ?>
    Your ID is <input type="text" name="id" value="">
<br><br>
    Your password is <input type="password" name="password" value="">
<br><br>
<input type="submit" value="Login"> <br> <br><br>
    </form>
    If you don't have a account register here, <a href="/register"> <input name="register" type="submit" value="Register"> </a> <br>
</body>
</html>
<?php /**PATH C:\xampp\htdocs\middleware\resources\views/login.blade.php ENDPATH**/ ?>