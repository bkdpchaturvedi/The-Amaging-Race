var ConfirmDelete = function (eventId) {
    $("#hiddenEventId").val(eventId);
    $("#myModal").modal('show');

};

var DeleteEvent = function () {
   
    var eventId = $("#hiddenEventId").val();
    $.ajax({
        type: "POST",
        url: '/Event/DeleteEvent',
        data: { EventId: eventId },
        success: function (result) {
         
            $("#myModal").modal('hide');
            $("#LoadEvent").html(result); 
            $("#refresh").empty();
            $("#refresh").html("<div class='NorecordFound'><br /> <p> Select an event to view Pit stops</p> </div>");
            
        }

    });
};
var EditEvent = function (eventId) {
    var url = "/Event/EditEvent?EventID=" + eventId;

    $("#ModalBodyEdit").load(url, function () {
        $("#ModalEdit").modal("show");
    });
};

var AddEvent = function () {
    var url = "/Event/CreateEvent";

    $("#ModalBodyAdd").load(url, function () {
        $("#ModalAdd").modal("show");
    });
};

var ShowEvent = function (eventId) {
    var url = "/Event/EventDetails?EventID=" + eventId;

    $("#ModalBodyShow").load(url, function () {
        $("#ModalShow").modal("show");
    });
};

var OnSuccess =  function (data) {
    $("#LoadEvent").html(data); 
}  

var ShowPitstop = function (eventId) {
    $("#loaderDiv").show();
    

    var url = "/PitStop/Index";
    $("#hiddenEventId").val(eventId);
    $.ajax({
        type: "GET",
        url: url,
        data: { EventId: eventId },
        success: function (data) {
            $("#1b").html(data);
            document.getElementById("eventId").value = eventId;
            
        }

    });
};

var AddPitStop = function () {
    var url = "/PitStop/CreatePitStop";
    $("#ModalBodyAddPit").load(url, function () {
        $("#ModalAddPit").modal("show");
    });
};

var allPitStops = function () {
    var url = "/PitStop/GetPitStopData";
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            setPitStopInMap(data);
        }

    });
    function setPitStopInMap(data) {
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

        var map = new google.maps.Map(document.getElementById("mainMap"), mapOptions);
        map.panTo(new google.maps.LatLng(data[0].Latitude, data[0].Longitude));
        var marker;
        var address;
        var name;
        for (i = 0; i < data.length; i++) {
            latlngPit = new google.maps.LatLng(data[i].Latitude, data[i].Longitude);
            if (data[i + 1]) {
                latlngNext = new google.maps.LatLng(data[i+1].Latitude, data[i+1].Longitude);
            }
            address = data[i].Address;
            name =i +1 + ". " + data[i].PitStopName;
             marker = new google.maps.Marker({
                 position: latlngPit,
                 title: address,
                 label: { text: name, color: "green" },
                map: map
            });
            calcRoute(latlngPit, latlngNext, map);
            //marker.setMap(latlngPit);
        }
        //var map = new google.maps.Map(document.getElementById("mainMap"), mapOptions);
        
        //var inputBox = new google.maps.places.SearchBox(document.getElementById('mapSearch'));
        //inputBox.bindTo('bounds', map);
        ////map.controls[google.maps.ControlPosition.TOP_CENTER].push(document.getElementById('mapSearch'));
        
    }

    function getAddress(location) {
        var geocoder = new google.maps.Geocoder();
        geocoder.geocode({ "latLng": location }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                $('#mapSearch').val(results[0].formatted_address);
                $('#Address').val(results[0].formatted_address);
                $('#Latitude').val(results[0].geometry.location.lat);
                $('#Longitude').val(results[0].geometry.location.lng);
            }
        });
    }

    function calcRoute(latlngPit, latlngNext, map) {

        var directionsService = new google.maps.DirectionsService();
        var directionsDisplay = new google.maps.DirectionsRenderer({ map: map, suppressMarkers: true });
        
        var start = latlngPit;
        var end = latlngNext;
        var request = {
            origin: start,
            destination: end,
            
            travelMode: 'WALKING'
        };
        directionsService.route(request, function (result, status) {
            if (status == 'OK') {
                directionsDisplay.setDirections(result);
                var marker = new google.maps.Marker({
                    position: result.position,
                    label: "ABC",
                    map: map                });
            }
            directionsDisplay.setMap(map);
           
        });
    }

    function placeMarker(location, map) {
        var marker;
        if (marker != null) {
            marker.setMap(null);
        }
        marker = new google.maps.Marker({
            position: location,
            title: 'PitStop',
            map: map
        });
        map.panTo(location);
        marker.setMap(location);
    }
}