import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import { Container, Table } from 'react-bootstrap';
import '../style/App.css';

export default function DisplayRestaurant() {
  const [restaurant, setRestaurant] = useState({});
  const [orders, setOrders] = useState([]);

  const { id } = useParams();
  const getRestaurant = (id) => {
    axios.get(`https://localhost:5420/restaurants/${id}`).then((response) => {
      setRestaurant(response.data);
    });
  };

  const getOrders = (id) => {
    axios
      .get(`https://localhost:5420/restaurants/${id}/orders`)
      .then((response) => {
        setOrders(response.data);
      });
  };
  useEffect(() => {
    getRestaurant(id);
    getOrders(id);
  }, []);

  return (
    <Container className="mt-3">
      <div className="restaurant-details">
        <h1>Restaurant</h1>
        <p>{restaurant.name}</p>
        <p>{restaurant.address}</p>
        <p>{restaurant.phoneNumber}</p>
        <p>{restaurant.email}</p>
      </div>
      <div className="restaurant-orders mt-3 table-responsive">
        <h1>Orders</h1>
        <Table responsive striped bordered hover variant="dark">
          <thead>
            <tr>
              <th>Item</th>
              <th>Description</th>
              <th>Quantity</th>
              <th>Price</th>
            </tr>
          </thead>
          <tbody>
            {orders?.map((order) => (
              <tr key={order.id}>
                <td>{order.item}</td>
                <td>{order.description}</td>
                <td>{order.quantity}</td>
                <td>{order.price}</td>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    </Container>
  );
}
