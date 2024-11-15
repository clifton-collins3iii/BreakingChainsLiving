﻿define(['plugins/router', 'durandal/app'], function (router, app) {
    return {
        router: router,
        search: function () {
            //It's really easy to show a message box.
            //You can add custom options too. Also, it returns a promise for the user's response.
            app.showMessage('Search not yet implemented...');
        },
        activate: function () {
            router.map([
                { route: '', title: 'Welcome', moduleId: 'viewmodels/welcome', nav: true },
                { route: 'building', title: 'Building Edit', moduleId: 'viewmodels/building', nav: true },
                { route: 'room', title: 'Room Edit', moduleId: 'viewmodels/room', nav: true },
                { route: 'resident', title: 'Resident Edit', moduleId: 'viewmodels/resident', nav: true }
            ]).buildNavigationModel();

            return router.activate();
        }
    };
});