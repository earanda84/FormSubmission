// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Redirect(){
    return window.location.href = "http://localhost:5058";
}

const btnBack = document.getElementById("backBtn");

btnBack.addEventListener("click",()=>{
    Redirect();
})