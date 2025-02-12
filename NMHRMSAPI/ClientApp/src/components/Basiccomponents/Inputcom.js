import React from 'react'

function Inputcom({ label, type, value, onChange,id,placeholder }) {
  return (
    <>
    {label && <label className="form-label" htmlFor={id}>{label}</label>}
    <input
      type={type}
        className="form-control rounded-pill w-100 rounded-pill"
        placeholder={placeholder}
      style={{ backgroundColor: "#f5f6fa" }}
      value={value}
      id={id}
      onChange={onChange}
    />
  </>
  )
}

export default Inputcom