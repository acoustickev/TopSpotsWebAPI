(function() {
    'use strict';

    angular
        .module('myApp')
        .controller('topSpotsCtrl', topSpotsCtrl);

    topSpotsCtrl.$inject = ['$http'];

    /* @ngInject */
    function topSpotsCtrl($http) {
        var vm = this;
        vm.title = 'topSpotsCtrl';


        activate();

        ////////////////

        function activate() {
            $http({
                method: "GET",
                url: "http://localhost:52458/api/topspots"
            }).then(function(response) {
                vm.topspots = response.data;
            });
        }
    }
})();
