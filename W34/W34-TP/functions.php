<?php
if (!isset($_SESSION))
    session_start();

//connexion à la bd
function pdo_connect_mysql()
{
    $db_host = 'localhost';
    $db_user = 'root';
    $db_pass = '';
    $db_name = 'w34tp1';

    try {
        return new PDO('mysql:host=' . $db_host . ';dbname=' . $db_name . ';charset=utf8', $db_user, $db_pass);
    } catch (PDOException $exception) {
        exit('Échec de connexion à la base de données!');
    }
}

//partie du template entete (header)
function template_header($titre)
{
    echo "<!DOCTYPE html>
        <html lang='en'>
        
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <title>$titre</title>
            <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.1/css/all.css'>
            <link rel='stylesheet' href='bootstrap.min.css' type='text/css'>
            <link rel='stylesheet' href='style.css' type='text/css'>
            <link rel='stylesheet' href='image-track.css' type='text/css'>
        </head>
        
        <body>
        
            <header>
                <div class='content-wrapper'>
                    <nav class='navbar navbar-expand-lg bg-dark' data-bs-theme='dark'>
                        <div class='container-fluid'>
                            <a class='navbar-brand' href='index.php'>Boutique</a>
                            <button class='navbar-toggler' type='button' data-bs-toggle='collapse' data-bs-target='#navbarColor02' aria-controls='navbarColor02' aria-expanded='false' aria-label='Toggle navigation'>
                                <span class='navbar-toggler-icon'></span>
                            </button>
                            <div class='collapse navbar-collapse' id='navbarColor02'>
                                <ul class='navbar-nav me-auto'>
                                    <li class='nav-item'>
                                        <a class='nav-link active' href='index.php'>Accueil</a>
                                    </li>
                                    <li class='nav-item'>";
                                    if (isset($_SESSION["membreUsername"])) echo "<a class='nav-link active' href='members.php'>Member</a>";                                                              
    echo                           "</li>
                                </ul>
                            </div>
                        </div>
                        <div>
                            <ul class='navbar-nav me-auto'>
                                <li class='nav-item'>
                                    <a class='nav-link active' href='register.php'>Register</a>
                                </li>
                                <li class='nav-item'>";
                                echo isset($_SESSION["membreUsername"]) ?"<a class='nav-link active' href='logout.php'>Logout</a>":"<a class='nav-link active' href='login.php'>Login</a>";                                                              
    echo                       "</li>                                   
                            </ul>
                        </div>
                    </nav>
                </div>
            </header>";
}

//partie du template pied de page (footer)
function template_footer()
{
    $annee = date('Y');
    echo "
        <footer>
		<div class='content-wrapper'>
			<p>Boutique en ligne &copy; $annee</p>
		</div>
		<script src='image-track.js'></script>
	</footer>

</body>

</html>";
}
