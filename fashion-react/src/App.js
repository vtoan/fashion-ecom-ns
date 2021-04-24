import { BrowserRouter as Router } from "react-router-dom";
import Header from "./components/Header";
import Navigate from "./components/Navigate";
import PageLayout from "./containers/PageLayout";
import Routes from "./routes";
import React from "react";
//auth
import { Provider } from "react-redux";
import store from "./store";
import AuthProvider from "./utils/authProvider.js";
//
import userManager, { loadUserFromStorage } from "./services/authService";
import { fetchTypeProduct } from "./services/typeService";
import { fetchCategory } from "./services/cateService";
import "react-toastify/dist/ReactToastify.css";

function App() {
  React.useEffect(() => {
    // fetch current user from cookies
    loadUserFromStorage(store);
    fetchTypeProduct(store);
    fetchCategory(store);
  }, []);

  return (
    <Provider store={store}>
      <AuthProvider userManager={userManager} store={store}>
        <Router>
          <PageLayout
            header={<Header />}
            nav={<Navigate />}
            content={<Routes />}
          />
        </Router>
      </AuthProvider>
    </Provider>
  );
}

export default App;
