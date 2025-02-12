import React from 'react'

function Buttonadd({ label, onClick, variant = 'primary' }) {
  return (
    <button className={`btn btn-${variant} w-100`} onClick={onClick}
    style={{ borderRadius: "50px" }}
    >
    {label}
  </button>
  )
}

export default Buttonadd