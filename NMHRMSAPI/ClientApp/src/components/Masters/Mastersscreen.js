import React from "react";
import "../Masters/MastersScreen.css";
import { Link } from "react-router-dom";
import {
  ClockCircleOutlined,
  LineChartOutlined,
  MailOutlined,
  PartitionOutlined,
  AppstoreOutlined,
  IdcardOutlined,
  CalendarOutlined,
  WalletOutlined,
  UsergroupAddOutlined,
  RestOutlined,
  ReconciliationOutlined,
  PercentageOutlined,
  BankOutlined,
  ClusterOutlined,
  CoffeeOutlined,
} from "@ant-design/icons";

const Masterscreen = () => {
  const cardItems = [
    {
      path: "/hrms/business_info",
      icon: <BankOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Business Units",
    },
    {
      path: "/hrms/branches",
      icon: <ClusterOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Branches",
    },
    {
      path: "/hrms/shifts",
      icon: <ClockCircleOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Work Shifts",
    },
    {
      path: "/hrms/divisions",
      icon: <PartitionOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Divisions",
    },
    {
      path: "/hrms/departments",
      icon: <AppstoreOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Departments",
    },
    {
      path: "/hrms/designations",
      icon: <IdcardOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Designations",
    },
    {
      path: "/hrms/holidays",
      icon: <CoffeeOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Holidays",
    },
    {
      path: "/hrms/addweekoffs",
      icon: <CalendarOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Weekly off",
    },
    {
      path: "/hrms/salaryheads",
      icon: <WalletOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Salary Heads",
    },
    {
      path: "/finance",
      icon: <LineChartOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Finance",
    },
    {
      path: "/hrms/addemployee",
      icon: (
        <UsergroupAddOutlined style={{ fontSize: "22px", color: "blue" }} />
      ),
      label: "Employee Master",
    },
    {
      path: "/hrms/leaves",
      icon: <RestOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Leaves",
    },
    {
      path: "/requests",
      icon: <MailOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Requests",
    },
    {
      path: "/expenses",
      icon: (
        <ReconciliationOutlined style={{ fontSize: "22px", color: "blue" }} />
      ),
      label: "Expenses",
    },
    {
      path: "/hrms/taxation",
      icon: <PercentageOutlined style={{ fontSize: "22px", color: "blue" }} />,
      label: "Taxation",
    },
  ];

  return (
    <div className="container_master col col-lg-12 col-md-10">
      <div className="row">
        <h2 className="title_master text-left mb-4">Masters</h2>

        {cardItems.map((item, index) => (
          <div className="col-md-2 mb-4" key={index}>
            <Link to={item.path} className="link_master text-decoration-none">
              <div className="card card_master">
                <div className="card_body_master text-center">
                  <div className="icon_wrapper_master">
                    {/* Use Ant Design icons here */}
                    <div className="icon_master">{item.icon}</div>
                  </div>
                </div>
                <h6 className="card_label_master text-center mt-2">
                  {item.label}
                </h6>
              </div>
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
};

export default Masterscreen;
