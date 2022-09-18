let map;

function initMap() {
    map = new google.maps.Map(document.getElementById("map"), {
        center: new google.maps.LatLng(50.075445, 14.425931),
        zoom: 14,
    });

    const iconBase =
        "https://developers.google.com/maps/documentation/javascript/examples/full/images/";
    const icons = {
        info: {
            icon: iconBase + "info-i_maps.png",
        }
    };

    map.addListener("click", (mapsMouseEvent) => {
        var latLng = mapsMouseEvent.latLng.toJSON()
        savePlace(latLng)
    });


}

window.initMap = initMap;

var addMarkerModal = new bootstrap.Modal(document.getElementById('addMarker'), {
    keyboard: false
})

function savePlace(location) {
    document.getElementById("ToiletName").value = null;
    document.getElementById("ToiletCost").value = undefined;

    document.getElementById("ToiletPosX").value = location.lat;
    document.getElementById("ToiletPosY").value = location.lng;
    addMarkerModal.show();
}


/*
 * 
 * Nevím jak spojit C# a JS, abych tam naházel ty body na mapu :/
@foreach(var item in toilets.toilets)
{
    <text>
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(@(item.PosX), @(item.PosY)),
            map: map
        });
    </text>
}*/
