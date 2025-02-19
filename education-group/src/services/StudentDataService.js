import http from "../http-common";

class StudentDataService {
  getAll() {
    return http.get("/students");
  }

  get(id) {
    return http.get(`/students/${id}`);
  }

  create(data) {
    return http.post("/students", data);
  }

  update(id, data) {
    return http.put(`/students?id=${id}`, data);
  }

  delete(id) {
    return http.delete(`/students/?id=${id}`);
  }

  deleteAll() {
    return http.delete(`/students`);
  }

  findByName(name) {
    return http.get(`/students?name=${name}`);
  }
}

export default new StudentDataService();