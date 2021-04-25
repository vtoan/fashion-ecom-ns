import axios from "axios";
import commonService from "./commonService";

class productService extends commonService {
  //attributes
  createAttr(productId, newAttr) {
    return axios({
      url: this.pathSer + "/" + productId + "/attrs",
      method: "post",
      data: { Size: newAttr },
      actionName: `Create new Product Attribute`,
    });
  }
  getListAttr(productId) {
    return axios({
      url: this.pathSer + "/" + productId + "/attrs",
      method: "get",
      actionName: `Get list Product Attribute of ${productId}`,
    });
  }

  deleteAttr(productId, itemId) {
    return axios({
      url: this.pathSer + "/" + productId + "/attrs/" + itemId,
      method: "delete",
      actionName: `Delete Product Attribute ${itemId}`,
    });
  }
  //image
  changeImageDefault(productId, newImage) {
    return axios({
      url: this.pathSer + "/" + productId + "/images",
      method: "put",
      data: { Id: productId, Image: newImage },
      actionName: `Change Image for ${productId}`,
    });
  }

  getListImages(productId) {
    return axios({
      url: this.pathSer + "/" + productId + "/images",
      method: "get",
      actionName: `Get List Image Product`,
    });
  }

  uploadImage(productId, newImage) {
    let formData = new FormData();
    formData.append("image", newImage);
    return axios({
      url: this.pathSer + "/" + productId + "/images",
      method: "post",
      headers: {
        "Content-Type": "multipart/form-data",
      },
      data: formData,
      actionName: `Upload Image for ${productId}`,
    });
  }

  removeImage(productId, imageName) {
    return axios({
      url: this.pathSer + "/" + productId + "/images?imageName=" + imageName,
      method: "delete",
      actionName: `Delete Product Attribute ${productId}`,
    });
  }
}

export default new productService("product", "Product");
