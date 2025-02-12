import logo from './logo.svg';
import './App.css';
import { Routes, Route } from "react-router-dom";
import Signup from './pages/Signup';
import Signin from './pages/Signin';
import AppRoutes from './routes/AppRoutes';
import ContextProvider from './context/Userstate';

function App() {
  return (
 <>
 <ContextProvider>
 <AppRoutes/>
 </ContextProvider>
 </>
  );
}

export default App;
