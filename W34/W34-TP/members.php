<?php
include 'functions.php';
if (!isset($_SESSION['membreUsername']))
{
    header('Location: ' . 'index.php');
}
$pdo = pdo_connect_mysql();
$stmt = $pdo->prepare('SELECT * FROM utilisateurs WHERE unom=:nom');
$stmt->bindParam(':nom', $_SESSION['membreUsername']);
$stmt->execute();
$membre = $stmt->fetchAll(PDO::FETCH_ASSOC);
?>

<?= template_header('Member') ?>

<div class="frm">
    <h1>Membre</h1>
    <form>
        <p style="display:flex;">
            <label for="user">Username: </label>
            <input type="text" value="<?php echo $membre[0]["unom"]; ?>" readonly style="flex-grow: 1;">
        </p>
        <p style="display:flex;">
            <label for="user">E-mail: </label>
            <input type="text" value="<?php echo $membre[0]["email"]; ?>" readonly style="flex-grow: 1;">
        </p>
        <p style="display:flex;">
            <label for="user">Level: </label>
            <input type="text" value="<?php echo $membre[0]["level"]; ?>" readonly style="flex-grow: 1;">
        </p>
    </form>
</div>

<?= template_footer() ?>