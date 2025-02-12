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

function Employesscategories() {
    const navigate = useNavigate();
    const headers = ["SR.NO","EmployeeCategory Name","Action"];
    const keys= ["SR.NO","name"];
    const { badgeStatus, setBadgeStatus } = useContext(UserContext);
    const [getemployeecategories, setGetEmployeecategories] = useState([]);
    const [employeecategoriesData, setEmployeeCategoriesData] = useState({
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
  
      setEmployeeCategoriesData({
        ...employeecategoriesData,
        [id]: value,
      });
    };
  
    const confirmButton = () => {
      setBadgeStatus((prevStatus) => ({
        ...prevStatus,
        employeecategoriesmaster: { confirm: true, next: false },
      }));
      navigate("/businesssetup/departmentmaster");
    };
  
    const nextButton = () => {
      setBadgeStatus((prevStatus) => ({
        ...prevStatus,
        employeecategoriesmaster: { confirm: false, next: true },
      }));
      navigate("/businesssetup/departmentmaster");
    };
  
    const addDivision = () => {
      if (!employeecategoriesData.name) {
        toast.error("Please enter a EmployeeCategory name!");
        return;
      }
      const newDivisionData = { ...employeecategoriesData };
      if (!newDivisionData.id) {
        delete newDivisionData.id;
        axios
          .post("http://localhost:3000/divisions", newDivisionData)
          .then((res) => {
            toast.success("EmployeeCategory added successfully!");
            getdivisiondata();
            resetForm();
          })
          .catch((err) => {
            console.error(err);
            toast.error("Error adding EmployeeCategory.");
          });
      } else {
        axios
          .put(
            `http://localhost:3000/divisions/${newDivisionData.id}`,
            newDivisionData
          )
          .then((res) => {
            toast.success("EmployeeCategory updated successfully!");
            getdivisiondata();
            resetForm();
          })
          .catch((err) => {
            console.error(err);
            toast.error("Error updating EmployeeCategory.");
          });
      }
    };
  
    const getdivisiondata = () => {
      axios
        .get("http://localhost:3000/divisions")
        .then((res) => {
          console.log(res.data);
          setGetEmployeecategories(res.data);
        })
        .catch((err) => {
          console.log(err);
        });
    };
  
    const deletedata = (id) => {
      axios
        .delete(`http://localhost:3000/divisions/${id}`)
        .then((res) => {
          toast.success("EmployeeCategory deleted successfully!");
          getdivisiondata();
        })
        .catch((err) => {
          console.error(err);
          toast.error("Error deleting EmployeeCategory.");
        });
    };
  
    const resetForm = () => {
      setEmployeeCategoriesData({
        id: null,
        business_id: "",
        name: "",
      });
    };
    const editdata = (EmployeeCategory) => {
      setEmployeeCategoriesData({
        ...EmployeeCategory,
        name: EmployeeCategory.name ? EmployeeCategory.name : "",
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
          <h5>{employeecategoriesData.id ? "Edit Employee Category" : "Create Employee Category"}</h5>
          <form>
            <div className="row mb-3">
              <div className="col">
              <Inputcom
              id='name'
              type="text"
              label="Name"
              placeholder='Management,Worker,Helper,Technical'
              value={employeecategoriesData.name}
              onChange={handleInputChange}
              style={{ backgroundColor: "#f5f6fa" }}
            />
              </div>
              <div className="col-auto d-flex align-items-end">
                <Buttonadd label={employeecategoriesData.id ? "Update Employee Category" : "Add Employee Category"} onClick={addDivision}/>
              </div>
            </div>
          </form>
        </div>
        <h5>Employee Category List</h5>

        <div className="col-md-12">
          <Tablecom headers={headers} data={getemployeecategories} deletedata={deletedata} editdata={editdata} keys={keys} />
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

export default Employesscategories