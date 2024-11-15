﻿requirejs.config({
    paths: {
        'text': '../Scripts/text',
        'durandal': '../Scripts/durandal',
        'plugins': '../Scripts/durandal/plugins',
        'transitions': '../Scripts/durandal/transitions',
        'jquery': '../Scripts/jquery-3.7.1',
        'knockout': '../Scripts/knockout-3.5.1',
        '@servicestack/client': '../ServiceStack/servicestack-client.mjs'
    }
});

//define('jquery', function() { return jQuery; });
//define('knockout', ko);

define(['durandal/system', 'durandal/app', 'durandal/viewLocator', 'jquery', 'knockout'],
    function (system, app, viewLocator, $, ko) {
    //>>excludeStart("build", true);
    system.debug(true);
    //>>excludeEnd("build");

    app.title = 'Breaking Chains Living';

    app.configurePlugins({
        router: true,
        dialog: true,
        widget: true
    });

    app.start().then(function() {
        //Replace 'viewmodels' in the moduleId with 'views' to locate the view.
        //Look for partial views in a 'views' folder in the root.
        viewLocator.useConvention();
         
        //Show the app by setting the root view model for our application with a transition.
        app.setRoot('viewmodels/shell', 'entrance');
    });
});