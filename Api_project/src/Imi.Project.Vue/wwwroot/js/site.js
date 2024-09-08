"use strict"
window.addEventListener("load", initialize);
let logout;
let divContanier;
function initialize() {
    logout = document.getElementById("logout");
    divContanier = document.getElementById("container");
    logout.style.cursor = "pointer";
       logout.addEventListener("click",function (){
           sessionStorage.clear();
           location.assign("https://localhost:5002/home/index");

        });
    checkLogin();
}

function checkLogin() {
    const token = JSON.parse(sessionStorage.getItem("token"));
    if (token == null) {
        logout.style.display = "none";
        divContanier.style.display = "none";

    } else {
        logout.style.display = "block";
        divContanier.style.display = "block";
    }
}