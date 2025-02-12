import React, { useEffect, useState, useContext } from "react"
import { useNavigate } from "react-router-dom"
import { UserContext } from "../../context/Userstate"
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons"
import { toast, ToastContainer } from "react-toastify"
import "react-toastify/dist/ReactToastify.css"
import Button from "../../components/Button"
import Table from "../../components/Table"
import Input from "../../components/Input"
// import { getRequest, postRequest } from "./Api"
// import { getAuthData } from "./authUtils"
import { getAuthData } from "../../services/authUtils"
import { getRequest,postRequest } from "../../services/Api"

function Grade() {
  const navigate = useNavigate()
  const headers = ["SR.NO", "Grade Name", "Action"]
  const keys = ["SR.NO", "name"]
  const { badgeStatus, setBadgeStatus } = useContext(UserContext)
  const [getgrades, setGetGrades] = useState([])
  const [gradeData, setGradeData] = useState({
    id: null,
    business_id: "",
    name: "",
  })

  const handleInputChange = (e) => {
    const { id, value } = e.target
    if (value.startsWith(" ")) {
      toast.error("Space is not allowed at the start of the name!")
      return
    }

    setGradeData({
      ...gradeData,
      [id]: value,
    })
  }

  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      divisionmaster: { confirm: true, next: false },
    }))
    navigate("/businesssetup/departmentmaster")
  }

  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      divisionmaster: { confirm: false, next: true },
    }))
    navigate("/businesssetup/departmentmaster")
  }

  const addGrade = async () => {
    const { userDetails } = getAuthData()
    try {
      const response = await postRequest("/Master/AddUpdateGrades", {
        companyID: userDetails.companyId,
        grade: gradeData.name,
        sequenceNo: 6, // You might want to make this dynamic
        isDeleted: false,
        isActive: true,
      })
      console.log(response.data)
      toast.success("Grade added successfully")
      getdivisiondata()
    } catch (err) {
      console.error("Failed to add grade:", err)
      if (err.response && err.response.status === 401) {
        toast.error("Authentication failed. Please log in again.")
        // Optionally, redirect to login page
        // navigate('/login');
      } else {
        toast.error("Failed to add grade")
      }
    }
  }

  const getdivisiondata = async () => {
    const { userDetails } = getAuthData()
    // try {
    //   const response = await getRequest(`/Master/GetGrades?companyId=${userDetails.companyId}`)
    //   setGetGrades(response.data)
    // } catch (err) {
    //   console.log(err)
    //   toast.error("Failed to fetch grades")
    // }
  }

  const deletedata = async (id) => {
    // try {
    //   await postRequest("/Master/DeleteGrade", { id })
    //   toast.success("Grade deleted successfully")
    //   getdivisiondata()
    // } catch (err) {
    //   console.log(err)
    //   toast.error("Failed to delete grade")
    // }
  }

  const resetForm = () => {
    setGradeData({
      id: null,
      business_id: "",
      name: "",
    })
  }

  const editdata = (Grade) => {
    setGradeData({
      ...Grade,
      name: Grade.name ? Grade.name : "",
    })
  }

  useEffect(() => {
    getdivisiondata()
  }, [getdivisiondata])

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row">
            <h5>{gradeData.id ? "Edit Grade" : "Create Grade"}</h5>
            {/* <form> */}
              <div className="row mb-3">
                <div className="col">
                  <Input
                    id="name"
                    type="text"
                    label="Name"
                    placeholder="Enter Grade"
                    value={gradeData.name}
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-auto d-flex align-items-end">
                  <Button label={gradeData.id ? "Update Grade" : "Add Grade"} onClick={addGrade} />
                </div>
              </div>
            {/* </form> */}
          </div>
          <h5>Grade List</h5>

          <div className="col-md-12">
            <Table headers={headers} data={getgrades} deletedata={deletedata} editdata={editdata} keys={keys} />
            <div className="d-flex justify-content-end">
              <button style={{ minWidth: "200px" }} onClick={confirmButton} className="btn btn-success me-2 rounded-5">
                Confirm
              </button>
              <button style={{ minWidth: "200px" }} onClick={nextButton} className="btn btn-primary rounded-5">
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

