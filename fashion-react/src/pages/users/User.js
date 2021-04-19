import React from "react";
import SingleLayout from "../../containers/SingleLayout";
import ListUser from "./ListUser";
import Paging from "../../components/Paging";

import _userSer from "../../services/userService";

const _pageSize = 8;

export default function User(props) {
  const [listUser, setUser] = React.useState([]);

  React.useEffect(() => {
    handlePage(1);
  }, []);

  //handle
  const handleDelete = (itemId) => {};

  const handlePage = (pageNumber) => {
    _userSer.getList({ pageSize: _pageSize, page: pageNumber }).then((resp) => {
      setUser(resp.data);
    });
  };

  return (
    <SingleLayout
      title="List User"
      content={
        <div>
          <ListUser datas={listUser} onDelete={handleDelete} />
          <Paging totalPage={0} onChangePage={handlePage} />
        </div>
      }
    />
  );
}
