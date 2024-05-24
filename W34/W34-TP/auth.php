<?php
    require('functions.php');

    extract($_POST);

    $pdo = pdo_connect_mysql();

    $user = stripslashes($user);
    $pass = stripslashes($pass);

    $user = htmlentities($user);
    $pass = htmlentities($pass);

    $stmt = $pdo->prepare("SELECT * FROM utilisateurs WHERE unom = :user AND umdp = :pass");
    $stmt->bindParam(':user', $user);
    $stmt->bindParam(':pass', $pass);
    $stmt->execute();
    $rowCount = $stmt->rowCount();
    $results = $stmt->fetchAll(PDO::FETCH_ASSOC);

    if($rowCount > 0){
        $_SESSION["membreUsername"] = $user;
        echo "<br><br><h1 style='color:green;'>Login Réussi!</h1>";
        echo "<a href='members.php'>Page du membre</a>";
    } else {
        echo "<br><br><h1 style='color:red;'>Login Échoué!</h1>";
        echo "<a href='index.php'>Retournez à l'accueil</a>";
    }
