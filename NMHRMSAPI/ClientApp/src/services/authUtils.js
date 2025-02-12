import { setAuthToken } from "./Api"
export const saveAuthData = (data) => {
  localStorage.setItem("userDetails", JSON.stringify(data.userDetails))
  localStorage.setItem("roleDetails", JSON.stringify(data.roleDetails))
  setAuthToken(data.token)
}

export const getAuthData = () => {
  const userDetails = JSON.parse(localStorage.getItem("userDetails"))
  const roleDetails = JSON.parse(localStorage.getItem("roleDetails"))
  const token = localStorage.getItem("token")
  return { userDetails, roleDetails, token }
}

export const clearAuthData = () => {
  localStorage.removeItem("userDetails")
  localStorage.removeItem("roleDetails")
  setAuthToken(null)
}

