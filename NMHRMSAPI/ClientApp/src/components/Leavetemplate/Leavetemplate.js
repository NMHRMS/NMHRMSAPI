import React, { useState, useContext, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../context/Userstate";
import axios from "axios";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Inputcom from "../Basiccomponents/Inputcom";
import Buttonadd from "../Basiccomponents/Buttonadd";
import Tablecom from "../Basiccomponents/Tablecom";
import Selectcom from "../Basiccomponents/Selectcom";
export default function Leavetemplate() {
  const headers = ["SR.NO"," Category Name", "Abbreviation","Count(Per Year)","Unused Leave Rule","Encashment/CF Limit", "Action"];
  const keys = ["SR.NO","name","abbreviation","count","unused_leave_rule","encashment_cf_limit"];
  const navigate = useNavigate();
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);
  const [getLeaves, setGetLeaves] = useState([]);
  const [leavesData, setLeavesData] = useState({
    id: null,
    business_id: "",
    name: "",
    abbreviation: "",
    count: "",
    unused_leave_rule: "",
    encashment_cf_limit: "",
  });

  const handleInputChange = (e) => {
    const { id, value } = e.target;
    //Validation of space
    if (id === "id" && /^\s/.test(value)) {
      toast.error("Space is not allowed at the start of the string.");
      return;
    }

    if (id === "abbreviation" && /^\s/.test(value)) {
      toast.error("Space is not allowed at the start of the string.");
      return;
    }
    setLeavesData({
      ...leavesData,
      [id]: value,
    });
  };

  const handleUnusedLeaveRuleChange = (e) => {
    const selectedValue = e.target.value;
    setLeavesData({
      ...leavesData,
      unused_leave_rule: selectedValue,
    });
  };

  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      leavemaster: { confirm: true, next: false },
    }));
    navigate("/businesssetup/salaryheadmaster");
  };

  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      leavemaster: { confirm: false, next: true },
    }));
    navigate("/businesssetup/salaryheadmaster");
  };

  const addLeaves = () => {
    // Validation
    let hasError = false;

    if (!leavesData.name) {
      toast.error("Please enter a leave name.");
      hasError = true;
    }

    if (!leavesData.abbreviation) {
      toast.error("Please enter a leave abbreviation.");
      hasError = true;
    }

    if (!leavesData.count) {
      toast.error("Please enter a leave count.");
      hasError = true;
    }

    if (!leavesData.unused_leave_rule) {
      toast.error("Please select an unused leave rule.");
      hasError = true;
    }

    if (hasError) {
      return;
    }

    const newLeavesData = { ...leavesData };
    if (!newLeavesData.id) {
      delete newLeavesData.id;
      axios.post("http://localhost:3000/leaves", newLeavesData).then((res) => {
        toast.success("Leave added successfully!");
        getLeavesData();
        resetForm();
      });
    } else {
      axios
        .put(`http://localhost:3000/leaves/${newLeavesData.id}`, newLeavesData)
        .then((res) => {
          toast.success("Leave updated successfully!");
          getLeavesData();
          resetForm();
        })
        .catch((err) => console.log(err));
    }
  };
  const getLeavesData = () => {
    axios
      .get("http://localhost:3000/leaves")
      .then((res) => {
        console.log(res.data);
        setGetLeaves(res.data);
      })
      .catch((err) => {
        console.log(err);
      });
  };
  const editData = (leave) => {
    setLeavesData({
      ...leave,
      name: leave.name ? leave.name : "",
    });
  };

  const deleteData = (id) => {
    axios
      .delete(`http://localhost:3000/leaves/${id}`)
      .then((res) => {
        toast.success("Leave deleted successfully!");
        getLeavesData();
      })
      .catch((err) => console.log(err));
  };

  const resetForm = () => {
    setLeavesData({
      id: null,
      business_id: "",
      name: "",
      abbreviation: "",
      count: "",
      unused_leave_rule: "",
      encashment_cf_limit: "",
    });
  };
  useEffect(() => {
    getLeavesData();
  }, []);

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row g-1 mb-3">
            <h5>{leavesData.id ? "Edit Leave" : "Create Leave"}</h5>

            <div className="col-md-4">
              {/* <label className="form-label">Leave Category Name</label>
              <input
                type="text"
                className="form-control"
                name="name"
                value={leavesData.name}
                onChange={handleInputChange}
                placeholder="Enter Category Name"
                style={{ borderRadius: "50px", backgroundColor: "#f5f6fa" }}
              /> */}
                 <Inputcom
                    id="name"
                    type="text"
                    label="Leave Category Name"
                    placeholder="Enter Category Name"
                    value={leavesData.name}
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
            </div>
            <div className="col-md-4">
              {/* <label className="form-label">Abbreviation</label>
              <input
                type="text"
                className="form-control"
                name="abbreviation"
                value={leavesData.abbreviation}
                onChange={handleInputChange}
                style={{ borderRadius: "50px", backgroundColor: "#f5f6fa" }}
              /> */}
                 <Inputcom
                    id="abbreviation"
                    type="text"
                    label="Abbreviation"
                    placeholder="days per year"
                    value={leavesData.abbreviation}
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
            </div>
            <div className="col-md-4">
            <Inputcom
                    id="count"
                    type="number"
                    label="Leave Count"
                    placeholder="days per year"
                    value={leavesData.count}
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
              {/* <label className="form-label">Leave Count</label>
              <input
                type="number"
                className="form-control"
                name="count"
                placeholder="days per year"
                value={leavesData.count}
                onChange={handleInputChange}
                style={{ borderRadius: "50px", backgroundColor: "#f5f6fa" }}
              /> */}
            </div>
            <div className="col-md-4">
              <label className="form-label">Unused Leave Rule</label>
              <select
                className="form-select rounded-pill"
                name="unused_leave_rule"
                value={leavesData.unused_leave_rule}
                onChange={handleUnusedLeaveRuleChange}
                style={{
                  backgroundColor: "#f5f6fa",
                }}
              >
                <option value="">Select</option>
                <option value="Lapse">Lapse</option>
                <option value="Carry Forward">Carry Forward</option>
                <option value="Encashment">Encashment</option>
              </select>
            </div>
            <div className="col-md-4">
              <label className="form-label">Encashment/CF Limit</label>
              <input
                type="number"
                className="form-control"
                id="encashment_cf_limit"
                placeholder="Days"
                value={leavesData.encashment_cf_limit}
                onChange={handleInputChange}
                disabled={
                  leavesData.unused_leave_rule !== "Encashment" &&
                  leavesData.unused_leave_rule !== "Carry Forward"
                }
                style={{ borderRadius: "50px", backgroundColor: "#f5f6fa" }}
              />
            </div>
            <div className="col-md-4 d-flex align-items-end">
              <Buttonadd label={leavesData.id ? "Update Leave" : "Add Leave"} onClick={addLeaves}/>
            </div>
          </div>

          <h5>Leave List</h5>
          <div className="col-md-12">
          <Tablecom
              headers={headers}
              data={getLeaves}
              deletedata={deleteData}
              editdata={editData}
              keys={keys}
            />
          </div>

          <div className="d-flex justify-content-end  mb-3 me-2">
            <button
              onClick={confirmButton}
              className="btn btn-success me-2 rounded-5"
              style={{ minWidth: "200px" }}
            >
              Confirm
            </button>
            <button
              onClick={nextButton}
              className="btn btn-primary rounded-5"
              style={{ minWidth: "200px" }}
            >
              Next
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}
