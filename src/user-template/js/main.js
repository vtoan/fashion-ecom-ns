const productInCarts = [];
const productItems = [
  {
    name: "Product 1",
    price: 100000,
    image: "./images/product-1.png",
    type: "woman",
    description: "This is a description of product 1",
  },
  {
    name: "Product 2",
    price: 200000,
    image: "./images/product-2.png",
    type: "woman",
    description: "This is a description of product 2",
  },
  {
    name: "Product 3",
    price: 300000,
    image: "./images/product-3.png",
    type: "woman",
    description: "This is a description of product 3",
  },
  {
    name: "Product 4",
    price: 100000,
    image: "./images/product-4.png",
    type: "men",
    description: "This is a description of product 4",
  },
  {
    name: "Product 5",
    price: 200000,
    image: "./images/product-5.png",
    type: "men",
    description: "This is a description of product 5",
  },
  {
    name: "Product 6",
    price: 300000,
    image: "./images/product-6.png",
    type: "men",
    description: "This is a description of product 6",
  },
];
// ====== helpful ====== //
function toCurrency(number) {
  return new Intl.NumberFormat("de-DE").format(number);
}

function filterGender(ar, typeGender) {
  return ar.filter((item) => item.type === typeGender);
}

// ====== add cart ====== //

let cartCounterElm = document.querySelector("#cart-counter");
// defint add cart event
function handleAddToCart(product) {
  productInCarts.push(product);
  cartCounterElm.textContent = productInCarts.length;
  console.log(product);
}

// ====== reander product ====== //
// create one product
function createProductElm(item) {
  let colElm = document.createElement("div");
  colElm.classList.add("col-4");
  // product elm
  let productElm = document.createElement("div");
  productElm.classList.add("product");
  // content html elm
  let elmString = `
        <div class="product-img border">
          <div class="img">
            <img src="${item.image}" alt="" srcset="" />
          </div>
        </div>
        <div class="product-content">
          <p product-name class="mb-none bold">${item.name}</p>
          <p>${item.description}</p>
          <p class="bold">${toCurrency(item.price)} VND</p>
          <a
              product-add-cart
              href="javascript:void(0)"
              class="btn btn-sm btn-anim-no bg-black white d-block border-primary"
              >ADD TO CART</a
          >
        </div>`;
  productElm.innerHTML = elmString;
  // append to col.
  colElm.appendChild(productElm);
  // attach event add cart to product;
  let addCartElm = productElm.querySelector("a[product-add-cart]");
  addCartElm.addEventListener("click", () => handleAddToCart(item));
  return colElm;
}
// create list product and append to container
function renderProducts(arr, container, title) {
  // row elm
  let rowElm = document.createElement("div");
  rowElm.classList.add("row");
  // create title tag
  if (title) {
    let heading = document.createElement("h3");
    heading.textContent = title;
    container.append(heading);
  }
  // check empty
  if (arr.length == 0) {
    let p = document.createElement("p");
    p.textContent = "Not find product matched.";
    container.append(p);
    return;
  }
  // append to container
  arr.forEach((item) => rowElm.appendChild(createProductElm(item)));
  container.append(rowElm);
}

let container = document.querySelector("#list-product");
let productMens = filterGender(productItems, "men");
let productWomans = filterGender(productItems, "woman");

function renderData() {
  renderProducts(productMens, container, "Men Products");
  renderProducts(productWomans, container, "Woman Products");
}
renderData();

// ====== filter ====== //
let formFilter = document.querySelector("#form-filter");

// define filter event
function filter(minVal, maxVal) {
  if (!minVal) minVal = 0;
  if (!maxVal) maxVal = Number.MAX_VALUE;
  let temp = productItems.filter(
    (item) => item.price >= minVal && item.price <= maxVal
  );
  container.innerHTML = "";
  renderProducts(temp, container, "Filter results");
}

// attach event when submit form
formFilter.addEventListener("submit", function (e) {
  let minVal = formFilter.querySelector("#min-price").value;
  let maxVal = formFilter.querySelector("#max-price").value;
  filter(minVal, maxVal);
  e.preventDefault();
});

// attach event when reset form
formFilter.addEventListener("reset", function (e) {
  container.innerHTML = "";
  renderData();
});
