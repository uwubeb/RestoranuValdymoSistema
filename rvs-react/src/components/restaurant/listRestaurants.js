import React from 'react';
import { Table, Button } from 'semantic-ui-react';
import axios from 'axios';
import { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';

export default function ListRestaurants() {
  const [restaurants, setRestaurants] = useState([]);
  useEffect(() => {
    axios.get(`https://localhost:5420/restaurants`).then((response) => {
      setRestaurants(response.data);
    });
  }, []);
  const getData = () => {
    axios.get(`https://localhost:5420/restaurants`).then((response) => {
      setRestaurants(response.data);
    });
  };
  const deleteRestaurant = (id) => {
    axios
      .delete(`https://localhost:5420/restaurants/${id}`)
      .then((response) => {
        getData();
      });
  };
  return (
    <div>
      <Table singleLine>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Id</Table.HeaderCell>
            <Table.HeaderCell>Name</Table.HeaderCell>
            <Table.HeaderCell>Address</Table.HeaderCell>
            <Table.HeaderCell>Phone Number</Table.HeaderCell>
            <Table.HeaderCell>Email</Table.HeaderCell>
            <Table.HeaderCell>Update</Table.HeaderCell>
            <Table.HeaderCell>Delete</Table.HeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>
          {restaurants.map((restaurant) => (
            <Table.Row key={restaurant.id}>
              <Table.Cell>{restaurant.id}</Table.Cell>
              <Table.Cell>{restaurant.name}</Table.Cell>
              <Table.Cell>{restaurant.address}</Table.Cell>
              <Table.Cell>{restaurant.phoneNumber}</Table.Cell>
              <Table.Cell>{restaurant.email}</Table.Cell>
              <Link to={`/update/${restaurant.id}`}>
                <Table.Cell>
                  <Button>Update</Button>
                </Table.Cell>
              </Link>
              <Table.Cell>
                <Button onClick={() => deleteRestaurant(restaurant.id)}>
                  Delete
                </Button>
              </Table.Cell>
            </Table.Row>
          ))}
        </Table.Body>
      </Table>
    </div>
  );
}
