import React, { useState } from 'react'

function AddUserModal({ show, onClose, onAdd }) {
     const [formData, setFormData] = useState({
        firstName: "",
        lastName: "",
        email: "",
        password: "",
        mobileNo: "",
        role: "Client Account Manager",
        isActive: true,
      })
    
      const handleChange = (e) => {
        const { name, value, type, checked } = e.target
        setFormData((prev) => ({
          ...prev,
          [name]: type === "checkbox" ? checked : value,
        }))
      }
    
      const handleSubmit = (e) => {
        e.preventDefault()
        onAdd({
          id: Date.now(),
          name: `${formData.firstName} ${formData.lastName}`,
          email: formData.email,
          role: formData.role,
          isAdmin: false,
        })
        onClose()
      }
  return (
    <div className={`modal fade ${show ? "show" : ""}`} style={{ display: show ? "block" : "none" }} tabIndex="-1">
    <div className="modal-dialog">
      <div className="modal-content">
        <div className="modal-header">
          <h5 className="modal-title">Add New User</h5>
          <button type="button" className="btn-close" onClick={onClose}></button>
        </div>
        <form onSubmit={handleSubmit}>
          <div className="modal-body">
            <div className="mb-3">
              <label className="form-label">First Name</label>
              <input
                type="text"
                className="form-control"
                name="firstName"
                value={formData.firstName}
                onChange={handleChange}
                required
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Last Name</label>
              <input
                type="text"
                className="form-control"
                name="lastName"
                value={formData.lastName}
                onChange={handleChange}
                required
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Email</label>
              <input
                type="email"
                className="form-control"
                name="email"
                value={formData.email}
                onChange={handleChange}
                required
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Password</label>
              <input
                type="password"
                className="form-control"
                name="password"
                value={formData.password}
                onChange={handleChange}
                required
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Mobile Number</label>
              <input
                type="tel"
                className="form-control"
                name="mobileNo"
                value={formData.mobileNo}
                onChange={handleChange}
                required
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Role</label>
              <select className="form-select" name="role" value={formData.role} onChange={handleChange}>
                <option value="Client Account Manager">Client Account Manager</option>
                <option value="Admin">Admin</option>
              </select>
            </div>
            <div className="mb-3 form-check">
              <input
                type="checkbox"
                className="form-check-input"
                id="isActive"
                name="isActive"
                checked={formData.isActive}
                onChange={handleChange}
              />
              <label className="form-check-label" htmlFor="isActive">
                Active User
              </label>
            </div>
          </div>
          <div className="modal-footer">
            <button type="button" className="btn btn-secondary" onClick={onClose}>
              Cancel
            </button>
            <button type="submit" className="btn btn-primary">
              Add User
            </button>
          </div>
        </form>
      </div>
    </div>
  </div>
  )
}

export default AddUserModal