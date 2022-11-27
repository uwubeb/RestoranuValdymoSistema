import React, { useState } from 'react';
import { Button, Form } from 'semantic-ui-react';
import axios from 'axios';

export default function CreateRestaurant() {
  const [name, setName] = useState('');
  const [address, setAddress] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [email, setEmail] = useState('');
  const postData = () => {
    axios.post(`https://60fbca4591156a0017b4c8a7.mockapi.io/fakeData`, {
      name,
      address,
      phoneNumber,
      email,
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
