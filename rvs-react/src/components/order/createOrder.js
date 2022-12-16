import React, { useState } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import { useNavigate, useParams } from 'react-router';
import axios from 'axios';
import { Container } from 'react-bootstrap';
import '../style/App.css';

export default function CreateOrder() {
  const [item, setItem] = useState('');
  const [description, setDescription] = useState('');
  const [quantity, setQuantity] = useState(0);
  const [price, setPrice] = useState(0.0);

  const [validated, setValidated] = useState(false);

  const { restaurantId } = useParams();

  const handleSubmit = (event) => {
    const form = event.currentTarget;
    if (form.checkValidity() === false) {
      event.preventDefault();
      event.stopPropagation();
    }
    postData();
    setValidated(true);
  };

  let navigate = useNavigate();

  const postData = () => {
    axios
      .post(
        `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants/${restaurantId}/orders`,
        {
          item,
          description,
          quantity,
          price,
        }
      )
      .then((response) => {
        navigate(`/restaurants/${restaurantId}`);
      });
  };

  return (
    <Container className="create-form ">
      <Form validated={validated} onSubmit={handleSubmit}>
        <Form.Group controlId="validationCustom01" className="mt-3">
          <Form.Label>Item</Form.Label>
          <Form.Control
            required
            type="text"
            placeholder="Item"
            onChange={(e) => setItem(e.target.value)}
          />
        </Form.Group>
        <Form.Group controlId="validationCustom02" className="mt-3">
          <Form.Label>Description</Form.Label>
          <Form.Control
            required
            type="text"
            placeholder="description"
            onChange={(e) => setDescription(e.target.value)}
          />
        </Form.Group>
        <Form.Group controlId="validationCustom03" className="mt-3">
          <Form.Label>Quantity</Form.Label>
          <Form.Control
            required
            type="number"
            placeholder="quantity"
            onChange={(e) => setQuantity(e.target.value)}
          />
        </Form.Group>
        <Form.Group controlId="validationCustom04" className="mt-3">
          <Form.Label>Price</Form.Label>
          <Form.Control
            required
            type="number"
            placeholder="price"
            onChange={(e) => setPrice(e.target.value)}
          />
        </Form.Group>

        <Button className="mt-3" type="submit">
          Submit
        </Button>
      </Form>
    </Container>
  );
}
