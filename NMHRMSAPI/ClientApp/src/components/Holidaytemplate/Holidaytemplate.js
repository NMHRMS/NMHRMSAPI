import React, { useState, useEffect, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../context/Userstate";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import { DatePicker } from "antd";
import moment from "moment";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Inputcom from "../Basiccomponents/Inputcom";
import Buttonadd from "../Basiccomponents/Buttonadd";
import Tablecom from "../Basiccomponents/Tablecom";
import Selectcom from "../Basiccomponents/Selectcom";
import Datecom from "../Basiccomponents/Datecom";

function HolidayTemplate() {
  const headers = ["SR.NO", "Holiday Template Name","Action"];
  const keys = ["SR.NO", "name", "date"];
  const navigate = useNavigate();
  const [holidays, setHolidays] = useState([]);
  const [holidayData, setHolidayData] = useState({
    id: null,
    name: "",
    date: null,
  });
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);

  const handleInputChange = (e) => {
    const { id, value } = e.target;
    const trimmedValue = value.replace(/^\s+/, "");
    // Validation Space
    if (/^\s/.test(value)) {
      toast.error("Space is not allowed at the start of the string.");
      return;
    }
    setHolidayData({
      ...holidayData,
      [id]: value,
    });
  };

  const handleDateChange = (date) => {
    // alert(date)
    setHolidayData({
      ...holidayData,
      date,
    });
  };

  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      holidaymaster: { confirm: true, next: false },
    }));
    navigate("/businesssetup/addweeklyoff");
  };

  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      holidaymaster: { confirm: false, next: true },
    }));
    navigate("/businesssetup/addweeklyoff");
  };

  const addOrUpdateHoliday = () => {
   
  };

  const fetchHolidays = () => {
  
  };

  const editHoliday = (holiday) => {
    
  };

  const deleteHoliday = (id) => {
   
  };

  const resetForm = () => {
    setHolidayData({
      id: null,
      name: "",
      date: null,
    });
  };

  useEffect(() => {
    fetchHolidays();
  }, []);

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row">
            <div className="">
              <h5>{holidayData.id ? "Edit Holiday" : "Create Holiday"}</h5>
              <form>
                <div className="row mb-3">
                  <div className="col">
                    <Inputcom
                      id="name"
                      type="text"
                      label="Name"
                      placeholder="Enter Holiday"
                      value={holidayData.name}
                      onChange={handleInputChange}
                      style={{ backgroundColor: "#f5f6fa" }}
                    />
                  </div>
                  {/* <div className="col">
                    <label htmlFor="date" className="form-label">
                      Holiday Date
                    </label>
                    <Datecom
                      label="Holiday Date"
                      value={holidayData.date}
                      onChange={handleDateChange}
                      style={{ backgroundColor: "#f5f6fa" }}
                      format="YYYY-MM-DD"
                    />
                  </div> */}
                  <div className="col-md-3 d-flex align-items-end">
                    <Buttonadd label={holidayData.id ? "Update Holiday" : "Add Holiday"} onClick={addOrUpdateHoliday} />
                  </div>
                </div>
              </form>
            </div>
          </div>

          <h5>Holiday Template List</h5>
          <Tablecom
            headers={headers}
            data={holidays}
            deletedata={deleteHoliday}
            editdata={editHoliday}
            keys={keys}
          />

          <div className="d-flex justify-content-end mb-3 me-2">
            <button
              style={{ minWidth: "200px" }}
              onClick={confirmButton}
              className="btn btn-success me-2 rounded-5"
            >
              Confirm
            </button>
            <button
              style={{ minWidth: "200px" }}
              onClick={nextButton}
              className="btn btn-primary rounded-5"
            >
              Next
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default HolidayTemplate;
