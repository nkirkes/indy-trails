var base_layer = new L.tileLayer(
    'http://{s}.tile.cloudmade.com/812a4f0f7ed8476c8915e4703c4414c1/997/256/{z}/{x}/{y}.png', {
        attribution: 'Map data &copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors, <a href="http://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery © <a href="http://cloudmade.com">CloudMade</a>',
        maxZoom: 18
    }
);

var map = new L.Map('map', {
    layers: [base_layer],
    center: [39.8062, -86.0858],
    zoom: 10,
    zoomControl: true
});

L.control.locate({
    follow: true
}).addTo(map);