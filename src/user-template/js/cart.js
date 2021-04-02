function Cart() {
  let order = [
    {
      ProductId: 1,
      Quantity: 1,
    },
  ];
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
    return order.find((i) => i.ProductId == id);
  };
  this.getCount = function () {
    return count;
  };
  this.isEmpty = function () {
    if (!order || order.length == 0) return true;
    return false;
  };
  this.addItem = function (id) {
    id = Number(id);
    let index = order.findIndex((item) => item.ProductId == id);
    if (index >= 0) order[index].Quantity++;
    else
      order.push({
        ProductId: id,
        Quantity: 1,
      });
    count++;
    console.log(order);
  };
  this.changeQuantityItem = function (id, operation) {
    if (this.isEmpty());
    id = Number(id);
    let indx = order.findIndex((i) => i.ProductId == id);
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
    if (this.isEmpty()) return;
    let idx = order.findIndex((i) => i.ProductId == id);
    if (idx < 0) return;
    count = count - order[idx].Quantity;
    order.splice(idx, 1);
  };
  this.clear = function () {
    order = [];
  };

  this._saveStorage = function () {
    let dt = new Date(Date.now() + 30 * 86400000);
    document.cookie = `basketshopping=${JSON.stringify(
      this.getData()
    )};expires=${dt.toString()};path=/;`;
  };
  this._getStorage = function () {
    let cookie = document.cookie;
    let stringUtf = decodeURIComponent(cookie);
    let asset = stringUtf.split(";");
    let cart;
    for (let i = 0; i < asset.length; i++) {
      let data = asset[i].split("=");
      if (data[0].trimStart() == "basketshopping") {
        cart = data[1];
      }
    }
    // if (cart) this.setData(JSON.parse(cart));
    // this.setData([]);
  };
}
