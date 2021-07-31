"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/userListHub").build();

connection.on("ReceiveUserList", function (users) {
    document.getElementById("userList").textContent = users;
});

connection.start().then(function () {
    window.setInterval(function () {
        connection.invoke("GetUserList").catch(function (err) {
            return console.error(err.toString());
        }, 500);
    });
});
