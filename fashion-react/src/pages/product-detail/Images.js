import React from "react";
import { Button, Col, Row, Input, FormGroup } from "reactstrap";
import ProductImage from "../../components/ProductImage";

import _imageProdSer from "../../services/imageProdService";
import _prodSer from "../../services/productService";

export default function Images({ productId, productImage }) {
  const [imageDefault, setDefault] = React.useState(productImage);
  const [imageUpload, setImageUpload] = React.useState(null);
  const [listImages, setImages] = React.useState([]);

  React.useEffect(() => {
    _imageProdSer.getListImages(productId).then(({ data }) => {
      setImages(data);
      setDefault(productImage);
      console.log(data);
      console.log(productImage);
    });
  }, [productId, productImage]);

  //handle
  const handleChangeFile = (e) => setImageUpload(e.target.files[0]);

  const handleUpload = () => {
    let result = window.confirm("Add the new item?");
    if (result)
      _imageProdSer.uploadImage(productId, imageUpload).then(({ data }) => {
        setImages([...listImages, productId + "/" + data]);
      });
  };

  const handleChangeDefault = (imageName) => {
    let result = window.confirm("Change to this item?");
    if (result)
      _imageProdSer.changeImageDefault(productId, imageName).then(() => {
        setDefault(imageName);
      });
  };

  const handleRemove = (imageName) => {
    let result = window.confirm("Delete this item?");
    if (result)
      if (imageName === imageDefault)
        _prodSer.edit(productId, { Id: productId, Image: null });
    _imageProdSer.removeImage(productId, imageName).then(() => {
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
