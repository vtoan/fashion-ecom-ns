// request api :" ?handler=cartitem&&ids="
// ====== main ====== //
function cartSite(config) {
  let options = {
    cart: null,
    quantityChanged: null,
    root: "#cart",
    currency: null,
    loader: { show: null, close: null },
    popup: { show: null, close: null },
    checkOutUri: "",
  };
  options = config;
  let cart = options.cart;
  let root = document.querySelector(options.root);
  let listCartItem = [];
  let listFees = [];
  // let promo;
  let elmTotal = root.querySelector("[order-total]");
  let elmPay = root.querySelector("[order-pay]");
  // let elmPromo = root.querySelector("[order-promotion]");
  let countItem = root.querySelector("#count-items");

  // ====== attach event ====== //
  countItem.textContent = cart.getCount();
  //get fees in cart;
  root.querySelectorAll("td[order-fees]").forEach(function (element) {
    let cost = element.getAttribute("fee-cost");
    if (!cost) return;
    listFees.push(cost);
    element.textContent =
      cost % 1 == 0 ? options.currency(cost) : cost * 100 + " %";
  });

  //get list item in cart;
  root.querySelectorAll(".cart-item").forEach((element) => {
    let itemId = element.getAttribute("item-id");
    listCartItem.push({
      id: itemId,
      elm: element,
    });
    attachEventItem(element, itemId);
  });

  // trigger submit form
  // root.querySelector("a[prom-submit]").addEventListener("click", function (e) {
  //   e.preventDefault();
  //   let promELm = this.previousElementSibling;
  //   let val = promELm.value;
  //   if (!val) return;
  //   checkPromotion(val);
  //   promELm.value = "";
  // });
  //create form submit promotion code.
  root.querySelector("form").addEventListener("submit", function (e) {
    // let promInput = document.createElement("input");
    // promInput.value = promo?.code;
    // promInput.name = "promCode";
    // promInput.type = "hidden";

    // this.appendChild(promInput);
    let listItem = document.createElement("input");
    listItem.value = JSON.stringify(cart.getData());
    listItem.name = "attrIds";
    listItem.type = "hidden";
    this.appendChild(listItem);

    return true;
  });
  // ========== define event ==========
  // attach event up, down, romve item
  function attachEventItem(element, id) {
    element
      .querySelector("a[quantity-add]")
      .addEventListener("click", function (e) {
        e.preventDefault();
        let elmCouter = this.parentNode.querySelector("[item-count]");
        updateQuantityItem(elmCouter, id, true);
      });
    element
      .querySelector("a[quantity-subtract]")
      .addEventListener("click", function (e) {
        e.preventDefault();
        let elmCouter = this.parentNode.querySelector("[item-count]");
        updateQuantityItem(elmCouter, id, false);
      });
    element
      .querySelector("a[quantity-remove]")
      .addEventListener("click", function (e) {
        e.preventDefault();
        removeItem(this);
      });
  }

  // handler remove item
  function removeItem(element) {
    let index = listCartItem.findIndex((obj) => obj.elm.contains(element));
    //remove
    cart.removeItem(listCartItem[index].id);
    listCartItem[index].elm.remove();
    listCartItem.splice(index, 1);
    if (listCartItem.length == 0) {
      // elmPromo.parentElement.classList.add("d-none");
      // elmPromo.textContent = "0 đ";
      root.querySelector(
        "#cart-container"
      ).innerHTML = `<p class="text-center"> Trống !</p>`;
    }
    //update change
    options.quantityChanged();
    countItem.textContent = cart.getCount();
    updateSummaryOrder();
  }

  // handler quantity change.
  function updateQuantityItem(countElm, itemId, operation) {
    let count = parseInt(countElm.textContent) + (operation ? 1 : -1);
    if (!count) return;
    //update change
    cart.changeQuantityItem(itemId, operation);
    countElm.textContent = count;
    updateTotalItem(countElm, count);
    options.quantityChanged();
    countItem.textContent = cart.getCount();
    updateSummaryOrder();
  }

  function updateTotalItem(element, count) {
    let price = element.getAttribute("item-price");
    let total = price * (count ?? 1);
    let elm = element
      .closest(".col-12")
      .nextElementSibling.querySelector("span[item-total]");
    elm.textContent = options.currency(total);
    elm.setAttribute("item-total", total);
  }

  // update Summary Order
  function updateSummaryOrder() {
    let totalOrder = listCartItem.reduce((count, value) => {
      return (count += Number(
        value.elm.querySelector("span[item-total]").getAttribute("item-total")
      ));
    }, 0);
    // cal total fee
    let totalFee =
      listFees?.reduce((count, value) => {
        return (count += Number(value % 1 == 0 ? value : totalOrder * value));
      }, 0) ?? 0;

    let pay = totalOrder + totalFee;
    //show to view
    elmTotal.textContent = options.currency(totalOrder);
    elmPay.textContent = options.currency(Math.round(pay));
  }
  //promotion
  // function checkPromotion(promCode) {
  //   let cost = elmPromo.getAttribute("item-promotion");
  //   if (!cost) return;
  //   elmPromo.textContent =
  //     "- " + (cost % 1 == 0 ? currency(cost) : cost * 100 + " %");
  //   elmPromo.parentElement.classList.remove("d-none");
  //   let path = location.href.replaceAll(/[#!]/g, "");
  //   let url = path + "?handler=checkprom&&code=" + promCode;
  //   fetch(url).then(function (response) {
  //     if (response.ok) {
  //       response.json().then(function (data) {
  //         promo = data;
  //         let cost = data.discount;
  //         elmPromo.textContent =
  //           "- " + (cost % 1 == 0 ? options.currency(cost) : cost * 100 + " %");
  //         elmPromo.parentElement.classList.remove("d-none");
  //       });
  //     }
  //   });
  // }
  updateSummaryOrder();
}
// ====== exe ====== //
let container = document.querySelector("#cart-container");

function renderCartItem(data) {
  container.innerHTML = "";
  container.innerHTML = data;
  let act = cartSite({
    cart: cartMng,
    quantityChanged: updateCountInCart,
    root: "#cart",
    currency: toCurrency,
    checkOutUri: "/gio-hang",
  });
}

// renderCartItem();
window.addEventListener("load", function () {
  let val = JSON.stringify(cartMng.getData());
  // let path = location.href.replaceAll(/[#!]/g, "");
  let path = "/OrderItem";
  let url = path + "?attrIds=" + val;
  fetch(url).then((response) => {
    if (response.ok) response.text().then(renderCartItem);
    return null;
  });
});
