import { SET_CATEGORY, SET_TYPE_PRODUCT } from "../actions/types";

export default function fetchReducer(state = [], action) {
  switch (action.type) {
    case SET_TYPE_PRODUCT:
      return { ...state, listTypes: action.payload };
    case SET_CATEGORY:
      return { ...state, listCates: action.payload };
    default:
      return state;
  }
}
