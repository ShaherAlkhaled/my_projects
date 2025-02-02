"use strict";

window.addEventListener("load", initialize);

let items;

function initialize() {
   setItems();

   if(items === null) document.getElementById("message").textContent = "Nothing ordered ...";

   generateOrderTable();
}

function setItems() {
   items = JSON.parse(localStorage.getItem("cart"));
}

function generateOrderTable() {

  

   const table = document.createElement("table");

   table.innerHTML = `
   <tr>
      <th>product image</th>
      <th>product name</th>
      <th>amount</th>
   </tr>`;
   
   items.forEach(item => {

      const row = document.createElement("tr");

      const imageCell = document.createElement("td");
      const image = document.createElement("img");
      image.src = item.image;
      image.alt = item.name;
      image.className = "image-circle";
      imageCell.appendChild(image);
      
      const productCell = document.createElement("td");
      productCell.textContent = item.name;
      
      const amountCell = document.createElement("td");
      amountCell.textContent = item.quantity;  
      
      row.appendChild(imageCell);
      row.appendChild(productCell);
      row.appendChild(amountCell);

      table.appendChild(row);      
   });

   document.body.appendChild(table);

}