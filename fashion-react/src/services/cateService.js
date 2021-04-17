import axios from "axios";
import { host } from "../config";
import commonService from "./commonService";

class cateService extends commonService {
  getList(typeId) {
    return axios({
      url: host + "/" + this.pathSer + "?typeId=" + typeId,
      method: "get",
      actionName: `Get list ${this.aliasName}`,
    });
  }
}

export default new cateService("category", "Category");
