"use strict";

window.addEventListener("load", initialize);

//Elements
let slcProductType, slcDetails;
let inpMinMaxPrice;
let divProductInfo, divShoppingList;
let sctShopping;

//global vars
let shoppingCart;
let products;

function initialize() {
  bindElements();
  addEventListeners();

  products = JSON.parse(data);
  loadCategories();
  updateCategories();
  showProductInfo();

  shoppingCart = initializeShoppingCart();
  displayCart();
}

function initializeShoppingCart() {
  if (localStorage.getItem("cart") === null) return [];
  else return JSON.parse(localStorage.getItem("cart"));
}

function bindElements() {
  slcProductType = document.getElementById("product-categories");
  slcDetails = document.getElementById("category-details");

  inpMinMaxPrice = document.getElementById("min-max-price");

  sctShopping = document.getElementById("shopping");

  divProductInfo = document.getElementById("product-info");
  divShoppingList = document.getElementById("shopping-list");
}

function addEventListeners() {
  slcProductType.addEventListener("change", function () {
    updateCategories();
    showProductInfo();
  });
  slcDetails.addEventListener("change", showProductInfo);
}

function loadCategories() {
  for (const key in products) {
    slcProductType.options[slcProductType.length] = new Option(key, key);
  }
}

function updateCategories() {
  slcDetails.options.length = 0;

  const selectedCategory =
    slcProductType.options[slcProductType.selectedIndex].value;

  for (let i = 0; i < products[selectedCategory].length; i++) {
    const item = products[selectedCategory][i];
    slcDetails.options[slcDetails.length] = new Option(item.name, item.name);
  }

  slcDetails.setAttribute("multiple", "multiple");
  slcDetails.setAttribute("size", slcDetails.length);
  slcDetails.selectedIndex = 0;
}

function getCurrentSelection() {
  const selectedCategory = getSelectedCategory();
  const selectedProductIndex = getSelectedProductIndex();

  //this could return a fish or a product
  return products[selectedCategory][selectedProductIndex];
}

function getSelectedCategory() {
  return slcProductType[slcProductType.selectedIndex].value;
}

function getSelectedProductIndex() {
  return slcDetails.selectedIndex;
}

function showProductInfo() {
  const selectedCategory = slcProductType[slcProductType.selectedIndex].value;

  if (selectedCategory !== "products") displayFish();
  else displayProducts();
}

function displayFish() {
  const product = getCurrentSelection();

  divProductInfo.innerHTML = `
        <div>
        <h4>${product.name} (${product.info.behaviour}) - € ${
    product.price
  }</h4>
        <p>${product.info.description}</p>
        <img src="${product.info.image}" alt="${product.name}"/>
        <table>
        <tr>
            <th>Min. size</th>
            <th>Max. size</th>
            <th>Max. age</th>
            <th>Food</th>
            <th>Behaviour</th>
            <th>Community fish?</th>
        </tr>
        <tr>
            <td>${product.info.minSize}</td>
            <td>${product.info.maxSize}</td>
            <td>${product.info.maxAge}</td>
            <td>${product.info.food.join(", ")}</td>
            <td>${product.info.behaviour}</td>
            <td>${product.info.communityFish ? "yes" : "no"}</td>
        </tr>
        <p><b>Enemies: </b>${product.enemies.join(", ")}</p>
        </table>
    </div>`;

  const button = document.createElement("button");
  button.textContent = `Koop '${product.name}'!`;
  button.addEventListener("click", function () {
    buySelection();
    displayCart();
  });

  divProductInfo.appendChild(button);
}

function displayProducts() {
  const product = getCurrentSelection();

  divProductInfo.innerHTML = `
    <div>
    <h4>${product.name} - € ${product.price}</h4>
    <p>${product.description}</p>
    <img src="${product.image}" alt="${product.name}"/>
    </div>
    `;

  const button = document.createElement("button");
  button.textContent = `Koop '${product.name}'!`;
  button.addEventListener("click", function () {
    buySelection();
    displayCart();
  });

  divProductInfo.appendChild(button);
}

function buySelection() {
  const productToBuy = getCurrentSelection();
  const selectedCategory = getSelectedCategory();

  if (!itemExists(productToBuy)) {
    const newShoppingItem = {
      name: productToBuy.name,
      quantity: 1,
      price: productToBuy.price,
      image:
        selectedCategory === "products"
          ? productToBuy.image
          : productToBuy.info.image,
      category: selectedCategory,
    };

    shoppingCart.push(newShoppingItem);
  } else {
    const existingProduct = shoppingCart.find(
      (item) => item.name === productToBuy.name
    );
    existingProduct.quantity++;
    existingProduct.price += productToBuy.price;
  }

  localStorage.setItem("cart", JSON.stringify(shoppingCart));
}

function displayCart() {
  divShoppingList.innerHTML = "";

  let totalPrice = 0;

  shoppingCart.forEach((item) => {
    divShoppingList.innerHTML += `
        <p>${item.name} (${item.quantity}x) - € ${item.price}</p>`;
    totalPrice += item.price;
  });

  divShoppingList.innerHTML += `<b>Totaal: € ${totalPrice}</b>`;

  const btnPlaceOrder = document.createElement("button");
  btnPlaceOrder.textContent = "Place order";
  btnPlaceOrder.addEventListener("click", placeOrder);
  divShoppingList.appendChild(btnPlaceOrder);

  const btnEmptyBasket = document.createElement("button");
  btnEmptyBasket.textContent = "Empty basket";
  btnEmptyBasket.addEventListener("click", function () {
    emptyBasket();
    displayCart();
  });
  divShoppingList.appendChild(btnEmptyBasket);
}

function emptyBasket() {
  shoppingCart = [];
  localStorage.removeItem("cart");
}

function placeOrder() {
  location.assign("./buy.html");
}

function itemExists(product) {
  const item = shoppingCart.find(
    (shoppingItem) => shoppingItem.name === product.name
  );
  return !(item === undefined);
}
