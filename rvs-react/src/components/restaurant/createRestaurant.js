import React, { useState } from 'react';
import { Button, Form } from 'semantic-ui-react';
import { useNavigate } from 'react-router';
import axios from 'axios';

export default function CreateRestaurant() {
  const [name, setName] = useState('');
  const [address, setAddress] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [email, setEmail] = useState('');

  let navigate = useNavigate();
  const postData = () => {
    axios
      .post(`https://localhost:5420/restaurants`, {
        name,
        address,
        phoneNumber,
        email,
      })
      .then((response) => {
        navigate('/list');
      });
  };

  return (
    <Form className="create-form">
      <Form.Field>
        <label>Name</label>
        <input placeholder="Name" onChange={(e) => setName(e.target.value)} />
      </Form.Field>
      <Form.Field>
        <label>Address</label>
        <input
          placeholder="Address"
          onChange={(e) => setAddress(e.target.value)}
        />
      </Form.Field>
      <Form.Field>
        <label>Phone Number</label>
        <input
          placeholder="Phone Number"
          onChange={(e) => setPhoneNumber(e.target.value)}
        />
      </Form.Field>
      <Form.Field>
        <label>Email</label>
        <input placeholder="Email" onChange={(e) => setEmail(e.target.value)} />
      </Form.Field>
      <Button type="submit" onClick={postData}>
        Submit
      </Button>
    </Form>
  );
}
