const h1 = document.getElementById('timeStamp');
const url = "/api/timestamp";

fetch(url)
    .then(response => response.json())
    .then(data => {
        h1.innerHTML = `Time stamp from API -  ${data}`
    })