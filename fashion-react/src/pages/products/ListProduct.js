import React from "react";
import { Button, Table } from "reactstrap";
import SelectTypeProduct from "../../components/SelectTypeProduct";
import SelectCategory from "../../components/SelectCategory";
import SelectSort from "../../components/SelectSort";
import ProductImage from "../../components/ProductImage";
import { Link } from "react-router-dom";
import { useSelector } from "react-redux";

export default function ListProduct({
  datas,
  onChangeType,
  onChangeCate,
  onChangeSort,
}) {
  const [typeCurrent, setType] = React.useState(1);
  const _listTypes = useSelector(({ fetchData }) => fetchData.listTypes);
  const _listCates = useSelector(({ fetchData }) => fetchData.listCates);

  const handleChangeType = (val) => {
    onChangeType && onChangeType(val);
    setType(val);
  };

  const _getTypeName = (id) =>
    (_listTypes && _listTypes.find((item) => item.Id === id)?.Name) ??
    "unknown";

  const _getCateName = (id) =>
    (_listCates && _listCates.find((item) => item.Id === id)?.Name) ??
    "unknown";

  return (
    <Table className="my-table">
      <thead>
        <tr>
          <th>#</th>
          <th>Image</th>
          <th>Name</th>
          <th>
            <div className="d-flex align-items-center">
              <span className="pr-2">Category</span>
              <SelectCategory
                typeId={typeCurrent}
                initalValue={0}
                novalid
                placeholder="All"
                className="border-0"
                onChange={onChangeCate}
              />
            </div>
          </th>
          <th>
            <div className="d-flex align-items-center">
              <span className="pr-2">Type</span>
              <SelectTypeProduct
                novalid
                placeholder="All"
                className="border-0"
                onChange={handleChangeType}
              />
            </div>
          </th>
          <th>
            <div className="d-flex align-items-center">
              <span className="pr-2">Price</span>
              <SelectSort
                placeholder="All"
                className="border-0"
                onChange={onChangeSort}
              />
            </div>
          </th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        {(!datas || datas.length < 1) && (
          <tr>
            <td colSpan={7}>
              <p className="py-5 text-center text-uppercase text-secondary">
                No data
              </p>
            </td>
          </tr>
        )}
        {datas.length > 0 &&
          datas.map((item, index) => (
            <tr key={+index}>
              <th scope="row">{item.Id}</th>
              <td>
                <ProductImage src={item.Image} />
              </td>
              <td>{item.Name}</td>
              <td>{_getCateName(item.CategoryId)}</td>
              <td>{_getTypeName(item.TypeProductId)}</td>
              <td>{item.Price}</td>
              <td className="text-right">
                <Button color="link">
                  <Link to={"/product/" + item.Id}>Edit</Link>
                </Button>
              </td>
            </tr>
          ))}
      </tbody>
    </Table>
  );
}
