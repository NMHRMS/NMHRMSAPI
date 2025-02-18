import React, { useEffect, useRef, useState } from "react";
import { Outlet, useNavigate, Link } from "react-router-dom";
import {
  Layout,
  Menu,
  Button,
  Badge,
  Dropdown,
  Avatar,
  Space ,
  // Breadcrumb,
} from "antd";
import {
  CalendarOutlined,
  CommentOutlined,
  DashboardOutlined,
  FileTextOutlined,
  HddOutlined,
  HeartOutlined,
  PoweroffOutlined,
  SettingOutlined,
  TableOutlined,
  TeamOutlined,
  TransactionOutlined,
  UnorderedListOutlined,
  UploadOutlined,
  MenuUnfoldOutlined,
  MenuFoldOutlined,
  BellOutlined,
  GlobalOutlined,
  UserOutlined,
  SmileOutlined,
  DownOutlined
} from "@ant-design/icons";
import "./Mainsidebar.css";

const { Header, Sider, Content } = Layout;

function MainSidebar() {
  const [collapsed, setCollapsed] = useState(true);
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);
  const [hovered, setHovered] = useState(false);

  const navigate = useNavigate();

  useEffect(()=>{
    // token=localStorage.getItem('token')
    const token = JSON.parse(localStorage.getItem('userDetails'));
    console.log(token);
    
    if(!token){
      navigate("/")
    }
  },[])
  // const location = useLocation();
  // Sidebar menu items
  const sidebarItems = [
    { label: "Dashboard", icon: <DashboardOutlined />, path: "#" },
    { label: "Masters", icon: <TableOutlined />, path: "#" },
    { label: "Attendance", icon: <HeartOutlined />, path: "#" },
    { label: "Payroll", icon: <CommentOutlined />, path: "#" },
    {
      label: "All Employee",
      icon: <UnorderedListOutlined />,
      path: "#",
    },
    {
      label: "On Boarding",
      icon: <UnorderedListOutlined />,
      path: "/onboarding",
    },
    { label: "Requests", icon: <HddOutlined />, path: "#" },
    { label: "Finance", icon: <TransactionOutlined />, path: "#" },
    { label: "Calendar", icon: <CalendarOutlined />, path: "#" },
    { label: "Bulk Upload", icon: <UploadOutlined />, path: "#" },
    { label: "Reports", icon: <FileTextOutlined />, path: "#" },
    { label: "Team", icon: <TeamOutlined />, path: "#" },
    { label: "Settings", icon: <SettingOutlined />, path: "#" },
    {
      label: "Logout",
      icon: <PoweroffOutlined />,
      danger: true,
      path: "#",
    },
  ];

  // Profile menu for dropdown
  // const profileMenu = (
  //   <Menu
  //     items={[
  //       { label: "View Profile", key: "1" },
  //       { label: "Settings", key: "2" },
  //       { label: "Logout", key: "3" },
  //     ]}
  //   />
  // );
  const items = [
    {
      key: '1',
      label: (
        <a target="_blank" rel="noopener noreferrer">
          Logout
        </a>
      ),
    },
    
  ];
  // Language dropdown menu
  const languageMenu = (
    <Menu
      items={[
        { label: "English", key: "1" },
        { label: "French", key: "2" },
        { label: "Spanish", key: "3" },
      ]}
    />
  );

  return (
    <Layout style={{ minHeight: "100vh"}}>
      {/* Fixed Navbar */}
      <Header className="mainsidebar-navbar">
        <div className="mainsidebar-navbar-content">
          <div className="d-flex align-items-center">
            {/* Collapse Button */}
            <Button
              type="text"
              icon={
                collapsed && !hovered ? (
                  <MenuUnfoldOutlined style={{ fontSize: "20px" }} />
                ) : (
                  <MenuFoldOutlined style={{ fontSize: "20px" }} />
                )
              }
              // onClick={() => setCollapsed(!collapsed)}
              onClick={() => {
                setCollapsed(!collapsed);
                setIsSidebarOpen(!collapsed);
              }}
              className="mainsidebar-menu-toggle-btn me-5"
            />
            <h3 style={{ color: "blue" }}>Logo</h3>
          </div>

          <div>
            {/* Notification Bell */}
            <Badge
              count={5}
              offset={[3, 0]}
              className="mainsidebar-navbar-badge"
            >
              <BellOutlined style={{ fontSize: "20px" }} />
            </Badge>

            {/* Language Dropdown */}
            {/* <Dropdown menu={languageMenu}>
              <Button
                type="text"
                icon={<GlobalOutlined style={{ fontSize: "20px" }} />}
              >
                Language
              </Button>
            </Dropdown> */}

            {/* Profile Dropdown */}
            {/* <Dropdown menu={profileMenu}>
              <Avatar
                size="large"
                icon={<UserOutlined />}
                className="mainsidebar-navbar-profile"
              />
            </Dropdown> */}
            <Dropdown
    menu={{
      items,
    }}
  >
    <a onClick={(e) => e.preventDefault()}>
      <Space>
      <Avatar
                size="large"
                icon={<UserOutlined />}
                className="mainsidebar-navbar-profile"
              />
        {/* <DownOutlined /> */}
      </Space>
    </a>
  </Dropdown>
          </div>
        </div>
      </Header>

      {/* Sidebar positioned below the Navbar */}
      <Layout style={{scrollbarWidth:'thin'}}>
        <Sider
          trigger={null}
          collapsible
          collapsed={collapsed && !hovered}
          className="mainsidebar-sidebar"
          onMouseEnter={() => setHovered(true)}
          onMouseLeave={() => setHovered(false)}
        >
          <Menu
         
            theme="light"
            mode="inline"
            items={sidebarItems.map((item, index) => ({
              key: index,
              icon: item.icon,
              label: (
                <Link to={item.path} style={{ textDecoration: "none" }}>
                  {item.label}
                </Link>
              ),
              // label: item.label,
              danger: item.danger || false,
            }))}
            style={{ height: "100%", overflowY: "auto", scrollbarWidth: "thin", }} // Sidebar scrollable
          />
        </Sider>

        {/* Main Content Area */}
        <Content
          className="mainsidebar-site-layout-content"
          style={{
            marginLeft: collapsed && !hovered ? 80 : 200, // Adjust margin dynamically
            transition: "margin-left 0.5s", // Smooth transition
            backgroundColor: "#f5f6fa",
          }}
        >
          {/* Breadcrumbs */}

          <div className="mainsidebar-content-wrapper">
            <Outlet />
          </div>
        </Content>
      </Layout>
    </Layout>
  );
}

export default MainSidebar;