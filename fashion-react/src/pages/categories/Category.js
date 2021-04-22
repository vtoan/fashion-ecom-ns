import React from "react";
import { Button } from "reactstrap";
import SplitLayout from "../../containers/SplitLayout";
import EditCategory from "./EditCategory";
import ListCategory from "./ListCategory";
import { useDispatch } from "react-redux";
import { setCategory } from "../../actions/fetchDataAction";

import _cateSer from "../../services/cateService";

//comp
export default function Product() {
  const [listCates, setCates] = React.useState([]);
  const [typeSelected, setTypeSelected] = React.useState(1);
  const [itemSelected, setSelected] = React.useState(null);
  const dispatch = useDispatch();

  React.useEffect(() => {
    handleChangeType(1);
  }, []);

  //handle
  const handleChangeType = (val) => {
    setTypeSelected(val);
    _cateSer.getList(0).then(({ data }) => {
      dispatch(setCategory(data));
      setCates(data.filter((item) => item.TypeProductId === Number(val)));
    });
  };

  const handleCreate = () => setSelected({ Name: "", TypeProductId: 0 });
  const handleEdit = (item) => setSelected(item);
  const handleCancel = () => setSelected(null);

  const handleDelete = (itemId) => {
    let result = window.confirm("Delete this item?");
    if (result) {
      _cateSer.delete(itemId).then(() => {
        setCates(_removeViewItem(listCates, itemId));
      });
    }
  };

  const handleSave = (data) => {
    let result = window.confirm("Save the changed items?");
    if (result) {
      if (!data.Id) {
        _cateSer.create(data).then(() => {
          handleChangeType(1);
        });
      } else {
        _cateSer.edit(data.Id, data).then(() => {
          handleChangeType(data.TypeProductId);
          setTypeSelected(data.TypeProductId);
        });
      }
      setSelected(null);
    }
  };

  //update view
  const _removeViewItem = (lists, itemIdDel) =>
    lists.filter((item) => item.Id !== Number(itemIdDel));
  //
  return (
    <SplitLayout
      title="Category"
      actions={
        <Button
          color="primary"
          children="New Category"
          onClick={() => handleCreate()}
        />
      }
      right={
        <ListCategory
          initalType={typeSelected}
          datas={listCates}
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
