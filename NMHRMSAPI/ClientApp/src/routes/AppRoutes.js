import React from 'react';
import { Routes, Route } from 'react-router-dom';
import MainSidebar from '../components/Mainsidebar/Mainsidebar';
import EmployeeList from '../features/Employee/EmployeeList';
import Signup from '../pages/Signup';
import Signin from '../pages/Signin';
import Masterscreen from '../features/Masters/Masterscreen';
import UserManagement from '../features/UserManagement/UserManagement';
import Grade from '../features/Grade/Grade';
import Shifttemplate from '../features/Workshift/Shifttemplate';
import AddShifttemplate from '../features/Workshift/AddShiftTemplate';


const AppRoutes = () => {
    return (
        <Routes>
            <Route path="/" element={<Signup />} />
            <Route path="/signin" element={<Signin />} />
            <Route path="/hrms" element={<MainSidebar />}>
                <Route path="masterscreen" element={<Masterscreen />} />
                <Route path='usermanagement' element={<UserManagement />} />
                <Route path="grade" element={<Grade/>} />
                <Route path='shift' element={<Shifttemplate/>} />
                <Route path='addshift' element={<AddShifttemplate/>} />

                <Route path='employeelist' element={<EmployeeList />} />
            </Route>
        </Routes>
    );
};

export default AppRoutes;
