import axios from 'axios';
import React from 'react';
import { Form, Button, Container, Row, Col } from 'react-bootstrap';
import { setAuthToken } from '../helpers/setAuthToken';

function LoginForm() {
  const handleSubmit = (event) => {
    event.preventDefault();
    const formData = new FormData(event.target);
    const username = formData.get('username');
    const password = formData.get('password');

    const loginPayload = {
      username,
      password,
    };

    axios
      .post('https://localhost:5420/login', loginPayload)
      .then((response) => {
        //get token from response
        const token = response.data;
        //set JWT token to local
        localStorage.setItem('token', token);

        //set token to axios common header
        setAuthToken(token);

        //redirect user to home page
        window.location.href = '/';
      })
      .catch((err) => console.log(err));
  };

  return (
    <div>
      <Container className="create-form ">
        <Row>
          <Col xs={12}>
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
              <Button variant="primary" type="submit">
                Submit
              </Button>
            </Form>
          </Col>
        </Row>
      </Container>
    </div>
  );
}

export default LoginForm;
