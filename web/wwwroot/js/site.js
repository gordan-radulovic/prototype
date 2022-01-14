// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var createRoomButton = document.getElementById('create-room')
var createRoomModal = document.getElementById('create-room-modal')

createRoomButton.addEventListener('click', function(){
    createRoomModal.classList.add("active");
})

var closeModal = function(){
    createRoomModal.classList.remove("active");
}