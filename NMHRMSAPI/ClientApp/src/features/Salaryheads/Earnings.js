import axios from "axios";
import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import { useNavigate, useParams } from "react-router-dom";

export default function Salaryform() {
  const navigate = useNavigate();
  const { id } = useParams();
  const [data, setData] = useState({
    name: "",
    calculationType: "",
    epf: "",
    csi: "",
  });

  const [newData, setNewData] = useState([]);

  const handleChange = (e) => {
    const { id, value, type, name } = e.target;

    if (type === "radio") {
      setData({ ...data, [name]: value });
    } else {
      setData({ ...data, [id]: value });
    }
  };

  const handleSubmit = (e) => {
    e.preventDefault(); // Prevent default form action
    if (id === undefined) {
      // Add new data
      axios
        .post("http://localhost:3000/salary_earning_head/", data)
        .then((res) => {
          console.log("Data added successfully:", res.data);
          setData({
            name: "",
            calculationType: "",
            epf: "",
            csi: "",
          });
          navigate("/businesssetup/salaryheadmaster"); // Navigate after success
        })
        .catch((error) => {
          console.error("Error adding data:", error);
        });
    } else {
      // Update existing data
      axios
        .put(`http://localhost:3000/salary_earning_head/${id}`, data)
        .then((res) => {
          console.log("Data updated successfully:", res.data);
          loadData(); // Refresh data
          navigate("/businesssetup/salaryheadmaster"); // Navigate after success
        })
        .catch((error) => {
          console.error("Error updating data:", error);
        });
    }
  };

  const loadData = () => {
    axios
      .get("http://localhost:3000/salary_earning_head/")
      .then((res) => {
        setNewData(res.data);
      })
      .catch((err) => console.error("Error loading data:", err));
  };

  useEffect(() => {
    if (id) {
      axios
        .get("http://localhost:3000/salary_earning_head/" + id)
        .then((res) => {
          console.log(res.data);
          setData({
            name: res.data.name,
            calculationType: res.data.calculationType,
            epf: res.data.epf,
            csi: res.data.csi,
          });
        });
    }
  }, []);

  useEffect(() => {
    loadData();
  }, []);

  return (
    <div className="container mt-2 border" style={{ backgroundColor: "white" }}>
      <h5 className="text-left mb-2 mt-2 ">Earnings</h5>
      <form>
        {/* First Row */}
        <div className=" m-3">
          <div className="row mb-3">
            {/* Name */}
            <div className="col-md-6">
              <label htmlFor="name" className="form-label">
                Name
              </label>
              <input
                onChange={(e) => handleChange(e)}
                value={data.name}
                type="text"
                id="name"
                className="form-control rounded-5"
                placeholder="Enter Name"
                style={{ backgroundColor: "#f5f6fa" }}
              />
            </div>
            {/* Calculation Type */}
            <div className="col-md-6">
              <label htmlFor="calculationType" className="form-label">
                Calculation Type
              </label>
              <select
                value={data.calculationType}
                onChange={(e) => handleChange(e)}
                id="calculationType"
                className="form-select rounded-5"
                style={{ backgroundColor: "#f5f6fa" }}
              >
                <option value="">Select Type</option>
                <option value="fixed">Fixed</option>
                <option value="variable">Variable</option>
              </select>
            </div>
          </div>
          <div className="row mb-3">
            {/* EPF */}
            <div className="col-md-6">
              <label className="form-label">EPF</label>
              <div>
                <div className="form-check form-check-inline">
                  <input
                    onChange={(e) => handleChange(e)}
                    type="radio"
                    id="epfYes"
                    name="epf" // Same name for grouping
                    value="yes" // Fixed value
                    checked={data.epf === "yes"} // Checked condition
                    className="form-check-input"
                  />
                  <label htmlFor="epfYes" className="form-check-label">
                    Yes
                  </label>
                </div>
                <div className="form-check form-check-inline">
                  <input
                    onChange={(e) => handleChange(e)}
                    type="radio"
                    id="epfNo"
                    name="epf" // Same name for grouping
                    value="no" // Fixed value
                    checked={data.epf === "no"} // Checked condition
                    className="form-check-input"
                  />
                  <label htmlFor="epfNo" className="form-check-label">
                    No
                  </label>
                </div>
              </div>
            </div>
            {/* Consider for CSI */}
            <div className="col-md-6">
              <label className="form-label">Consider for CSI</label>
              <div>
                <div className="form-check form-check-inline">
                  <input
                    onChange={(e) => handleChange(e)}
                    type="radio"
                    id="csiYes"
                    name="csi" // Same name for grouping
                    value="yes" // Fixed value
                    checked={data.csi === "yes"} // Checked condition
                    className="form-check-input"
                  />
                  <label htmlFor="csiYes" className="form-check-label">
                    Yes
                  </label>
                </div>
                <div className="form-check form-check-inline">
                  <input
                    onChange={(e) => handleChange(e)}
                    type="radio"
                    id="csiNo"
                    name="csi" // Same name for grouping
                    value="no" // Fixed value
                    checked={data.csi === "no"} // Checked condition
                    className="form-check-input"
                  />
                  <label htmlFor="csiNo" className="form-check-label">
                    No
                  </label>
                </div>
              </div>
            </div>
            {/* Second Row */}
            <div className="d-flex justify-content-end mt-3">
              <Link to="/businesssetup/salaryheadmaster">
                <button
                  onClick={(e) => handleSubmit(e)}
                  type="submit"
                  className="btn btn-primary rounded-5"
                  style={{ width: "200px" }}
                >
                  {id ? "UPDATE" : "ADD"}
                </button>
              </Link>
            </div>
          </div>
        </div>
      </form>
    </div>
  );
}
