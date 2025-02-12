import React, { useState, useEffect, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../context/Userstate";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import axios from "axios";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Inputcom from "../Basiccomponents/Inputcom";
import Buttonadd from "../Basiccomponents/Buttonadd";
import Tablecom from "../Basiccomponents/Tablecom";
import Selectcom from "../Basiccomponents/Selectcom";
function Department() {
  const headers = ["SR.NO","Division Name", "Department Name", "Action"];
  const keys = ["SR.NO", "division_name", "name"];
  const navigate = useNavigate();
  const [getDepartments, setGetDepartments] = useState([]);
  const [getDivisions, setGetDivisions] = useState([]);
  const [departmentData, setDepartmentData] = useState({
    id: null,
    business_id: "", // Assuming a business_id might be needed if it’s part of your data model
    division_id: "",
    name: "",
  });
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);

  const handleInputChange = (e) => {
    const { id, value } = e.target;
    //validation space updation, Check if the input starts with a space
    if (id === "name" && value.startsWith(" ")) {
      toast.error("Space is not allowed at the start of the Department Name.");
      return;
    }
    setDepartmentData({
      ...departmentData,
      [id]: value,
    });
  };

  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      departmentmaster: { confirm: true, next: false },
    }));
    navigate("/businesssetup/designationmaster");
  };

  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      departmentmaster: { confirm: false, next: true },
    }));
    navigate("/businesssetup/designationmaster");
  };
  const addDepartment = () => {
    // Validation
    if (!departmentData.division_id) {
      toast.error("Please select a division.");
      return;
    }

    if (!departmentData.name) {
      toast.error("Please enter the department name.");
      return;
    }

    const newDepartmentData = { ...departmentData };
    if (!newDepartmentData.id) {
      delete newDepartmentData.id;
      axios
        .post("http://localhost:3000/departments", newDepartmentData)
        .then((res) => {
          toast.success("Department added successfully!");
          getDepartmentData();
          resetForm();
        })
        .catch((err) => {
          console.error(err);
          toast.error("Failed to add department.");
        });
    } else {
      axios
        .put(
          `http://localhost:3000/departments/${newDepartmentData.id}`,
          newDepartmentData
        )
        .then((res) => {
          toast.success("Department updated successfully!");
          getDepartmentData();
          resetForm();
        })
        .catch((err) => {
          console.error(err);
          toast.error("Failed to update department.");
        });
    }
  };


  const getDepartmentData = async() => {

    try {
      const divisionresponse= await axios.get("http://localhost:3000/divisions")
      setGetDivisions(divisionresponse.data)

      const departmentResponse = await axios.get("http://localhost:3000/departments");
      const enrichedData = departmentResponse.data.map((department) => {
        const division = divisionresponse.data.find(
          (dept) => dept.id === department.division_id
        );
        return {
          ...department,
          division_name: division ? division.name : "Unknown",
        };
      });
      setGetDepartments(enrichedData)
    } catch (error) {
      console.error("Error fetching data:", error); 
    }
    // axios
    //   .get("http://localhost:3000/departments")
    //   .then((res) => {
    //     console.log(res.data);
    //     setGetDepartments(res.data);
    //   })
    //   .catch((err) => {
    //     console.log(err);
    //   });
  };

  // const getDivisionData = () => {
  //   axios
  //     .get("http://localhost:3000/divisions")
  //     .then((res) => {
  //       console.log(res.data);
  //       setGetDivisions(res.data);
  //     })
  //     .catch((err) => {
  //       console.log(err);
  //     });
  // };

  const editData = (department) => {
    setDepartmentData({
      ...department,
      name: department.name ? department.name : "",
    });
  };

  const deleteData = (id) => {
    alert(id)
    axios
      .delete(`http://localhost:3000/departments/${id}`)
      .then((res) => {
        toast.success("Department deleted successfully!");
        getDepartmentData();
      })
      .catch((err) => {
        console.error(err);
        toast.error("Failed to delete department.");
      });
  };

  const resetForm = () => {
    setDepartmentData({
      id: null,
      business_id: "",
      division_id: "",
      name: "",
    });
  };
  useEffect(() => {
    getDepartmentData();
    // getDivisionData();
  }, []);

  console.log("depres",getDepartments);
  

  return (
    <div className="container mt-2 ">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row">
            <h5>
              {departmentData.id ? "Edit Department" : "Create Department"}
            </h5>
            <form>
              <div className="row mb-3">
                <div className="col">
                <Selectcom
                    id="division_id"
                    label="Select Division"
                    options={getDivisions}
                    value={departmentData.division_id}
                    onChange={handleInputChange}
                    placeholder="Select a department"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col">
                <Inputcom
                    id="name"
                    type="text"
                    label="Name"
                    placeholder="Enter Designation"
                    value={departmentData.name}
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3 d-flex align-items-end">
              <Buttonadd label={departmentData.id ? "Update Department" : "Add Department"} onClick={addDepartment}/>
                </div>
              </div>
            </form>
          </div>

          <h5>Department List</h5>
          <div className="col-md-12">
          <Tablecom
              headers={headers}
              data={getDepartments}
              deletedata={deleteData}
              editdata={editData}
              keys={keys}
            />
          </div>

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

export default Department;
