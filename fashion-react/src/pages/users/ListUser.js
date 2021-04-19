import React from "react";
import { Table } from "reactstrap";

export default function ListUser({ datas }) {
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
              <th>Province</th>
            </tr>
          </thead>
          <tbody>
            {datas.map((item, index) => (
              <tr key={+index}>
                <th scope="row">{index + 1}</th>
                <td>{item.CustomerName ?? "unknown"}</td>
                <td>{item.Email}</td>
                <td>{item.Phone ?? "no"}</td>
                <td>{item.CustomerProvince ?? "no"}</td>
              </tr>
            ))}
          </tbody>
        </Table>
      )}
    </>
  );
}
