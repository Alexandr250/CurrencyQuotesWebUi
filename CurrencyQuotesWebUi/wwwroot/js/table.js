$ (document).ready( function () {
    $("#selectable-table").selectable();

    function CurrenciesViewModel() {
        var self = this;

        self.filter = ko.observable();;
        self.currencies = ko.observableArray();

        self.getData = function () {
            var innerFilter = typeof self.filter() == "undefined" ? "" : self.filter();
            $.get('/api/currencies/' + innerFilter).done(function (json) {
                self.currencies.removeAll();
                for (var i = 0; i < json.length; i++)
                    self.currencies.push(json[i]);
            });
        }

        self.filter.subscribe(function (newValue) {
            self.getData();
        });

        self.getData();
    };

    ko.applyBindings(new CurrenciesViewModel());
});




