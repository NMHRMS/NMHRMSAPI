import React, { useState, useContext, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../../context/Userstate";
import { TimePicker } from "antd";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import axios from "axios";
import moment from "moment";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Inputcom from "../../components/Input";
import Timecom from "../../components/Time";
import Tablecom from "../../components/Table";
import Buttonadd from "../../components/Button";
import Selectcom from "../../components/Select";

function Shifttemplate() {
  const navigate = useNavigate();
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);
  const [getshifts, setGetshifts] = useState([]);
  const headers = ["SR.NO","Shift Name", "Shift Time From", " Shift Time To","Action"];
  const keys= ["SR.NO","shift_name", "shift_start_time", "shift_end_time"];

  const [shiftData, setshiftData] = useState({
    id: null,
    business_id: "2",
    shift_type: "fixed",
    shift_name: "",
    shift_start_time: "",
    shift_end_time: "",
    shift_duration: "",
    status: "active",
    buffer_time: "",
    break_time: "",
    break_start_time: "",
    break_end_time: "",
    break_duration: "",
  });

  const shifttype =[
    {id:1,name:"Fixed"},
    {id:2,name:"Rotation"},

  ]
  const handleTimeChange = (time, timeString, field) => {
    setshiftData({
      ...shiftData,
      [field]: timeString,
    });
  };
  const handleInputChange = (e) => {
    const { id, value } = e.target;
    //validation of space
    // Trim leading and trailing spaces
    const trimmedValue = value.trimStart();

    // Prevent input if the trimmed value differs significantly
    if (id === "shift_name" && value !== trimmedValue) {
      toast.error("Shift Name cannot start or end with spaces!");
      return;
    }
    setshiftData({
      ...shiftData,
      [id]: value,
    });
  };
  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      shiftmaster: { confirm: true, next: false },
    }));
    console.log(shiftData);
    navigate("/businesssetup/divisionmaster");
  };

  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      shiftmaster: { confirm: false, next: true },
    }));
    navigate("/businesssetup/divisionmaster");
  };
  const addshift = () => {
    if (shiftData.shift_name.trim() === "") {
      toast.error("Shift Name cannot be empty or have only spaces.");
      return;
    }
    // Validate inputs
    if (
      !shiftData.shift_name ||
      !shiftData.shift_start_time ||
      !shiftData.shift_end_time
    ) {
      toast.error("Please enter shift name and shift times.");
      return;
    }

    // Check if shift_name contains invalid characters
    if (/\s/.test(shiftData.shift_name)) {
      toast.error("Shift Name cannot contain spaces.");
      return;
    }

    const newShiftData = { ...shiftData };
    if (!newShiftData.id) {
      delete newShiftData.id;
      axios
        .post("http://localhost:3000/shifts", newShiftData)
        .then((res) => {
          console.log(res.data);
          getshiftdata();
          resetForm();
          toast.success("Shift added successfully!", {
            position: "top-right",
            autoClose: 3000,
            hideProgressBar: false,
            closeOnClick: true,
            pauseOnHover: true,
            draggable: true,
            theme: "light",
          });
        })
        .catch((err) => console.log(err));
    } else {
      axios
        .put(`http://localhost:3000/shifts/${newShiftData.id}`, newShiftData)
        .then((res) => {
          console.log(res.data);
          getshiftdata();
          resetForm();
          toast.success("Shift updated successfully!", {
            position: "top-right",
            autoClose: 3000,
            hideProgressBar: false,
            closeOnClick: true,
            pauseOnHover: true,
            draggable: true,
            theme: "light",
          });
        })
        .catch((err) => console.log(err));
    }
  };

  const getshiftdata = () => {
    axios
      .get("http://localhost:3000/shifts")
      .then((res) => {
        console.log(res.data);
        setGetshifts(res.data);
      })
      .catch((err) => {
        console.log(err);
      });
  };

  const deletedata = (id) => {
    axios
      .delete(`http://localhost:3000/shifts/${id}`)
      .then((res) => {
        console.log(res.data);
        getshiftdata();
        toast.success("Shift deleted successfully!", {
          position: "top-right",
          autoClose: 3000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
          theme: "light",
        });
      })
      .catch((err) => {
        console.error(err);
        toast.error("Failed to delete the shift. Please try again!", {
          position: "top-right",
          autoClose: 3000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
          theme: "light",
        });
      });

      alert("id",id)
  };

  const editdata = (shift) => {
    setshiftData({
      ...shift,
      shift_start_time: shift.shift_start_time
        ? moment(shift.shift_start_time, "h:mm a").format("h:mm a")
        : "",
      shift_end_time: shift.shift_end_time
        ? moment(shift.shift_end_time, "h:mm a").format("h:mm a")
        : "",
      break_start_time: shift.break_start_time
        ? moment(shift.break_start_time, "h:mm a").format("h:mm a")
        : "",
      break_end_time: shift.break_end_time
        ? moment(shift.break_end_time, "h:mm a").format("h:mm a")
        : "",
    });
  };
  const resetForm = () => {
    setshiftData({
      id: null,
      business_id: "2",
      shift_type: "fixed",
      shift_name: "",
      shift_start_time: "",
      shift_end_time: "",
      shift_duration: "",
      status: "active",
      buffer_time: "",
      break_time: "",
      break_start_time: "",
      break_end_time: "",
      break_duration: "",
    });
  };

  useEffect(() => {
    getshiftdata();
  }, []);

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row mb-4 g-3">
            <h5>{shiftData.id ? "Edit Shift" : "Create Shift"}</h5>

            <div className="col-md-4">
            <Selectcom
                    id="shift_type"
                    label="Shift Type"
                    options={shifttype}
                    value={shifttype.id}
                    onChange={handleInputChange}
                    placeholder="Select"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
            </div>
            <div className="col-md-8">
            <Selectcom
                    id="shift_name"
                    label="Name"
                    options={shifttype}
                    value={shifttype.id}
                    onChange={handleInputChange}
                    placeholder="Select"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
            </div>
            <div className="col-md-4 ">
              <Timecom
                label="Shift Start Time"
                value={shiftData.shift_start_time}
                onChange={(time, timeString) =>
                  handleTimeChange(time, timeString, "shift_start_time")
                }
              />
            </div>
            <div className="col-md-4">
              <Timecom
                label="Shift End Time"
                value={shiftData.shift_end_time}
                onChange={(time, timeString) =>
                  handleTimeChange(time, timeString, "shift_end_time")
                }
              />
           
            </div>
            <div className="col-md-4">
            <Inputcom
                id='ShiftTotalduration'
                label="Total Shift duration"
                type="text"
                placeholder='Enter '
                value=''
                onChange={handleInputChange}
                style={{ backgroundColor: "#f5f6fa" }}
              />
           
            </div>
            <div className="col-md-4">
              <Timecom
                label=" Break Start Time"
                value={shiftData.break_start_time}
                onChange={(time, timeString) =>
                  handleTimeChange(time, timeString, "break_start_time")
                }
              />
            </div>
            <div className="col-md-4">
              <Timecom
                label=" Break End Time"
                value={shiftData.break_end_time}
                onChange={(time, timeString) =>
                  handleTimeChange(time, timeString, "break_end_time")
                }
              />
            </div>
            <div className="col-md-4">
              <Inputcom
                id='Totalbreak'
                label="Totalbreak Duration"
                type="text"
                placeholder='Enter '
                value=''
                onChange={handleInputChange}
                style={{ backgroundColor: "#f5f6fa" }}
              />
            </div>
            <div className="col-md-4 d-flex align-items-end w-auto ms-auto">
              <Buttonadd label={shiftData.id ? "Update Shift" : "Add Shift"} onClick={addshift}/>
            </div>
          </div>

          {/* Shift List */}
          <h5>Shift List</h5>
          <Tablecom headers={headers} data={getshifts} deletedata={deletedata} editdata={editdata} keys={keys}  />
        </div>
        
      </div>
    </div>
  );
}

export default Shifttemplate;
