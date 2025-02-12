import React, { useState, useEffect } from "react";
import { useNavigate, useNavigation } from "react-router-dom";
import axios from "axios";
import "./businessdetails.module.css";

function Businessdetails() {
  const navigate = useNavigate();

  const [businessSectors, setBusinessSectors] = useState([]);
  const [businessTypes, setBusinessTypes] = useState([]);
  const [countries, setCountries] = useState([]);
  const [states, setStates] = useState([]);
  const [cities, setCities] = useState([]);
  const [currencies, setCurrencies] = useState([]);
  const [errors, setErrors] = useState({});
  const [bankAccountNumber, setBankAccountNumber] = useState("");
  const [mobileNumber, setMobileNumber] = useState("");
  const [formData, setFormData] = useState({
    business_code: "b001",
    business_sector: "",
    business_type: "",
    business_name: "",
    business_logo: null,
    pinCode: "",
    business_address: "",
    country: "",
    state: "",
    city: "",
    currency: "",
    employee_code: "",
    business_website: "",
    business_email: "",
    bank_holder_name: "",
    bank_accountno: "",
    bank_ifsc: "",
    bank_address: "",
    owner_full_name: "",
    owner_mob: "",
    owner_email: "",
    location1: "",
    contact_person_name: "",
    contact_person_mobile_no: "",
    contact_person_email: "",
    contact_person_address: "",
    location2: "",
  });

  useEffect(() => {
    // Fetch data from API endpoints  
    // const fetchData = async () => {
    //   try {
    //     const [sectors, types, countries, states, currencies, cities] =
    //       await Promise.all([
    //         axios.get("http://localhost:3000/business_sector"),
    //         axios.get("http://localhost:3000/business_type"),
    //         axios.get("http://localhost:3000/country"),
    //         axios.get("http://localhost:3000/state"),
    //         axios.get("http://localhost:3000/currency"),
    //         axios.get("http://localhost:3000/city_region"),
    //       ]);

    //     setBusinessSectors(sectors.data);
    //     setBusinessTypes(types.data);
    //     setCountries(countries.data);
    //     setStates(states.data);
    //     setCurrencies(currencies.data);
    //     setCities(cities.data);
    //   } catch (error) {
    //     console.error("Error fetching data:", error);
    //   }
    // };
    // fetchData();
  }, []);

  const handleChange = (e) => {
    const { id, value, files } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [id]: files ? files[0] : value,
    })); // Handle file inputs and text inputs
    // Clear error for the field being modified
    setErrors((prevErrors) => ({
      ...prevErrors,
      [id]: "", // Reset the error for the current field
    }));
  };
 

  const handleSubmit = (e) => {
    e.preventDefault()

    navigate("/businesssetup/shiftmaster");
  };

  return (
    <div
      style={{ margin: "auto", backgroundColor: "#f5f6fa" }}
      className="container-fluid"
    >
      <div className="row justify-content-center">
        <div className="col-lg-10 col-md-11">
          <p className="ms-5 mt-3 mb-2 small">Setup your organisation</p>
          <h4 className="ms-5 mb-3">Company Name</h4>

          <div className="card px-3 py-2" style={{ border: "none" }}>
            <div className="form-section px-3 py-2 mb-2">
              <label className="section-title fw-bold fs-6 ">
                Business Details
              </label>
              <div className="row g-3">
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="businessSector">
                    Business Sector
                  </label>
                  <select
                    id="businessSector"
                    // value={formData.business_sector}
                    // onChange={handleChange}
                    className={`form-select rounded-pill ${
                      errors.businessSector ? "is-invalid" : ""
                    }`}
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option>Select</option>
                    {/* {businessSectors.map((sector) => (
                      <option key={sector.id} value={sector.name}>
                        {sector.name}
                      </option>
                    ))} */}
                      <option>Construction</option>
                      <option>Hospitality</option>
                      <option>Retail</option>
                      <option>Education</option>
                  </select>
                  {errors.businessSector && (
                    <div className="invalid-feedback">
                      {errors.businessSector}
                    </div>
                  )}
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="businessType">
                    Business Type
                  </label>
                  <select
                    id="businessType"
                    // value={formData.businessType}
                    // onChange={handleChange}
                    className={`form-select rounded-pill ${
                      errors.businessType ? "is-invalid" : ""
                    }`}
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option>Select</option>
                    <option>Partnership</option>
                    <option>Corporation</option>
                    <option>Cooperative</option>
                    <option>S corporation</option>
                    {/* {businessTypes.map((type) => (
                      <option key={type.id} value={type.name}>
                        {type.name}
                      </option>
                    ))} */}
                  </select>
                  {errors.businessType && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.businessType}
                    </div>
                  )}
                </div>
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="businessName">
                    Business Name
                  </label>
                  <input
                    id="businessName"
                    value={formData.businessName} // Bind to state
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.businessName ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.businessName && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.businessName}
                    </div>
                  )}
                </div>
              </div>
              <div className="row g-3 mt-1">
              <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="pinCode">
                    Business Short Name
                  </label>
                  <input
                    id="pinCode"
                    onChange={handleChange}
                    type="text"
                    className="form-control rounded-pill w-100"
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="pinCode">
                    Pin Code
                  </label>
                  <input
                    id="pinCode"
                    onChange={handleChange}
                    type="text"
                    className="form-control rounded-pill w-100"
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                </div>
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="businessAddress">
                    Business Address
                  </label>
                  <input
                    id="businessAddress"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.pinCode ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.businessAddress && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.businessAddress}
                    </div>
                  )}
                </div>
              </div>
              <div className="row g-3 mt-1">
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="country">
                    Country
                  </label>
                  <select
                    id="country"
                    onChange={handleChange}
                    className={`form-select rounded-pill ${
                      errors.country ? "is-invalid" : ""
                    }`}
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option>Select</option>
                    <option>India</option>
                    <option>Us</option>
                    <option>UK</option>
                    {/* {countries.map((country) => (
                      <option key={country.id} value={country.name}>
                        {country.name}
                      </option>
                    ))} */}
                  </select>
                  {errors.country && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.country}
                    </div>
                  )}
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="state">
                    State
                  </label>
                  <select
                    id="state"
                    // onChange={handleChange}
                    className={`form-select rounded-pill ${
                      errors.state ? "is-invalid" : ""
                    }`}
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option>Select</option>
                    <option>Maharastra</option>
                    <option>Karnataka</option>
                    <option>Gujrat</option>
                    {/* {states.map((state) => (
                      <option key={state.id} value={state.name}>
                        {state.name}
                      </option>
                    ))} */}
                  </select>
                  {errors.state && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.state}
                    </div>
                  )}
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="city">
                    City
                  </label>
                  <select
                    id="city"
                    // onChange={handleChange}
                    className={`form-select rounded-pill ${
                      errors.city ? "is-invalid" : ""
                    }`}
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option>Select</option>
                    <option>Kolhapur</option>
                    <option>Mumbai</option>
                    <option>Pune</option>
                    {/* {cities.map((city) => (
                      <option key={city.id} value={city.name}>
                        {city.name}
                      </option>
                    ))} */}
                  </select>
                  {errors.city && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.city}
                    </div>
                  )}
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="businessLogo">
                    Business Logo
                  </label>
                  <input
                    id="businessLogo"
                    onChange={handleChange}
                    type="file"
                    className={`form-control rounded-pill ${
                      errors.businessLogo ? "is-invalid" : ""
                    }`}
                    placeholder="Select"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.businessLogo && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.businessLogo}
                    </div>
                  )}
                </div>
      
              </div>

              <div className="row g-3 mt-1">
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="Financial Year">
                    Financial Year
                  </label>
                  <select
                    id="Financial Year"
                    // onChange={handleChange}
                    className={`form-select rounded-pill ${
                      errors.country ? "is-invalid" : ""
                    }`}
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option>Select</option>
                    <option>Jan-Dec</option>
                    <option>Apr-March</option>
                   
                    {/* {countries.map((country) => (
                      <option key={country.id} value={country.name}>
                        {country.name}
                      </option>
                    ))} */}
                  </select>
                  {errors.country && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.country}
                    </div>
                  )}
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="url">
                   GST NO
                  </label>
                  <input
                    id="url"
                    onChange={handleChange}
                    type="text"
                    className="form-control rounded-pill w-100"
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="url">
                    Business Website
                  </label>
                  <input
                    id="url"
                    onChange={handleChange}
                    type="text"
                    className="form-control rounded-pill w-100"
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                </div>
                <div className="col-md-3">
                  <label className="ps-3 small" htmlFor="businessLogo">
                    LetterHead Image
                  </label>
                  <input
                    id="businessLogo"
                    onChange={handleChange}
                    type="file"
                    className={`form-control rounded-pill ${
                      errors.businessLogo ? "is-invalid" : ""
                    }`}
                    placeholder="Select"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.businessLogo && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.businessLogo}
                    </div>
                  )}
                </div>
      
              </div>

              <div className="row g-3 mt-1">
              <div className="col-md-4">
                  <label className="ps-3 small" htmlFor="url">
                    Business Vision
                  </label>
                  <input
                    id="url"
                    onChange={handleChange}
                    type="text"
                    className="form-control rounded-pill w-100"
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                </div>
          
                <div className="col-md-4">
                  <label className="ps-3 small" htmlFor="url">
                    Business Mission
                  </label>
                  <input
                    id="url"
                    onChange={handleChange}
                    type="text"
                    className="form-control rounded-pill w-100"
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                </div>
                <div className="col-md-4">
                  <label className="ps-3 small" htmlFor="url">
                    Business Profile
                  </label>
                  <input
                    id="url"
                    onChange={handleChange}
                    type="text"
                    className="form-control rounded-pill w-100"
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                </div>
      
              </div>
            </div>
          </div>
     
   
          {/* Contact Person */}
          <div className="card mt-3 px-3 py-2" style={{ border: "none" }}>
            <div className="form-section px-3 py-2 mb-2">
              <label className="section-title fw-bold fs-6 ">
                Contact Person
              </label>
              <div className="row g-3">
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="contact_person_name">
                    Full Name
                  </label>
                  <input
                    id="contact_person_name"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.contact_person_name ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.contact_person_name && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.contact_person_name}
                    </div>
                  )}
                </div>
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="mobileNumber2">
                    Mobile Number
                  </label>
                  <input
                    id="mobileNumber2"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.mobileNumber2 ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.mobileNumber2 && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.mobileNumber2}
                    </div>
                  )}
                </div>
              </div>
              <div className="row g-3 mt-1">
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="contact_person_email">
                    Email
                  </label>
                  <input
                    id="contact_person_email"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.contact_person_email ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.contact_person_email && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.contact_person_email}
                    </div>
                  )}
                </div>
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="location2">
                    Address
                  </label>
                  <input
                    id="location2"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.location2 ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.location2 && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.location2}
                    </div>
                  )}
                </div>
              </div>
            </div>
          </div>

   {/* Company Account Details */}
   <div className="card mt-3 px-3 py-2" style={{ border: "none" }}>
            <div className="form-section px-3 py-2 mb-2">
              <label className="section-title fw-bold fs-6 ">
              Company Account Details
              </label>
              <div className="row g-3">
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="contact_person_name">
                    Account No
                  </label>
                  <input
                    id="contact_person_name"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.contact_person_name ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.contact_person_name && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.contact_person_name}
                    </div>
                  )}
                </div>
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="mobileNumber2">
                    IFSC Code
                  </label>
                  <input
                    id="mobileNumber2"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.mobileNumber2 ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.mobileNumber2 && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.mobileNumber2}
                    </div>
                  )}
                </div>
              </div>
              <div className="row g-3 mt-1">
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="contact_person_email">
                    Account Holder Name
                  </label>
                  <input
                    id="contact_person_email"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.contact_person_email ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.contact_person_email && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.contact_person_email}
                    </div>
                  )}
                </div>
                <div className="col-md-6">
                  <label className="ps-3 small" htmlFor="location2">
                    Bank/Branch Address
                  </label>
                  <input
                    id="location2"
                    onChange={handleChange}
                    type="text"
                    className={`form-control rounded-pill w-100 ${
                      errors.location2 ? "is-invalid" : ""
                    }`}
                    placeholder="Enter"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  />
                  {errors.location2 && (
                    <div
                      className="invalid-feedback"
                      style={{ fontSize: "12px", paddingLeft: "10px" }}
                    >
                      {errors.location2}
                    </div>
                  )}
                </div>
              </div>
            </div>
          </div>

          {/* Submit Button */}
          <div className="text-end my-3" style={{ border: "none" }}>
            <button
              className="btn btn-primary rounded-pill mt-2 px-5"
              onClick={handleSubmit}
              style={{ minWidth: "200px" }}
            >
              Submit
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Businessdetails;

