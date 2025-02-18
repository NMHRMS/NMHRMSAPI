import React from 'react';
import { Routes, Route } from 'react-router-dom';
import MainSidebar from '../components/Mainsidebar/Mainsidebar';
import EmployeeList from '../features/Employee/EmployeeList';
import Signup from '../pages/Signup';
import Signin from '../pages/Signin';
import Masterscreen from '../features/Masters/Masterscreen';
import UserManagement from '../features/UserManagement/UserManagement';
import Grade from '../features/Grade/Grade';
import BranchDetails from '../features/BranchDetails/BranchDetails';
import Shifttemplate from '../features/Shifttemplate/Shifttemplate';
import Division from '../features/Division/Division';
import Department from '../features/Department/Department';
import Designation from '../features/Designation/Designation';
import Holidaytemplate from '../features/Holidaytemplate/Holidaytemplate';
import Weeklyoff from '../features/Weeklyofftemplate/Weeklyoff';
import Salaryhead from '../features/Salaryheads/Salaryheads';
import Employesscategories from '../features/EmployeeCategories/Employesscategories';
import Taxation from '../features/Taxation/Taxation';
import Leavetemplate from '../features/Leavetemplate/Leavetemplate';
import AddShifttemplate from '../features/Workshift/AddShiftTemplate';
;

const AppRoutes = () => {
    return (
        <Routes>
            <Route path="/" element={<Signup />} />
            <Route path="/signin" element={<Signin />} />
            <Route path="/hrms" element={ <MainSidebar />}>
                <Route path="masterscreen" element={<Masterscreen />} />
                <Route path='usermanagement' element={<UserManagement />} />
                <Route path='branches' element={<BranchDetails />} />
                <Route path='shift' element={<Shifttemplate />} />
                <Route path='division' element={<Division />} />
                <Route path='department' element={<Department />} />
                <Route path='designation' element={<Designation />} />
                <Route path='holidaytemplate' element={<Holidaytemplate />} />
                <Route path='weeklyoff' element={<Weeklyoff />} />
                <Route path='salaryhead' element={<Salaryhead />} />
                <Route path='employescategories' element={<Employesscategories />} />
                <Route path='leavetemplate' element={<Leavetemplate />} />
                <Route path='taxation' element={<Taxation />} />
                <Route path="grade" element={<Grade/>} />
                <Route path="addshift" element={<AddShifttemplate/>} />
                
                <Route path='employeelist' element={<EmployeeList />} />
            </Route>
        </Routes>
    );
};

export default AppRoutes