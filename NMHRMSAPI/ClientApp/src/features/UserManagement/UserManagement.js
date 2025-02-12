import React, { useState } from "react";
import AddUserModal from "./AddUserModal";

const dummyUsers = [
  {
    id: 1,
    name: "DRCC",
    email: "drc@gmail.com",
    role: "Super Admin",
    isCurrentUser: true,
  },
  {
    id: 2,
    name: "Scott Stewart",
    email: "scott@heliacare.com",
    role: "Client Account Manager",
  },
  {
    id: 3,
    name: "Jane Doe",
    email: "jane@heliacare.com",
    role: "Client Account Manager",
    isAdmin: true,
  },
]

const Avatar = ({ name }) => {
  const initials = name
    .split(" ")
    .map((n) => n[0])
    .join("")
    .toUpperCase()

  return <div className="avatar">{initials}</div>
}

function UserManagement() {
  const [users, setUsers] = useState(dummyUsers)
  const [showModal, setShowModal] = useState(false)

  const handleAddUser = (newUser) => {
    setUsers((prev) => [...prev, newUser])
  }

    return (
      <div className="user-management">
      <div className="header-section">
        <div className="header-title">
          <h1>Manage Users</h1>
          <span className="total-count">{users.length} total</span>
        </div>
        <button className="add-user-btn" onClick={() => setShowModal(true)}>
          <i className="fas fa-user-plus"></i>
          Add User
        </button>
      </div>

      <div className="users-table">
        <table className="table table-hover mb-0">
          <thead className="table-header">
            <tr>
              <th style={{ width: "40%" }}>NAME</th>
              <th style={{ width: "30%" }}>EMAIL</th>
              <th style={{ width: "25%" }}>ROLE</th>
              <th style={{ width: "5%" }}></th>
            </tr>
          </thead>
          <tbody>
            {users.map((user) => (
              <tr key={user.id} className={`user-row ${user.isCurrentUser ? "active" : ""}`}>
                <td>
                  <div className="user-info">
                    <Avatar name={user.name} />
                    <span>
                      {user.name}
                      {user.isCurrentUser && <span className="ms-2 text-muted">(you)</span>}
                    </span>
                  </div>
                </td>
                <td>{user.email}</td>
                <td>
                  <span className={`role-badge ${user.isAdmin ? "admin" : ""}`}>
                    {user.role}
                    {user.isAdmin && <span className="ms-2">(Admin)</span>}
                  </span>
                </td>
                <td>
                  <button className="actions-btn">
                    <i className="fas fa-ellipsis-h"></i>
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>

      {/* Modal Backdrop */}
      {showModal && <div className="modal-backdrop fade show"></div>}

      {/* Add User Modal */}
      <AddUserModal show={showModal} onClose={() => setShowModal(false)} onAdd={handleAddUser} />
    </div>
    )
  }

export default UserManagement;
