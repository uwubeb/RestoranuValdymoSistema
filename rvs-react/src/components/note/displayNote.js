import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import { Container, Table, Row, Spinner } from 'react-bootstrap';
import '../style/App.css';

export default function DisplayNote() {
  const [note, setNote] = useState({});
  const [showDelete, setShowDelete] = useState(false);

  const { restaurantId, orderId, noteId } = useParams();

  const [loading, setLoading] = useState(true);

  const navigate = useNavigate();

  const handleShowDelete = () => setShowDelete(true);
  const handleCloseDelete = () => setShowDelete(false);
  const handleDelete = () => {
    axios
      .delete(
        `https://localhost:5420/restaurants/${restaurantId}/orders/${orderId}/notes/${noteId}`
      )
      .then((response) => {
        navigate('/restaurants');
      });
  };
  const getNote = (restaurantId, orderId, noteId) => {
    axios
      .get(
        `https://localhost:5420/restaurants/${restaurantId}/orders/${orderId}/notes/${noteId}`
      )
      .then((response) => {
        setNote(response.data);
        setLoading(false);
      });
  };

  useEffect(() => {
    getNote(restaurantId, orderId, noteId);
  }, []);

  return (
    <Container className="mt-3">
      <Modal show={showDelete} onHide={handleCloseDelete}>
        <Modal.Header closeButton>
          <Modal.Title>Delete</Modal.Title>
        </Modal.Header>
        <Modal.Body>Are you sure you want to delete this note?</Modal.Body>
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
        <h1>Note</h1>
        <Spinner animation="border" role="status" hidden={!loading}>
          <span className="sr-only loader">Loading...</span>
        </Spinner>
        <p>{note.text}</p>
        <div className="restaurant-buttons">
          <Button
            variant="primary"
            onClick={() =>
              navigate(
                `/restaurants/${restaurantId}/orders/${orderId}/notes/${noteId}/update`
              )
            }
          >
            Edit
          </Button>
          <Button variant="danger" onClick={() => handleShowDelete()}>
            Delete
          </Button>
        </div>
      </div>
    </Container>
  );
}
