import React from "react";
import { useSelector } from "react-redux";
import { Input } from "reactstrap";

export default function SelectCategory({
  initalValue,
  typeId,
  onChange,
  placeholder = null,
  novalid = false,
  ...other
}) {
  const [inputCate, setInputCate] = React.useState(0);
  const [listCates, setCates] = React.useState([]);
  const listCateDatas = useSelector(({ fetchData }) => fetchData.listCates);

  React.useEffect(() => {
    setCates(
      listCateDatas.filter((item) => item.TypeProductId === Number(typeId))
    );
    setInputCate(initalValue);
  }, [listCateDatas, typeId, initalValue]);

  //handle
  const handleChangeCate = (e) => {
    let val = e.target.value;
    setInputCate(val);
    onChange && onChange(val);
  };

  return (
    <Input
      {...other}
      type="select"
      invalid={!novalid && !inputCate}
      onChange={handleChangeCate}
      value={inputCate}
    >
      {placeholder && (
        <option className="text-secondary" value={0}>
          {placeholder}
        </option>
      )}
      {listCates.map((item) => (
        <option key={+item.Id} value={item.Id}>
          {item.Name}
        </option>
      ))}
    </Input>
  );
}
