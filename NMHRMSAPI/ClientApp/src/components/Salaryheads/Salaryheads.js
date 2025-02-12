import { useState, useEffect, useContext } from "react";
import { Link, useNavigate } from "react-router-dom";
import styles from "./Salaryhead.module.css";
import { UserContext } from "../context/Userstate";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import axios from "axios";
import { toast, ToastContainer } from "react-toastify";

export default function Salaryheads() {
  const [isEarning, setIsEarning] = useState(true); // Toggle between Earning and Deduction
  const [earningData, setEarningData] = useState([]); // Stores earnings data
  const [deductionData, setDeductionData] = useState([]); // Stores deductions data
  const [loading, setLoading] = useState(false); // Loading indicator
  const [error, setError] = useState(null); // Error messages
  const navigate = useNavigate();
  const { badgeStatus, setBadgeStatus } = useContext(UserContext);

  // Navigation buttons for confirmation or moving to the next page
  const confirmButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      salarymaster: { confirm: true, next: false },
    }));
    navigate("/businesssetup/taxationmaster");
  };

  const nextButton = () => {
    setBadgeStatus((prevStatus) => ({
      ...prevStatus,
      salarymaster: { confirm: false, next: true },
    }));
    navigate("/businesssetup/taxationmaster");
  };

  // Toggle between Earning and Deduction tables
  const toggleTable = (type) => {
    setIsEarning(type === "earning");
  };

  // Fetch data from the API
  const loadData = () => {
    setLoading(true);
    Promise.all([
      axios.get("http://localhost:3000/salary_earning_head"),
      axios.get("http://localhost:3000/salary_deduction_head"),
    ])
      .then(([earningRes, deductionRes]) => {
        setEarningData(earningRes.data); // Set earnings data
        setDeductionData(deductionRes.data); // Set deductions data
        setLoading(false);
      })
      .catch((err) => {
        console.error("Error loading data:", err);
        setError("Failed to load data.");
        setLoading(false);
      });
  };

  // Delete an item
  const deleteItem = async (id, type) => {
    const url =
      type === "earning"
        ? `http://localhost:3000/salary_earning_head/${id}`
        : `http://localhost:3000/salary_deduction_head/${id}`;
    try {
      await axios.delete(url);
      if (type === "earning") {
        setEarningData((prevData) => prevData.filter((item) => item.id !== id));
      } else {
        setDeductionData((prevData) =>
          prevData.filter((item) => item.id !== id)
        );
      }
      toast.success(
        `${type.charAt(0).toUpperCase() + type.slice(1)} deleted successfully!`
      );
    } catch (error) {
      console.error("Error deleting item:", error);
      alert("Failed to delete the item. Please try again.");
    }
  };

  function handleEdit(id, type) {
    console.log("Editing ID:", id);
    const url =
      type === "earning"
        ? `http://localhost:3000/salary_earning_head/${id}`
        : `http://localhost:3000/salary_deduction_head/${id}`;

    axios
      .get(url)
      .then((res) => {
        console.log("Response data:", res.data);
        const targetRoute =
          type === "earning"
            ? `/businesssetup/earnings/${id}`
            : `/businesssetup/deduction/${id}`;
        navigate(targetRoute, { state: res.data });
      })
      .catch((err) => console.error("Error fetching data for edit:", err));
  }
  useEffect(() => {
    loadData();
  }, []);

  // Table Columns
  const columns = isEarning
    ? [
        { name: "Name", key: "name" },
        { name: "Calculation Type", key: "calculationType" },
        { name: "EPF", key: "epf" },
        { name: "Consider for CSI", key: "csi" },
      ]
    : [
        { name: "First Name", key: "firstName" },
        { name: "Deduction Type", key: "deductionType" },
        { name: "Calculation Type", key: "calculationType" },
        { name: "Tax Implication", key: "taxImplication" },
      ];

  const data = isEarning ? earningData : deductionData;

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="row">
            <h5>Define Salary Head</h5>
            <div className="d-flex justify-content-between mb-3">
              <div className={styles["switches-container"]}>
                <input
                  type="radio"
                  id="switchEarning"
                  name="switchPlan"
                  defaultChecked
                />
                <input type="radio" id="switchDeduction" name="switchPlan" />
                <label
                  htmlFor="switchEarning"
                  onClick={() => toggleTable("earning")}
                >
                  Earnings
                </label>
                <label
                  htmlFor="switchDeduction"
                  onClick={() => toggleTable("deduction")}
                >
                  Deductions
                </label>
                <div className={styles["switch-wrapper"]}>
                  <div className={styles["switch"]}>
                    <div>Earnings</div>
                    <div>Deductions</div>
                  </div>
                </div>
              </div>
              <Link
                to={
                  isEarning
                    ? "/businesssetup/earnings"
                    : "/businesssetup/deduction"
                }
              >
                <button
                  style={{ minWidth: "200px" }}
                  className="btn btn-primary rounded-5"
                >
                  Add {isEarning ? "Earning" : "Deduction"}
                </button>
              </Link>
            </div>

            <div className="col-lg-12">
              {error && <p className="text-danger text-center">{error}</p>}
              {loading ? (
                <p className="text-center">Loading...</p>
              ) : (
                <table className="table table-bordered table-hover table-responsive">
                  <thead>
                    <tr>
                      {columns.map((col) => (
                        <td
                          key={col.key}
                          className="bg-primary text-light text-center"
                        >
                          {col.name}
                        </td>
                      ))}
                      <td className="bg-primary text-light text-center">
                        Actions
                      </td>
                    </tr>
                  </thead>
                  <tbody>
                    {data.length > 0 ? (
                      data.map((row) => (
                        <tr key={row.id}>
                          {columns.map((col) => (
                            <td key={col.key} className="text-center">
                              {row[col.key]}
                            </td>
                          ))}
                          <td className="text-center">
                            <button
                              type="button"
                              className="btn btn-link me-2 p-0"
                              onClick={() =>
                                handleEdit(
                                  row.id,
                                  isEarning ? "earning" : "deduction"
                                )
                              }
                            >
                              <EditTwoTone />
                            </button>
                            <button
                              type="button"
                              className="btn btn-link text-danger p-0"
                              onClick={() =>
                                deleteItem(
                                  row.id,
                                  isEarning ? "earning" : "deduction"
                                )
                              }
                            >
                              <DeleteOutlined />
                            </button>
                          </td>
                        </tr>
                      ))
                    ) : (
                      <tr>
                        <td
                          colSpan={columns.length + 1}
                          className="text-center"
                        >
                          No data available for display.
                        </td>
                      </tr>
                    )}
                  </tbody>
                </table>
              )}
            </div>
          </div>

          <div className="d-flex justify-content-end">
            <button
              onClick={confirmButton}
              className="btn btn-success me-2 rounded-5"
              style={{ minWidth: "200px" }}
            >
              Confirm
            </button>
            <button
              onClick={nextButton}
              className="btn btn-primary rounded-5"
              style={{ minWidth: "200px" }}
            >
              Next
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}
