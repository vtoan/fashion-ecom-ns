import React from "react";
import { Col, Row } from "reactstrap";
import SingleLayout from "./SingleLayout";

export default function SplitLayout({ title, actions, right, left }) {
  return (
    <SingleLayout
      title={title}
      actions={actions}
      content={
        <Row>
          <Col xs="6">{right}</Col>
          <Col xs={{ size: 5, offset: 1 }}>{left}</Col>
        </Row>
      }
    />
  );
}
