import React, { useState } from "react"
import { useNavigate } from "react-router-dom"
import { EyeOutlined, EyeInvisibleOutlined } from "@ant-design/icons"
import Input from "../components/Input"
import { postRequest } from "../services/Api"
import { saveAuthData } from "../services/authUtils"
import axios from "axios"

function Signin() {
  // const [showPassword, setShowPassword] = useState(false)
  // const [formData, setFormData] = useState({
  //   mobileNo: "",
  //   password: "",
  // })
  // const [companies, setCompanies] = useState([])
  // const [selectedCompanyId, setSelectedCompanyId] = useState(null)
  // const [isLoading, setIsLoading] = useState(false)
  // const navigate = useNavigate()

  // const togglePasswordVisibility = () => {
  //   setShowPassword((prevState) => !prevState)
  // }

  // const handleInputChange = (e) => {
  //   const { id, value } = e.target
  //   setFormData((prevData) => ({
  //     ...prevData,
  //     [id]: value,
  //   }))
  // }

  // const fetchCompanies = async () => {
  //   if (!formData.mobileNo || !formData.password) {
  //     alert("Please enter both mobile number and password.")
  //     return
  //   }

  //   setIsLoading(true)
  //   try {
  //     const response = await postRequest("/Auth/GetLoginCompanies", {
  //       mobileNo: formData.mobileNo,
  //       password: formData.password,
  //       companyId: 0,
  //     })
  //     setCompanies(response.data)

  //     if (response.data.length === 1) {
  //       setSelectedCompanyId(response.data[0].companyId)
  //     } else if (response.data.length > 1) {
  //       setSelectedCompanyId(null)
  //     } else {
  //       alert("No companies found for this user. Please check your credentials.")
  //     }
  //   } catch (error) {
  //     console.error("Failed to fetch companies:", error)
  //     alert("Failed to fetch companies. Please check your credentials and try again.")
  //   } finally {
  //     setIsLoading(false)
  //   }
  // }

  // const handleCompanySelect = (e) => {
  //   setSelectedCompanyId(Number(e.target.value))
  // }

  // const signinButton = async (e) => {
  //   e.preventDefault()
  //   setIsLoading(true)

  //   try {
  //     // Always fetch companies first
  //     const companiesResponse = await postRequest("/Auth/GetLoginCompanies", {
  //       mobileNo: formData.mobileNo,
  //       password: formData.password,
  //       companyId: 0,
  //     })

  //     if (companiesResponse.data.length === 0) {
  //       alert("No companies found for this user. Please check your credentials.")
  //       setIsLoading(false)
  //       return
  //     }

  //     setCompanies(companiesResponse.data)

  //     let companyIdToUse
  //     if (companiesResponse.data.length === 1) {
  //       companyIdToUse = companiesResponse.data[0].companyId
  //     } else {
  //       if (!selectedCompanyId) {
  //         setIsLoading(false)
  //         return
  //       }
  //       companyIdToUse = selectedCompanyId
  //     }

  //     // Proceed with login
  //     const loginResponse = await postRequest("/Auth/Login", {
  //       mobileNo: formData.mobileNo,
  //       password: formData.password,
  //       companyId: companyIdToUse,
  //     })

  //     console.log("Sign-In successful:", loginResponse.data)

  //     // Save auth data
  //     saveAuthData(loginResponse.data)

  //     navigate("/hrms/masterscreen")
  //   } catch (error) {
  //     console.error("Sign-In failed:", error)
  //     alert("Invalid credentials or company selection. Please try again.")
  //   } finally {
  //     setIsLoading(false)
  //   }

  const [showPassword, setShowPassword] = useState(false)
  const [formData, setFormData] = useState({
    mobileNo: "",
    password: "",
  })
  const [companies, setCompanies] = useState([])
  const [selectedCompanyId, setSelectedCompanyId] = useState(null)
  const [isLoading, setIsLoading] = useState(false)
  const [authToken, setAuthToken] = useState(null) // Added state for auth token
  const navigate = useNavigate()

  const togglePasswordVisibility = () => {
    setShowPassword((prevState) => !prevState)
  }

  const handleInputChange = (e) => {
    const { id, value } = e.target
    setFormData((prevData) => ({
      ...prevData,
      [id]: value,
    }))
  }

  const fetchCompanies = async () => {
    if (!formData.mobileNo || !formData.password) {
      alert("Please enter both mobile number and password.")
      return
    }

    setIsLoading(true)
    try {
      const response = await postRequest("/Auth/GetLoginCompanies", {
        mobileNo: formData.mobileNo,
        password: formData.password,
        companyId: 0,
      })
      setCompanies(response.data)

      if (response.data.length === 1) {
        setSelectedCompanyId(response.data[0].companyId)
      } else if (response.data.length > 1) {
        setSelectedCompanyId(null)
      } else {
        alert("No companies found for this user. Please check your credentials.")
      }
    } catch (error) {
      console.error("Failed to fetch companies:", error)
      alert("Failed to fetch companies. Please check your credentials and try again.")
    } finally {
      setIsLoading(false)
    }
  }

  const handleCompanySelect = (e) => {
    setSelectedCompanyId(Number(e.target.value))
  }

  const signinButton = async (e) => {
    e.preventDefault()
    setIsLoading(true)

    try {
      // Always fetch companies first
      const companiesResponse = await postRequest("/Auth/GetLoginCompanies", {
        mobileNo: formData.mobileNo,
        password: formData.password,
        companyId: 0,
      })

      if (companiesResponse.data.length === 0) {
        alert("No companies found for this user. Please check your credentials.")
        setIsLoading(false)
        return
      }

      setCompanies(companiesResponse.data)

      let companyIdToUse
      if (companiesResponse.data.length === 1) {
        companyIdToUse = companiesResponse.data[0].companyId
      } else {
        if (!selectedCompanyId) {
          setIsLoading(false)
          return
        }
        companyIdToUse = selectedCompanyId
      }

      // Proceed with login
      const loginResponse = await postRequest("/Auth/Login", {
        mobileNo: formData.mobileNo,
        password: formData.password,
        companyId: companyIdToUse,
      })

      console.log("Sign-In successful:", loginResponse.data)

      // Save auth data and set token
      saveAuthData(loginResponse.data)
      setAuthToken(loginResponse.data.token)

      navigate("/hrms/masterscreen")
    } catch (error) {
      console.error("Sign-In failed:", error)
      alert("Invalid credentials or company selection. Please try again.")
    } finally {
      setIsLoading(false)
    }
  
  }

  return (
    <div className="container-fluid min-vh-100 bg-primary d-flex align-items-center">
      <div className="row w-100">
        <div className="col-md-6 d-flex flex-column justify-content-center text-white px-5">
          <h1 className="display-4 fw-bold text-center">"Welcome Back,</h1>
          <h1 className="display-4 fw-bold text-center">Let's Achieve Together".</h1>
        </div>

        <div className="col-md-6">
          <div className="card p-4" style={{ borderRadius: "25px" }}>
            <h2 className="text-start ps-4 mb-4">Sign In</h2>
            <form className="m-2" onSubmit={signinButton}>
              {/* mobileNo */}
              <div className="form-group mb-3">
                <Input
                  id="mobileNo"
                  type="number"
                  label="mobileNo"
                  placeholder="Enter mobileNo"
                  onChange={handleInputChange}
                  style={{ backgroundColor: "#f5f6fa" }}
                  required
                />
              </div>

              {/* Password */}
              <div className="form-group position-relative">
                <label style={{ marginLeft: "14px", color: "grey" }}>Password</label>
                <input
                  id="password"
                  type={showPassword ? "text" : "password"}
                  className="form-control rounded-pill mb-3"
                  style={{ backgroundColor: "#f5f6fa" }}
                  placeholder="Enter password"
                  onChange={handleInputChange}
                  required
                />
                <span
                  style={{ position: "absolute", top: "30px" }}
                  className="end-0 me-4"
                  onClick={togglePasswordVisibility}
                >
                  {showPassword ? <EyeInvisibleOutlined /> : <EyeOutlined />}
                </span>
              </div>

              {/* Company Dropdown */}
              {companies.length > 1 && (
                <div className="form-group mb-3">
                  <label style={{ marginLeft: "14px", color: "grey" }}>Select Company</label>
                  <select className="form-select rounded-pill" onChange={handleCompanySelect} required>
                    <option value="">Choose a company</option>
                    {companies.map((company) => (
                      <option key={company.companyId} value={company.companyId}>
                        {company.name}
                      </option>
                    ))}
                  </select>
                </div>
              )}

              {/* Remember Me */}
              <div className="form-check my-3">
                <input type="checkbox" className="form-check-input me-2" id="rememberMe" />
                <label className="form-check-label small" htmlFor="rememberMe">
                  Remember me
                </label>
              </div>

              {/* Sign In Button */}
              <div className="d-block text-center">
                <button type="submit" className="btn btn-primary rounded-pill my-3 w-50" disabled={isLoading}>
                  {isLoading ? "Signing In..." : "Sign In"}
                </button>
              </div>

              {/* Forgot Password and Sign Up Links */}
              <div className="text-center">
                <p className="small">
                  <a href="/forgot-password" className="text-primary">
                    Forgot Password?
                  </a>
                </p>
                <p className="small">
                  Don't have an account?{" "}
                  <a href="/signup" className="text-primary">
                    Sign Up
                  </a>
                </p>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  )
}

export default Signin

