import React from "react";
import { Button } from "reactstrap";
import SplitLayout from "../../containers/SplitLayout";
import EditCategory from "./EditCategory";
import ListCategory from "./ListCategory";
import _cateSer from "../../services/cateService";

//comp
export default function Product() {
  const [listCategory, setCategory] = React.useState([]);
  const [itemSelected, setSelected] = React.useState(null);

  React.useEffect(() => {
    handleChangeType(1);
  }, []);

  //handle
  const handleChangeType = (val) => {
    _cateSer.getList(val).then((resp) => {
      setCategory(resp.data);
    });
  };

  const handleCreate = () => setSelected({ Name: "", TypeProductId: 0 });
  const handleEdit = (item) => setSelected(item);
  const handleCancel = () => setSelected(null);

  const handleDelete = (itemId) => {
    let result = window.confirm("Delete this item?");
    if (result) {
      _cateSer.delete(itemId).then((resp) => {
        setCategory(_removeViewItem(listCategory, itemId));
      });
    }
  };

  const handleSave = (data) => {
    let result = window.confirm("Save the changed items?");
    if (result) {
      if (!data.Id) {
        _cateSer.create(data).then((reps) => {
          handleChangeType(1);
        });
      } else {
        _cateSer.edit(data.Id, data).then((reps) => {
          setCategory(_updateViewItem(listCategory, data));
        });
      }
      setSelected(null);
    }
  };

  //update view
  const _removeViewItem = (lists, itemDel) =>
    lists.filter((item) => item.Id !== itemDel);

  const _updateViewItem = (lists, itemEdit) =>
    lists.map((item) => (item.Id === itemEdit.Id ? itemEdit : item));
  //
  return (
    <SplitLayout
      title="Category"
      actions={
        <Button
          color="primary"
          className="float-right"
          children="New Category"
          onClick={() => handleCreate()}
        />
      }
      right={
        <ListCategory
          datas={listCategory}
          onEdit={handleEdit}
          onDelete={handleDelete}
          onChangeType={handleChangeType}
        />
      }
      left={
        <EditCategory
          itemEdit={itemSelected}
          onCancel={handleCancel}
          onSave={handleSave}
        />
      }
    ></SplitLayout>
  );
}
