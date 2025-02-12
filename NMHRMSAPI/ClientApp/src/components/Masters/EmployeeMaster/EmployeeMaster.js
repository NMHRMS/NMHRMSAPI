import React, { useState } from "react";

export default function EmployeeMaster() {
  const [imagePreview, setImagePreview] = useState(
    "https://via.placeholder.com/100"
  );
  const handleImageChange = (event) => {
    const file = event.target.files[0];
    if (file) {
      const reader = new FileReader();
      reader.onloadend = () => {
        setImagePreview(reader.result);
      };
      reader.readAsDataURL(file);
    }
  };
  return (
    <div
      className="containerre w-100 mb-5 p-4"
      style={{ backgroundColor: "white" }}
    >
      <div className="row mb-3">
        <div className="col-lg-4">
          <label htmlFor="employeeCode" className="form-label ">
            Employee Code
          </label>
          <input
            type="text"
            className="form-control rounded-5"
            id="employeeCode"
            placeholder="Enter Code"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-4 text-center">
          <label htmlFor="employeeImage" className="form-label">
            Employee Image
          </label>
          <div>
            <input
              type="file"
              className="form-control rounded-5 mb-2"
              id="employeeImage"
              style={{ backgroundColor: "#f5f6fa" }}
              onChange={handleImageChange}
            />
          </div>
        </div>
        <div className="col-lg-4">
          <img
            src={imagePreview}
            alt="Employee"
            className="rounded-circle"
            style={{ width: "100px", height: "100px" }}
          />
        </div>
      </div>

      <h5>Basic Information</h5>
      <div className="row mb-3">
        <div className="col-lg-3">
          <label
            htmlFor="firstName"
            className="form-label rounded rounded-pill"
          >
            First Name
          </label>
          <input
            type="text"
            className="form-control rounded-5"
            id="firstName"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label htmlFor="middleName" className="form-label">
            Middle Name
          </label>
          <input
            type="text"
            className="form-control rounded-5"
            id="middleName"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label htmlFor="lastName" className="form-label">
            Last Name
          </label>
          <input
            type="text"
            className="form-control rounded-5"
            id="lastName"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label htmlFor="dob" className="form-label">
            Date of Birth
          </label>
          <input
            type="date"
            className="form-control rounded-5"
            id="dob"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
      </div>

      <div className="row mb-3">
        <div className="col-lg-3">
          <label htmlFor="gender" className="form-label">
            Gender
          </label>
          <select
            className="form-select rounded-5 "
            id="gender"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Male</option>
            <option>Female</option>
            <option>Other</option>
          </select>
        </div>
        <div className="col-lg-3">
          <label className="form-label">Marital Status</label>
          <div>
            <div className="form-check form-check-inline">
              <input
                className="form-check-input rounded-5"
                type="radio"
                name="maritalStatus"
                id="married"
                value="Married"
              />
              <label className="form-check-label" htmlFor="married">
                Married
              </label>
            </div>
            <div className="form-check form-check-inline">
              <input
                className="form-check-input rounded-5"
                type="radio"
                name="maritalStatus"
                id="unmarried"
                value="Unmarried"
              />
              <label className="form-check-label" htmlFor="unmarried">
                Unmarried
              </label>
            </div>
          </div>
        </div>
        <div className="col-lg-3">
          <label htmlFor="personalMobile" className="form-label">
            Personal Mobile
          </label>
          <input
            type="tel"
            className="form-control rounded-5"
            id="personalMobile"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label htmlFor="personalEmail" className="form-label">
            Personal Email
          </label>
          <input
            type="email"
            className="form-control rounded-5"
            id="personalEmail"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
      </div>
      <hr />
      <h5>Permanent Address</h5>
      <div className="row mb-3">
        <div className="col-lg-6">
          <label className="form-label">Address</label>
          <input
            type="text"
            className="form-control rounded-5"
            placeholder="Address"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label className="form-label">Pin Code</label>
          <input
            type="text"
            className="form-control rounded-5"
            placeholder="Pin Code"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label className="form-label">Country</label>
          <select
            className="form-select rounded-5"
            placeholder="State"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Select Country</option>
          </select>
        </div>
      </div>
      <div className="row mb-3">
        <div className="col-lg-3">
          <label className="form-label">State</label>
          <select
            className="form-select rounded-5"
            placeholder="State"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Select State</option>
          </select>
        </div>
        <div className="col-lg-3">
          <label className="form-label">City</label>
          <select
            className="form-select rounded-5"
            placeholder="State"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Select Country</option>
          </select>
        </div>
      </div>

      <h5>Present Address</h5>
      <div className="row mb-3">
        <div className="col-lg-6">
          <label className="form-label">Address</label>
          <input
            type="text"
            className="form-control rounded-5"
            placeholder="Address"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label className="form-label">Pin Code</label>
          <input
            type="text"
            className="form-control rounded-5"
            placeholder="Pin Code"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label className="form-label">Country</label>
          <select
            className="form-select rounded-5"
            placeholder="State"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Select Country</option>
          </select>
        </div>
      </div>

      <div className="row mb-3">
        <div className="col-lg-3">
          <label className="form-label">State</label>
          <select
            className="form-select rounded-5"
            placeholder="State"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Select State</option>
          </select>
        </div>
        <div className="col-lg-3">
          <label className="form-label">City</label>
          <select
            className="form-select rounded-5"
            placeholder="State"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Select Country</option>
          </select>
        </div>
      </div>

      <hr />

      <h5>Official Records</h5>
      <div className="row mb-3">
        <div className="col-lg-3">
          <label htmlFor="dateOfJoining" className="form-label">
            Date of Joining
          </label>
          <input
            type="date"
            className="form-control rounded-5"
            id="dateOfJoining"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label htmlFor="dateOfConfirmation" className="form-label">
            Date of Confirmation
          </label>
          <input
            type="date"
            className="form-control rounded-5"
            id="dateOfConfirmation"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label htmlFor="officialEmail" className="form-label">
            Official Mobile{" "}
          </label>
          <input
            type="email"
            className="form-control rounded-5"
            id="officialEmail"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
        <div className="col-lg-3">
          <label htmlFor="officialEmail" className="form-label">
            Official Email
          </label>
          <input
            type="email"
            className="form-control rounded-5"
            id="officialEmail"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
      </div>

      <div className="row mb-3">
        <div className="col-lg-3">
          <label className="form-label">Biometric Code</label>
          <select
            className="form-select rounded-5"
            placeholder="State"
            style={{ backgroundColor: "#f5f6fa" }}
          >
            <option>Select State</option>
          </select>
        </div>
        <div className="col-lg-3">
          <label className="form-label">Notice Period(Month)</label>
          <input
            type="email"
            className="form-control rounded-5"
            id="officialEmail"
            placeholder="Enter"
            style={{ backgroundColor: "#f5f6fa" }}
          />
        </div>
      </div>

      <div className="text-end">
        <button type="button" className="btn btn-primary rounded-5 mb-2">
          Save
        </button>
      </div>
    </div>
  );
}
