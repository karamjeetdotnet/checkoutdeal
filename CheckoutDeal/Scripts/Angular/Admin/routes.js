app.config(function ($routeProvider) {
    $routeProvider.when('/user/list', {
        templateUrl: '/AngularViews/Admin/User/list.html',
        controller: 'UserController'
    }).when('/user/add', {
        templateUrl: '/AngularViews/Admin/User/add.html',
        controller: 'UserController'
    }).when('/product/list', {
        templateUrl: '/AngularViews/Admin/Product/list.html',
        controller: 'ProductController'
    }).otherwise({ redirectTo: '/user/list' });
});