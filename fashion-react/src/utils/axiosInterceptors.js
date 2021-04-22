import axios from "axios";
import { toast } from "react-toastify";

export default function Interceptor() {
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
      let msg = error.config["actionName"];
      if (msg) _message(msg, false);
      return Promise.reject(error);
    }
  );

  function _message(msg, status) {
    if (status) toast.success(msg + " success");
    else toast.error(msg + " failed");
  }
}
