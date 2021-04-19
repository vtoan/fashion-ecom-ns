import React from "react";
import SingleLayout from "../../containers/SingleLayout";
import ListUser from "./ListUser";
import Paging from "../../components/Paging";

import _userSer from "../../services/userService";

const _pageSize = 3;

export default function User(props) {
  const [listUser, setUser] = React.useState([]);
  const [totalUser, setTotalUser] = React.useState(2);

  React.useEffect(() => {
    handlePage(1);
  }, []);

  //handle

  const handlePage = (pageNumber) => {
    _userSer
      .getList({ limited: _pageSize, offset: pageNumber - 1 })
      .then((resp) => {
        setUser(resp.data);

        console.log(resp);
      });
  };

  return (
    <SingleLayout
      title="List User"
      content={
        <div>
          <ListUser datas={listUser} />
          <Paging totalPage={totalUser} onChangePage={handlePage} />
        </div>
      }
    />
  );
}
