// SetupSidebar.js
import React, { useEffect, useState } from "react";
import styles from "./Setupsidebar.module.css";
import { Link, Outlet, useLocation } from "react-router-dom";
import { UserContext } from "../context/Userstate";
import { useContext } from "react";

function SetupSidebar() {
  const { badgeStatus } = useContext(UserContext);

  const [activeItem, setActiveItem] = useState("");
  const location = useLocation();

  useEffect(() => {
    setActiveItem(location.pathname);
  }, [location]);

  const handleNavClick = (item) => {
    setActiveItem(item);
  };

  return (
    <div
      className="pt-3 container-fluid"
      style={{ backgroundColor: "#f5f6fa" }}
    >
      <div className="container px-3 d-flex justify-content-between ">
        <h5 className="mb-1">Company Name</h5>
        <Link to={'/hrms/masters'} className="mb-1">Skip</Link>
        {/* <div className="text-center ">
          <button className="btn btn-primary px-3 rounded-pill">
            Business Details
          </button>
        </div> */}
      </div>
      <div className="row justify-content-center">
        {/* Sidebar */}
        <div className="col-lg-2 col-md-2 col-sm-2">
          <Link
            to={"/businesssetup/shiftmaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() => handleNavClick("/businesssetup/shiftmaster")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/shiftmaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.shiftmaster.confirm
                    ? "bg-success"
                    : badgeStatus.shiftmaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                1
              </span>
              Shift
            </button>
          </Link>
          <Link
            to={"/businesssetup/grademaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() => handleNavClick("/businesssetup/grademaster")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/grademaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.grademaster.confirm
                    ? "bg-success"
                    : badgeStatus.grademaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                2
              </span>
              Grade
            </button>
          </Link>
          <Link
            to={"/businesssetup/employeecategoriesmaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() => handleNavClick("/businesssetup/employeecategoriesmaster")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/employeecategoriesmaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.employeecategoriesmaster.confirm
                    ? "bg-success"
                    : badgeStatus.employeecategoriesmaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                3
              </span>
             Employee Category
            </button>
          </Link>
          <Link
            to={"/businesssetup/departmentmaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() => handleNavClick("/businesssetup/departmentmaster")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/departmentmaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.departmentmaster.confirm
                    ? "bg-success"
                    : badgeStatus.departmentmaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                4
              </span>
              Department
            </button>
          </Link>

          <Link
            to={"/businesssetup/designationmaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() => handleNavClick("/businesssetup/designationmaster")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/designationmaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.designationmaster.confirm
                    ? "bg-success"
                    : badgeStatus.designationmaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                5
              </span>
              Designation
            </button>
          </Link>

          <Link
            to={"/businesssetup/holidaytemplatemaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() =>
                handleNavClick("/businesssetup/holidaytemplatemaster")
              }
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/holidaytemplatemaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.holidaymaster.confirm
                    ? "bg-success"
                    : badgeStatus.holidaymaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                6
              </span>
              Holiday Template
            </button>
          </Link>
          <Link
            to={"/businesssetup/addweeklyoff"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() => handleNavClick("/businesssetup/addweeklyoff")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/addweeklyoff"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.weeklyoffmaster.confirm
                    ? "bg-success"
                    : badgeStatus.weeklyoffmaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                7
              </span>
              Weekly Off
            </button>
          </Link>
          <Link
            to={"/businesssetup/leavetemplatemaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() =>
                handleNavClick("/businesssetup/leavetemplatemaster")
              }
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/leavetemplatemaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.leavemaster.confirm
                    ? "bg-success"
                    : badgeStatus.leavemaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                8
              </span>
              Leave Template
            </button>
          </Link>
          <Link
            to={"/businesssetup/salaryheadmaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              onClick={() => handleNavClick("/businesssetup/salaryheadmaster")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/salaryheadmaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span
                className={`p-2 me-2 badge ${
                  badgeStatus.salarymaster.confirm
                    ? "bg-success"
                    : badgeStatus.salarymaster.next
                    ? "bg-danger"
                    : "bg-primary"
                }`}
              >
                9
              </span>
              Salary Head
            </button>
          </Link>
          <Link
            to={"/businesssetup/taxationmaster"}
            className="list-group"
            style={{ textDecoration: "none" }}
          >
            <button
              style={{ minWidth: "100px" }}
              onClick={() => handleNavClick("/businesssetup/taxationmaster")}
              className={`${
                styles["list-group-item"]
              } list-group-item list-group-item-action m-2 p-2 ${
                activeItem === "/businesssetup/taxationmaster"
                  ? styles["border-primary"]
                  : ""
              }`}
            >
              <span className="p-2 me-2 badge bg-primary">10</span>Taxation
            </button>
          </Link>
        </div>

        {/* Main Content */}
        <div className={`col-lg-8 col-md-8 col-sm-8`}>
          <Outlet />
        </div>
      </div>
    </div>
  );
}

export default SetupSidebar;
