import React from "react";
import { Button } from "reactstrap";
import ListProduct from "./ListProduct";
import SingleLayout from "../../containers/SingleLayout";
import Paging from "../../components/Paging";
import SearchBar from "../../components/SearchBar";

import _prodSer from "../../services/productService";
import { useHistory } from "react-router";

//props
let totalProduct = 0;
const _pageSize = 6;
const _parmas = {
  query: "",
  typeId: 0,
  cateId: 0,
  limited: _pageSize,
  offset: 0,
  sort: null,
};

export default function Product(props) {
  const [listProducts, setProducts] = React.useState([]);
  const history = useHistory();
  React.useEffect(() => {
    _getProduct(1);
  }, []);

  //handle
  const _getProduct = (pageNumber) => {
    _parmas.offset = pageNumber - 1;
    _prodSer.getList(_parmas).then((resp) => {
      console.log(resp.config.url);
      totalProduct = resp.headers["total-item"] ?? 0;
      setProducts(resp.data);
    });
  };

  const handleChangeCate = (val) => {
    _parmas.cateId = val;
    _getProduct(1);
  };

  const handleChangeType = (val) => {
    _parmas.typeId = val;
    _parmas.cateId = 0;
    _getProduct(1);
  };

  const handleChangeSort = (val) => {
    if (val < 0) _parmas.sort = null;
    else _parmas.sort = val;
    _getProduct(1);
  };

  const handleSearch = (query) => {
    _parmas.query = query;
    _getProduct(1);
  };

  const handleCreate = () => {
    history.push("/product/0");
  };

  const handlePage = (pageSelected) => {
    _getProduct(pageSelected);
  };

  const handleRefressh = () => {
    _parmas.cateId = 0;
    _parmas.typeId = 0;
    _parmas.sort = null;
    _parmas.query = "";
    _getProduct(1);
  };

  return (
    <SingleLayout
      title="List Product"
      actions={
        <div className="d-flex">
          <Button onClick={handleRefressh} color="link">
            Refresh
          </Button>
          <SearchBar
            placeholder="Product name ..."
            onSearchSubmit={handleSearch}
          />
          <Button
            className="ml-3"
            color="primary"
            children="New"
            onClick={() => handleCreate()}
          />
        </div>
      }
      content={
        <>
          <ListProduct
            datas={listProducts}
            onChangeCate={handleChangeCate}
            onChangeType={handleChangeType}
            onChangeSort={handleChangeSort}
          />
          <Paging
            totalItem={totalProduct}
            pageSize={_pageSize}
            onChangePage={handlePage}
          />
        </>
      }
    />
  );
}
