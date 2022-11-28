import React from 'react';
import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';
import axios from 'axios';
import { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';

export default function ListRestaurants() {
  const [restaurants, setRestaurants] = useState([]);
  useEffect(() => {
    axios.get(`https://localhost:5420/restaurants`).then((response) => {
      setRestaurants(response.data);
    });
  }, []);
  const getData = () => {
    axios.get(`https://localhost:5420/restaurants`).then((response) => {
      setRestaurants(response.data);
    });
  };
  const deleteRestaurant = (id) => {
    axios
      .delete(`https://localhost:5420/restaurants/${id}`)
      .then((response) => {
        getData();
      });
  };
  return (
    <div>
      <div className="m-3">
        <h1 className="text-center">Restaurants</h1>
        <Link to="/restaurants/create">
          <Button variant="success">Create</Button>
        </Link>
      </div>
      <Table responsive="lg" striped bordered hover variant="dark">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Address</th>
            <th>Phone Number</th>
            <th>Email</th>
            <th>Update</th>
            <th>Delete</th>
          </tr>
        </thead>

        <tbody>
          {restaurants.map((restaurant) => (
            <tr key={restaurant.id}>
              <td>{restaurant.id}</td>
              <td>{restaurant.name}</td>
              <td>{restaurant.address}</td>
              <td>{restaurant.phoneNumber}</td>
              <td>{restaurant.email}</td>
              <td>
                <Link to={`/restaurants/update/${restaurant.id}`}>
                  <Button variant="warning">Update</Button>
                </Link>
              </td>
              <td>
                <Button
                  variant="danger"
                  onClick={() => deleteRestaurant(restaurant.id)}
                >
                  Delete
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
}
