//var app = angular.module("app", ["ngRoute"]);
//app.config(function ($routeProvider) {
//    $routeProvider
//        .when("/add", {
//            templateUrl: '/ClientCode/Template/ProductAdd.html'
//        });
        
//});

var myapp;
(function () {

    myapp = angular.module('app', ['angularUtils.directives.dirPagination']);
})();