import React from "react";
import SingleLayout from "../../containers/SingleLayout";
import ListUser from "./ListUser";
import Paging from "../../components/Paging";
import SearchBar from "../../components/SearchBar";

import _userSer from "../../services/userService";

const _pageSize = 6;
let _queryValue = "";

export default function User(props) {
  const [listUser, setUser] = React.useState([]);
  const [totalUser, setTotalUser] = React.useState(2);

  React.useEffect(() => {
    handlePage(1);
  }, []);

  //handle
  const handlePage = (pageNumber) => {
    _userSer
      .getList({
        query: _queryValue,
        limited: _pageSize,
        offset: pageNumber - 1,
      })
      .then((resp) => {
        let total = resp.headers["total-item"] ?? 0;
        setTotalUser(total);
        setUser(resp.data);
      });
  };

  const handleSearch = (query) => {
    _queryValue = query;
    handlePage(1);
  };

  return (
    <SingleLayout
      title="List User"
      actions={
        <SearchBar placeholder="User email ..." onSearchSubmit={handleSearch} />
      }
      content={
        <div>
          <ListUser datas={listUser} />
          <Paging
            totalItem={totalUser}
            pageSize={_pageSize}
            onChangePage={handlePage}
          />
        </div>
      }
    />
  );
}
