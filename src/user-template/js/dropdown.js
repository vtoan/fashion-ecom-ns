function UIDropDown(callBack, target = ".dropdown") {
  let dropdown = document.querySelector(target);
  console.log(target);
  console.log(dropdown);
  let selected = dropdown.querySelector(".select span");
  let showDrop = function (item) {
    item.classList.add("active");
    item.querySelector(".dropdown-menu").classList.add("show-drop");
  };
  let hideDrop = function (item) {
    item.classList.remove("active");
    item.querySelector(".dropdown-menu").classList.remove("show-drop");
  };
  let onSelected = function (item, dropdown, callback) {
    let index = Number(item.getAttribute("value"));
    // let result = dropdown.querySelector(".select span");
    dropdown.querySelector("input").setAttribute("value", index);
    selected.classList.remove("placeholder");
    selected.textContent = item.textContent;
    selected.parentElement.classList.remove("input-invalid");
    callback && callBack(index);
  };
  let onClickDrop = function () {
    this.classList.contains("active") ? hideDrop(this) : showDrop(this);
  };
  this.destroy = function () {
    dropdown.removeEventListener("click", onClickDrop);
    dropdown.removeEventListener("onfocusout", hideDrop);
    dropdown
      .querySelectorAll(".dropdown-menu li")
      .forEach((item) => item.removeEventListener("click", onSelected));
  };
  this.invalid = function () {
    selected.parentElement.classList.add("input-invalid");
  };
  //Attach Element
  this.attach = function () {
    dropdown.addEventListener("click", onClickDrop);
    dropdown.addEventListener("onfocusout", hideDrop);
    let dropItem = dropdown.querySelectorAll(".dropdown-menu li");
    let lengItem = dropItem.length > 5 ? 5 : dropItem.length;
    dropItem.forEach((item) =>
      item.addEventListener("click", function (e) {
        // e.preventDefault();
        onSelected(this, dropdown, callBack);
      })
    );
    dropdown.querySelector(".dropdown-menu").style.height =
      dropItem.item(0).offsetHeight * lengItem + "px";
  };
  this.attach();
}
