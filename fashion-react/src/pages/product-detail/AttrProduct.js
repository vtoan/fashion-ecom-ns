import React from "react";
import { InputGroup, InputGroupAddon, Button, Input, Alert } from "reactstrap";

import _attrProdSer from "../../services/attributeProdService";

export default function AttrProduct({ productId, datas }) {
  const inputRef = React.useRef(null);
  const [listAttrs, setAttrs] = React.useState([]);

  React.useEffect(() => {
    setAttrs(datas);
  }, [datas]);

  //handle
  const _fetchAttrData = () => {
    if (productId)
      _attrProdSer.getListAttr(productId).then(({ data }) => {
        setAttrs(data);
      });
  };
  const handleSubmit = () => {
    var attrName = inputRef.current.value;
    if (attrName) {
      let result = window.confirm("Add the new item?");
      if (result)
        _attrProdSer.createAttr(productId, attrName).then(() => {
          _fetchAttrData();
          inputRef.current.value = "";
        });
    } else window.alert("Please enter new size!");
  };
  const handleRemove = (itemId) => {
    if (itemId) {
      let result = window.confirm("Delete this item?");
      if (result)
        _attrProdSer.deleteAttr(productId, itemId).then(() => {
          _fetchAttrData();
        });
    }
  };

  return (
    <div>
      <h5>Sizes</h5>
      <InputGroup className="mb-3">
        <Input innerRef={inputRef} placeholder="New Size" />
        <InputGroupAddon addonType="append" onClick={handleSubmit}>
          <Button color="success">Add</Button>
        </InputGroupAddon>
      </InputGroup>
      <div>
        {listAttrs &&
          listAttrs.map((item) => (
            <Alert
              key={+item.Id}
              color="info"
              toggle={() => handleRemove(item.Id)}
            >
              {item.Size}
            </Alert>
          ))}
      </div>
    </div>
  );
}
