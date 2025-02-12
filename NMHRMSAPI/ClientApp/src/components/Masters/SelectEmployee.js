import React from "react";
import { Link } from "react-router-dom";

function SelectEmployee() {
  return (
    <div className="container w-75">
      <div className="row"></div>
      <div className="card shadow-sm p-4">
        <h5 className="text-center mb-4">
          Please choose the type of employee you would <br />
          like to add to the Employee Masters.
        </h5>
        <div className="row align-items-center">
          {/* Left Section */}
          <div className="col-md-6 border-end text-center mb-md-0">
            <img
              src={require("../../assets/emp3.png")}
              alt="Regular Employee"
              className="img-fluid mb-3"
            />
            <h5>Regular Employee</h5>
            <p>A full-time permanent employee.</p>
            <Link to="/hrms/tabcontent">
              <button className="btn btn-primary rounded-pill w-25">
                Select
              </button>
            </Link>
          </div>

          {/* Right Section */}
          <div
            className="col-md-6 text-center"
            style={{ borderLeft: "2px dashed #0d6efd" }}
          >
            <img
              src={require("../../assets/emp4.png")}
              alt="Contractual Employee"
              className="img-fluid mb-3"
            />
            <h5>Contractual / Work Basis</h5>
            <p>A part-time contractual or work basis employee.</p>
            <Link to="">
              <button className="btn btn-primary rounded-pill w-25">
                Select
              </button>
            </Link>
          </div>
        </div>
      </div>
    </div>
  );
}

export default SelectEmployee;
