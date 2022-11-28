import * as React from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import { useEffect, useState } from 'react';
import { Button, Form } from 'semantic-ui-react';

export default function UpdateRestaurant() {
  const { id } = useParams();
  const [name, setName] = useState('');
  const [address, setAddress] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [email, setEmail] = useState('');

  let navigate = useNavigate();

  useEffect(() => {
    axios.get(`https://localhost:5420/restaurants/${id}`).then((response) => {
      setName(response.data.name);
      setAddress(response.data.address);
      setPhoneNumber(response.data.phoneNumber);
      setEmail(response.data.email);
    });
  }, [id]);

  const updateData = () => {
    axios
      .put(`https://localhost:5420/restaurants`, {
        id,
        name,
        address,
        phoneNumber,
        email,
      })
      .then((response) => {
        navigate('/restaurants');
      });
  };

  return (
    <div>
      <Form className="create-form">
        <Form.Field>
          <label>Name</label>
          <input
            placeholder="Name"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
        </Form.Field>
        <Form.Field>
          <label>Address</label>
          <input
            placeholder="Address"
            value={address}
            onChange={(e) => setAddress(e.target.value)}
          />
        </Form.Field>
        <Form.Field>
          <label>Phone Number</label>
          <input
            placeholder="Phone Number"
            value={phoneNumber}
            onChange={(e) => setPhoneNumber(e.target.value)}
          />
        </Form.Field>
        <Form.Field>
          <label>Email</label>
          <input
            placeholder="Email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </Form.Field>
        <Button type="submit" onClick={updateData}>
          Submit
        </Button>
      </Form>
    </div>
  );
}
