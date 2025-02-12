import React from 'react'
import { DatePicker } from "antd";
import moment from "moment";

function Date({label, value, onChange,format,style}) {
  return (
    <>
    <label htmlFor="date" className="form-label">
    {label}
  </label>
  <DatePicker
    className="form-control rounded-pill w-100"
    value={value}
    onChange={onChange}
    style={style}
    format={format}
  />
</>
  )
}

export default Date