import React from 'react';
import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';
import axios from 'axios';
import { useEffect, useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';

export default function ListRestaurants() {
  const [restaurants, setRestaurants] = useState([]);
  const navigate = useNavigate();
  useEffect(() => {
    axios
      .get(
        `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants`
      )
      .then((response) => {
        setRestaurants(response.data);
      });
  }, []);
  const getData = () => {
    axios
      .get(
        `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants`
      )
      .then((response) => {
        setRestaurants(response.data);
      });
  };
  const deleteRestaurant = (id) => {
    axios
      .delete(
        `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants/${id}`
      )
      .then((response) => {
        getData();
      });
  };

  const viewRestaurant = (id) => {
    navigate(`/restaurants/${id}`);
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
          </tr>
        </thead>

        <tbody>
          {restaurants.map((restaurant) => (
            <tr
              onClick={() => viewRestaurant(restaurant.id)}
              key={restaurant.id}
            >
              <td>{restaurant.id}</td>
              <td>{restaurant.name}</td>
              <td>{restaurant.address}</td>
              <td>{restaurant.phoneNumber}</td>
              <td>{restaurant.email}</td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
}
