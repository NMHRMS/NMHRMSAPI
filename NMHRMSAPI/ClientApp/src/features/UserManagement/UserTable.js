import React from "react"

export const UserTable = ({ users }) => {
  return (
    <table className="table table-striped">
      <thead>
        <tr>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Email</th>
          <th>Mobile No</th>
          <th>Role</th>
          <th>Status</th>
        </tr>
      </thead>
      <tbody>
        {users.map((user) => (
          <tr key={user.id}>
            <td>{user.firstName}</td>
            <td>{user.lastName}</td>
            <td>{user.email}</td>
            <td>{user.mobileNo}</td>
            <td>{user.role}</td>
            <td>{user.isActive ? "Active" : "Inactive"}</td>
          </tr>
        ))}
      </tbody>
    </table>
  )
}

