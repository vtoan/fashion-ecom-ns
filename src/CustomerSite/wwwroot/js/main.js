// ====== helpful ====== //
function toCurrency(number) {
  return new Intl.NumberFormat("de-DE", {
    style: "currency",
    currency: "VND",
  }).format(number);
}
// ====== event listener  ====== //
function addListener(arrElms) {
  arrElms.forEach((item) => {
    if (item.elm) item.elm.addEventListener(item.event, item.handle);
  });
}
function removeListener(arrElms) {
  arrElms.forEach((item) => {
    if (item.elm) item.elm.removeEventListener(item.event, item.handle);
  });
}
// ======  define - event  ====== //
function toggleClass(elmOpenQuery, elmCloseQuery, elmTargetQuery, callBack) {
  let elmOpen = document.querySelector(elmOpenQuery),
    elmClose = document.querySelector(elmCloseQuery),
    elmTarget = document.querySelector(elmTargetQuery);
  let arrElms = [
    {
      elm: elmOpen,
      event: "click",
      handle: () => {
        callBack && callBack();
        elmTarget.classList.add("show");
      },
    },
    {
      elm: elmClose,
      event: "click",
      handle: () => elmTarget.classList.remove("show"),
    },
  ];
  addListener(arrElms);
  document.addEventListener("unload", () => removeListener(arrElms));
}

// ======  add cart product event  ====== //
function updateCountInCart() {
  cartCounterElm.textContent = cartMng.getCount();
}

// ====== view resize ====== //
function checkViewClient() {
  let wScreen = window.screen.width;
  let classNameCouter = "#cart-counter";
  if (wScreen < 992) {
    viewModile();
    classNameCouter += "-mobile";
  } else {
    viewLarge();
  }
  cartCounterElm = document.querySelector(classNameCouter);
}

function viewLarge() {
  toggleClass("#search-trigger", "#search-close", ".search-bar");
  //
  let details = document.querySelector("details");
  details?.setAttribute("open", "");
}

function viewModile() {
  let menuTrigger = document.querySelector("#menu-trigger");
  var popup = new jPopup({
    content: `
    <div class="nav-mobile d-flex">
      <a id="search-trigger-mobile"  href="#" class="nav-item">search</a>
      <a href="#" class="nav-item">login</a>
      <a href="#" class="nav-item">features</a>
      <a href="#" class="nav-item">men</a>
      <a href="#" class="nav-item">women</a>
      <a href="#" class="nav-item">contacts</a>
    </div>`,
    transition: "fade",
  });

  toggleClass(
    "#search-trigger-mobile",
    "#search-close",
    ".search-bar",
    function () {
      popup.close();
    }
  );

  menuTrigger.addEventListener("click", function (e) {
    popup.open();
  });
}
let searchBar = document.querySelector(".search-bar input");
searchBar.addEventListener("keydown", (e) => {
  if (e.keyCode === 13) {
    location.href = "/search?query=" + e.target.value;
  }
});

// ====== exce ====== //
var cartMng = new Cart();
var cartCounterElm;

checkViewClient();

cartMng._getStorage();
cartCounterElm.textContent = cartMng.getCount();

window.addEventListener("resize", () => checkViewClient());
window.addEventListener("beforeunload", () => cartMng._saveStorage());
