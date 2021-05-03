import { UserManager } from "oidc-client";
import { storeUserError, storeUser } from "../actions/authAction";
import { host, client } from "../config";

const config = {
  authority: host,
  client_id: "spa",
  redirect_uri: client + "/signin-oidc",
  response_type: "id_token token",
  scope: "openid profile fashion.client",
  post_logout_redirect_uri: client + "/signout-oidc",
};

const userManager = new UserManager(config);

export async function loadUserFromStorage(store) {
  try {
    let user = await userManager.getUser();
    console.log(user);
    if (!user) {
      return store.dispatch(storeUserError());
    }
    store.dispatch(storeUser(user));
  } catch (e) {
    console.error(`User not found: ${e}`);
    store.dispatch(storeUserError());
  }
}

export function signinRedirect() {
  return userManager.signinRedirect();
}

export function signinRedirectCallback() {
  return userManager.signinRedirectCallback();
}

export function signoutRedirect() {
  userManager.clearStaleState();
  userManager.removeUser();
  return userManager.signoutRedirect();
}

export function signoutRedirectCallback() {
  userManager.clearStaleState();
  userManager.removeUser();
  return userManager.signoutRedirectCallback();
}

export default userManager;
