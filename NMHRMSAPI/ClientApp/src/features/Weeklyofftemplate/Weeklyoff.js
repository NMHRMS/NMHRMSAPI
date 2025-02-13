import React, { useContext, useEffect, useState } from "react";
import { useLocation, useNavigate, useParams } from "react-router-dom";
import axios from "axios";
import { UserContext } from "../../context/Userstate";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

function Weeklyoff() {
  const navigate = useNavigate();
  const { id } = useParams();
  const location = useLocation();
  const { state: policyData } = location;
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);

  const [data, setData] = useState({
    policyName: "",
    generalWeeklyOffs: [],
    alternatingWeeklyOffs: {
      Monday: [],
      Tuesday: [],
      Wednesday: [],
      Thursday: [],
      Friday: [],
      Saturday: [],
      Sunday: [],
    },
  });

  // Handle Input Changes
  const handleChange = (e) => {
    const { id, type, checked, value } = e.target;

    if (type === "checkbox") {
      const [field, day, idx] = id.split("-");
      if (field === "day") {
        // General Weekly Off
        setData((prev) => ({
          ...prev,
          generalWeeklyOffs: checked
            ? [...prev.generalWeeklyOffs, day]
            : prev.generalWeeklyOffs.filter((d) => d !== day),
        }));
      } else if (field === "toggle") {
        // Alternating Weekly Off
        const weekNumber = parseInt(idx) + 1;
        setData((prev) => ({
          ...prev,
          alternatingWeeklyOffs: {
            ...prev.alternatingWeeklyOffs,
            [day]: checked
              ? [...prev.alternatingWeeklyOffs[day], weekNumber]
              : prev.alternatingWeeklyOffs[day].filter(
                  (week) => week !== weekNumber
                ),
          },
        }));
      }
    } else {
      setData({ ...data, policyName: value });
    }
  };

  // Handle Form Submission (Add or Update)
  const handleSubmit = (e) => {
    e.preventDefault();

    if (!data.policyName.trim()) {
      toast.error("Policy Name is required!");
      return;
    }

    if (data.generalWeeklyOffs.length === 0) {
      toast.error("Please select at least one General Weekly Off!");
      return;
    }

    const apiUrl = id
      ? `http://localhost:3000/weekly_off_policies/${id}`
      : "http://localhost:3000/weekly_off_policies";

    const apiCall = id ? axios.put(apiUrl, data) : axios.post(apiUrl, data);

    apiCall
      .then((res) => {
        toast.success(
          id ? "Policy updated successfully!" : "Policy added successfully!"
        );
        navigate(
          location.pathname.includes("/businesssetup")
            ? "/businesssetup/addweeklyoff"
            : "/hrms/addweekoffs"
        );
      })
      .catch((error) => {
        console.error("Error during API request:", error);
        toast.error("Failed to save policy.");
      });
  };

  // Fetch Existing Data in Edit Mode
  useEffect(() => {
    if (policyData) {
      setData(policyData);
    } else if (id) {
      axios
        .get(`http://localhost:3000/weekly_off_policies/${id}`)
        .then((res) => setData(res.data))
        .catch((err) => {
          console.error("Error fetching policy:", err);
          toast.error("Failed to fetch policy data.");
        });
    }
  }, [policyData, id]);

  // Confirm Button Action
  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      weeklyoffmaster: { confirm: true, next: false },
    }));
    navigate("/businesssetup/leavetemplatemaster");
  };

  // Next Button Action
  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      weeklyoffmaster: { confirm: false, next: true },
    }));
    navigate("/businesssetup/leavetemplatemaster");
  };

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row">
            <h5>{data.id ? "Edit Weekly Off" : "Create Weekly Off"}</h5>
            <form>
              <div className="row mb-3">
                {/* Policy Name Input */}
                <div className="col mb-3">
                  <label htmlFor="policyName" className="form-label">
                    Policy Name
                  </label>
                  <input
                    type="text"
                    value={data.policyName}
                    onChange={handleChange}
                    className="form-control rounded-pill w-50"
                    id="policyName"
                    placeholder="Enter Policy Name"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
              </div>
            </form>
          </div>
          {/* General Weekly Offs */}
          <div className="mb-3">
            <label className="form-label">General Weekly Off's</label>
            <div className="d-flex flex-wrap">
              {[
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
              ].map((day, index) => (
                <div key={index} className="form-check me-3">
                  <input
                    checked={data.generalWeeklyOffs.includes(day)}
                    onChange={handleChange}
                    className="form-check-input"
                    type="checkbox"
                    id={`day-${day}`}
                  />
                  <label className="form-check-label" htmlFor={`day-${day}`}>
                    {day}
                  </label>
                </div>
              ))}
            </div>
          </div>

          {/* Alternating Weekly Offs */}
          <div className="mb-3">
            <label className="form-label small">
              Alternating Weekly Off's (Optional)
            </label>
            <div className="table-responsive">
              <table className="table">
                <thead>
                  <tr>
                    <th></th>
                    {["1st", "2nd", "3rd", "4th", "5th"].map((week, index) => (
                      <th key={index} className="text-center">
                        {week}
                      </th>
                    ))}
                  </tr>
                </thead>
                <tbody>
                  {[
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday",
                  ].map((day, index) => (
                    <tr key={index}>
                      <td>{day}</td>
                      {Array.from({ length: 5 }).map((_, idx) => (
                        <td key={idx} className="text-center">
                          <div className="form-check form-switch d-flex justify-content-center">
                            <input
                              checked={
                                data.alternatingWeeklyOffs[day]?.includes(
                                  idx + 1
                                ) || false
                              }
                              onChange={handleChange}
                              className="form-check-input"
                              type="checkbox"
                              id={`toggle-${day}-${idx}`}
                            />
                          </div>
                        </td>
                      ))}
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          </div>

          {/* Action Buttons */}
          <div className="d-flex justify-content-end mb-3">
            <button
              style={{ minWidth: "170px" }}
              onClick={handleSubmit}
              className="btn btn-primary me-2 w-10 rounded-5"
            >
              {id ? "Update" : "Add"}
            </button>
            <button
              className="btn btn-success me-2 rounded-5"
              onClick={confirmButton}
              style={{ minWidth: "170px" }}
            >
              Confirm
            </button>
            <button
              className="btn btn-primary rounded-5"
              onClick={nextButton}
              style={{ minWidth: "170px" }}
            >
              Next
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Weeklyoff;
