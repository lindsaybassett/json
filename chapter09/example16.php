<!DOCTYPE html>
<html>
	<head>
		<title>Introduction to JavaScript Object Notation</title>
	</head>
	<body>
		<h1>
			<?php 
				class Account {
					public $firstName;
					public $lastName;
					public $phone;
					public $gender;
					public $addresses;
					public $famous;
					public
					function loadFromJSON($json) {
						$object = json_decode($json);
						foreach($object AS $name => $value) {
							$this->{$name} = $value;
						}
					}
				}
				class Address {
					public $street;
					public $city;
					public $state;
					public $zip;
				}
				
				$json = file_get_contents("example15.json");
				$deserializedAccount = new Account(); 
				$deserializedAccount->loadFromJSON($json);

				echo $deserializedAccount->firstName . " " . $deserializedAccount->lastName;
			?>
		</h1>
	</body>
</html>