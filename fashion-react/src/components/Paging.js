import React from "react";
import { Pagination, PaginationItem, PaginationLink } from "reactstrap";

export default function Paging({
  totalItem = 0,
  pageSize = 0,
  selectPage = 1,
  onChangePage,
}) {
  const [pageSelected, setPage] = React.useState(selectPage);
  let arrayUris = [];
  const totalPage = Math.ceil(totalItem / pageSize);

  React.useEffect(() => {
    setPage(selectPage);
  }, [selectPage]);

  //handle
  const handleClickPage = (page) => {
    setPage(page);
    onChangePage && onChangePage(page);
  };

  for (let page = 1; page <= totalPage; page++) {
    arrayUris.push(
      <PaginationItem key={+page} active={page === pageSelected}>
        <PaginationLink onClick={() => handleClickPage(page)}>
          {page}
        </PaginationLink>
      </PaginationItem>
    );
  }

  return <>{totalPage > 0 && <Pagination>{arrayUris}</Pagination>}</>;
}
