import React, { useEffect, useState } from "react";
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";
import axios from "axios";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import { useLocation, useNavigate } from "react-router-dom";

export default function weeklyadd() {
  const location = useLocation();
  const navigate = useNavigate();

  const [weeklyOffPolicies, setWeeklyOffPolicies] = useState([]);

  const fetchWeeklyOffPolicies = () => {
    axios
      .get("http://localhost:3000/weekly_off_policies")
      .then((res) => {
        setWeeklyOffPolicies(res.data);
      })
      .catch((err) => {
        toast.error("Error fetching policies.");
        console.error(err);
      });
  };

  const deleteWeeklyOff = (id) => {
    axios
      .delete(`http://localhost:3000/weekly_off_policies/${id}`)
      .then((res) => {
        toast.success("Policy deleted successfully!");
        fetchWeeklyOffPolicies();
      })
      .catch((err) => {
        toast.error("Error deleting policy.");
        console.error(err);
      });
  };

  const handleAddTemplate = () => {
    navigate(
      location.pathname.includes("/businesssetup")
        ? "/businesssetup/weeklyoffmaster"
        : "/hrms/weeklyoff"
    );
  };

  const handleEdit = (policy) => {
    const basePath = location.pathname.includes("/businesssetup")
      ? "/businesssetup/weeklyoffmaster"
      : "/hrms/weeklyadd";

    navigate(`${basePath}/${policy.id}`, { state: policy });
  };

  useEffect(() => {
    fetchWeeklyOffPolicies();
  }, []);

  return (
    <div className="container mt-2">
      <ToastContainer />
      <div className="card mb-4" style={{ border: "none" }}>
        <div className="card-body">
          <div className="d-flex justify-content-between align-items-center mb-3">
            <h5 className=" mb-0">Weekly Off Policy List</h5>
            <button
              onClick={handleAddTemplate}
              className="btn btn-primary rounded-5"
            >
              Add Template
            </button>
          </div>

          <div className="col-md-12">
            <table className="table table-bordered">
              <thead>
                <tr>
                  <td className="bg-primary text-light text-center">
                    Policy Name
                  </td>
                  <td className="bg-primary text-light text-center">
                    General Weekly Off
                  </td>
                  <td className="bg-primary text-light text-center">
                    Alternate Weekly Off
                  </td>
                  <td className="bg-primary text-light text-center">Action</td>
                </tr>
              </thead>
              <tbody>
                {weeklyOffPolicies.map((item, i) => (
                  <tr key={i}>
                    <td className="text-center">{item.policyName}</td>
                    <td className="text-center">
                      {item.generalWeeklyOffs.join(", ")}
                    </td>
                    <td className="text-center">
                      {Object.keys(item.alternatingWeeklyOffs).map(
                        (day, index) => {
                          const hours = item.alternatingWeeklyOffs[day];
                          if (hours.length > 0) {
                            return (
                              <div key={index}>
                                {day}: {hours.join(", ")}
                              </div>
                            );
                          }
                          return null;
                        }
                      )}
                    </td>
                    <td className="text-center">
                      <button
                        className="btn btn-link p-1"
                        onClick={() => handleEdit(item)}
                      >
                        <EditTwoTone />
                      </button>
                      <button
                        className="btn btn-link p-1 text-danger"
                        onClick={() => deleteWeeklyOff(item.id)}
                      >
                        <DeleteOutlined />
                      </button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  );
}
