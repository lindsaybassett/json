SELECT Account.firstName, Account.lastName, Address.street, Address.zip  
FROM Account 
JOIN Address ON Account.accountId = Address.accountId