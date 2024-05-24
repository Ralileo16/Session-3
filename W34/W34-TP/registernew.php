<?php
    require('functions.php');

    extract($_POST);

    $pdo = pdo_connect_mysql();

    $user = stripslashes($user);
    $pass = stripslashes($pass);
    $mail = stripslashes($mail);

    $user = htmlentities($user);
    $pass = htmlentities($pass);
    $mail = htmlentities($mail);

    $stmt = $pdo->prepare("INSERT INTO `utilisateurs`(`unom`, `umdp`, `email`, `level`) VALUES (:user, :pass, :mail, 5)");
    $stmt->bindParam(':user', $user);
    $stmt->bindParam(':pass', $pass);
    $stmt->bindParam(':mail', $mail);
    $stmt->execute();
    $rowCount = $stmt->rowCount();

    if($rowCount > 0){
        echo "<br><br><h1 style='color:green;'>Register Réussi!</h1>";
        echo "<a href='login.php'>Se connecter maintenant</a>";
    } else {
        echo "<br><br><h1 style='color:red;'>Register Échoué!</h1>";
        echo "<a href='index.php'>Retournez à l'accueil</a>";
    }
