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
				}
				class Address {
					public $street;
					public $city;
					public $state;
					public $zip;
				}
				
				$address1 = new Address();
				$address1->street = "123 fakey st";
				$address1->city = "Somewhere";
				$address1->state = "CA";
				$address1->zip = 96027;
				
				$address2 = new Address();
				$address2->street = "456 fake dr";
				$address2->city = "Some Place";
				$address2->state = "CA";
				$address2->zip = 96345;
				
				$account = new Account();
				$account->firstName = "Bob";
				$account->lastName = "Barker";
				$account->gender = "male";
				$account->phone = "555-555-5555";
				$account->famous = true;
				$account->addresses = array($address1, $address2);
				$json = json_encode($account);
				
				echo $json;
			?>
		</h1>
	</body>
</html>