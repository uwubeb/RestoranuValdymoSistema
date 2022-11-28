import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import { Container } from 'react-bootstrap';
import '../style/App.css';

export default function DisplayRestaurant() {
  const [restaurant, setRestaurant] = useState({});

  const { id } = useParams();
  const getRestaurant = (id) => {
    axios.get(`https://localhost:5420/restaurants/${id}`).then((response) => {
      setRestaurant(response.data);
    });
  };
  useEffect(() => {
    getRestaurant(id);
  }, []);

  return (
    <Container>
      <h1>Restaurant</h1>
      <p>{restaurant.name}</p>
      <p>{restaurant.address}</p>
      <p>{restaurant.city}</p>
      <p>{restaurant.state}</p>
      <p>{restaurant.telephone}</p>
      <p>{restaurant.genre}</p>
    </Container>
  );
}
