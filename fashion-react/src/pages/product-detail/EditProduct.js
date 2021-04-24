import React from "react";
import { Button, Form, FormGroup, Label, Input } from "reactstrap";
import SelectTypeProduct from "../../components/SelectTypeProduct";
import SelectCategory from "../../components/SelectCategory";

export default function EditProduct({ itemEdit, onSave, onCancel }) {
  console.log(itemEdit);
  const itemId = itemEdit?.Id ?? 0;
  const [inputName, setInputName] = React.useState("");
  const [inputPrice, setInputPrice] = React.useState("");
  const [inputDescription, setInputDescription] = React.useState("");
  const [inputType, setInputType] = React.useState(0);
  const [inputCate, setInputCate] = React.useState(0);
  const [inputMaterial, setInputMaterial] = React.useState("");
  const [inputOrigin, setInputOrigin] = React.useState("");

  React.useEffect(() => {
    setInputName(itemEdit?.Name);
    setInputCate(itemEdit?.CategoryId);
    setInputType(itemEdit?.TypeProductId);
    setInputPrice(itemEdit?.Price);
    setInputDescription(itemEdit?.ProductDescription);
    setInputMaterial(itemEdit?.Material);
    setInputOrigin(itemEdit?.Origin);
    console.log("Set initial value");
  }, [itemEdit]);

  //handle form
  const handleChangeName = (e) => setInputName(e.target.value);
  const handleChangePrice = (e) => setInputPrice(e.target.value);
  const handleChangeDescription = (e) => setInputDescription(e.target.value);
  const handleChangeMaterial = (e) => setInputMaterial(e.target.value);
  const handleChangeOrigin = (e) => setInputOrigin(e.target.value);
  const handleChangeType = (val) => {
    setInputType(val);
    setInputCate(0);
  };
  const handleChangeCate = (val) => setInputCate(val);

  //handle
  const handleSubmit = () => {
    if (inputName && inputPrice && inputCate && inputType)
      onSave &&
        onSave({
          Id: itemId,
          Name: inputName,
          Price: inputPrice,
          ProductDescription: inputDescription,
          Material: inputMaterial,
          Origin: inputOrigin,
          CategoryId: inputCate,
          TypeProductId: inputType,
        });
    else window.alert("Please fill the form below");
  };
  //
  return (
    <Form>
      <FormGroup>
        <Label for="Name">Product Name</Label>
        <Input
          invalid={!inputName}
          type="text"
          name="Name"
          id="Name"
          onChange={handleChangeName}
          value={inputName}
        />
      </FormGroup>
      <FormGroup>
        <Label for="Price">Product Price</Label>
        <Input
          invalid={!inputPrice}
          type="number"
          name="Price"
          id="Price"
          onChange={handleChangePrice}
          value={inputPrice}
        />
      </FormGroup>
      <FormGroup>
        <Label for="Type">Select Type</Label>
        <SelectTypeProduct
          placeholder="Choose type"
          initalValue={inputType}
          onChange={handleChangeType}
        />
      </FormGroup>
      <FormGroup>
        <Label for="Type">Select Category</Label>
        <SelectCategory
          typeId={inputType}
          placeholder="Choose category"
          initalValue={inputCate}
          onChange={handleChangeCate}
        />
      </FormGroup>
      <FormGroup>
        <Label for="Material">Material</Label>
        <Input
          type="text"
          name="Material"
          id="Material"
          onChange={handleChangeMaterial}
          value={inputMaterial}
        />
      </FormGroup>
      <FormGroup>
        <Label for="Origin">Origin</Label>
        <Input
          type="text"
          name="Origin"
          id="Origin"
          onChange={handleChangeOrigin}
          value={inputOrigin}
        />
      </FormGroup>
      <FormGroup>
        <Label for="ProductDescription">Product Description</Label>
        <Input
          type="textarea"
          name="ProductDescription"
          id="ProductDescription"
          onChange={handleChangeDescription}
          value={inputDescription}
        />
      </FormGroup>
      <div className="pt-3">
        <Button color="primary" className="mr-3" onClick={handleSubmit}>
          Save
        </Button>
        <Button color="danger" onClick={() => onCancel && onCancel()}>
          Cancel
        </Button>
      </div>
    </Form>
  );
}
