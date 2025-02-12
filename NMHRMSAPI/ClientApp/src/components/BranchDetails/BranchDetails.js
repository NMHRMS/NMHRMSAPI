import { useState, useEffect } from "react";
import { Link, useNavigate } from "react-router-dom";
import axios from "axios";

export default function BranchDetail() {
  const [activeTab, setActiveTab] = useState("organizationTax");
  const [states, setStates] = useState([]);
  const [showModal, setShowModal] = useState(false); // State for showing the modal
  const navigate = useNavigate();
  const [errors, setErrors] = useState({});
  const [countries, setCountries] = useState([]);
  const [cities, setCities] = useState([]);
  const [currencies, setCurrencies] = useState([]);
  const [selectedCountry, setSelectedCountry] = useState("");

  const handleTabClick = (tab) => {
    setActiveTab(tab);
  };

  const handleChange = (e) => {
    const { id, value } = e.target;
  };

  const handleConfirmClick = () => {
    setShowModal(true); // Show modal on confirm button click
  };

  const handleModalClose = () => {
    setShowModal(false); // Close modal
  };

  const handleYesClick = () => {
    setShowModal(false); // Close modal
    navigate("/branchdetails"); // Navigate to branch detail
  };

  const handleNoClick = () => {
    setShowModal(false); // Close modal
    navigate("/hrms/masters");
    // Optionally, handle the No button action
  };

  const handleBackdropClick = (e) => {
    if (e.target === e.currentTarget) {
      setShowModal(false); // Close modal if the backdrop is clicked
    }
  };
  useEffect(() => {
    // Fetch data from API endpoints
    const fetchData = async () => {
      try {
        const [countries, states, currencies, cities] = await Promise.all([
          axios.get("http://localhost:3000/country"),
          axios.get("http://localhost:3000/state"),
          axios.get("http://localhost:3000/currency"),
          axios.get("http://localhost:3000/city_region"),
        ]);

        setCountries(countries.data);
        setStates(states.data);
        setCurrencies(currencies.data);
        setCities(cities.data);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };
    fetchData();
  }, []);

  return (
    <div
      style={{ margin: "auto", backgroundColor: "#f5f6fa" }}
      className="container-fluid"
    >
      <div className="row justify-content-center">
        <div className="col-lg-10 col-md-11">
          <h5 className="ms-5 my-3">Company Name</h5>
          {/* <div className="d-flex justify-content-center mb-3">
            <button className="btn btn-success rounded-pill px-3 me-3">
              Business Details
            </button>
            <button className="btn btn-primary rounded-pill px-3">
              Branch Details
            </button>
          </div> */}
          {/* Branch details */}
          <div className="card px-3 py-2" style={{ border: "none" }}>
            <div className="form-section px-3 py-2 mb-2">
              <label className="section-title fw-bold fs-6 ">
                Branch Details
              </label>
              <div className="row g-3 ">
                <div className="col-md-3">
                  <label for="branchName" className="ps-3 small">
                    Branch Name
                  </label>
                  <input
                    type="text"
                    className="form-control rounded-pill px-3"
                    placeholder="Branch Name"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3">
                  <label for="branchCode" className="ps-3 small">
                    Branch Code
                  </label>
                  <input
                    type="text"
                    className="form-control rounded-pill px-3"
                    placeholder="Branch Code"
                    readonly
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3">
                  <label for="branchLogo" className="ps-3 small">
                    Branch Logo
                  </label>
                  <input
                    id="businessLogo"
                    onChange={handleChange}
                    type="file"
                    className="form-control rounded-pill px-3"
                    placeholder="Select"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3">
                  <label for="EmployeeCode" className="ps-3 small">
                    Employee Code
                  </label>
                  <input
                    type="text"
                    className="form-control rounded-pill px-3"
                    placeholder="Employee Code"
                    readonly
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
              </div>
              <div className="row g-3 mt-1">
                <div className="col-md-6">
                  <label for="branchAddress" className="ps-3 small">
                    Branch Address
                  </label>
                  <input
                    type="text"
                    className="form-control rounded-pill px-3"
                    placeholder="Business Address"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3">
                  <label for="pinCode" className="ps-3 small">
                    Pin Code
                  </label>
                  <input
                    type="text"
                    className="form-control rounded-pill px-3"
                    placeholder="Pin Code"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3">
                  <label for="country" className="ps-3 small">
                    Country
                  </label>
                  <select
                    className="form-select rounded-pill px-3"
                    style={{ backgroundColor: "#f5f6fa" }}
                    value={selectedCountry}
                    onChange={(e) => setSelectedCountry(e.target.value)}
                  >
                    <option selected>Select Country</option>
                    {countries.map((country) => (
                      <option key={country.id} value={country.name}>
                        {country.name}
                      </option>
                    ))}
                  </select>
                </div>
              </div>
              <div className="row g-3 mt-1">
                <div className="col-md-3">
                  <label for="state" className="ps-3 small">
                    State
                  </label>
                  <select
                    id="state"
                    onChange={(e) => setStates(e.target.value)}
                    className="form-select rounded-pill px-3"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option selected>Select</option>
                    {states.map((state) => (
                      <option key={state.id} value={state.name}>
                        {state.name}
                      </option>
                    ))}
                  </select>
                </div>
                <div className="col-md-3">
                  <label for="city" className="ps-3 small">
                    City
                  </label>
                  <select
                    id="city"
                    onChange={handleChange}
                    className="form-select rounded-pill px-3"
                    style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                  >
                    <option selected>Select</option>
                    {cities.map((city) => (
                      <option key={city.id} value={city.name}>
                        {city.name}
                      </option>
                    ))}
                  </select>
                </div>
                <div className="col-md-3">
                  <label for="email" className="ps-3 small">
                    Email
                  </label>
                  <input
                    type="email"
                    className="form-control rounded-pill px-3"
                    placeholder="Email"
                    value="Email"
                    style={{ backgroundColor: "#f5f6fa" }}
                  />
                </div>
                <div className="col-md-3">
                  <label for="currancy" className="ps-3 small">
                    Currency
                  </label>
                  <select
                    className="form-select rounded-pill px-3"
                    style={{ backgroundColor: "#f5f6fa" }}
                  >
                    <option selected>Select Currency</option>
                    {currencies.map((currency) => (
                      <option key={currency.id} value={currency.name}>
                        {currency.name}
                      </option>
                    ))}
                  </select>
                </div>
              </div>
            </div>
          </div>
          {/* taxation */}
          <div className="card my-3" style={{ border: "none" }}>
            <div className="form-section px-3 py-2 mb-2">
              <div style={{ padding: "20px" }}>
                <div className="tabs">
                  <label className="section-title fw-bold fs-6">Taxation</label>{" "}
                  <ul
                    className="nav nav-tabs nav-pills d-flex mb-2 taxDeductor-tab"
                    id="myTab"
                    role="tablist"
                  >
                    <li className="nav-item rounded" role="presentation">
                      <a
                        className={`nav-link ${
                          activeTab === "esi" ? "active" : ""
                        }`}
                        id="esi-tab"
                        data-bs-toggle="tab"
                        href="#esi"
                        role="tab"
                        onClick={() => handleTabClick("esi")}
                      >
                        ESI
                      </a>
                    </li>
                    <li className="nav-item rounded" role="presentation">
                      <a
                        className={`nav-link ${
                          activeTab === "pt" ? "active" : ""
                        }`}
                        id="pt-tab"
                        data-bs-toggle="tab"
                        href="#pt"
                        role="tab"
                        onClick={() => handleTabClick("pt")}
                      >
                        PT
                      </a>
                    </li>
                  </ul>
                  <form>
                    {activeTab === "esi" && (
                      <div className="tab-content  my-4">
                        <label className="section-title fw-bold fs-6 ms-3">
                          Employee State Insurance
                        </label>
                        <div className="form-row row">
                          <div className="form-group col-sm-4">
                            <label className="ps-3 small" for="inputAddress">
                              ESI Number
                            </label>
                            <input
                              type="text"
                              className="form-control rounded-pill px-3"
                              placeholder="Enter ESI number"
                              style={{ backgroundColor: "#f5f6fa" }}
                            />
                          </div>
                          <div className="form-group col-sm-4">
                            <label className="ps-3 small" for="inputAddress">
                              Employer Contribution
                            </label>
                            <input
                              type="text"
                              className="form-control rounded-pill px-3"
                              placeholder="% of Gross pay"
                              style={{ backgroundColor: "#f5f6fa" }}
                            />
                          </div>
                          <div className="form-group col-sm-4">
                            <label className="ps-3 small" for="inputAddress">
                              Employee Contribution
                            </label>
                            <input
                              type="text"
                              className="form-control rounded-pill px-3"
                              placeholder="% of Gross pay"
                              style={{ backgroundColor: "#f5f6fa" }}
                            />
                          </div>
                        </div>
                      </div>
                    )}
                    {activeTab === "pt" && (
                      <div className="tab-content  my-4">
                        <label className="section-title fw-bold fs-6 ms-3">
                          Professional Tax
                        </label>
                        <div className="form-row row">
                          <div className="form-group col-sm-4">
                            <label className="ps-3 small" for="inputAddress">
                              PT Number
                            </label>
                            <input
                              type="text"
                              className="form-control rounded-pill px-3"
                              placeholder="Enter"
                              style={{ backgroundColor: "#f5f6fa" }}
                            />
                          </div>
                          <div className="form-group col-sm-4">
                            <label className="ps-3 small" for="inputAddress">
                              State
                            </label>
                            <select
                              id="state"
                              onChange={(e) => setStates(e.target.value)}
                              className="form-select rounded-pill px-3"
                              style={{
                                backgroundColor: "#f5f6fa",
                                height: "38px",
                              }}
                            >
                              <option selected>Select</option>
                              {states.map((state) => (
                                <option key={state.id} value={state.name}>
                                  {state.name}
                                </option>
                              ))}
                            </select>
                          </div>
                        </div>
                      </div>
                    )}
                  </form>
                </div>

                <div className="d-flex justify-content-end">
                  <button
                    className="btn btn-success rounded-pill px-4 me-2"
                    onClick={handleConfirmClick}
                    style={{ minWidth: "200px" }}
                  >
                    Confirm
                  </button>
                </div>
              </div>
            </div>
          </div>
          {/* Modal */}
          {showModal && (
            <div
              className="modal show d-block"
              style={{
                display: "block",
                backgroundColor: "rgba(0, 0, 0, 0.5)",
              }}
              onClick={handleBackdropClick}
            >
              <div className="modal-dialog">
                <div className="modal-content">
                  <div className="modal-body">
                    <img
                      src={require("../../assets/modal1.png")}
                      alt="Illustration"
                    />

                    <p>Do you want to add another branch?</p>
                  </div>
                  <div className="modalfooter">
                    <button
                      type="button"
                      className="btn btn-primary"
                      onClick={handleYesClick}
                    >
                      Yes
                    </button>
                    <button
                      type="button"
                      className="btn btn-secondary"
                      onClick={handleNoClick}
                    >
                      No
                    </button>
                  </div>
                </div>
              </div>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}
