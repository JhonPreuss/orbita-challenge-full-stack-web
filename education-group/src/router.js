import Vue from "vue";
import Router from "vue-router";

Vue.use(Router);

export default new Router({
  mode: "history",
  routes: [
    {
      path: "/",
      alias: "/students",
      name: "studenst",
      component: () => import("./components/StudentsList.vue")
    },
    {
      path: "/students/:id",
      name: "students-details",
      component: () => import("./components/Students.vue")
    },
    {
      path: "/add",
      name: "add",
      component: () => import("./components/AddStudent.vue")
    },
    {
      path: "/:pathMatch(.*)*",
      name: "not-found",
      component: () => import("./components/NotFound.vue")
    }
  ]
});