
function CreatePitStop() {
    var url = "/PitStop/AddPitStop";

    $("#loaderDiv").show();
    var formData = $("#addPitStop").serialize();
    $.ajax({
        type: "POST",
        url: url,
        data: formData,
        success: function (data) {
            $("#loaderDiv").hide();
            $("#ModalAddPit").modal("hide");
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
            $("#1b").html(data);
        }
    });
}
function pitStopEdit() {

    var latlng = new google.maps.LatLng(1.281766, 103.818346);
    var mapOptions = {
        center: latlng,
        zoom: 13,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("mapEdit"), mapOptions);

    var currentLatitude = $('#Latitude').val();
    var currentLongitude = $('#Longitude').val();
    var marker;
    var url = "/PitStop/GetPitStop";
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            currentLatitude = data[0].Latitude;
            currentLongitude = data[0].Longitude;
            var currentLocation = new google.maps.LatLng(currentLatitude, currentLongitude);
            placeMarker(currentLocation);
            google.maps.event.addListener(map, "click", function (event) {
                placeMarker(event.latLng);
                getAddress(event.latLng);
            });
        }

    });

    //var inputBox = new google.maps.places.SearchBox(document.getElementById('mapSearch'));
    //inputBox.bindTo('bounds', map);
    //map.controls[google.maps.ControlPosition.TOP_CENTER].push(document.getElementById('mapSearch'));
    

    function getAddress(location) {
        var geocoder = new google.maps.Geocoder();
        geocoder.geocode({ "latLng": location }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                
                $('#Address').val(results[0].formatted_address);
                $('#Latitude').val(results[0].geometry.location.lat);
                $('#Longitude').val(results[0].geometry.location.lng);
            }
        });
    }

    function placeMarker(location) {
        
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

function pitStopLocate() {
    
        var latlng = new google.maps.LatLng(1.281766, 103.818346);
    var mapOptions = {
        center: latlng,
        zoom: 13,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("mapCreate"), mapOptions);
    
    var currentLatitude = $('#Latitude').val();
    var currentLongitude = $('#Longitude').val();
    var marker;
    var url = "/PitStop/GetPitStop";
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            currentLatitude = data[0].Latitude;
            currentLongitude = data[0].Longitude;
            var currentLocation = new google.maps.LatLng(currentLatitude, currentLongitude);
        }

    });
    
    var inputBox = new google.maps.places.SearchBox(document.getElementById('mapSearch'));
    inputBox.bindTo('bounds', map);
    map.controls[google.maps.ControlPosition.TOP_CENTER].push(document.getElementById('mapSearch'));
    map.addListener("click", function (event) {
            placeMarker(event.latLng, map);
            getAddress(event.latLng);
        });

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

var EditPitStop = function (pitStopId) {
    var url = "/PitStop/EditPitStops?pitStopId=" + pitStopId;

    $("#ModalBodyEditPit").load(url, function () {
        $("#ModalEditPit").modal("show");
    });
}

var VewPitstop = function (pitStopId) {
    var url = "/PitStop/PitStopDetails?pitStopId=" + pitStopId;

    $("#ModalBodyShow").load(url, function () {
        $("#ModalShow").modal("show");
    });
};
var UpdatePitStop = function () {
    $("#loaderDiv").show();
    var formData = $("#editPitForm").serialize();
    $.ajax({
        type: "POST",
        url: "/PitStop/AddPitStop",
        data: formData,
        success: function (data) {
            $("#loaderDiv").hide();
            $("#ModalEditPit").modal("hide");
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
            $("#1b").html(data);
        }
    })
}

var deletePitStop = function (pitStipId) {
    $('#hiddenPitStopId').val(pitStipId);
    $("#deleteModel").modal('show');

};

var DeletePitConfirm = function () {
    $("#loaderDiv").show();
    var pitStopId = $('#hiddenPitStopId').val();
    $.ajax({
        type: "POST",
        url: '/PitStop/DeletePitStop',
        data: { PitStopId: pitStopId },
        success: function (result) {
            $("#loaderDiv").hide();
            $("#deleteModel").modal('hide');
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
            $("#1b").html(result);
        }

    });
}