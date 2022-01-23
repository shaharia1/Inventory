
'use strict';
myapp.controller('product', function ($scope, productService) {

    $scope.IsVisible = false;

    $scope.ShowHide = function () {
        $scope.IsVisible = true;
    }
    $scope.Back = function () {
        $scope.IsVisible = false;
        loadProducts();
    }



    $scope.clear = function () {
        $scope.name = "";
        $scope.code = "";
        $scope.description = "";
        $scope.price = "";
        $scope.type = "";
        $scope.date = "";
    }


    $scope.save = function () {

        var product = {
            Id: 0,
            ProductName: $scope.name,
            ProductCode: $scope.code,
            Description: $scope.description,
            Price: $scope.price,
            TypeId: $scope.type,
            ExpiryDate: $scope.expiryDate.toDateString(),
        }

        console.log(product);

        var save = productService.SaveProduct(product);

        save.then(function (data) {
            //success
            alert("Save success")
            console.log(data);
        },
            function (error) {
                console.log(error);
                alert("Error occured");
            });
    }

    loadProducts();

    function loadProducts() {
        var records = productService.GetProduct();

        records.then(function (data) {
            //success

            $scope.products = data.data;
            console.log(data);
        },
            function (error) {
                console.log(error);
                alert("Error occured while fetching product list...");
            });


    }

    //function saveProduct() {


    //}

    //$scope.loadBranches = function () {
    //    productService.GetProduct()
    //        .success(function (response) {
    //            console.log(response);
    //        })
    //        .error(function (error) {
    //            $scope.status = 'Unable to load labtest category for lab test only data: ' + error.message;
    //            console.log($scope.status);
    //        });
    //};



    $scope.TypeString = function (value) {
        if (value == 1) {
            return "Local";
        } else {
            return "Imported";
        }
    }

    $scope.ToJavaScriptDate = function (value) {
        var pattern = /Date\(([^)]+)\)/;
        var results = pattern.exec(value);
        if (results != null) {
            var dt = new Date(parseFloat(results[1]));

            return dt.getFullYear() + "-" + (dt.getMonth() + 1) + "-" + dt.getDate();

        } else {
            return value;
        }
    }
});