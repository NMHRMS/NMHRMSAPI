import React, { useEffect, useState, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../../context/Userstate";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import axios from "axios";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Inputcom from "../../components/Input";
import Buttonadd from "../../components/Button";
import Tablecom from "../../components/Table";
import Selectcom from "../../components/Select";

export default function Designation() {
  const navigate = useNavigate();
  const headers = ["SR.NO", "Designation Name", "Department Name", "Grade", "Action"];
  const keys = ["SR.NO", "name", "department_name", "grades"];
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);

  const [getDesignations, setGetDesignations] = useState([]);
  const [getDepartments, setGetDepartments] = useState([]);
  const [getGrades, setGetGrades] = useState([]);
  const [designationData, setDesignationData] = useState({
    id: null,
    business_id: "",
    department_id: "",
    name: "",
    grades: "",
  });

  // Handle Input Changes
  const handleInputChange = (e) => {
    const { id, value } = e.target;
    if (/^\s/.test(value)) {
      toast.error("Space is not allowed at the start of the string.");
      return;
    }
    setDesignationData({
      ...designationData,
      [id]: value,
    });
  };

  // Confirm and Next Navigation Buttons
  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      designationmaster: { confirm: true, next: false },
    }));
    navigate("/businesssetup/holidaytemplatemaster");
  };

  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      designationmaster: { confirm: false, next: true },
    }));
    navigate("/businesssetup/holidaytemplatemaster");
  };

  // Add or Update Designation
  const addDesignation = () => {
    if (!designationData.name) {
      toast.error("Please enter the designation name.");
      return;
    }

    if (!designationData.department_id) {
      toast.error("Please select a department.");
      return;
    }

    if (!designationData.grades) {
      toast.error("Please select a grade.");
      return;
    }

    const newDesignationData = { ...designationData };

    if (!newDesignationData.id) {
      delete newDesignationData.id;
      axios
        .post("http://localhost:3000/designations", newDesignationData)
        .then(() => {
          toast.success("Designation added successfully!");
          getDesignationData();
          resetForm();
        })
        .catch(() => toast.error("Failed to add designation."));
    } else {
      axios
        .put(`http://localhost:3000/designations/${newDesignationData.id}`, newDesignationData)
        .then(() => {
          toast.success("Designation updated successfully!");
          getDesignationData();
          resetForm();
        })
        .catch(() => toast.error("Failed to update designation."));
    }
  };

  // Fetch Designations Data
  const getDesignationData = async () => {
    try {
      const departmentResponse = await axios.get("http://localhost:3000/departments");
      setGetDepartments(departmentResponse.data);

      const designationResponse = await axios.get("http://localhost:3000/designations");
      const enrichedData = designationResponse.data.map((designation) => {
        const department = departmentResponse.data.find(
          (dept) => dept.id === designation.department_id
        );
        return {
          ...designation,
          department_name: department ? department.name : "Unknown",
        };
      });
      setGetDesignations(enrichedData);
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  };

  // Fetch Grades Data
  const getGradesData = async () => {
    try {
      const gradesResponse = await axios.get("http://localhost:3000/grades");
      const gradesArray = gradesResponse.data[0]?.name || [];
      setGetGrades(gradesArray);
    } catch (error) {
      console.error("Error fetching grades data:", error);
    }
  };

  // Edit Designation
  const editdata = (designation) => {
    setDesignationData({
      ...designation,
      name: designation.name || "",
    });
  };

  // Delete Designation
  const deletedata = (id) => {
    axios
      .delete(`http://localhost:3000/designations/${id}`)
      .then(() => {
        toast.success("Designation deleted successfully!");
        getDesignationData();
      })
      .catch(() => toast.error("Failed to delete designation."));
  };

  // Reset Form
  const resetForm = () => {
    setDesignationData({
      id: null,
      business_id: "",
      department_id: "",
      name: "",
      grades: "",
    });
  };

  // Initial Data Fetching
  useEffect(() => {
    getDesignationData();
    getGradesData();
  }, []);

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row">
            <h5>{designationData.id ? "Edit Designation" : "Create Designation"}</h5>
            <form>
              <div className="row mb-3">
                <div className="col">
                  <Inputcom
                    id="name"
                    type="text"
                    label="Name"
                    placeholder="Enter Designation"
                    value={designationData.name}
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col">
                  <Selectcom
                    id="department_id"
                    label="Select Department"
                    options={getDepartments}
                    value={designationData.department_id}
                    onChange={handleInputChange}
                    placeholder="Select a department"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col">
                  <Selectcom
                    id="grades"
                    label="Select Grade"
                    options={getGrades.map((grade) => ({ id: grade, name: grade }))}
                    value={designationData.grades}
                    onChange={handleInputChange}
                    placeholder="Select a grade"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3 d-flex align-items-end">
              <Buttonadd label={designationData.id ? "Update Designation" : "Add Designation"} onClick={addDesignation}/>
                </div>
              </div>
            </form>
          </div>

          <h5>Designation List</h5>
          <div className="col-md-12">
            <Tablecom
              headers={headers}
              data={getDesignations}
              deletedata={deletedata}
              editdata={editdata}
              keys={keys}
            />
          </div>
          <div className="d-flex justify-content-end mb-3 me-2">
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
              style={{ minWidth: "200px " }}
            >
              Next
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}
