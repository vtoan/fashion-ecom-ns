//requset api : location.origin + "/asset/province.json"
//requset api : location.origin + "/asset/district/${id}.json"
// ====== main ====== //
let province = "";
let district = "";
let dropProvince = null;
let dropDistrict = null;

document.querySelector("#send-order").addEventListener("click", function (e) {
  document.querySelector("#formOrder [type=submit]").click();
});

let form = document.querySelector("#formOrder");
form.addEventListener("submit", function (e) {
  if (!province || dropProvince == null) {
    dropProvince.invalid();
    window.alert("Vui lòng nhập thông tin giao hàng.");
    e.preventDefault();
    return;
  }
  if (!district || dropDistrict == null) {
    dropDistrict.invalid();
    window.alert("Vui lòng nhập thông tin giao hàng.");
    e.preventDefault();
    return;
  }
  console.log(form);
  e.preventDefault();
});
function createInputElm(name, data) {
  return `<input type="hidden" name="${name}" value="${data}">`;
}

function renderAddress(target, data) {
  let container = document.querySelector(target + " .dropdown-menu");
  let htmlString = "";
  let arr = Object.values(data);
  arr.forEach((item) => {
    htmlString += `<li class="p-3" value="${item.code}">${item.name_with_type}</li>`;
  });
  container.innerHTML = "";
  container.innerHTML = htmlString;
}

function showProvince(data) {
  renderAddress("[local-province]", data);
  dropProvince = new UIDropDown(function (val) {
    province = val;
    getDistrict(val);
  }, "div[local-province]");
}
function showDistrict(data) {
  renderAddress("[local-district]", data);
  dropDistrict = new UIDropDown(function (val) {
    district = val;
  }, "div[local-district]");
}
function getProvince() {
  fetch(location.origin + "/asset/province.json").then((response) => {
    if (response.ok) {
      response.json().then(showProvince);
    }
  });
}
function getDistrict(id) {
  fetch(location.origin + `/asset/district/${id}.json`).then((response) => {
    if (response.ok) {
      response.json().then(showDistrict);
    }
  });
}
getProvince();
