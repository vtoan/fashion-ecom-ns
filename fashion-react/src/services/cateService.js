import axios from "axios";
import commonService from "./commonService";
import { setCategory } from "../actions/fetchDataAction";

class cateService extends commonService {
  getList(typeId) {
    return axios({
      url: this.pathSer + "?typeId=" + typeId,
      method: "get",
      actionName: `Get list ${this.aliasName}`,
    });
  }
}
let _cateType = new cateService("category", "Category");
export default _cateType;

export function fetchCategory(store) {
  _cateType.getList(0).then(({ data }) => store.dispatch(setCategory(data)));
}
