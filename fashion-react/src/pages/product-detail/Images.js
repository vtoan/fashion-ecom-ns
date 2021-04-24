import React from "react";
import { Button, Col, Row, Input, FormGroup } from "reactstrap";
import ProductImage from "../../components/ProductImage";

import _proSer from "../../services/productService";

export default function Images({ productId, productImage }) {
  const [imageDefault, setDefault] = React.useState(productImage);
  const [imageUpload, setImageUpload] = React.useState(null);
  const [listImages, setImages] = React.useState([]);

  React.useEffect(() => {
    _proSer.getListImages(productId).then(({ data }) => {
      setImages(data);
      setDefault(productImage);
    });
  }, [productId, productImage]);

  //handle
  const handleChangeFile = (e) => setImageUpload(e.target.files[0]);

  const handleUpload = () => {
    let result = window.confirm("Add the new item?");
    if (result)
      _proSer.uploadImage(productId, imageUpload).then(({ data }) => {
        setImages([...listImages, productId + "/" + data]);
      });
  };

  const handleChangeDefault = (imageName) => {
    let result = window.confirm("Change to this item?");
    if (result)
      _proSer.changeImageDefault(productId, imageName).then(() => {
        setDefault(imageName);
      });
  };

  const handleRemove = (imageName) => {
    let result = window.confirm("Delete this item?");
    if (result)
      _proSer.removeImage(productId, imageName).then(() => {
        setImages(listImages.filter((img) => img !== imageName));
      });
  };

  return (
    <>
      <h5>Images</h5>
      <FormGroup row className="mb-3">
        <Col sm={8}>
          <Input type="file" name="image" onChange={handleChangeFile} />
        </Col>
        <Col sm={4} className="text-right">
          <Button
            disabled={!imageUpload}
            color="success"
            onClick={handleUpload}
          >
            Upload
          </Button>
        </Col>
      </FormGroup>
      <Row>
        {listImages &&
          listImages.map((item) => (
            <Col xs="6" className="text-center mb-3">
              <ProductImage src={item} />
              <div className="d-flex">
                <Button
                  color="link"
                  className="text-danger text-decoration-none"
                  onClick={() => handleRemove(item)}
                >
                  Remove
                </Button>
                {imageDefault !== item && (
                  <Button
                    color="link"
                    onClick={() => handleChangeDefault(item)}
                    className="text-decoration-none"
                  >
                    Default
                  </Button>
                )}
              </div>
            </Col>
          ))}
      </Row>
    </>
  );
}
