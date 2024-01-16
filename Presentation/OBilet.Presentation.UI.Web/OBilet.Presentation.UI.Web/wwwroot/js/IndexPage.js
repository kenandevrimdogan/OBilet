
$(document).ready(() => {
    // Elements
    const $buttonToday = $("#buttonToday");
    const $buttonTomorrow = $("#buttonTomorrow");

    const $searchForm = $("#searchForm");
    const $inputOriginId = $("#OriginId");
    const $inputDestinationId = $("#DestinationId");
    const $inputDepartureDate = $("#DepartureDate");



    function getCurrentDate() {
        return new Date().toLocaleDateString();
    }


    function getTomorrowDate() {
        const tomorrow = new Date();
        tomorrow.setDate(tomorrow.getDate() + 1);
        return tomorrow.toLocaleDateString();
    }

    function performAjaxRequest(data) {
        $.ajax({
            type: 'POST',
            url: '/Journey/Index',
            data: JSON.stringify(data),
            contentType: 'application/json',
        })
            .fail((err) => {
                console.error(err);
            });
    }

    //$searchForm.submit(function (event) {
    //    event.preventDefault();

    //    const data = {
    //        OriginId: $inputOriginId.val(),
    //        DestinationId: $inputDestinationId.val(),
    //        DepartureDate: $inputDepartureDate.val()
    //    };

    //    performAjaxRequest(data);
    //});

    $buttonToday.click(function () {
        $inputDepartureDate.val(getCurrentDate())
    })

    $buttonTomorrow.click(function () {
        $inputDepartureDate.val(getTomorrowDate())
    })

})