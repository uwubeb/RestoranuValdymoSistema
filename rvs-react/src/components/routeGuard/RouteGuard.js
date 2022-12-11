import React from 'react';
import { Route, Navigate, useLocation, Outlet } from 'react-router-dom';

export const Guard = ({ token, routeRedirect }) => {
  const location = useLocation();

  return localStorage.getItem(token) ? (
    <Outlet />
  ) : (
    <Navigate to={routeRedirect} replace state={{ from: location }} />
  );
};
