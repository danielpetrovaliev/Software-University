(function() {
	'use strict';

	var students = [{
		"gender": "Male",
		"firstName": "Joe",
		"lastName": "Riley",
		"age": 22,
		"country": "Russia"
	}, {
		"gender": "Female",
		"firstName": "Lois",
		"lastName": "Morgan",
		"age": 41,
		"country": "Bulgaria"
	}, {
		"gender": "Male",
		"firstName": "Roy",
		"lastName": "Wood",
		"age": 33,
		"country": "Russia"
	}, {
		"gender": "Female",
		"firstName": "Diana",
		"lastName": "Freeman",
		"age": 40,
		"country": "Argentina"
	}, {
		"gender": "Female",
		"firstName": "Bonnie",
		"lastName": "Hunter",
		"age": 23,
		"country": "Bulgaria"
	}, {
		"gender": "Male",
		"firstName": "Joe",
		"lastName": "Young",
		"age": 16,
		"country": "Bulgaria"
	}, {
		"gender": "Female",
		"firstName": "Kathryn",
		"lastName": "Murray",
		"age": 22,
		"country": "Indonesia"
	}, {
		"gender": "Male",
		"firstName": "Dennis",
		"lastName": "Woods",
		"age": 37,
		"country": "Bulgaria"
	}, {
		"gender": "Male",
		"firstName": "Billy",
		"lastName": "Patterson",
		"age": 24,
		"country": "Bulgaria"
	}, {
		"gender": "Male",
		"firstName": "Willie",
		"lastName": "Gray",
		"age": 42,
		"country": "China"
	}, {
		"gender": "Male",
		"firstName": "Justin",
		"lastName": "Lawson",
		"age": 38,
		"country": "Bulgaria"
	}, {
		"gender": "Male",
		"firstName": "Ryan",
		"lastName": "Foster",
		"age": 24,
		"country": "Indonesia"
	}, {
		"gender": "Male",
		"firstName": "Eugene",
		"lastName": "Morris",
		"age": 37,
		"country": "Bulgaria"
	}, {
		"gender": "Male",
		"firstName": "Eugene",
		"lastName": "Rivera",
		"age": 45,
		"country": "Philippines"
	}, {
		"gender": "Female",
		"firstName": "Kathleen",
		"lastName": "Hunter",
		"age": 28,
		"country": "Bulgaria"
	}];

	var books = [{
		"book": "The Grapes of Wrath",
		"author": "John Steinbeck",
		"price": "34,24",
		"language": "French"
	}, {
		"book": "The Great Gatsby",
		"author": "F. Scott Fitzgerald",
		"price": "39,26",
		"language": "English"
	}, {
		"book": "Nineteen Eighty-Four",
		"author": "George Orwell",
		"price": "15,39",
		"language": "English"
	}, {
		"book": "Ulysses",
		"author": "James Joyce",
		"price": "23,26",
		"language": "German"
	}, {
		"book": "Lolita",
		"author": "Vladimir Nabokov",
		"price": "14,19",
		"language": "German"
	}, {
		"book": "Catch-22",
		"author": "Joseph Heller",
		"price": "47,89",
		"language": "German"
	}, {
		"book": "The Catcher in the Rye",
		"author": "J. D. Salinger",
		"price": "25,16",
		"language": "English"
	}, {
		"book": "Beloved",
		"author": "Toni Morrison",
		"price": "48,61",
		"language": "French"
	}, {
		"book": "Of Mice and Men",
		"author": "John Steinbeck",
		"price": "29,81",
		"language": "Bulgarian"
	}, {
		"book": "Animal Farm",
		"author": "George Orwell",
		"price": "38,42",
		"language": "English"
	}, {
		"book": "Finnegans Wake",
		"author": "James Joyce",
		"price": "29,59",
		"language": "English"
	}, {
		"book": "The Grapes of Wrath",
		"author": "John Steinbeck",
		"price": "42,94",
		"language": "English"
	}];

	/* =============================
	Problem 1. Students Collection
	================================*/

	var studentsBetween18And24 = _.filter(students, function(student) {
		return (student.age >= 18 && student.age <= 24)
	});
	console.log('Students between 18 and 24:');
	console.log(JSON.stringify(studentsBetween18And24));

	var fNameSmalelstLName = _.filter(students, function(student) {
		return (student.firstName.localeCompare(student.lastName));
	});
	console.log('');
	console.log('Students whose first name is alphabetically before their last name');
	console.log(JSON.stringify(fNameSmalelstLName));

	var studentsFNames = _(students).chain()
		.where({
			country: 'Bulgaria'
		})
		.map(function(student) {
			return student.firstName;
		})
		.value();

	console.log('');
	console.log('First name of students from bulgaria');
	console.log(JSON.stringify(studentsFNames));

	var lastFiveStudents = _.last(students, 5);
	console.log('');
	console.log('Last 5 Students');
	console.log(JSON.stringify(lastFiveStudents));

	var firstThree = _(students).chain()
		.filter(function(student) {
			return student.country !== 'Bulgaria' && student.gender === 'Male';
		})
		.first(3)
		.value();

	console.log('');
	console.log('First three students who are not from Bulgaria and are male.');
	console.log(JSON.stringify(firstThree));


	/* =============================
	Problem 2. Book Store
	================================*/

	var booksGroupedByLanguage = _(books).chain()
		.sortBy(function(book){
			return book.author + ' ' + book.price;
		})
		.groupBy(function(book) {
		  return book.language;
		})
		.value();

	console.log('');
	console.log('Books by language and sort them by author (if two books have the same author, sort by price.');
	console.log(JSON.stringify(booksGroupedByLanguage));

	 // ---------- •	Get the average book price for each author ----------
    var averageBookPrices = {};

    _.each(books, function (book) {
        var price = parseFloat(book.price.replace(',', '.'));
        var author = book.author;
        if (!averageBookPrices[author]) {
            averageBookPrices[author] = {
                'booksLength': 0,
                'totalPrice': 0
            };
        }

        averageBookPrices[book.author]['booksLength'] += 1;
        averageBookPrices[book.author]['totalPrice'] += price;
    });

    console.log('---------- The average book price for each author ----------');
    for (var author in averageBookPrices) {
        var averageBookPrice = averageBookPrices[author]['totalPrice'] / averageBookPrices[author]['booksLength'];
        console.log(author + ', Average book price: ' + averageBookPrice.toFixed(2));
    }

    // ----------  •	Get all books in English or German, with price below 30.00, and group them by author ----------
    var cheapEnglishAndGermanBooks = _.chain(books)
        .filter(function (book) {
            return (book.language === 'English' || book.language === 'German') && parseFloat(book.price) < 30;
        })
        .groupBy('author')
        .value();

    console.log('---------- All books in English or German, with price below 30.00, and group them by author ----------');
    console.log(cheapEnglishAndGermanBooks);

}());