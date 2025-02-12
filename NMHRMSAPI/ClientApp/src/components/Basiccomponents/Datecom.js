import React from 'react'
import { DatePicker } from "antd";
import moment from "moment";

function Datecom({label, value, onChange,format,style}) {
    // const parsedValue = value && moment.isMoment(value) ? value : value ? moment(value, format) : null;
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

export default Datecom