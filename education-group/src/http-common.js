import axios from "axios";

export default axios.create({
  baseURL: "https://localhost:44353",
  headers: {
    "Accept": "application/json; charset=utf-8",
    "Content-Type": "application/json;charset=UTF-8"
  }
});