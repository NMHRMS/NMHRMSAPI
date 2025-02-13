import React, { useState } from "react";
import "./Taxation.module2.css";
import { Link, useNavigate } from "react-router-dom";

export default function Taxation() {
  const [activeTab, setActiveTab] = useState("organizationTax");
  const [states, setStates] = useState([]);

  const [isModalOpen, setIsModalOpen] = useState(false); // Modal visibility state
  const navigate = useNavigate(); // For programmatic navigation

  const handleTabClick = (tab) => {
    setActiveTab(tab);
  };

  const openModal = () => {
    setIsModalOpen(true);
  };

  const closeModal = () => {
    setIsModalOpen(false);
    navigate("/hrms/masters");
  };

  const handleYesClick = () => {
    setIsModalOpen(false);
    navigate("/branchdetails"); // Navigate to branch detail
  };

  const handleChange = (e) => {
    const { id, value } = e.target;
  };
  return (
    <div className="container mt-2 ">
      <div className="card mb-4" style={{ border: "none" }}>
        <div style={{ padding: "20px" }}>
          <div className="tabs">
            <h5>Taxation</h5>
            <ul
              className="nav nav-tabs nav-pills d-flex mb-2 taxDeductor-tab"
              id="myTab"
              role="tablist"
            >
              <li className="nav-item rounded" role="presentation">
                <a
                  className={`nav-link ${
                    activeTab === "organizationTax" ? "active" : ""
                  }`}
                  id="organizationTax-tab"
                  data-bs-toggle="tab"
                  href="#organizationTax"
                  role="tab"
                  onClick={() => handleTabClick("organizationTax")}
                >
                  Org Tax
                </a>
              </li>
              <li className="nav-item rounded" role="presentation">
                <a
                  className={`nav-link ${
                    activeTab === "taxDeductor" ? "active" : ""
                  }`}
                  id="taxDeductor-tab"
                  data-bs-toggle="tab"
                  href="#taxDeductor"
                  role="tab"
                  onClick={() => handleTabClick("taxDeductor")}
                >
                  TDS
                </a>
              </li>
              <li className="nav-item rounded" role="presentation">
                <a
                  className={`nav-link ${activeTab === "epf" ? "active" : ""}`}
                  id="epf-tab"
                  data-bs-toggle="tab"
                  href="#epf"
                  role="tab"
                  onClick={() => handleTabClick("epf")}
                >
                  EPF
                </a>
              </li>

              {/* </ul>
    <ul className="nav nav-tabs nav-pills d-flex " id="myTab" role="tablist"> */}

              <li className="nav-item rounded" role="presentation">
                <a
                  className={`nav-link ${activeTab === "esi" ? "active" : ""}`}
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
                  className={`nav-link ${activeTab === "pt" ? "active" : ""}`}
                  id="pt-tab"
                  data-bs-toggle="tab"
                  href="#pt"
                  role="tab"
                  onClick={() => handleTabClick("pt")}
                >
                  PT
                </a>
              </li>
              <li className="nav-item rounded" role="presentation">
                <a
                  className={`nav-link ${
                    activeTab === "labourFund" ? "active" : ""
                  }`}
                  id="labourFund-tab"
                  data-bs-toggle="tab"
                  href="#labourFund"
                  role="tab"
                  onClick={() => handleTabClick("labourFund")}
                >
                  LWF
                </a>
              </li>
            </ul>

            <form>
              {activeTab === "organizationTax" && (
                <div className="tab-content my-4">
                  <div className="h3" style={{ fontSize: "18px" }}>
                    Organization Tax Details
                  </div>
                  <div className="form-row row">
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputEmail4">
                        PAN Number
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputPassword4">
                        TAN Number
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        TDS Circle AO Code Number
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                  </div>
                </div>
              )}

              {activeTab === "taxDeductor" && (
                <div className="tab-content  my-4">
                  <div className="h3" style={{ fontSize: "18px" }}>
                    Tax Deductor Details
                  </div>
                  <div className="form-row row">
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        Deductors Type
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        Deductors Name
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        Deductors Father Name
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                  </div>
                </div>
              )}

              {activeTab === "epf" && (
                <div className="tab-content  my-4">
                  <div className="h3" style={{ fontSize: "18px" }}>
                    Employee Provident Fund
                  </div>
                  <div className="form-row row">
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        EPF Number
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        Employer Contribution Rate
                      </label>
                      <select id="inputState" class="form-control w-100">
                        <option selected>Select...</option>
                        <option>...</option>
                      </select>
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        Employee Contribution Rate
                      </label>
                      <select id="inputState" class="form-control w-100">
                        <option selected>Select...</option>
                        <option>...</option>
                      </select>
                    </div>
                  </div>
                </div>
              )}

              {activeTab === "esi" && (
                <div className="tab-content  my-4">
                  <div className="h3" style={{ fontSize: "18px" }}>
                    Employee State Insurance
                  </div>
                  <div className="form-row row">
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        ESI Number
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        Employer Contribution
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="% of Gross pay"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        Employee Contribution
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="% of Gross pay"
                      />
                    </div>
                  </div>
                </div>
              )}

              {activeTab === "pt" && (
                <div className="tab-content  my-4">
                  <div className="h3" style={{ fontSize: "18px" }}>
                    Professional Tax
                  </div>
                  <div className="form-row row">
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        PT Number
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label className="small" for="inputAddress">
                        State
                      </label>
                      {/* <select
                        id="state"
                        onChange={handleChange}
                        className="form-select rounded-pill"
                        style={{ backgroundColor: "#f5f6fa", height: "38px" }}
                      >
                        <option>Select</option>
                        {states.map((state) => (
                          <option key={state.id} value={state.name}>
                            {state.name}
                          </option>
                        ))}
                      </select> */}
                      <select id="inputState" class="form-control">
                        <option selected>Choose...</option>
                        <option>...</option>
                      </select>
                    </div>
                  </div>
                </div>
              )}

              {activeTab === "labourFund" && (
                <div className="tab-content  my-4">
                  <div className="h3" style={{ fontSize: "18px" }}>
                    Labour Welfare Fund
                  </div>
                  <div className="form-row row">
                    <div className="form-group col-sm-4">
                      <label for="inputAddress" className="small">
                        Employer Contribution
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                    <div className="form-group col-sm-4">
                      <label for="inputAddress" className="small">
                        Employee Contribution
                      </label>
                      <input
                        type="text"
                        class="form-control w-100"
                        placeholder="Enter"
                      />
                    </div>
                  </div>
                </div>
              )}
              {/* <Link to="/branchdetails"> */}
              <button
                type="button"
                className="btn btn-primary taxbtn"
                onClick={openModal}
              >
                Confirm
              </button>
              {/* </Link> */}
            </form>
          </div>
        </div>
      </div>

      {/* Modal */}
      {isModalOpen && (
        <div className="modal fade show d-block" tabIndex="-1" role="dialog">
          <div className="modal-dialog" role="document">
            <div className="modal-content">
              <div className="modal-body">
                <img
                  src={require("../../assets/modal1.png")}
                  alt="Illustration"
                />
                <p>
                  Does Your Business Have <br /> Multiple Branch Locations?
                </p>
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
                  onClick={closeModal}
                >
                  No
                </button>
              </div>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
