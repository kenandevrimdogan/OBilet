
$(document).ready(() => {
    // Elements
    const $buttonToday = $("#buttonToday");
    const $buttonTomorrow = $("#buttonTomorrow");

    const $inputDepartureDate = $("#DepartureDate");

    function getBusLocations(inputName) {
        $(inputName).select2({
            ajax: {
                type: "GET",
                url: '/home/getBusLocations',
                dataType: 'json',
                delay: 250,
                minimumInputLength: 3,
                minimumResultsForSearch: 10,
                data: function (params) {
                    var query = {
                        search: params.term
                    }

                    return query;
                },
                processResults: function (data) {
                    return {
                        results: $.map(data, function (item) {
                            return {
                                text: item.text,
                                id: item.value
                            }
                        })
                    };
                }
            }
        })
    }

    getBusLocations("#OriginId");
    getBusLocations("#DestinationId");



    function getDateFormat(date) {
        var day = ("0" + date.getDate()).slice(-2);
        var month = ("0" + (date.getMonth() + 1)).slice(-2);

        var dateFormat = date.getFullYear() + "-" + (month) + "-" + (day);

        return dateFormat;
    }

    function getCurrentDate() {
        var now = new Date();
        return getDateFormat(now);
    }


    function getTomorrowDate() {
        var date = new Date();
        date.setDate(date.getDate() + 1)

        return getDateFormat(date);;
    }


    $buttonToday.click(function () {
        $inputDepartureDate.val(getCurrentDate())
    })

    $buttonTomorrow.click(function () {
        $inputDepartureDate.val(getTomorrowDate())
    })

})