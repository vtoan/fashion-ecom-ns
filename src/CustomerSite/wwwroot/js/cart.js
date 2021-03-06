function Cart() {
  let keySave = "basketshopping";
  let order = [];
  let count = 1;
  this.setData = function (asset) {
    if (!asset) return;
    order = asset;
    let len = order.length;
    for (let index = 0; index < len; index++) {
      count += order[index].Quantity;
    }
  };
  this.getData = function () {
    return order;
  };
  this.getItem = function (id) {
    return order.find((i) => i.AttributeId == id);
  };
  this.getCount = function () {
    return order.reduce((accur, item) => (accur += item.Quantity), 0);
  };
  this.isEmpty = function () {
    if (!order || order.length == 0) return true;
    return false;
  };
  this.addItem = function (id, quantity = 1) {
    id = Number(id);
    let index = order.findIndex((item) => item.AttributeId == Number(id));
    if (index >= 0) {
      order[index].Quantity += quantity;
    } else
      order.push({
        AttributeId: id,
        Quantity: quantity,
      });
  };
  this.changeQuantityItem = function (id, operation) {
    if (this.isEmpty());
    id = Number(id);
    let indx = order.findIndex((i) => i.AttributeId == Number(id));
    if (indx < 0) return;
    if (operation) {
      order[indx].Quantity++;
      count++;
    } else {
      order[indx].Quantity--;
      count--;
    }
  };
  this.removeItem = function (id) {
    console.log(id);
    if (this.isEmpty()) return;
    let idx = order.findIndex((i) => i.AttributeId == Number(id));
    if (idx < 0) return;
    count = count - order[idx].Quantity;
    order.splice(idx, 1);
  };
  this.clear = function () {
    order = [];
  };

  this._saveStorage = function () {
    window.localStorage.setItem(keySave, JSON.stringify(this.getData()));
  };
  this._getStorage = function () {
    let cart = window.localStorage.getItem(keySave);
    if (cart) this.setData(JSON.parse(cart));
    else this.setData([]);
  };
}
