var http = require('http');
http.get({
	host: 'api.openweathermap.org',
	path: '/data/2.5/weather?q=London,uk'
}, function(response) {
	var body = '';
	response.on('data', function(data) {
		body += data;
	});
	response.on('end', function() {
		var weatherData = JSON.parse(body);
		console.log(weatherData.coord.lon);
	});
});