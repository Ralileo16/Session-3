<?php
    session_start();    //démarre la session
    session_unset();    //effacer le contenu de la session
    session_destroy();  //détruire la session et son contenu
    header("Location: index.php");
?>