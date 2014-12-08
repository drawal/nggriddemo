var app = angular.module('myApp', ['ngGrid']);
//app.controller('regularGridController', function ($scope, $http) {
//    $scope.gridOptions = {
//        data: 'serverData',
//        showGroupPanel: true
//    };
//    $scope.serverData = [];

//    function fetchData() {
//        $http({
//            url: 'http://localhost/JsonWithWebApi/api/displayitems', type: 'Get'
//        })
//        .success(function (data) { $scope.serverData = data; });
//    } fetchData();

//    $scope.loadData = function () {
//        $http({
//            url: 'http://localhost/JsonWithWebApi/api/displayitems', type: 'Get'
//        })
//       .success(function (data) { $scope.serverData = data; });
//    };

//});


//app.controller('editableGridController', function ($scope, $http) {
//    $scope.gridOptions = {
//        data: 'serverData',
//        showGroupPanel: true,
//        enableCellSelection: true,
//        enableRowSelection: true,
//        enableCellEditOnFocus: true,
//        columnDefs: [
//            { field: 'Name', displayName: 'Name', enableCellEdit: true }
//        ]
//    };
//    $scope.serverData = [];

//    //function fetchData() {
//    //    $http({
//    //        url: 'http://localhost:27834/api/applications', type: 'Get'
//    //    })
//    //    .success(function (data) { $scope.serverData = data; });
//    //} fetchData();

//    $scope.loadData = function () {
//        $http({
//            url: 'http://localhost/JsonWithWebApi/api/applications', type: 'Get'
//        })
//       .success(function (data) { $scope.serverData = data; });
//    };

//});
