import { SET_CATEGORY, SET_TYPE_PRODUCT } from "./types";

export function setTypeProduct(data) {
  return {
    type: SET_TYPE_PRODUCT,
    payload: data,
  };
}

export function setCategory(data) {
  return {
    type: SET_CATEGORY,
    payload: data,
  };
}
