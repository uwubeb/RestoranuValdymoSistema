import React, { useState, useEffect } from 'react';
import { Form, Button, Container, Row, Col, Spinner } from 'react-bootstrap';

function RegistrationForm() {
  const [items, setItems] = useState(null);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    // Use the fetch API to get the items from the API endpoint
    setIsLoading(true);
    fetch('https://localhost:5420/restaurants')
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
              <Form>
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
                  </Form.Control>
                </Form.Group>
                <Form.Group>
                  <Form.Label>First name</Form.Label>
                  <Form.Control
                    required
                    name="name"
                    type="firstName"
                    placeholder="Enter first name"
                  />
                </Form.Group>
                <Form.Group>
                  <Form.Label>Last name</Form.Label>
                  <Form.Control
                    required
                    name="lastName"
                    type="lastName"
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
                    name="phone"
                    type="phone"
                    placeholder="Enter phone"
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
