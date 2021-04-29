import axios from "axios";
import { toast } from "react-toastify";
import { host } from "../config";

export default function httpClient() {
  axios.defaults.baseURL = host;
  // Add a response interceptor
  axios.interceptors.response.use(
    function (response) {
      let method = response.config.method;
      if (method !== "get") {
        let msg = response.config["actionName"];
        _message(msg, true);
      }
      return response;
    },
    function (error) {
      console.dir(error);
      let msg =
        error.config["actionName"] + ". \n" + error.response?.data?.detail;
      if (msg) _message(msg, false);
      return Promise.reject(error);
    }
  );

  function _message(msg, status) {
    if (status) toast.success("Success -" + msg);
    else toast.error("Failed -" + msg);
  }
}
