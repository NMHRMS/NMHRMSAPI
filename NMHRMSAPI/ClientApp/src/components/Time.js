import React from 'react'
import { TimePicker } from "antd";
import moment from "moment";
function Time({ label, value, onChange }) {
  return (
    <>
    <label htmlFor="shift_start_time" className="form-label">
      {label}
    </label>
    <TimePicker
      use12Hours
      className="form-control rounded-pill"
      onChange={onChange}
      value={value ? moment(value, "h:mm a") : null}
      format="h:mm a"
      style={{
        backgroundColor: "#f5f6fa",
      }}
    />
  </>
  )
}

export default Time