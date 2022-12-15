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
import DisplayOrder from './order/displayOrder';
import CreateOrder from './order/createOrder';
import UpdateOrder from './order/updateOrder';
import DisplayNote from './note/displayNote';
import CreateNote from './note/createNote';
import UpdateNote from './note/updateNote';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import Footer from './footer/footer';

function App() {
  //check jwt token
  const token = localStorage.getItem('token');
  if (token) {
    setAuthToken(token);
  }
  return (
    <Router>
      <div className="wrapper">
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
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/:restaurantId/orders/:orderId"
                element={<DisplayOrder />}
              />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/:restaurantId/orders/create"
                element={<CreateOrder />}
              />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/:restaurantId/orders/:orderId/update"
                element={<UpdateOrder />}
              />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/:restaurantId/orders/:orderId/notes/:noteId"
                element={<DisplayNote />}
              />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/:restaurantId/orders/:orderId/notes/create"
                element={<CreateNote />}
              />
            </Route>
            <Route element={<Guard token="token" routeRedirect="/login" />}>
              <Route
                exact
                path="/restaurants/:restaurantId/orders/:orderId/notes/:noteId/update"
                element={<UpdateNote />}
              />
            </Route>
            <Route exact path="/login" element={<LoginForm />} />
            <Route exact path="/register" element={<RegistrationForm />} />
          </Routes>
        </div>
        <Footer />
      </div>
    </Router>
  );
}

export default App;
