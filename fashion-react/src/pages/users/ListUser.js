import React from "react";
import { Button, Table } from "reactstrap";

export default function ListUser({ datas, onDelete }) {
  return (
    <>
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
              <th>Name</th>
              <th>Email</th>
              <th>Phone</th>
            </tr>
          </thead>
          <tbody>
            {datas.map((item, index) => (
              <tr key={+index}>
                <th scope="row">{index + 1}</th>
                <td>{item.CustomerName}</td>
                <td>{item.Email}</td>
                <td>{item.Phone}</td>
                <td className="text-right">
                  <Button
                    onClick={() => onDelete(item.Id)}
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
