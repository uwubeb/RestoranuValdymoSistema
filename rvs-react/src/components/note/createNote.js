import React, { useState } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import { useNavigate, useParams } from 'react-router';
import axios from 'axios';
import { Container } from 'react-bootstrap';
import '../style/App.css';

export default function CreateNote() {
  const [text, setText] = useState('');

  const [validated, setValidated] = useState(false);

  const { restaurantId, orderId } = useParams();

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
    axios.post(
      `https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurants/${restaurantId}/orders/${orderId}/notes`,
      {
        text,
      }
    );
    navigate(`/restaurants/${restaurantId}/orders/${orderId}`);
  };

  return (
    <Container className="create-form ">
      <Form validated={validated} onSubmit={handleSubmit}>
        <Form.Group controlId="validationCustom01" className="mt-3">
          <Form.Label>Text</Form.Label>
          <Form.Control
            required
            type="text"
            placeholder="Text"
            onChange={(e) => setText(e.target.value)}
          />
        </Form.Group>

        <Button className="mt-3" type="submit">
          Submit
        </Button>
      </Form>
    </Container>
  );
}
