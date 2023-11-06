// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var i = 0;
function move() {
    if (i == 0) {
        i = 1;
        var elem = document.getElementById("myBar");
        var width = 10;
        var id = setInterval(frame, 10);
        function frame() {
            if (width >= 100) {
                clearInterval(id);
                i = 0;
            } else {
                width++;
                elem.style.width = width + "%";
                elem.innerHTML = width + "%";
            }
        }
    }
}


// Get the Available Balance and GoalPrice values
var availableBalance = parseInt(document.getElementById("availableBalance")); // You can replace this with the actual available balance value
var goalPrice = @Html.Raw(Json.Encode(item.GoalPrice)); // Get the goal price from your ASP.NET model

// Calculate the percentage
var percentage = (availableBalance / goalPrice) * 100;

// Set the percentage as innerHTML of the "myBar" element
var myBar = document.getElementById("myBar");
myBar.innerHTML = percentage.toFixed(2) + "%"; // Use toFixed(2) to format the percentage with 2 decimal places