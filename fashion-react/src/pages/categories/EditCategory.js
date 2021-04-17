import React from "react";
import { Button, Form, FormGroup, Label, Input } from "reactstrap";
import SelectTypeProduct from "../../components/SelectTypeProduct";

export default function EditCategory({ itemEdit, onSave, onCancel }) {
  const itemId = itemEdit?.Id ?? 0;
  const [inputName, setInputName] = React.useState("");
  const [inputType, setInputType] = React.useState(0);

  React.useEffect(() => {
    setInputName(itemEdit?.Name);
    setInputType(itemEdit?.TypeProductId);
    console.log("Set initial value");
  }, [itemEdit]);

  const handleChangeName = (e) => setInputName(e.target.value);
  const handleChangeType = (val) => setInputType(val);
  //
  const handleSubmit = () => {
    if (inputName && inputType)
      onSave({ Id: itemId, Name: inputName, TypeProductId: inputType });
    else window.alert("Please fill the form below");
  };
  //
  return (
    <>
      {!itemEdit && (
        <p className="pt-5 text-center text-uppercase text-secondary">
          Select item
        </p>
      )}
      {itemEdit && (
        <Form>
          <FormGroup>
            <Label for="Name">Category Name</Label>
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
            <Label for="Type">Select Type</Label>
            <SelectTypeProduct
              placeholder
              initalValue={inputType}
              onChange={handleChangeType}
            />
          </FormGroup>
          <div className="pt-3">
            <Button color="primary" className="mr-3" onClick={handleSubmit}>
              Save
            </Button>
            <Button color="danger" onClick={() => onCancel()}>
              Cancel
            </Button>
          </div>
        </Form>
      )}{" "}
    </>
  );
}
