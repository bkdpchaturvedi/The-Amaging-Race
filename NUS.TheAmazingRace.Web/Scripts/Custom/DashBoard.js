function showDashBoardMap() {
    var url = "/DashBoard/GetPitStopData";
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            setDashBoardMap(data);
        }

    });
}
function setDashBoardMap(data) {
    var i;
    var latlngCenter;
    var mapOptions;
    var latlngPit;
    latlngCenter = new google.maps.LatLng(1.281766, 103.818346);
    mapOptions = {
        center: latlngCenter,
        zoom: 12,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    var map = new google.maps.Map(document.getElementById("dashboardMap"), mapOptions);
    map.panTo(new google.maps.LatLng(data[0].Latitude, data[0].Longitude));
    var marker;
    var addressOne;
    var addressTwo;
    var name;
    for (i = 0; i < data.length; i++) {
        latlngPit = new google.maps.LatLng(data[i].Latitude, data[i].Longitude);
        if (data[i + 1]) {
            latlngNext = new google.maps.LatLng(data[i + 1].Latitude, data[i + 1].Longitude);
            addressTwo = data[i + 1].Address;
        }
        addressOne = data[i].Address;
        
        name = i + 1 + ". " + data[i].PitStopName;
        marker = new google.maps.Marker({
            position: latlngPit,
            title: addressOne,
            animation: google.maps.Animation.DROP,
            label: { text: name, color: "green" },
            map: map
        });

        var service = new google.maps.DistanceMatrixService();
        service.getDistanceMatrix(
            {
                origins: [latlngPit, addressOne],
                destinations: [latlngNext, addressTwo],
                travelMode: 'DRIVING'
            }, callback);
        function callback(response, status) {
            if (status == 'OK') {
                
            }
        }
        calcRoute(latlngPit, latlngNext, map);
        //marker.setMap(latlngPit);
        
    }
    //var map = new google.maps.Map(document.getElementById("mainMap"), mapOptions);

    //var inputBox = new google.maps.places.SearchBox(document.getElementById('mapSearch'));
    //inputBox.bindTo('bounds', map);
    ////map.controls[google.maps.ControlPosition.TOP_CENTER].push(document.getElementById('mapSearch'));

}

function calcRoute(latlngPit, latlngNext, map) {

    var directionsService = new google.maps.DirectionsService();
    var directionsDisplay = new google.maps.DirectionsRenderer({ map: map, suppressMarkers: true, preserveViewport: true });

    var start = latlngPit;
    var end = latlngNext;

    

    var request = {
        origin: start,
        destination: end,

        travelMode: 'DRIVING'
    };
    directionsService.route(request, function (result, status) {
        if (status == 'OK') {
            directionsDisplay.setDirections(result);
            var marker = new google.maps.Marker({
                position: result.position,
                map: map
            });
        }
        directionsDisplay.setMap(map);
       
    });
}


function ShowDashBoardPitstop(eventId) {
    // $("#loaderDiv").show();
    var url = "/DashBoard/ShowEventData";
    $.ajax({
        type: "GET",
        url: url,
        data: { EventId: eventId },
        success: function (data) {
            $("#pitStopsTab").html(data);
        }

    });
}