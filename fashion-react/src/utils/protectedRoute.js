import React from "react";
import { Route } from "react-router-dom";
import { useSelector } from "react-redux";
import Login from "../pages/auth/Login";
import { toast } from "react-toastify";

export default function ProtectedRoute({
  children,
  component: Component,
  ...rest
}) {
  const user = useSelector((state) => state.auth.user);
  if (!user) toast.error("You need to login before continuing.");

  return user ? <Route {...rest} component={Component} /> : <Login />;
}
