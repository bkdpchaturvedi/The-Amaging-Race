
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
            $("#1b").html(data);
        }
    });
}

function pitStopLocate() {
    
        var latlng = new google.maps.LatLng(1.281766, 103.818346);
    var mapOptions = {
        center: latlng,
        zoom: 13,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
        var map = new google.maps.Map(document.getElementById("map"), mapOptions);
    var marker;
    var inputBox = new google.maps.places.SearchBox(document.getElementById('mapSearch'));
    inputBox.bindTo('bounds', map);
    map.controls[google.maps.ControlPosition.TOP_CENTER].push(document.getElementById('mapSearch'));
    map.addListener("click", function (event) {
            placeMarker(event.latLng);
            getAddress(event.latLng);
        });

        function getAddress(location) {
            var geocoder = new google.maps.Geocoder();
            geocoder.geocode({ "latLng": location }, function (results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    $('#mapSearch').val(results[0].formatted_address);
                    $('#Address').val(results[0].formatted_address);
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

var EditPitStop = function (pitStopId) {
    var url = "/PitStop/EditPitStop?pitStopId=" + pitStopId;

    $("#ModalBodyEdit").load(url, function () {
        $("#ModalEdit").modal("show");
    });
}

var PitStopDetails = function (pitStopId) {
    var url = "/PitStop/PitStopDetails?pitStopId=" + pitStopId;

    $("#ModalBodyShow").load(url, function () {
        $("#ModalShow").modal("show");
    });
};
var UpdatePitSTop = function () {
    $("#loaderDiv").show();
    var formData = $("#editPitForm").serialize();
    alert(formData);
    $.ajax({
        type: "POST",
        url: "/PitStop/AddPitStop",
        data: formData,
        success: function () {
            $("#loaderDiv").hide();
            $("#ModalEdit").modal("hide");
            
        }
    })
}