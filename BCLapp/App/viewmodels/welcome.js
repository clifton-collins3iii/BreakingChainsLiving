﻿define(function () {
    var ctor = function () {
        this.displayName = 'Breaking Chains Living';
        this.description = 'A web application to assist in the operations of the organication.';
        this.features = [
            'Building Management',
            '     --  Lease Management',
            '     --  Room Management',
            'Resident Management',
            '     --  Intake',
            '     --  Rent, Deposit, Fine and other charges',
            '     --  Issues history',
            '     --  Exit Interview',
            'General Ledger',
            '     --  Invoice',
            '     --  Payment',
            '     --  Accounts Receivable',
            '     --  Accounts Payable',
            'Community',
            '     --  Notices',
            '     --  News and Information',
            '     --  Complaints',
            'Maintenance',
            '     --  Building request',
            '     --  Repairs',
            '     --  Expenses',
            'Integrates with other systems',
            '...'
        ];

    };

    //Note: This module exports a function. That means that you, the developer, can create multiple instances.
    //This pattern is also recognized by Durandal so that it can create instances on demand.
    //If you wish to create a singleton, you should export an object instead of a function.
    //See the "flickr" module for an example of object export.

    return ctor;
});