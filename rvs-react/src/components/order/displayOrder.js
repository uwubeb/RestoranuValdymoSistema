import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import { Container, Table, Row } from 'react-bootstrap';
import '../style/App.css';

export default function DisplayOrder() {
  const [order, setOrder] = useState({});
  const [notes, setNotes] = useState([]);
  const [showDelete, setShowDelete] = useState(false);

  const { restaurantId, orderId } = useParams();

  const navigate = useNavigate();

  const handleShowDelete = () => setShowDelete(true);
  const handleCloseDelete = () => setShowDelete(false);
  const handleDelete = () => {
    axios
      .delete(
        `https://localhost:5420/restaurants/${restaurantId}/orders/${orderId}`
      )
      .then((response) => {
        navigate('/restaurants');
      });
  };
  const getOrder = (restaurantId, orderId) => {
    axios
      .get(
        `https://localhost:5420/restaurants/${restaurantId}/orders/${orderId}`
      )
      .then((response) => {
        setOrder(response.data);
      });
  };

  const getNotes = (restaurantId, orderId) => {
    axios
      .get(
        `https://localhost:5420/restaurants/${restaurantId}/orders/${orderId}/notes`
      )
      .then((response) => {
        setNotes(response.data);
      });
  };

  useEffect(() => {
    getOrder(restaurantId, orderId);
    getNotes(restaurantId, orderId);
  }, []);

  return (
    <Container className="mt-3">
      <Modal show={showDelete} onHide={handleCloseDelete}>
        <Modal.Header closeButton>
          <Modal.Title>Modal heading</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          Are you sure you want to delete order {order.name}{' '}
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
        <h1>Order</h1>
        <p>{order.item}</p>
        <p>{order.description}</p>
        <p>{order.quantity}</p>
        <p>{order.price}</p>
        <div className="restaurant-buttons">
          <Button
            variant="primary"
            onClick={() =>
              navigate(`/restaurants/${restaurantId}/orders/${orderId}/update`)
            }
          >
            Edit
          </Button>
          <Button variant="danger" onClick={() => handleShowDelete()}>
            Delete
          </Button>
        </div>
      </div>

      <div className="restaurant-orders mt-3 table-responsive">
        <h1>Notes</h1>
        <Table responsive striped bordered hover variant="dark">
          <thead>
            <tr>
              <th>Text</th>
            </tr>
          </thead>
          <tbody>
            {notes?.map((note) => (
              <tr key={note.id}>
                <td>{note.text}</td>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    </Container>
  );
}
