import React, { useState, createContext } from "react";

export const UserContext = createContext();

const ContextProvider = ({ children }) => {
  const [badgeStatus, setBadgeStatus] = useState({
    shiftmaster: { confirm: false, next: false },
    divisionmaster: { confirm: false, next: false },
    departmentmaster: { confirm: false, next: false },
    designationmaster: { confirm: false, next: false },
    holidaymaster: { confirm: false, next: false },
    weeklyoffmaster: { confirm: false, next: false },
    leavemaster: { confirm: false, next: false },
    salarymaster: { confirm: false, next: false },
    taxationmaster: { confirm: false, next: false },
    employeecategoriesmaster:{confirm: false, next: false},
    grademaster:{confirm: false, next: false}
  });

  const Data = {
    badgeStatus,
    setBadgeStatus,
  };

  return <UserContext.Provider value={Data}>{children}</UserContext.Provider>;
};

export default ContextProvider;
