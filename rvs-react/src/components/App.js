import React from 'react';
import {
  BrowserRouter as Router,
  Navigate,
  Route,
  Routes,
} from 'react-router-dom';
import RVSNavbar from './navbar/rvsNavbar';
import CreateRestaurant from './restaurant/createRestaurant';
import ListRestaurants from './restaurant/listRestaurants';
import UpdateRestaurant from './restaurant/updateRestaurant';
import '../index.css';
import DisplayRestaurant from './restaurant/displayRestaurant';

import { history } from './helpers/history';
import { Guard } from './routeGuard/RouteGuard';
import LoginForm from './login/loginPage';
import { setAuthToken } from './helpers/setAuthToken';
import RegistrationForm from './register/registrationPage';

function App() {
  //check jwt token
  const token = localStorage.getItem('token');
  if (token) {
    setAuthToken(token);
  }
  return (
    <Router>
      <div>
        <RVSNavbar></RVSNavbar>
        <div>
          <Routes history={history}>
            <Route path="/" element={<Navigate to="/restaurants" replace />} />
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/create"
                element={<CreateRestaurant />}
              />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route exact path="/restaurants" element={<ListRestaurants />} />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/update/:id"
                element={<UpdateRestaurant />}
              />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="restaurants/:id"
                element={<DisplayRestaurant />}
              />
            </Route>
            <Route exact path="/login" element={<LoginForm />} />
            <Route exact path="/register" element={<RegistrationForm />} />
          </Routes>
        </div>
      </div>
    </Router>
  );
}

export default App;
