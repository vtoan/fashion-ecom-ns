import React from "react";
import { Button } from "reactstrap";
import SplitLayout from "../../containers/SplitLayout";
import EditCategory from "./EditCategory";
import ListCategory from "./ListCategory";
import _cateSer from "../../services/cateService";
import { useDispatch, useSelector } from "react-redux";
import { setCategory } from "../../actions/fetchDataAction";

//comp
export default function Product() {
  const [listCates, setCates] = React.useState([]);
  const [itemSelected, setSelected] = React.useState(null);
  const dispatch = useDispatch();

  React.useEffect(() => {
    handleChangeType(1);
  }, []);

  //handle
  const handleChangeType = (val) => {
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
        setCategory(_removeViewItem(listCates, itemId));
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
          setCategory(_updateViewItem(listCates, data));
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
          children="New Category"
          onClick={() => handleCreate()}
        />
      }
      right={
        <ListCategory
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
