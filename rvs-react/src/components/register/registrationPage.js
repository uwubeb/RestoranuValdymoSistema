import axios from 'axios';
import React, { useState, useEffect } from 'react';
import { Form, Button, Container, Row, Col, Spinner } from 'react-bootstrap';

function RegistrationForm() {
  const [items, setItems] = useState(null);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    // Use the fetch API to get the items from the API endpoint
    setIsLoading(true);
    fetch(
      'https://restoranuvaldymosistema20221216125610.azurewebsites.net/restaurantList'
    )
      .then((response) => response.json())
      .then((data) => {
        setItems(data);
        setIsLoading(false);
      })
      .catch((error) => {
        // Handle any errors that occurred during the request
        console.error(error);
        setIsLoading(false);
      });
  }, []);

  const handleSubmit = (event) => {
    event.preventDefault();
    const formData = new FormData(event.target);
    const username = formData.get('username');
    const password = formData.get('password');
    const role = formData.get('role');
    const name = formData.get('name');
    const surname = formData.get('surname');
    const email = formData.get('email');
    const phoneNumber = formData.get('phoneNumber');
    // const restaurantIds = formData.get('restaurantIds');
    // get checked restaurant ids
    const restaurantIds = [];
    const checkboxes = document.querySelectorAll(
      'input[type=checkbox]:checked'
    );
    checkboxes.forEach((checkbox) => {
      restaurantIds.push(checkbox.value);
    });

    console.log(restaurantIds);

    const registerRequest = {
      username,
      password,
      role,
      name,
      surname,
      email,
      phoneNumber,
      restaurantIds,
    };

    axios
      .post(
        'https://restoranuvaldymosistema20221216125610.azurewebsites.net/register',
        registerRequest
      )
      .then((response) => {
        //redirect user to home page
        window.location.href = '/login';
      })
      .catch((err) => console.log(err));
  };

  return (
    <div>
      <Container className="create-form ">
        <Row>
          <Col xs={12}>
            {isLoading ? (
              // Show a spinner while the items are being fetched
              <Spinner animation="border" role="status">
                <span className="sr-only">Loading...</span>
              </Spinner>
            ) : (
              <Form onSubmit={handleSubmit}>
                <Form.Group>
                  <Form.Label>Username</Form.Label>
                  <Form.Control
                    required
                    name="username"
                    type="username"
                    placeholder="Enter username"
                  />
                </Form.Group>
                <Form.Group>
                  <Form.Label>Password</Form.Label>
                  <Form.Control
                    name="password"
                    required
                    type="password"
                    placeholder="Password"
                  />
                </Form.Group>
                <Form.Group>
                  <Form.Label>Select role</Form.Label>
                  <Form.Control as="select" name="role">
                    <option value="user">User</option>
                    <option value="admin">Admin</option>
                    <option value="superadmin">Superadmin</option>
                  </Form.Control>
                </Form.Group>
                <Form.Group>
                  <Form.Label>First name</Form.Label>
                  <Form.Control
                    required
                    name="name"
                    type="text"
                    placeholder="Enter first name"
                  />
                </Form.Group>
                <Form.Group>
                  <Form.Label>Last name</Form.Label>
                  <Form.Control
                    required
                    name="surname"
                    type="text"
                    placeholder="Enter last name"
                  />
                </Form.Group>
                <Form.Group>
                  <Form.Label>Email</Form.Label>
                  <Form.Control
                    required
                    name="email"
                    type="email"
                    placeholder="Enter email"
                  />
                </Form.Group>
                <Form.Group>
                  <Form.Label>Phone</Form.Label>
                  <Form.Control
                    required
                    name="phoneNumber"
                    type="phone"
                    placeholder="Enter phone number"
                  />
                </Form.Group>
                {items && (
                  <Form.Group>
                    <Form.Label>Select restaurants</Form.Label>
                    {items.map((item) => (
                      <Form.Check
                        key={item.id}
                        type="checkbox"
                        label={item.name}
                        value={item.id}
                        id={`item-${item.id}`}
                      />
                    ))}
                  </Form.Group>
                )}
                <Button variant="primary" type="submit">
                  Register
                </Button>
              </Form>
            )}
          </Col>
        </Row>
      </Container>
    </div>
  );
}

export default RegistrationForm;
