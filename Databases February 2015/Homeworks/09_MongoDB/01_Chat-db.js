use ChatDB;
db.createCollection("messages");
db.messages.save(
	'text': "Hi, how are you?",
	'date': Date(),
	'user': {
		'username': "Pesho123",
		'fullName': "Petar Minkov",
		'website': "www.pesho.bg"
	});