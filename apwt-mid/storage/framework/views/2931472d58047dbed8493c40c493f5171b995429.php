<!DOCTYPE html>
<html>

<head>
    <title>Profile</title>
</head>
<div>

    <body>
        <h1> USER PROFILE </h1>
        <form name="profileUpdate" action="/profileUpdate" method="post">
            <br>
            <?php echo e(csrf_field()); ?>

            Name : <input type="text" id="udname" name="udname" value="<?php echo e($uname); ?>">
            <?php if($errors->has('udname')): ?>
                <b><?php echo e($errors->first('udname')); ?></b>
            <?php endif; ?>
            <br><br>
            ID : <?php echo e($uid); ?> <br>
            <br>
            Contact : <input type="text" id="udcontact" name="udcontact" value="<?php echo e($ucontact); ?>">
            <?php if($errors->has('udcontact')): ?>
                <b><?php echo e($errors->first('udcontact')); ?></b>
            <?php endif; ?>
            <br><br>
            Email : <input type="text" id="udemail" name="udemail" value="<?php echo e($uemail); ?>">
            <?php if($errors->has('udemail')): ?>
                <b><?php echo e($errors->first('udemail')); ?></b>
            <?php endif; ?>
            <br><br>
            Password : <input type="text" id="udpassword" name="udpassword" value="<?php echo e($upassword); ?>">
            <?php if($errors->has('udpassword')): ?>
                <b><?php echo e($errors->first('udpassword')); ?></b>
            <?php endif; ?>
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
<?php /**PATH C:\xampp\htdocs\middleware\resources\views/profile.blade.php ENDPATH**/ ?>