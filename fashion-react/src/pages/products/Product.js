import { Button, Table } from "reactstrap";
import React from "react";

export default function Product(props) {
  const [products, setProducts] = React.useState([]);

  const handleEdit = (itemId) => {};

  return (
    <>
      {(!products || products.length < 1) && (
        <p className="py-5 text-center text-uppercase text-secondary">
          No data
        </p>
      )}
      {products.length > 0 && (
        <Table>
          <thead>
            <tr>
              <th>#</th>
              <th>Image</th>
              <th>Name</th>
              <th>Category</th>
              <th>Type</th>
              <th>Price</th>
              <th>Rate</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            {products.map((item, index) => (
              <tr key={+index}>
                <th scope="row">{index + 1}</th>
                <td>{item.Image}</td>
                <td>{item.Name}</td>
                <td>{item.CategoryId}</td>
                <td>{item.TypeProductId}</td>
                <td>{item.Price}</td>
                <td>{item.Rate}</td>
                <td className="text-right">
                  <Button onClick={() => handleEdit(item.Id)} color="link">
                    Edit
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
