import React, { useState, useEffect } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import { useNavigate, useParams } from 'react-router';
import axios from 'axios';
import { Container } from 'react-bootstrap';
import '../style/App.css';

export default function UpdateNote() {
  const [text, setText] = useState('');

  const [validated, setValidated] = useState(false);

  const { restaurantId, orderId, noteId } = useParams();

  useEffect(() => {
    axios
      .get(
        `https://localhost:5420/restaurants/${restaurantId}/orders/${orderId}/notes/${noteId}`
      )
      .then((response) => {
        setText(response.data.text);
      });
  }, []);

  const handleSubmit = (event) => {
    const form = event.currentTarget;
    if (form.checkValidity() === false) {
      event.preventDefault();
      event.stopPropagation();
    }
    putData();
    setValidated(true);
  };

  let navigate = useNavigate();

  const putData = () => {
    console.log('put');
    axios.put(
      `https://localhost:5420/restaurants/${restaurantId}/orders/${orderId}/notes`,
      {
        id: noteId,
        text,
      }
    );
    console.log(restaurantId);
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
            value={text}
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
