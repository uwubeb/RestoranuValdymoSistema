import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import RVSNavbar from './navbar/rvsNavbar';
import CreateRestaurant from './restaurant/createRestaurant';
import ListRestaurants from './restaurant/listRestaurants';
import UpdateRestaurant from './restaurant/updateRestaurant';
import '../index.css';
import DisplayRestaurant from './restaurant/displayRestaurant';

function App() {
  return (
    <Router>
      <div>
        <RVSNavbar></RVSNavbar>
        <div>
          <Routes>
            <Route
              exact
              path="/restaurants/create"
              element={<CreateRestaurant />}
            />
            <Route exact path="/restaurants" element={<ListRestaurants />} />
            <Route
              exact
              path="/restaurants/update/:id"
              element={<UpdateRestaurant />}
            />
            <Route
              exact
              path="restaurants/:id"
              element={<DisplayRestaurant />}
            />
          </Routes>
        </div>
      </div>
    </Router>
  );
}

export default App;
