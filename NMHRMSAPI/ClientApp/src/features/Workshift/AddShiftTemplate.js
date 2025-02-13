import React, { useState, useEffect } from "react";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import axios from "axios";
import Inputcom from "../../components/Input";
import Buttonadd from "../../components/Button";
import Tablecom from "../../components/Table";
import Shifttemplate from "./Shifttemplate"; // Import the ShiftDetails component

function AddShifttemplate() {
  const [getshifts, setGetshifts] = useState([]);
  const [shiftData, setShiftData] = useState({
    id: null,
    shift_name: "",
    net_working_hours: "",
    is_rotated: false, // Checkbox state
  });
  
  const [selectedTab, setSelectedTab] = useState("addShift"); // State for tab selection

  // Validation function
  const validateForm = () => {
    if (shiftData.shift_name.trim() === "") {
      toast.error("Shift Name cannot be empty or contain only spaces.");
      return false;
    }
    if (/\s/.test(shiftData.shift_name)) {
      toast.error("Shift Name cannot contain spaces.");
      return false;
    }
    if (shiftData.net_working_hours === "" || isNaN(shiftData.net_working_hours) || shiftData.net_working_hours <= 0) {
      toast.error("Net Working Hours must be a positive number.");
      return false;
    }
    return true;
  };

  // Handle input changes
  const handleInputChange = (e) => {
    const { id, value, type, checked } = e.target;

    if (type === "checkbox") {
      setShiftData({ ...shiftData, [id]: checked });
    } else {
      setShiftData({ ...shiftData, [id]: value });
    }
  };

  // Add or update shift
  const addShift = () => {
    if (!validateForm()) return;

    const newShiftData = { ...shiftData };
    if (!newShiftData.id) {
      axios.post("http://localhost:3000/shifts", newShiftData)
        .then((res) => {
          getShiftData();
          resetForm();
          toast.success("Shift added successfully!");
        })
        .catch((err) => console.log(err));
    } else {
      axios.put(`http://localhost:3000/shifts/${newShiftData.id}`, newShiftData)
        .then((res) => {
          getShiftData();
          resetForm();
          toast.success("Shift updated successfully!");
        })
        .catch((err) => console.log(err));
    }
  };

  // Fetch shifts from API
  const getShiftData = () => {
    axios.get("http://localhost:3000/shifts")
      .then((res) => {
        setGetshifts(res.data);
      })
      .catch((err) => console.log(err));
  };

  // Delete shift
  const deleteShift = (id) => {
    axios.delete(`http://localhost:3000/shifts/${id}`)
      .then(() => {
        getShiftData();
        toast.success("Shift deleted successfully!");
      })
      .catch((err) => console.log(err));
  };

  // Edit shift
  const editShift = (shift) => {
    setShiftData({ ...shift });
  };

  // Reset form
  const resetForm = () => {
    setShiftData({
      id: null,
      shift_name: "",
      net_working_hours: "",
      is_rotated: false,
    });
  };

  useEffect(() => {
    getShiftData();
  }, []);

  return (
    <div className="container mt-2">
      <ToastContainer />
      
      {/* Tab Navigation */}
      <ul className="nav nav-tabs" role="tablist">
        <li className="nav-item" role="presentation">
          <button
            className={`nav-link ${selectedTab === "addShift" ? "active" : ""}`}
            onClick={() => setSelectedTab("addShift")}
            role="tab"
          >
            Add Shifts
          </button>
        </li>
        <li className="nav-item" role="presentation">
          <button
            className={`nav-link ${selectedTab === "shiftDetails" ? "active" : ""}`}
            onClick={() => setSelectedTab("shiftDetails")}
            role="tab"
          >
            Shift Details
          </button>
        </li>
      </ul>

      {/* Tab Content */}
      <div className="tab-content mt-4">
        {/* Add Shift Tab Content */}
        {selectedTab === "addShift" && (
          <div className="tab-pane fade show active" role="tabpanel">
            <div className="card mb-4" style={{ border: "none" }}>
              <div className="card-body">
                <h5>{shiftData.id ? "Edit Shift" : "Create Shift"}</h5>

                <div className="row mb-4 g-3">
                  {/* Shift Name Input */}
                  <div className="col-md-6">
                    <Inputcom
                      id="shift_name"
                      label="Shift Name"
                      type="text"
                      placeholder="Enter Shift Name"
                      value={shiftData.shift_name}
                      onChange={handleInputChange}
                      className="form-control"
                    />
                  </div>

                  {/* Net Working Hours Input */}
                  <div className="col-md-6">
                    <Inputcom
                      id="net_working_hours"
                      label="Net Working Hours"
                      type="number"
                      placeholder="Enter Working Hours"
                      value={shiftData.net_working_hours}
                      onChange={handleInputChange}
                      className="form-control"
                    />
                  </div>

                  {/* Is Rotated Checkbox */}
                  <div className="col-md-6 d-flex align-items-center">
                    <input
                      type="checkbox"
                      id="is_rotated"
                      checked={shiftData.is_rotated}
                      onChange={handleInputChange}
                      className="form-check-input me-2"
                    />
                    <label htmlFor="is_rotated" className="form-check-label">Is Rotated</label>
                  </div>

                  {/* Submit Button */}
                  <div className="col-md-6 d-flex align-items-end w-auto ms-auto">
                    <Buttonadd label={shiftData.id ? "Update Shift" : "Add Shift"} onClick={addShift} />
                  </div>
                </div>

                {/* Shift List Table */}
                <h5>Shift List</h5>
                <Tablecom
                  headers={["SR.NO", "Shift Name", "Net Working Hours", "Is Rotated", "Actions"]}
                  data={getshifts}
                  keys={["id", "shift_name", "net_working_hours", "is_rotated"]}
                  deletedata={deleteShift}
                  editdata={editShift}
                />
              </div>
            </div>
          </div>
        )}

        {/* Shift Details Tab Content */}
        {selectedTab === "shiftDetails" && (
          <div className="tab-pane fade show active" role="tabpanel">
            <Shifttemplate /> {/* Render the Shift Details Component */}
          </div>
        )}

<div className="d-flex justify-content-end  mb-3 me-2">
            <button className="btn btn-success me-2 rounded-5"
              style={{ minWidth: "200px" }}
            >
              Confirm
            </button>
            <button

              className="btn btn-primary rounded-5"
              style={{ minWidth: "200px" }}
            >
              Next
            </button>
          </div>
      </div>
      
    </div>
  );
}

export default AddShifttemplate;
