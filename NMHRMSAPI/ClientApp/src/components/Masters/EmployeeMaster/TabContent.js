import React, { useState } from "react";
import EmployeeMaster from "./EmployeeMaster";
import Accounts from "./Accounts";
import WorkProfile from "./WorkProfile";
import Salary from "./Salary";
import Documents from "./Documents";
import Assests from "./Assests";
import EmployeeOptions from "./EmployeeOptions";
import Summary from "./Summary";
import "../EmployeeMaster/TabContent.css";

function TabContent() {
  const [activeTab, setActiveTab] = useState("personal-info");

  const tabs = [
    { id: "personal-info", label: "Personal Info" },
    { id: "accounts", label: "Accounts" },
    { id: "work-profile", label: "Work Profile" },
    { id: "salary", label: "Salary" },
    { id: "documents", label: "Documents" },
    { id: "assets", label: "Assets" },
    { id: "employee-options", label: "EmployeeOptions" },
    { id: "summary", label: "Summary" },
  ];

  return (
    <div>
      <h2 className="mb-3">Add Regular Employee</h2>
      <div className="tabss-containerrr">
        <ul className="navv mb-3 d-flex flex-wrap justify-content-start">
          {tabs.map((tab) => (
            <li
              key={tab.id}
              className={`nav-items p-2 rounded-pill mx-1 ${
                activeTab === tab.id ? "active-tabs" : "inactive-tabs"
              }`}
              onClick={() => setActiveTab(tab.id)}
            >
              <span className="tooltips">{tab.label}</span>
              {tab.label}
            </li>
          ))}
        </ul>
      </div>

      <div className="tab-content">
        {activeTab === "personal-info" && <EmployeeMaster />}
        {activeTab === "accounts" && <Accounts />}
        {activeTab === "work-profile" && <WorkProfile />}
        {activeTab === "salary" && <Salary />}
        {activeTab === "documents" && <Documents />}
        {activeTab === "assets" && <Assests />}
        {activeTab === "employee-options" && <EmployeeOptions />}
        {activeTab === "summary" && <Summary />}
      </div>
    </div>
  );
}

export default TabContent;
