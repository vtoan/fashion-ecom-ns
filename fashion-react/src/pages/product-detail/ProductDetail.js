import React from "react";
import { Button } from "reactstrap";
import SplitLayout from "../../containers/SplitLayout";
import EditProduct from "./EditProduct";
import { useHistory, useParams } from "react-router";
import AttrProduct from "./AttrProduct";
import Images from "./Images";

import _proSer from "../../services/productService";

export default function ProductDetail() {
  let { id } = useParams();
  const history = useHistory();
  const [itemEdit, setEdit] = React.useState(null);

  React.useEffect(() => {
    if (Number(id) > 0)
      _proSer.get(id).then((resp) => {
        console.log(resp);
        setEdit(resp.data);
      });
  }, [id]);

  const handleDelelte = () => {
    let result = window.confirm("Delete this item?");
    if (result) {
      _proSer.delete(id).then(() => {
        history.goBack();
      });
    }
  };

  const handleSave = (data) => {
    let result = window.confirm("Save the changed items?");
    if (result) {
      if (!data.Id) {
        _proSer.create(data).then(() => {
          history.goBack();
        });
      } else {
        _proSer.edit(data.Id, data).then(() => {
          history.goBack();
        });
      }
    }
  };

  return (
    <SplitLayout
      title="Product Detail"
      actions={
        <Button color="danger" children="Delete" onClick={handleDelelte} />
      }
      right={
        <EditProduct
          itemEdit={itemEdit}
          onSave={handleSave}
          onCancel={() => history.goBack()}
        />
      }
      left={
        <>
          <AttrProduct productId={id} datas={itemEdit?.ProductAttributes} />
          <div className="pt-5">
            <Images productId={id} productImage={itemEdit?.Image} />
          </div>
        </>
      }
    ></SplitLayout>
  );
}
