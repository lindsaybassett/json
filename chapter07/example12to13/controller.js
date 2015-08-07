angular.module('myApp', []).controller('myAppController', function($scope, $http) {
    $http.get('http://api.openweathermap.org/data/2.5/weather?lat=35&lon=139').success(function(data, status, headers, config) {
        $scope.weatherData = data;
    });
});