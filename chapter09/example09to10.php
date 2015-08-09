<!DOCTYPE html>
<html>
	<head>
		<title>Introduction to JavaScript Object Notation</title>
	</head>
	<body>
		<h1>
			<?php 
				class Cat {
					public $name;
					public $breed;
					public $age;
					public $declawed;
				}
				
				$cat = new Cat();
				$cat->name = "Fluffy Boo";
				$cat->breed = "Maine Coon";
				$cat->age = 2.5;
				$cat->declawed = false;
				
				echo $cat->name;
			?>
		</h1>
	</body>
</html>