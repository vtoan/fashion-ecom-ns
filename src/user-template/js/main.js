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
  document.addEventListener("unload", function (e) {
    removeListener(arrElms);
  });
}

function attachSearchMobile() {
  let searchTriger = "#search-trigger-mobile";
  let menuTrigger = document.querySelector("#menu-trigger");
  var jPopupDemo = new jPopup({
    content: `
    <div class="nav-mobile d-flex">
      <a id="search-trigger-mobile" href="#" class="nav-item">search</a>
      <a href="#" class="nav-item">login</a>
      <a href="#" class="nav-item">sale</a>
      <a href="#" class="nav-item">features</a>
      <a href="#" class="nav-item">men</a>
      <a href="#" class="nav-item">women</a>
      <a href="#" class="nav-item">contacts</a>
      </div>`,
    transition: "fade",
  });

  menuTrigger.addEventListener("click", (e) => {
    jPopupDemo.open();
  });

  toggleClass(searchTriger, "#search-close", ".search-bar", () =>
    jPopupDemo.close()
  );
}

function attachSearchTriger() {
  let wScreen = window.screen.width;
  if (wScreen < 992) attachSearchMobile();
  else toggleClass("#search-trigger", "#search-close", ".search-bar");
}

// ====== exce ====== //
var splide = new Splide(".splide", {
  type: "loop",
  autoplay: true,
}).mount();

attachSearchTriger();
window.addEventListener("resize", (e) => attachSearchTriger());
