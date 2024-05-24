<?php include 'functions.php'; ?>

<?=template_header('Register')?>
        <div class="frm">
            <h1>Register</h1>
            <form action="registernew.php" method="post" name="f1" onsubmit="return validation()">
                <p style="display:flex;">
                    <label for="mail">E-Mail: </label>
                    <input type="text" name="mail" id="mail" style="flex-grow: 1;">
                </p>
                <p>
                    <label for="user">Username: </label>
                    <input type="text" name="user" id="user">
                </p>
                <p>
                    <label for="pass">Password: </label>
                    <input type="text" name="pass" id="pass">
                </p>
                <p>
                    <input class="btn" type="submit" value="Register">
                    <input class="btn" type="reset">
                </p>
            </form>
        </div>
        <script>
            function validation(){
                var id = document.f1.user.value;
                var ps = document.f1.pass.value;
                var em =document.f1.mail.value;

                if(id.length == 0 || ps.length == 0|| em.length == 0){
                    alert("Veuillez remplir tous les champs");
                    return false;
                }
            }
        </script>
<?=template_footer()?>
