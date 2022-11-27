import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import CreateRestaurant from './restaurant/createRestaurant';
import ListRestaurants from './restaurant/listRestaurants';
import UpdateRestaurant from './restaurant/updateRestaurant';
import './style/App.css';

function App() {
  return (
    <Router>
      <div className="main">
        <h2 className="main-header">Restoranų valdymo sistema</h2>
        <div>
          <Routes>
            <Route exact path="/create" element={<CreateRestaurant />} />
            <Route exact path="/list" element={<ListRestaurants />} />

            <Route exact path="/update" element={<UpdateRestaurant />} />
          </Routes>
        </div>
      </div>
    </Router>
  );
}

export default App;
