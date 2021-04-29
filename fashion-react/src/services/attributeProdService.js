import axios from "axios";

class productService {
  constructor(pathSer, aliasName) {
    this.pathSer = pathSer;
    this.aliasName = aliasName;
  }
  //attributes
  create(productId, newAttr) {
    return axios({
      url: this.pathSer + "/" + productId + "/attrs",
      method: "post",
      data: { Size: newAttr },
      actionName: `Create new ${this.aliasName}`,
    });
  }
  getList(productId) {
    return axios({
      url: this.pathSer + "/" + productId + "/attrs",
      method: "get",
      actionName: `Get list ${this.aliasName} of ${productId}`,
    });
  }
  delete(productId, itemId) {
    return axios({
      url: this.pathSer + "/" + productId + "/attrs/" + itemId,
      method: "delete",
      actionName: `Delete ${this.aliasName} ${itemId}`,
    });
  }
}

export default new productService("product", "Product Attribute");
