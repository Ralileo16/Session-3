<?php include 'functions.php'; ?>

<?=template_header('Login')?>
        <div class="frm">
            <h1>Login</h1>
            <form action="auth.php" method="post" name="f1" onsubmit="return validation()">
                <p>
                    <label for="user">Username: </label>
                    <input type="text" name="user" id="user">
                </p>
                <p>
                    <label for="pass">Password: </label>
                    <input type="text" name="pass" id="pass">
                </p>
                <p>
                    <input class="btn" type="submit" value="Login">
                    <input class="btn" type="reset">
                </p>
            </form>
        </div>
        <script>
            function validation(){
                var id = document.f1.user.value;
                var ps = document.f1.pass.value;

                if(id.length == "" && ps.length == ""){
                    alert("Username et Password ne peuvent pas être vide!");
                    return false;
                } else {
                    if(id.length == ""){
                        alert("Username ne peut pas être vide!");
                        return false;
                    }
                    if(ps.length == ""){
                        alert("Password ne peut pas être vide!");
                        return false;
                    }
                }
            }
        </script>
<?=template_footer()?>