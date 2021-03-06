import { Link } from "react-router-dom";
import { Nav, NavItem, NavLink } from "reactstrap";

export default function Navigate() {
  return (
    <Nav vertical>
      <NavItem>
        <NavLink>
          <Link className="text-decoration-none" to="/products">
            Products
          </Link>
        </NavLink>
      </NavItem>
      <NavItem>
        <NavLink>
          <Link className="text-decoration-none" to="/categories">
            Categories
          </Link>
        </NavLink>
      </NavItem>
      <NavItem>
        <NavLink>
          <Link className="text-decoration-none" to="/users">
            Users
          </Link>
        </NavLink>
      </NavItem>
    </Nav>
  );
}
