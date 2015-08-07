// this is the controller
angular.module('myApp', []).controller('myAppController', function($scope) {
    // added variable "signedIn" to the example.  You can change this to false to see the example change.
	var signedIn = true;
	
    // scope.userData is the data model
	$scope.userData = {
        userName: "Stranger"
    };
    if (signedIn) {
        $scope.userData = {
            userName: "Bob"
        };
    }
});