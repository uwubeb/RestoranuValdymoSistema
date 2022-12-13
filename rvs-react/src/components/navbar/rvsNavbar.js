import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { setAuthToken } from '../helpers/setAuthToken';

function RVSNavbar() {
  const logout = () => {
    localStorage.removeItem('token');
    setAuthToken(null);
    window.location.href = '/login';
  };

  const hidden = localStorage.getItem('token') ? false : true;

  return (
    <Navbar bg="dark" variant="dark" expand="lg">
      <Container>
        <Navbar.Brand href="#home">RVS</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link href="/restaurants">Restaurants</Nav.Link>
            <Nav.Link href="/login" hidden={!hidden}>
              Login
            </Nav.Link>
            <Nav.Link href="/register" hidden={!hidden}>
              Register
            </Nav.Link>
            <Nav.Link onClick={logout} hidden={hidden}>
              Logout
            </Nav.Link>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}

export default RVSNavbar;
