import axios from "axios"

const Api = axios.create({
  baseURL: process.env.REACT_APP_API_URL || "https://localhost:7111/api",
  headers: {
    "Content-Type": "application/json",
  },
})

export const setAuthToken = (token) => {
  if (token) {
    Api.defaults.headers.common["Authorization"] = `Bearer ${token}`
    localStorage.setItem("token", token)
  } else {
    delete Api.defaults.headers.common["Authorization"]
    localStorage.removeItem("token")
  }
}

// Initialize token from localStorage
const token = localStorage.getItem("token")
if (token) {
  setAuthToken(token)
}

export const getRequest = (url, config = {}) => Api.get(url, config)
export const postRequest = (url, data, config = {}) => Api.post(url, data, config)
export const putRequest = (url, data, config = {}) => Api.put(url, data, config)
export const deleteRequest = (url, config = {}) => Api.delete(url, config)

export default Api

