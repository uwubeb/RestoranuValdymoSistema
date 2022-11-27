import CreateRestaurant from './restaurant/createRestaurant';
import './style/App.css';

function App() {
  return (
    <div className="main">
      <h2 className="main-header">Restoranų valdymo sistema</h2>
      <div>
        <CreateRestaurant />
      </div>
    </div>
  );
}

export default App;
