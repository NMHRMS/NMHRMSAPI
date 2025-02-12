import React, { useState } from "react";
import PhoneInput from "react-phone-input-2";
import "react-phone-input-2/lib/style.css";
import { useNavigate } from "react-router-dom";
import { EyeOutlined, EyeInvisibleOutlined } from "@ant-design/icons";

function Signup() {
  const [showPassword, setShowPassword] = useState(false);
  const [showConfirmPassword, setShowConfirmPassword] = useState(false);
  const [country, setCountry] = useState("in");
  const [number, setNumber] = useState("");

  const navigate = useNavigate();

  const togglePasswordVisibility = () => {
    setShowPassword((prevState) => !prevState);
  };

  const toggleConfirmPasswordVisibility = () => {
    setShowConfirmPassword((prevState) => !prevState);
  };

  const signupbutton = () => {
    alert("Signup button clicked");
    navigate("businessdetails");
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
            <h2 className="text-start ps-4 mb-4">Sign up now</h2>
            <form className="m-2">
              <div className="form-group mb-3">
                <label style={{ marginLeft: "14px", color: "grey" }}>
                  Business Name
                </label>
                <input
                  type="text"
                  className={`form-control rounded-pill mb-3`}
                  placeholder="Enter business name"
                  required
                  style={{
                    backgroundColor: "#f5f6fa",
                  }}
                />
              </div>


              <div className="form-group row">
              <div className="col-md-6">
                <label style={{ marginLeft: "14px", color: "grey" }}>
                  User First Name
                </label>
                <input
                  type="text"
                  className={`form-control rounded-pill mb-3`}
                  placeholder="Enter first name"
                  required
                  style={{
                    backgroundColor: "#f5f6fa",
                  }}
                />
              </div>
              <div className="col-md-6">
                <label style={{ marginLeft: "14px", color: "grey" }}>
                  User Last Name
                </label>
                <input
                  type="text"
                  className={`form-control rounded-pill mb-3`}
                  placeholder="Enter last name"
                  required
                  style={{
                    backgroundColor: "#f5f6fa",
                  }}
                />
              </div>
                <div className="col-md-6">
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
                </div>
                <div className="col-md-6">
                  <label style={{ marginLeft: "12px", color: "grey" }}>
                    Email
                  </label>
                  <input
                    type="email"
                    className={`form-control rounded-pill mb-3`}
                    style={{
                      backgroundColor: "#f5f6fa",
                    }}
                    placeholder="Enter email"
                    required
                  />
                </div>
              </div>

              <div className="form-group row">
                <div className="col-md-6 position-relative">
                  <label style={{ marginLeft: "14px", color: "grey" }}>
                    Password
                  </label>
                  <input
                    type={showPassword ? "text" : "password"}
                    className={`form-control rounded-pill mb-3`}
                    style={{
                      backgroundColor: "#f5f6fa",
                    }}
                    placeholder="Enter password"
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
                    type={showConfirmPassword ? "text" : "password"}
                    className={`form-control rounded-pill mb-3`}
                    style={{
                      backgroundColor: "#f5f6fa",
                    }}
                    placeholder="Confirm password"
                    required
                  />
                  <span
                    style={{ position: "absolute", top: "30px" }}
                    className={` end-0 me-4`}
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

              <div className="form-check my-3">
                <input
                  type="checkbox"
                  className="form-check-input me-2"
                  id="terms"
                />
                <label className="form-check-label small" htmlFor="terms">
                  By creating an account, I agree to our{" "}
                  <a href="#">Terms of use</a> and{" "}
                  <a href="#">Privacy Policy</a>
                </label>
              </div>
              <div className="form-check mb-3">
                <input
                  type="checkbox"
                  className="form-check-input me-2"
                  id="smsConsent"
                />
                <label className="form-check-label small" htmlFor="smsConsent">
                  By creating an account, I am also consenting to receive SMS
                  messages and emails, including product updates, events, and
                  marketing promotions.
                </label>
              </div>

              <div className="d-block text-center">
                <button
                  onClick={signupbutton}
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
