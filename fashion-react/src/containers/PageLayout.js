import { Col, Container, Row } from "reactstrap";
import { ToastContainer } from "react-toastify";
import { useSelector } from "react-redux";

export default function PageLayout({ header, nav, content }) {
  const user = useSelector((state) => state.auth.user);

  return (
    <Container fluid={true}>
      <div className="p-3">{header}</div>
      <Row className="h-100">
        <Col className="pt-3" xs={2}>
          {user && nav}
        </Col>
        <Col className="p-4" style={{ backgroundColor: "#fafafa" }} xs={10}>
          <div className="bg-white h-100 rounded p-3">{content}</div>
        </Col>
      </Row>
      <ToastContainer
        position="bottom-right"
        autoClose={3000}
        hideProgressBar
      />
    </Container>
  );
}
