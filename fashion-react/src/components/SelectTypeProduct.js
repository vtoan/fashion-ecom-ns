import React from "react";
import { useSelector } from "react-redux";
import { Input } from "reactstrap";

export default function SelectTypeProduct({
  initalValue,
  onChange,
  placeholder = null,
  novalid = false,
  ...other
}) {
  const [inputType, setInputType] = React.useState(0);
  const listTypes = useSelector(({ fetchData }) => fetchData.listTypes);

  React.useEffect(() => {
    setInputType(initalValue);
  }, [initalValue]);

  //handle
  const handleChangeType = (e) => {
    let val = e.target.value;
    setInputType(val);
    onChange && onChange(val);
  };

  return (
    <Input
      {...other}
      type="select"
      invalid={!novalid && !inputType}
      onChange={handleChangeType}
      value={inputType}
    >
      {placeholder && (
        <option className="text-secondary" value={0}>
          {placeholder}
        </option>
      )}
      {listTypes &&
        listTypes.map((item) => (
          <option key={+item.Id} value={item.Id}>
            {item.Name}
          </option>
        ))}
    </Input>
  );
}
