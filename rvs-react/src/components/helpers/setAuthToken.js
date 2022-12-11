import axios from 'axios';

export const setAuthToken = (token) => {
  if (token !== null) {
    axios.defaults.headers.common['Authorization'] = `Bearer ${token}`;
  } else delete axios.defaults.headers.common['Authorization'];
};
