import React, { useEffect, useState, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../../context/Userstate";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import Inputcom from "../../components/Input";
import axios from "axios";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Buttonadd from "../../components/Button";
import Tablecom from "../../components/Table";

export default function Division() {
  const navigate = useNavigate();
  const headers = ["SR.NO","Division Name","Action"];
  const keys= ["SR.NO","name"];
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);
  const [getdivisions, setGetDivisions] = useState([]);
  const [divisionData, setDivisionData] = useState({
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

    setDivisionData({
      ...divisionData,
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
    if (!divisionData.name) {
      toast.error("Please enter a division name!");
      return;
    }
    const newDivisionData = { ...divisionData };
    if (!newDivisionData.id) {
      delete newDivisionData.id;
      axios
        .post("http://localhost:3000/divisions", newDivisionData)
        .then((res) => {
          toast.success("Division added successfully!");
          getdivisiondata();
          resetForm();
        })
        .catch((err) => {
          console.error(err);
          toast.error("Error adding division.");
        });
    } else {
      axios
        .put(
          `http://localhost:3000/divisions/${newDivisionData.id}`,
          newDivisionData
        )
        .then((res) => {
          toast.success("Division updated successfully!");
          getdivisiondata();
          resetForm();
        })
        .catch((err) => {
          console.error(err);
          toast.error("Error updating division.");
        });
    }
  };

  const getdivisiondata = () => {
    axios
      .get("http://localhost:3000/divisions")
      .then((res) => {
        console.log(res.data);
        setGetDivisions(res.data);
      })
      .catch((err) => {
        console.log(err);
      });
  };

  const deletedata = (id) => {
    axios
      .delete(`http://localhost:3000/divisions/${id}`)
      .then((res) => {
        toast.success("Division deleted successfully!");
        getdivisiondata();
      })
      .catch((err) => {
        console.error(err);
        toast.error("Error deleting division.");
      });
  };

  const resetForm = () => {
    setDivisionData({
      id: null,
      business_id: "",
      name: "",
    });
  };
  const editdata = (division) => {
    setDivisionData({
      ...division,
      name: division.name ? division.name : "",
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
            <h5>{divisionData.id ? "Edit Division" : "Create Division"}</h5>
            <form>
              <div className="row mb-3">
                <div className="col">
                <Inputcom
                id='name'
                type="text"
                label="Name"
                placeholder='Enter Division'
                value={divisionData.name}
                onChange={handleInputChange}
                style={{ backgroundColor: "#f5f6fa" }}
              />
                </div>
                <div className="col-auto d-flex align-items-end">
                  <Buttonadd label={divisionData.id ? "Update Division" : "Add Division"} onClick={addDivision}/>
                </div>
              </div>
            </form>
          </div>
          <h5>Division List</h5>

          <div className="col-md-12">
            <Tablecom headers={headers} data={getdivisions} deletedata={deletedata} editdata={editdata} keys={keys} />
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
  );
}
