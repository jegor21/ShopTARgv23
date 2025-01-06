﻿
var connectionUserCount = new signalR.HubConnectionBuilder()
    .withAutomaticReconnect()
    .withUrl("/hubs/userHub", signalR.HttpTransportType.WebSockets).build();


connectionUserCount.on("updateTotalViews", (value) => {
    var newCountSpan = document.getElementById("totalViewsCounter");
    newCountSpan.innerText = value.toString();
});

connectionUserCount.on("updateTotalUsers", (value) => {
    var newCountSpan = document.getElementById("totalUsersCounter");
    newCountSpan.innerText = value.toString();
});


function newWindowLoadedOnClient() {
    connectionUserCount.invoke("NewWindowLoaded", "Test").then((value) => console.log(value));
}


function fulfilled() {
    console.log("Connection to User Hub Successful");
    newWindowLoadedOnClient();
}
function rejected() {

}

connectionUserCount.start().then(fulfilled, rejected);