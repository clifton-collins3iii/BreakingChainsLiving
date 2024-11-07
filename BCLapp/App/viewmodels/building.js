define(['plugins/http', 'durandal/app', 'jquery', 'knockout', 'jtable'],
    function (http, app, $, ko, jtable) {
    //Note: This module exports an object.
    //That means that every module that "requires" it will get the same object instance.
    //If you wish to be able to create multiple instances, instead export a function.
        //See the "welcome" module for an example of function export.
        var isLoading = ko.observable(false);

        var activate = function () {
            //the router's activator calls this function and waits for it to complete before proceding
        }

        var compositionComplete = function () {
            $('#BuildingTableContainer').jtable({
                title: 'Building Edit',
                actions: {
                    listAction: buildingselect,     // this calls the javascript function buildingselect() below
                    //listAction: function (postData, jtParams) {
                    //    return $.Deferred(function ($dfd) {
                    //        $.ajax({
                    //            url: 'https://localhost:5043/jTable/BuildingSelect?format=json',
                    //            type: 'POST',
                    //            dataType: 'json',
                    //            data: postData,
                    //            success: function (data) {
                    //                $dfd.resolve(data);
                    //            },
                    //            error: function () {
                    //                $dfd.reject();
                    //            }
                    //        });
                    //    });
                        //return {
                        //    "Result": "OK",
                        //    "Records": [
                        //        { "PK_Building_ID": 1, "Name_Short": "T-Buildins", "Name_Long": "The temp building" },

                        //    ],
                        //    "TotalRecordCount": 1
                        //};
                    //},
                    createAction: '/BuildingInsert',
                    updateAction: '/BuildingUpdate',
                    deleteAction: '/BuildingDelete',
                },
                fields: {
                    PK_Building_Id: {
                        key: true,
                        list: false
                    },
                    Name_Short: {
                        title: 'Building Short Name',
                        width: '20%'
                    },
                    Name_Long: {
                        title: 'Building Long Name',
                        width: '30%'
                    }
                }
            });
            $('#BuildingTableContainer').jtable('load');
            return true;
        };

        //  Used by jTable listAction method
        var buildingselect = function (postData, jtParams) {
            return $.Deferred(function ($dfd) {
                $.ajax({
                    url: 'https://localhost:5043/jTable/BuildingSelect',
                    type: 'POST',
                    dataType: 'json',
                    data: postData,
                    success: function (data) {
                        $dfd.resolve(data);
                    },
                    error: function () {
                        $dfd.reject();
                    }
                });
            });
            //return {
            //    "Result": "OK",
            //    "Records": [
            //        { "PK_Building_ID": 1, "Name_Short": "T-Buildins", "Name_Long": "The temp building" },

            //    ],
            //    "TotalRecordCount": 1
            //};
        }

        var jtableCallback = function (evt) {
            isLoading(true);
        }
        var select = function (item) {
            //the app model allows easy display of modal dialogs by passing a view model
            //views are usually located by convention, but you an specify it as well with viewUrl
            item.viewUrl = 'views/detail';
            app.showDialog(item);
        };

        var canDeactivate = function () {
            //the router's activator calls this function to see if it can leave the screen
            return app.showMessage('Are you sure you want to leave this page?', 'Navigate', ['Yes', 'No']);
        };


    return {
        displayName: 'Building',
        images: ko.observableArray([]),
        isLoading: isLoading,
        activate: activate,
        compositionComplete: compositionComplete,
    };
});