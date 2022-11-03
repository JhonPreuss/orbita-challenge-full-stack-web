import Vue from "vue";
import Router from "vue-router";

Vue.use(Router);

export default new Router({
  mode: "history",
  routes: [
    {
      path: "/students/:id",
      name: "students-details",
      component: () => import("./components/Students.vue")
    },
    {
      path: "/add",
      name: "add",
      component: () => import("./components/Students.vue")
    }
  ]
});