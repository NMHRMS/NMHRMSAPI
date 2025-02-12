import React, { useEffect, useState, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../context/Userstate";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import Inputcom from "../Basiccomponents/Inputcom";
import axios from "axios";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Buttonadd from "../Basiccomponents/Buttonadd";
import Tablecom from "../Basiccomponents/Tablecom";

function Grade() {
    const navigate = useNavigate();
    const headers = ["SR.NO","Grade Name","Action"];
    const keys= ["SR.NO","name"];
    const { badgeStatus, setBadgeStatus } = useContext(UserContext);
    const [getgrades, setGetGrades] = useState([]);
    const [gradeData, setGradeData] = useState({
      id: null,
      business_id: "",
      name: "",
    });
  
    const handleInputChange = (e) => {
      const { id, value } = e.target;
      // Prevent leading spaces
      if (value.startsWith(" ")) {
        toast.error("Space is not allowed at the start of the name!");
        return;
      }
  
      setGradeData({
        ...gradeData,
        [id]: value,
      });
    };
  
    const confirmButton = () => {
      setBadgeStatus((prevStatus) => ({
        ...prevStatus,
        divisionmaster: { confirm: true, next: false },
      }));
      navigate("/businesssetup/departmentmaster");
    };
  
    const nextButton = () => {
      setBadgeStatus((prevStatus) => ({
        ...prevStatus,
        divisionmaster: { confirm: false, next: true },
      }));
      navigate("/businesssetup/departmentmaster");
    };
  
    const addDivision = () => {
    
    };
  
    const getdivisiondata = () => {
  
    };
  
    const deletedata = (id) => {
   
    };
  
    const resetForm = () => {
      setGradeData({
        id: null,
        business_id: "",
        name: "",
      });
    };
    const editdata = (Grade) => {
      setGradeData({
        ...Grade,
        name: Grade.name ? Grade.name : "",
      });
    };
  
    useEffect(() => {
      getdivisiondata();
    }, []);
  return (
    <div className="container mt-2">
    <ToastContainer />
    <div className="card mb-4" style={{ border: "none" }}>
      <div className="card-body">
        <div className="row">
          <h5>{gradeData.id ? "Edit Grade" : "Create Grade"}</h5>
          <form>
            <div className="row mb-3">
              <div className="col">
              <Inputcom
              id='name'
              type="text"
              label="Name"
              placeholder='Enter Grade'
              value={gradeData.name}
              onChange={handleInputChange}
              style={{ backgroundColor: "#f5f6fa" }}
            />
              </div>
              <div className="col-auto d-flex align-items-end">
                <Buttonadd label={gradeData.id ? "Update Grade" : "Add Grade"} onClick={addDivision}/>
              </div>
            </div>
          </form>
        </div>
        <h5>Grade List</h5>

        <div className="col-md-12">
          <Tablecom headers={headers} data={getgrades} deletedata={deletedata} editdata={editdata} keys={keys} />
          <div className="d-flex justify-content-end">
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
  </div>
  )
}

export default Grade