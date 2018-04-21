var ConfirmDelete = function (eventId) {
    $("#hiddenEventId").val(eventId);
    $("#myModal").modal('show');

};

var DeleteEvent = function () {
    $("#loaderDiv").show();
    var eventId = $("#hiddenEventId").val();
    $.ajax({
        type: "POST",
        url: '/Event/DeleteEvent',
        data: { EventId: eventId },
        success: function (result) {
            $("#loaderDiv").hide();
            $("#myModal").modal('hide');
            $("#EventCard_" + eventId).remove();
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
            zoom: 13,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };

        var map = new google.maps.Map(document.getElementById("mainMap"), mapOptions);
        map.panTo(new google.maps.LatLng(data[0].Latitude, data[0].Longitude));
        var marker;
        for (i = 0; i < data.length; i++) {
            latlngPit = new google.maps.LatLng(data[i].Latitude, data[i].Longitude)
            
             marker = new google.maps.Marker({
                position: latlngPit,
                title: 'PitStop',
                map: map
            });
            
            marker.setMap(latlngPit);
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