import React, { useState } from "react";
import { Link } from "react-router-dom";
import * as XLSX from "xlsx";

function AddEmployee() {
  const [selectedFile, setSelectedFile] = useState(null);
  const [fileData, setFileData] = useState(null);

  const handleFileChange = (event) => {
    const file = event.target.files[0];
    setSelectedFile(file);
    console.log("Selected file:", file?.name);

    // Read the Excel file
    const reader = new FileReader();
    reader.onload = (e) => {
      const data = e.target.result;
      const workbook = XLSX.read(data, { type: "binary" });
      const sheetName = workbook.SheetNames[0];
      const worksheet = workbook.Sheets[sheetName];
      const jsonData = XLSX.utils.sheet_to_json(worksheet);
      setFileData(jsonData); // Store parsed data
      console.log("Excel data:", jsonData);
    };
    reader.readAsBinaryString(file);
  };

  // Handle validation
  const handleValidation = () => {
    if (!fileData || fileData.length === 0) {
      console.error("No file data to validate or the file is empty.");
      alert("Please upload a valid file with data.");
      return;
    }

    // Define required columns
    const requiredColumns = ["id", "Name", "Surname", "Address"];
    const firstRow = fileData[0];

    // Check for missing columns
    const missingColumns = requiredColumns.filter((col) => !(col in firstRow));

    // Check for extra columns
    const fileColumns = Object.keys(firstRow || {});
    const extraColumns = fileColumns.filter(
      (col) => !requiredColumns.includes(col)
    );

    // Generate validation messages
    let errorMessage = "";
    if (missingColumns.length > 0) {
      errorMessage += `Missing columns: ${missingColumns.join(", ")}.\n`;
    }
    if (extraColumns.length > 0) {
      errorMessage += `Extra columns detected: ${extraColumns.join(", ")}.\n`;
    }

    if (errorMessage) {
      alert(`Validation Error:\n${errorMessage}`);
    } else {
      alert("Validation Passed: The file structure is correct.");
    }
  };

  return (
    <div className="container">
      <div className="row justify-content-center">
        <div className="col-12 col-md-10 col-lg-9">
          <div className="card shadow-sm p-4">
            <h4 className="text-center mb-4">Add New Employees in Master</h4>
            <div className="row d-flex align-items-stretch h-100">
              <div
                className="col-md-6 d-flex flex-column align-items-center justify-content-center"
                style={{ marginBottom: "50px" }}
              >
                <img
                  src={require("../../assets/emp1.png")}
                  alt="Add Employee Manually"
                  className="mb-0"
                />
                <h5>Add Employee Manually</h5>
                <p>You can add employees manually in our system</p>
                <Link to="/hrms/selectemployee">
                  <button className="btn btn-primary rounded-pill">
                    Add Employee
                  </button>
                </Link>
              </div>
              <div
                className="col-md-6 d-flex flex-column align-items-center justify-content-center"
                style={{ borderLeft: "2px dashed #0d6efd" }}
              >
                <img
                  src={require("../../assets/emp2.png")}
                  alt="Add Bulk Employee"
                  className="mb-3"
                />
                <h5>Add Bulk Employee</h5>
                <p
                  style={{
                    fontSize: "16px",
                    lineHeight: "1.5",
                    textAlign: "center",
                    marginBottom: "10px",
                  }}
                >
                  You can easily add bulk employees in just a few simple steps.
                  <br />
                  Download .xlsx template{" "}
                  <a href="/Book1.xlsx" download>
                    Bulk Template
                  </a>
                </p>
                <input
                  type="file"
                  accept=".xlsx,.xls"
                  onChange={handleFileChange}
                  style={{ display: "none" }}
                  id="fileUpload"
                />
                <label
                  htmlFor="fileUpload"
                  className="btn btn-primary mt-2"
                  style={{ borderRadius: "25px" }}
                >
                  {selectedFile ? selectedFile.name : "Upload File"}
                </label>
                <p
                  className="text-muted mt-2"
                  style={{
                    fontSize: 12,
                  }}
                >
                  Only .xls, .xlsx formats supported. Max Size up to 5 MB
                </p>
              </div>
            </div>
          </div>
          {fileData && (
            <div className="col-11 d-flex justify-content-end">
              <button
                className="btn btn-primary"
                style={{ marginTop: 10, borderRadius: "25px" }}
                onClick={handleValidation}
              >
                Validation
              </button>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}

export default AddEmployee;
// import React from "react";
// import { Link } from "react-router-dom";

// function AddEmployee() {
//   return (
//     <div className="container">
//       <div className="row justify-content-center">
//         <div className="col-12 col-md-10 col-lg-9">
//           <div className="card shadow-sm p-4">
//             <h4 className="text-center mb-4">Add New Employees in Master</h4>

//             <div className="row">
//               {/* Left Section */}
//               <div className="col-12 col-md-6 text-center mb-4 mb-md-0">
//                 <img
//                   src={require("../../assets/emp1.png")}
//                   alt="Add Employee Manually"
//                   className="img-fluid mb-3"
//                 />
//                 <h5>Add Employee Manually</h5>
//                 <p>You can add employees manually in our system</p>
//                 <Link to="/hrms/selectemployee">
//                   <button className="btn btn-primary">Add Employee</button>
//                 </Link>
//               </div>

//               {/* Right Section */}
//               <div
//                 className="col-12 col-md-6 text-center"
//                 style={{ borderLeft: "2px dashed #0d6efd" }}
//               >
//                 <img
//                   src={require("../../assets/emp2.png")}
//                   alt="Add Bulk Employee"
//                   className="img-fluid mb-3"
//                 />
//                 <h5>Add Bulk Employee</h5>
//                 <p className="text-center">
//                   You can easily add bulk employees in just a few simple steps.
//                   <br />
//                   Download .xlsx template <a href="/">Bulk Template</a>
//                 </p>
//                 <button className="btn btn-primary">Upload File</button>
//                 <p className="text-muted mt-2" style={{ fontSize: "12px" }}>
//                   Only xls, xlsx, csv format supported. Max Size up to 5 MB
//                 </p>
//               </div>
//             </div>
//           </div>
//         </div>
//       </div>
//     </div>
//   );
// }

// export default AddEmployee;
