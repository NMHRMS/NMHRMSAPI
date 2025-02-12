import React, { useState, useEffect } from "react";
import { useNavigate, useParams } from "react-router-dom";
import axios from "axios";

export default function Deduction() {
  const { id } = useParams();
  const navigate = useNavigate();

  const [data, setData] = useState({
    firstName: "",
    deductionType: "",
    calculationType: "",
    taxImplication: "",
  });

  const [newData, setNewData] = useState([]);

  // Handle input changes
  const handleChange = (e) => {
    const { id, value, type, name } = e.target;
    const key = type === "radio" ? name : id;
    setData((prev) => ({ ...prev, [key]: value }));
  };

  // Fetch data for update
  useEffect(() => {
    if (id) {
      axios
        .get(`http://localhost:3000/salary_deduction_head/${id}`)
        .then((res) => {
          setData({
            firstName: res.data.firstName || "",
            deductionType: res.data.deductionType || "",
            calculationType: res.data.calculationType || "",
            taxImplication: res.data.taxImplication || "",
          });
        })
        .catch((err) => console.error("Error fetching data:", err));
    }
  }, [id]);

  // Load all data
  const loadData = () => {
    axios
      .get("http://localhost:3000/salary_deduction_head/")
      .then((res) => setNewData(res.data))
      .catch((err) => console.error("Error loading data:", err));
  };

  useEffect(() => {
    loadData();
  }, []);

  // Handle form submission
  const handleSubmit = (e) => {
    e.preventDefault();
    if (!id) {
      // POST request
      axios
        .post("http://localhost:3000/salary_deduction_head/", data)
        .then(() => {
          setData({
            firstName: "",
            deductionType: "",
            calculationType: "",
            taxImplication: "",
          });
          navigate("/businesssetup/salaryheadmaster");
        })
        .catch(() => alert("Something went wrong while adding data."));
    } else {
      // PUT request
      axios
        .put(`http://localhost:3000/salary_deduction_head/${id}`, data)
        .then(() => {
          navigate("/businesssetup/salaryheadmaster");
        })
        .catch(() => alert("Something went wrong while updating data."));
    }
  };

  return (
    <div className="container mt-2 border pb-5" style={{ backgroundColor: "white"}}>
      <h5 className="text-left mb-4 mt-2">Deduction</h5>
      <form onSubmit={handleSubmit}>
        {/* First Row */}
        <div className="row mb-3">
          {/* Name */}
          <div className="col-md-4">
            <label htmlFor="firstName" className="form-label">
              Name
            </label>
            <input
              type="text"
              id="firstName"
              name="firstName"
              value={data.firstName}
              onChange={handleChange}
              className="form-control rounded-5"
              placeholder="Enter Name"
              style={{ backgroundColor: "#f5f6fa" }}
            />
          </div>
          {/* Deduction Type */}
          <div className="col-md-4">
            <label htmlFor="deductionType" className="form-label">
              Deduction Type
            </label>
            <select
              id="deductionType"
              name="deductionType"
              value={data.deductionType}
              onChange={handleChange}
              className="form-select rounded-5"
              style={{ backgroundColor: "#f5f6fa" }}
            >
              <option value="">Select Type</option>
              <option value="National Pension Scheme">National Pension Scheme</option>
              <option value="AD-HOC Deduction">AD-HOC Deduction</option>
              <option value="System Fine">System Fine</option>
            </select>
          </div>
          {/* Calculation Type */}
          <div className="col-md-4">
            <label htmlFor="calculationType" className="form-label">
              Calculation Type
            </label>
            <select
              id="calculationType"
              name="calculationType"
              value={data.calculationType}
              onChange={handleChange}
              className="form-select rounded-5"
              style={{ backgroundColor: "#f5f6fa" }}
            >
              <option value="">Select Type</option>
              <option value="Fixed">Fixed</option>
              <option value="Variable">Variable</option>
              <option value="Variable">Basic</option>

            </select>
          </div>
        </div>

        {/* Second Row */}
        <div className="row mb-3">
          {/* Tax Implication */}
          <div className="col-md-4">
            <label className="form-label">Tax Implication</label>
            <div>
              <div className="form-check form-check-inline">
                <input
                  type="radio"
                  id="taxYes"
                  name="taxImplication"
                  value="yes"
                  checked={data.taxImplication === "yes"}
                  onChange={handleChange}
                  className="form-check-input"
                />
                <label htmlFor="taxYes" className="form-check-label">
                  Yes
                </label>
              </div>
              <div className="form-check form-check-inline">
                <input
                  type="radio"
                  id="taxNo"
                  name="taxImplication"
                  value="no"
                  checked={data.taxImplication === "no"}
                  onChange={handleChange}
                  className="form-check-input"
                />
                <label htmlFor="taxNo" className="form-check-label">
                  No
                </label>
              </div>
            </div>
          </div>
        </div>

        {/* Submit Button */}
        <div className="d-flex justify-content-end">
          <button type="submit" className="btn btn-primary rounded-5" style={{ width: "200px" }}>
            {id ? "Update" : "Add"}
          </button>
        </div>
      </form>
    </div>
  );
}
