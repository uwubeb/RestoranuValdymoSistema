import * as React from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import { useEffect, useState } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import { Container } from 'react-bootstrap';

export default function UpdateRestaurant() {
  const { id } = useParams();
  const [name, setName] = useState('');
  const [address, setAddress] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [email, setEmail] = useState('');
  const [validated, setValidated] = useState(false);

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

  useEffect(() => {
    axios.get(`https://localhost:5420/restaurants/${id}`).then((response) => {
      setName(response.data.name);
      setAddress(response.data.address);
      setPhoneNumber(response.data.phoneNumber);
      setEmail(response.data.email);
    });
  }, [id]);

  const postData = () => {
    axios.put(`https://localhost:5420/restaurants`, {
      id,
      name,
      address,
      phoneNumber,
      email,
    });
    navigate('/restaurants');
  };

  return (
    <Container className="create-form ">
      <Form noValidate validated={validated} onSubmit={handleSubmit}>
        <Form.Group controlId="validationCustom01" className="mt-3">
          <Form.Label>Name</Form.Label>
          <Form.Control
            required
            type="text"
            value={name}
            placeholder="Name"
            onChange={(e) => setName(e.target.value)}
          />
        </Form.Group>
        <Form.Group controlId="validationCustom02" className="mt-3">
          <Form.Label>Address</Form.Label>
          <Form.Control
            required
            value={address}
            type="text"
            placeholder="Address"
            onChange={(e) => setAddress(e.target.value)}
          />
        </Form.Group>
        <Form.Group controlId="validationCustom03" className="mt-3">
          <Form.Label>Phone Number</Form.Label>
          <Form.Control
            required
            value={phoneNumber}
            type="tel"
            placeholder="Phone Number"
            onChange={(e) => setPhoneNumber(e.target.value)}
          />
        </Form.Group>
        <Form.Group controlId="validationCustom04" className="mt-3">
          <Form.Label>Email</Form.Label>
          <Form.Control
            required
            value={email}
            type="email"
            placeholder="Email"
            onChange={(e) => setEmail(e.target.value)}
          />
        </Form.Group>

        <Button className="mt-3" type="submit">
          Submit
        </Button>
      </Form>
    </Container>
  );
}
