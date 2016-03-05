app.directive("dealViewHeader", function () {
    return {
        templateUrl: '/AngularViews/Admin/Common/Header.html',
        restrict: 'A',
        link: function (scope, element, attrs) {
            //console.log("inside link function");
        }
    };
});
app.directive("dealViewFooter", function () {
    return {
        restrict: 'A',
        templateUrl: '/AngularViews/Admin/Common/Footer.html'
    };
});

app.factory("globalFactory", function ($location) {
    
    var GlobalSettings= {};

    GlobalSettings.Url = {
            Details: '#',
            User: '/Admin/Management/UserView#/user/list',
            Product: '/Admin/Management/ProductView#/product/list'
        };


    return GlobalSettings;
});