import axios from "axios";

export default class commonService {
  constructor(pathSer, aliasName) {
    this.pathSer = pathSer;
    this.aliasName = aliasName;
  }

  getList(params = null) {
    return axios({
      url: this.pathSer + this._createQuery(params),
      method: "get",
      actionName: `Get list ${this.aliasName}`,
    });
  }

  get(id) {
    return axios({
      url: this.pathSer + "/" + id,
      method: "get",
      actionName: `Get ${this.aliasName} with ID: ${id}`,
    });
  }

  edit(id, object) {
    return axios({
      url: this.pathSer + "/" + id,
      method: "put",
      data: object,
      actionName: `Edit ${this.aliasName} with ID: ${id}`,
    });
  }

  delete(id) {
    return axios({
      url: this.pathSer + "/" + id,
      method: "delete",
      actionName: `Delete ${this.aliasName} with ID: ${id}`,
    });
  }

  create(object, params = null) {
    return axios({
      url: this.pathSer + this._createQuery(params),
      method: "post",
      data: object,
      actionName: `Create new ${this.aliasName}`,
    });
  }

  _createQuery(params) {
    if (!params) return "";
    let queryStr = "";
    for (const key in params) {
      if (!params[key]) continue;
      if (queryStr) queryStr += "&&";
      queryStr += key + "=" + params[key];
    }
    return "?" + queryStr;
  }
}
