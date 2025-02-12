import React, { useState } from "react";
import PhoneInput from "react-phone-input-2";
import "react-phone-input-2/lib/style.css";
import { useNavigate } from "react-router-dom";
import { EyeOutlined, EyeInvisibleOutlined, AlignRightOutlined } from "@ant-design/icons";
import Input from "../components/Input";
import axios from "axios";
import { Link } from "react-router-dom";
// import Api from "../services/Api";
import { postRequest } from "../services/Api";

function Signup() {
  const [showPassword, setShowPassword] = useState(false);
  const [showConfirmPassword, setShowConfirmPassword] = useState(false);
  const [country, setCountry] = useState("in");
  const [number, setNumber] = useState("");
  const [formData, setFormData] = useState({
    companyName: "",
    firstName: "",
    lastName: "",
    email: "",
    mobileNo:"",
    password: "",
    confirmPassword: "",
    selectedCountry: "", // For the Country field
  });

  const navigate = useNavigate();

  const togglePasswordVisibility = () => {
    setShowPassword((prevState) => !prevState);
  };

  const toggleConfirmPasswordVisibility = () => {
    setShowConfirmPassword((prevState) => !prevState);
  };

  // Update form data when input changes
  const handleInputChange = (e) => {
    const { id, value } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [id]: value,
    }));
  };

  const signupbutton = async (e) => {
    e.preventDefault();

    // Validate passwords
    if (formData.password !== formData.confirmPassword) {
      alert("Passwords do not match!");
      return;
    }

    // API request body
    const requestBody = {
      name: formData.companyName,
      // firstName: formData.firstName,
      // lastName: formData.lastName,
      emailID: formData.email,
      password: formData.password,
      confirmPassword: formData.confirmPassword,
      mobileNo: formData.mobileNo,
      countryId: 4,


    };
    console.log(requestBody);

    try {
      // Call API
      const response = await postRequest("/Auth/SignUp", requestBody);
      // const response = await axios.post("https://localhost:7111/api/Auth/SignUp", requestBody);
      console.log("Signup successful:", response.data);
      alert("sucessfully ")
      // Navigate to business details page
      navigate("/signin");
    } catch (error) {
      console.error("Signup failed:", error);
      alert("An error occurred during signup.");
    }
  };

  return (
    <div className="container-fluid min-vh-100 bg-primary d-flex align-items-center">
      <div className="row w-100">
        <div className="col-md-6 d-flex flex-column justify-content-center text-white px-5">
          <h1 className="display-4 fw-bold text-center">"Empower Your Team,</h1>
          <h1 className="display-4 fw-bold text-center">
            Simplify Management".
          </h1>
        </div>

        <div className="col-md-6">
          <div className={`card p-4`} style={{ borderRadius: "25px" }}>
            <h2 className="text-start ps-4">Sign up</h2>
            <form className="m-2" onSubmit={signupbutton}>
              <a>Create an account or <Link to={'/signin'}>signIn</Link></a>
              {/* Company Name */}
              <div className="form-group mb-3">
                <Input
                  id="companyName"
                  type="text"
                  label="Company Name"
                  placeholder="Enter Company Name"
                  onChange={handleInputChange}
                  style={{ backgroundColor: "#f5f6fa" }}
                />
              </div>

              {/* User First and Last Name */}
              <div className="form-group row">
                <div className="col-md-6">
                  <Input
                    id="firstName"
                    type="text"
                    label="User First Name"
                    placeholder="Enter First Name"
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-6">
                  <Input
                    id="lastName"
                    type="text"
                    label="User Last Name"
                    placeholder="Enter Last Name"
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
              </div>

              {/* Mobile Number */}
              <div className="form-group row">
                {/* <div className="col-md-6">
                  <label style={{ marginLeft: "14px", color: "grey" }}>
                    Mobile Number
                  </label>
                  <PhoneInput
                    country={country}
                    value={number}
                    placeholder="Enter mobile number"
                    onChange={(value) => setNumber(value)}
                    countryCodeEditable={false}
                    containerStyle={{
                      width: "100%",
                      marginBottom: "16px",
                    }}
                    inputStyle={{
                      width: "100%",
                      borderRadius: "50px",
                      backgroundColor: "#f5f6fa",
                      fontSize: "12px",
                      borderColor: "#dee2e6",
                      paddingLeft: "65px",
                    }}
                    buttonStyle={{
                      padding: "10px",
                      borderRight: "1px solid #ccc",
                      borderColor: "#dee2e6",
                      borderRadius: "50px 0 0 50px",
                    }}
                  />
                </div> */}

                <div className="col-md-6">
                  <Input
                    id="mobileNo"
                    type="number"
                    label="Mobile No"
                    placeholder="Enter Mobile no"
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>

                {/* Email */}
                <div className="col-md-6">
                  <Input
                    id="email"
                    type="email"
                    label="Email"
                    placeholder="Enter Email"
                    onChange={handleInputChange}
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
              </div>

              {/* Country */}
              <div className="form-group mb-3">
                <label style={{ color: "grey" }}>Country</label>
                <select
                  id="selectedCountry"
                  className="form-control rounded-pill"
                  onChange={handleInputChange}
                  value={formData.selectedCountry}
                  style={{ backgroundColor: "#f5f6fa" }}
                >
                  <option value="">Select Country</option>
                  <option value="India">India</option>
                  <option value="United States">United States</option>
                  <option value="United Kingdom">United Kingdom</option>
                  <option value="Australia">Australia</option>
                </select>
              </div>

              {/* Password and Confirm Password */}
              <div className="form-group row">
                <div className="col-md-6 position-relative">
                  <label style={{ marginLeft: "14px", color: "grey" }}>
                    Password
                  </label>
                  <input
                    id="password"
                    type={showPassword ? "text" : "password"}
                    className={`form-control rounded-pill mb-3`}
                    style={{ backgroundColor: "#f5f6fa" }}
                    placeholder="Enter password"
                    onChange={handleInputChange}
                    required
                  />
                  <span
                    style={{ position: "absolute", top: "30px" }}
                    className={`end-0 me-4`}
                    onClick={togglePasswordVisibility}
                  >
                    {showPassword ? <EyeInvisibleOutlined /> : <EyeOutlined />}
                  </span>
                </div>
                <div className="col-md-6 position-relative">
                  <label style={{ marginLeft: "14px", color: "grey" }}>
                    Confirm Password
                  </label>
                  <input
                    id="confirmPassword"
                    type={showConfirmPassword ? "text" : "password"}
                    className={`form-control rounded-pill mb-3`}
                    style={{ backgroundColor: "#f5f6fa" }}
                    placeholder="Confirm password"
                    onChange={handleInputChange}
                    required
                  />
                  <span
                    style={{ position: "absolute", top: "30px" }}
                    className={`end-0 me-4`}
                    onClick={toggleConfirmPasswordVisibility}
                  >
                    {showConfirmPassword ? (
                      <EyeInvisibleOutlined />
                    ) : (
                      <EyeOutlined />
                    )}
                  </span>
                </div>
              </div>

              {/* Terms and Conditions */}
              <div className="form-check my-3">
                <input
                  type="checkbox"
                  className="form-check-input me-2"
                  id="terms"
                  required
                />
                <label className="form-check-label small" htmlFor="terms">
                  By creating an account, I agree to our{" "}
                  <a href="#">Terms of use</a> and{" "}
                  <a href="#">Privacy Policy</a>.
                </label>
              </div>

              {/* Sign Up Button */}
              <div className="d-block text-center">
                <button
                  type="submit"
                  className={`btn btn-primary rounded-pill my-3 w-50`}
                >
                  Sign Up
                </button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Signup;
