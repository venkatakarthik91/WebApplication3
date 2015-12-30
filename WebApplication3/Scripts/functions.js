/// <reference path="../Scripts/jquery-2.1.0-vsdoc.js" />

/****************************** Core Communication logic *************************/

function AddGirlFriend(nameOfGirlfriend) {
    var promiseOfAdd = $.ajax({
        url: "/api/test",
        type: "POST",
        data: JSON.stringify(nameOfGirlfriend),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
    });
    return promiseOfAdd;
}
function ShowAllGirlFriends() {
    var promiseOfShow = $.ajax({
        url: "/api/test",
        type: "GET",
        dataType: "json",
    });
    return promiseOfShow;
}
function UpdateGirlFriend(oldGF, newGF) {
    var promiseOfUpdate = $.ajax({
        url: "/api/test",
        type: "PUT",
        data: JSON.stringify({ "oldGF": oldGF, "newGF": newGF }),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
    });
    return promiseOfUpdate;
}
function DeleteGirlFriend(nameOfGirlfriend) {
    var promiseOfDelete = $.ajax({
        url: "/api/test",
        type: "DELETE",
        data: JSON.stringify(nameOfGirlfriend),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
    });
    return promiseOfDelete;
}