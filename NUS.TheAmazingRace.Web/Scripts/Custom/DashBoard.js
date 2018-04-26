function showDashBoardMap() {
    var latlngCenter;
    var mapOptions;
    
    latlngCenter = new google.maps.LatLng(1.281766, 103.818346);
    mapOptions = {
        center: latlngCenter,
        zoom: 12,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    var map = new google.maps.Map(document.getElementById("dashboardMap"), mapOptions);
    var url = "/DashBoard/GetPitStopData";
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            setDashBoardMap(data, map);
            startSimulation();
        }

    });

    function startSimulation() {
        setupSignalR();
        var apiJsonData;
        var number = 1;
        var refreshIntervalId = setInterval(function () {
            var url = "/DashBoard/GetLocations";
            $.ajax({
                type: "GET",
                url: url,
                data: { number: number },
                success: function (apiData) {
                    apiStaffData = JSON.parse(apiData);
                    locateStaff(apiStaffData);
                }

            });
            if (number >30) {
                clearInterval(refreshIntervalId);
            }
            //num++;
            number++;
        }, 3000);


    }

    function locateStaff(apiStaffData) {
        for (i = 0; i < apiStaffData.length; i++) {
            var latitude = apiStaffData[i].location[0].lat;
            var longitude = apiStaffData[i].location[0].lng;
            var staffId = apiStaffData[i].staffID;

            if (window["staffCount" + staffId] != null) {
                window["staffCount" + staffId].setMap(null);
            }

            var latlngLocations = new google.maps.LatLng(latitude, longitude);
            window["staffCount" + staffId] = new google.maps.Marker({
                position: latlngLocations,
                title: "Staff :" + staffId,
                icon: 'http://maps.google.com/mapfiles/ms/icons/green-dot.png',
                visible: true,
                map: map
            });
            
        }
    }

    function setupSignalR() {
        connection = $.hubConnection();
        var hub = connection.createHubProxy('mappingHub');
        hub.on('locationReceived', function (l) {
            
            $("#distance_" + l.TeamID).text(l.Distance);
            $("#time_" + l.TeamID).text(l.Time);
            $("#nextPit_" + l.TeamID).text(l.NextPitStop);

            locationTracker(l.Latitude, l.Longitude, l.TeamID);
        });
        connection.start(function () {
            alert('connection started');

        });


    }

    function locationTracker(latitude, longitude, teamId) {
        
        if (window["count" + teamId] != null) {
            window["count" + teamId].setMap(null);
        }
        
        var latlngLocations = new google.maps.LatLng(latitude, longitude);
        window["count" + teamId] = new google.maps.Marker({
            position: latlngLocations,
            title: "Team :" + teamId,
            icon: 'http://maps.google.com/mapfiles/ms/icons/blue-dot.png',
            visible: true,
            map: map
        });
    }
}





function setDashBoardMap(data, map) {


    var i;
    var latlngCenter;
    var mapOptions;
    var latlngPit;

   // var map = new google.maps.Map(document.getElementById("dashboardMap"), mapOptions);
    map.panTo(new google.maps.LatLng(data[0].Latitude, data[0].Longitude));
    var marker;
    var name;
    
    
    var num = 0;
    var number = 1;
    var latlngLocations;
    var locationMarker;
    var i;
    var dataLength = 1;
    
    
    

    for (i = 0; i < data.length; i++) {
        latlngPit = new google.maps.LatLng(data[i].Latitude, data[i].Longitude);
        if (data[i + 1]) {
            latlngNext = new google.maps.LatLng(data[i + 1].Latitude, data[i + 1].Longitude);
            calcRoute(latlngPit, latlngNext, map);
        }

        name = i + 1 + ". " + data[i].PitStopName;
        marker = new google.maps.Marker({
            position: latlngPit,
            title: addressOne,
            animation: google.maps.Animation.DROP,
            label: { text: name, color: "green" },
            map: map
        });
    
    }
    //var map = new google.maps.Map(document.getElementById("mainMap"), mapOptions);

    //var inputBox = new google.maps.places.SearchBox(document.getElementById('mapSearch'));
    //inputBox.bindTo('bounds', map);
    ////map.controls[google.maps.ControlPosition.TOP_CENTER].push(document.getElementById('mapSearch'));

}


function saveLocation(apiJsonData) {
    var url = "/Team/saveLocation";
    $.ajax({
        type: "POST",
        url: url,
        data: { apiJsonData: JSON.stringify(apiJsonData) },
        success: function (apiData) {
            alert("success");
        }
    });
}




function getLocationDistance(apiJsonData) {
    for (i = 0; i < apiJsonData.length; i++) {
        var teamId = apiJsonData[i].teamID;
        $("#distance_" + teamId).text(teamId);
        $("#time_" + teamId).text(teamId);
        
        
    }
}

function getDistance(latlngPit, latlngNext, latlngPitAddress, latlngNextAddress, teamId) {
    var service = new google.maps.DistanceMatrixService();
    //alert(latlngPit + " " + latlngNext + "  " + latlngPitAddress + " " + latlngNextAddress);
    service.getDistanceMatrix(
        {
            origins: [latlngPit, latlngPitAddress],
            destinations: [latlngNext, latlngNextAddress],
            travelMode: 'WALKING'
        }, callback(teamId));
    function callback(teamId) {
        return function callback(response, status) {
            
                
        }
    }
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
    $("#homeEventId").val(eventId);
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