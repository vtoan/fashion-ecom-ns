let totalQuanlity = 1;
let itemAttrid = 0;
let itemProductId = Number(
  document.querySelector(".product-detail").getAttribute("itemid")
);

function attachEventItem(element) {
  element
    .querySelector("a[quantity-add]")
    .addEventListener("click", function (e) {
      e.preventDefault();
      let elmCouter = this.parentNode.querySelector("[item-count]");
      updateQuantityItem(elmCouter, true);
    });
  element
    .querySelector("a[quantity-subtract]")
    .addEventListener("click", function (e) {
      e.preventDefault();
      let elmCouter = this.parentNode.querySelector("[item-count]");
      updateQuantityItem(elmCouter, false);
    });
}

function updateQuantityItem(countElm, operation) {
  totalQuanlity = parseInt(countElm.textContent) + (operation ? 1 : -1);
  if (!totalQuanlity) return;
  //update change
  countElm.textContent = totalQuanlity;
}

// ====== execx ====== //
let quantityElm = document.querySelector("div[quantity]");
let addCartElm = document.querySelector(".add-cart");
let attrsElm = document.querySelectorAll(".attr-item");

let firstElm = attrsElm[0];
firstElm.classList.add("active");
itemAttrid = Number(firstElm.getAttribute("itemid"));
attrsElm.forEach((item) => {
  item.addEventListener("click", (e) => {
    attrsElm.forEach((item) => {
      if (item.classList.contains("active")) item.classList.remove("active");
    });
    let elmTarget = e.target;
    itemAttrid = elmTarget.getAttribute("itemid");
    elmTarget.classList.add("active");
  });
});

attachEventItem(quantityElm);

addCartElm.addEventListener("click", (e) => {
  cartMng.addItem(itemAttrid, totalQuanlity);
  updateCountInCart();
});
