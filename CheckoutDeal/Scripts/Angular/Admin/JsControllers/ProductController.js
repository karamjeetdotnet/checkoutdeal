app.controller("ProductController", function ($scope, $route, $routeParams, $location, $http, globalFactory) {
    $scope.CheckoutDeal = {};
    $scope.CheckoutDeal.Title = "Add Product";
    $scope.CheckoutDeal.GlobalSettings = globalFactory;


});