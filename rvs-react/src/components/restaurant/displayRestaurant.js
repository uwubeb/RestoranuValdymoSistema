import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import { Container, Table, Row, Spinner } from 'react-bootstrap';
import '../style/App.css';

export default function DisplayRestaurant() {
  const [restaurant, setRestaurant] = useState({});
  const [orders, setOrders] = useState([]);
  const [showDelete, setShowDelete] = useState(false);
  const [loading, setLoading] = useState(true);

  const { id } = useParams();
  const navigate = useNavigate();

  const handleShowDelete = () => setShowDelete(true);
  const handleCloseDelete = () => setShowDelete(false);
  const handleDelete = () => {
    axios
      .delete(
        `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants/${id}`
      )
      .then((response) => {
        navigate('/restaurants');
      });
  };
  const getRestaurant = (id) => {
    axios
      .get(
        `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants/${id}`
      )
      .then((response) => {
        setRestaurant(response.data);
      });
  };

  const getOrders = (id) => {
    axios
      .get(
        `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants/${id}/orders`
      )
      .then((response) => {
        setOrders(response.data);
        setLoading(false);
      });
  };
  useEffect(() => {
    getRestaurant(id);
    getOrders(id);
  }, []);

  const viewOrder = (orderId) => {
    navigate(`/restaurants/${id}/orders/${orderId}`);
  };
  return (
    <Container className="mt-3">
      <Modal show={showDelete} onHide={handleCloseDelete}>
        <Modal.Header closeButton>
          <Modal.Title>Modal heading</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          Are you sure you want to delete restaurant {restaurant.name}{' '}
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={handleCloseDelete}>
            Close
          </Button>
          <Button variant="primary" onClick={handleDelete}>
            Delete
          </Button>
        </Modal.Footer>
      </Modal>
      <div className="restaurant-details">
        <h1>Restaurant</h1>
        <p>{restaurant.name}</p>
        <p>{restaurant.address}</p>
        <p>{restaurant.phoneNumber}</p>
        <p>{restaurant.email}</p>
        <div className="restaurant-buttons">
          <Button
            variant="primary"
            onClick={() => navigate(`/restaurants/update/${id}`)}
          >
            Edit
          </Button>
          <Button variant="danger" onClick={() => handleShowDelete(id)}>
            Delete
          </Button>
        </div>
      </div>

      <div className="restaurant-orders mt-3 table-responsive">
        <h1>Orders</h1>
        <Spinner animation="border" role="status" hidden={!loading}>
          <span className="sr-only loader">Loading...</span>
        </Spinner>
        <Button
          className="mb-3"
          variant="primary"
          onClick={() => navigate(`/restaurants/${id}/orders/create`)}
        >
          Create order
        </Button>
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
              <tr onClick={() => viewOrder(order.id)} key={order.id}>
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
