import React from "react";
import { useSelector } from "react-redux";
import { Button, Table } from "reactstrap";
import SelectTypeProduct from "../../components/SelectTypeProduct";

export default function ListCategory({
  datas,
  onEdit,
  onDelete,
  onChangeType,
}) {
  const _listTypes = useSelector(({ fetchData }) => fetchData.listTypes);

  const _getTypeName = (id) =>
    (_listTypes && _listTypes.find((item) => item.Id === id)?.Name) ??
    "unknown";
  return (
    <>
      <SelectTypeProduct
        initalValue={1}
        onChange={(val) => onChangeType && onChangeType(val)}
      />
      {(!datas || datas.length < 1) && (
        <p className="py-5 text-center text-uppercase text-secondary">
          No data
        </p>
      )}
      {datas.length > 0 && (
        <Table>
          <thead>
            <tr>
              <th>#</th>
              <th>Category</th>
              <th>Type</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            {datas.map((item, index) => (
              <tr key={+index}>
                <th scope="row">{index + 1}</th>
                <td>{item.Name}</td>
                <td> {_getTypeName(item.TypeProductId)}</td>
                <td className="text-right">
                  <Button onClick={() => onEdit && onEdit(item)} color="link">
                    Edit
                  </Button>
                  <Button
                    onClick={() => onDelete && onDelete(item.Id)}
                    color="link"
                    className="text-danger"
                  >
                    Remove
                  </Button>
                </td>
              </tr>
            ))}
          </tbody>
        </Table>
      )}
    </>
  );
}
