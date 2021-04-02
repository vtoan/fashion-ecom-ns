let totalQuanlity = 1;
let itemid = 1;
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

attachEventItem(quantityElm);

addCartElm.addEventListener("click", (e) => {
  cartMng.addItem(itemid, totalQuanlity);
  updateCountInCart();
});
