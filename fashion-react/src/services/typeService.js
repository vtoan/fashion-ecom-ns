import axios from "axios";
import { setTypeProduct } from "../actions/fetchDataAction";

class typeService {
  constructor(pathSer, aliasName) {
    this.pathSer = pathSer;
    this.aliasName = aliasName;
  }

  getList() {
    return axios({
      url: this.pathSer,
      method: "get",
      actionName: `Get list ${this.aliasName}`,
    });
  }
}

let _typeSer = new typeService("typeproduct", "Type Product");
export default _typeSer;

export function fetchTypeProduct(store) {
  _typeSer.getList().then(({ data }) => store.dispatch(setTypeProduct(data)));
}
