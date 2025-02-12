import React from 'react'

function Selectcom({ id, label, options, value, onChange, placeholder, style }) {
  return (
    <div className="form-group">
    <label htmlFor={id} className="form-label">{label}</label>
    <select
      className="form-select rounded-pill w-100"
      id={id}
      value={value}
      onChange={onChange}
      style={style}
    >
      <option value="">{placeholder || "Select"}</option>
      {options.map((option) => (
        <option key={option.id || option} value={option.id || option}>
          {option.name || option}
        </option>
      ))}
    </select>
  </div>
  )
}

export default Selectcom