import "./App.css";
import { Routes, Route } from "react-router-dom";

// Context
import ContextProvider from "./components/context/Userstate";

// Pages
import Signup from "./pages/Signup";
import Businessdetails from "./components/Organisationsetup/Businessdetails";

// Components for Business Setup
import SetupSidebar from "./components/Setupsidebar/Setupsidebar";
import Shifttemplate from "./components/Shifttemplate/Shifttemplate";
import Department from "./components/Department/Department";
import Division from "./components/Division/Division";
import Designation from "./components/Designation/Designation";
import Holidaytemplate from "./components/Holidaytemplate/Holidaytemplate";
import Weeklyoff from "./components/Weeklyofftemplate/Weeklyoff";
import WeeklyAdd from "./components/Weeklyofftemplate/Weeklyadd";
import Leavetemplate from "./components/Leavetemplate/Leavetemplate";
import Salaryheads from "./components/Salaryheads/Salaryheads";
import Earnings from "./components/Salaryheads/Earnings";
import Deduction from "./components/Salaryheads/Deduction";
import Taxation from "./components/Taxation/Taxation";
import BranchDetails from "./components/BranchDetails/BranchDetails";
import Employesscategories from "./components/EmployeeCategories/Employesscategories";

// Components for HRMS
import Mainsidebar from "./components/Mainsidebar/Mainsidebar";
import Masterscreen from "./components/Masters/Mastersscreen";
import AddEmployee from "./components/Masters/AddEmployee";
import SelectEmployee from "./components/Masters/SelectEmployee";
import TabContent from "./components/Masters/EmployeeMaster/TabContent";
import Grade from "./components/Grade/Grade";

function App() {
  return (
    <>
      <ContextProvider>
        <Routes>
          {/* Signup Route */}
          <Route path="/" element={<Signup />} />

          {/* Business Details */}
          <Route path="/businessdetails" element={<Businessdetails />} />

          {/* Business Setup Routes */}
          <Route path="/businesssetup" element={<SetupSidebar />}>
            <Route path="shiftmaster" element={<Shifttemplate />} />
            <Route path="departmentmaster" element={<Department />} />
            <Route path="divisionmaster" element={<Division />} />
            <Route path="grademaster" element={<Grade/>} />
            <Route path="employeecategoriesmaster" element={<Employesscategories />} />
            <Route path="designationmaster" element={<Designation />} />
            <Route path="holidaytemplatemaster" element={<Holidaytemplate />} />
            <Route path="weeklyoffmaster" element={<Weeklyoff />} />
            <Route path="weeklyoffmaster/:id" element={<Weeklyoff />} />
            <Route path="addweeklyoff" element={<WeeklyAdd />} />
            <Route path="weeklyadd/:id" element={<Weeklyoff />} />
            <Route path="leavetemplatemaster" element={<Leavetemplate />} />
            <Route path="salaryheadmaster" element={<Salaryheads />} />
            {/* <Route path="salaryform" element={<Salaryform />} /> */}
            <Route path="salaryheadmaster/:id" element={<Salaryheads />} />
            <Route path="earnings" element={<Earnings />} />
            <Route path="earnings/:id" element={<Earnings />} />
            <Route path="deduction" element={<Deduction />} />
            <Route path="deduction/:id" element={<Deduction />} />
            <Route path="taxationmaster" element={<Taxation />} />
          </Route>

          {/* Branch Details */}
          <Route path="/branchdetails" element={<BranchDetails />} />

          {/* HRMS Routes */}
          <Route path="/hrms" element={<Mainsidebar />}>
            <Route path="masters" element={<Masterscreen />} />
            <Route path="addemployee" element={<AddEmployee />} />
            <Route path="selectemployee" element={<SelectEmployee />} />
            <Route path="tabcontent" element={<TabContent />} />
            <Route path="business_info" element={<Businessdetails />} />
            <Route path="branches" element={<BranchDetails />} />
            <Route path="shifts" element={<Shifttemplate />} />
            <Route path="divisions" element={<Division />} />
            <Route path="Grades" element={<Grade />} />
            <Route path="departments" element={<Department />} />
            <Route path="designations" element={<Designation />} />
            <Route path="holidays" element={<Holidaytemplate />} />
            <Route path="addweekoffs" element={<WeeklyAdd />} />
            <Route path="addweekoff/:id" element={<Weeklyoff />} />
            <Route path="weeklyoff" element={<Weeklyoff />} />
            <Route path="weeklyadd/:id" element={<Weeklyoff />} />
            <Route path="leaves" element={<Leavetemplate />} />
            <Route path="salaryheads" element={<Salaryheads />} />
            <Route path="salaryheads/:id" element={<Salaryheads />} />
            <Route path="earnings" element={<Earnings />} />
            <Route path="earnings/:id" element={<Earnings />} />
            <Route path="deduction" element={<Deduction />} />
            <Route path="deduction/:id" element={<Deduction />} />
            <Route path="taxation" element={<Taxation />} />
          </Route>
        </Routes>
      </ContextProvider>
    </>
  );
}

export default App;
