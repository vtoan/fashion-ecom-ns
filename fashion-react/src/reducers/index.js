import { combineReducers } from "redux";
import authReducer from "./authReducer";
import fetchReducer from "./fetchReducer";

export default combineReducers({
  auth: authReducer,
  fetchData: fetchReducer,
});
