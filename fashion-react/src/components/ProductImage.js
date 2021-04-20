import React from "react";
import { productRes } from "../config";

export default function ProductImage({ src }) {
  return (
    <div>
      <img width={100} src={productRes + src} alt="" />
    </div>
  );
}
