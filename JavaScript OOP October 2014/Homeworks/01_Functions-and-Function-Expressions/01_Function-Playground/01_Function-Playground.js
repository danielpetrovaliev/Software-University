function myFunc() {
}

function Person(name) {
	this.name = name;
	this.getName = function() {
		return name;
	}
	return this;
}

myFunc("daa", 2, 3, 1);
var dani = new Person("Daniel");
console.log(dani);
myFunc("ko staaaa wee chuekk", new Person("Stamena"));
myFunc.call({
	name: "what ??"
});
myFunc.call(null, 'Shit', 22, function() {
	return 'lalala';
});