<?php
$stmt = $pdo->prepare('SELECT * FROM produits');
$stmt->execute();
$produits = $stmt->fetchAll(PDO::FETCH_ASSOC);
?>

<?=template_header('Accueil')?>
	<main>
		<div id="image-track" data-mouse-down-at="0" data-prev-percentage="0">
			<?php foreach ($produits as $p) : //remplissage du image-track ?>
				<div class="image-wrapper">
					<img class="image" src="<?php echo htmlspecialchars($p['image']); ?>" draggable="false" />
					<div class="hover-box">
						<h4><?php echo htmlspecialchars($p['titre']); ?></h4>
						<p><?php echo htmlspecialchars($p['description']); ?></p>
					</div>
				</div>
			<?php endforeach; ?>
		</div>
	</main>
<?=template_footer()?>