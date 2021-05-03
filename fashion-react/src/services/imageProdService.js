import axios from "axios";

class imageProdService {
  constructor(pathSer, aliasName) {
    this.pathSer = pathSer;
    this.aliasName = aliasName;
  }
  changeImageDefault(productId, newImage) {
    return axios({
      url: this.pathSer + "/" + productId + "/images",
      method: "put",
      data: { Id: productId, Image: newImage },
      actionName: `Change ${this.aliasName} for ${productId}`,
    });
  }

  getListImages(productId) {
    return axios({
      url: this.pathSer + "/" + productId + "/images",
      method: "get",
      actionName: `Get List ${this.aliasName} of ${productId}`,
    });
  }

  uploadImage(productId, newImages) {
    let formData = new FormData();
    if (!newImages) return;
    let lengImages = newImages.length;
    for (let i = 0; i < lengImages; i++) {
      formData.append("images", newImages[i]);
    }
    return axios({
      url: this.pathSer + "/" + productId + "/images",
      method: "post",
      headers: {
        "Content-Type": "multipart/form-data",
      },
      data: formData,
      actionName: `Upload ${this.aliasName} for ${productId}`,
    });
  }

  removeImage(productId, imageName) {
    return axios({
      url: this.pathSer + "/" + productId + "/images?imageName=" + imageName,
      method: "delete",
      actionName: `Delete ${this.aliasName} ${productId}`,
    });
  }
}

export default new imageProdService("product", "Image");
