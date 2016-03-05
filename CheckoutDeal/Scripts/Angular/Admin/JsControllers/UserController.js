app.controller("UserController", function ($scope, $route, $routeParams, $location, $http, globalFactory) {
    $scope.CheckoutDeal = {};
    $scope.CheckoutDeal.Title = "Add User";
    $scope.CheckoutDeal.User = {};
    $scope.CheckoutDeal.GlobalSettings = globalFactory;
    $scope.Add = function (User) {
        User.UserName = User.Email;
        User.CreatedOn = new Date(new Date().getUTCFullYear(), new Date().getUTCMonth(), new Date().getUTCDate());

        $http({
            url: '/api/Admin/User/Post',
            method: 'POST',
            data: JSON.stringify(User)
        }).success(function (data, status, headers, config) {
            $scope.color = data;
        });
    };
    
    $scope.GetAll = function () {
        $http({
            url: '/api/Admin/User/Get',
            method: 'GET'
        }).success(function (data, status, headers, config) {
            $scope.CheckoutDeal.Users = data;
        });
    };
});