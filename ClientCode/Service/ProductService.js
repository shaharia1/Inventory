'use strict';
myapp.service('productService', ['$http', function ($http) {
    var productService = {};


    productService.GetProduct = function () {
        /*return $http.get('/Product/GetProduct?patientId=' + patientId + "&admissionId=" + admissionId);*/
        return $http.get('/Product/GetProduct');
    }


    productService.SaveProduct = function (product) {

        return $http.post('/Product/SaveProduct', product);
    };


    return productService;
}]);