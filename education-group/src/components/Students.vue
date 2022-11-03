<template>
  <div v-if="currentStudent" class="edit-form py-3">
    <p class="headline">Editar Aluno</p>

    <v-form ref="form" lazy-validation>
      <v-text-field
        v-model="currentStudent.name"
        :rules="[(v) => !!v || 'O nome é obrigatório']"
        label="Nome"
        required
      ></v-text-field>

      <v-text-field
        v-model="currentStudent.email"
        :rules="[(v) => !!v || 'O Email é obrigatório']"
        label="E-mail"
        required
      ></v-text-field>

      <v-text-field
        v-model="currentStudent.academicRecord"
        :rules="[(v) => !!v || 'O RA é obrigatório']"
        label="RA"
        disable
      ></v-text-field>

      <v-text-field
        v-model="currentStudent.cpf"
        :rules="[(v) => !!v || 'O CPF é obrigatório']"
        label="CPF"
        disable
      ></v-text-field>

      <label><strong>Status:</strong></label>
      {{ currentStudent.active ? "Ativo" : "Inativo" }}

      <v-divider class="my-5"></v-divider>

      <v-btn color="error" small class="mr-2" @click="deleteStudent">
        Delete
      </v-btn>

      <v-btn color="success" small @click="updateStudent">
        Update
      </v-btn>
    </v-form>

    <p class="mt-3">{{ message }}</p>
  </div>

  <div v-else>
    <p>Selecione um aluno</p>
  </div>
</template>

<script>
import StudentDataService from "../services/StudentDataService";

export default {
  name: "student-detail",
  data() {
    return {
      currentStudent: null,
      message: "",
    };
  },
  methods: {
    getStudent(id) {
      StudentDataService.get(id)
        .then((response) => {
          this.currentStudent = response.data;
          console.log(response.data);
        })
        .catch((e) => {
          console.log(e);
        });
    },

    updateStudent() {
      StudentDataService.update(this.currentStudent.id, this.currentStudent)
        .then((response) => {
          console.log(response.data);
          this.message = "Dados do aluno atualizados com sucesso!";
        })
        .catch((e) => {
          console.log(e);
        });
    },

    deleteStudent() {
      StudentDataService.delete(this.currentStudent.id)
        .then((response) => {
          console.log(response.data);
          this.$router.push({ name: "students" });
        })
        .catch((e) => {
          console.log(e);
        });
    },
  },
  mounted() {
    this.message = "";
    this.getStudent(this.$route.params.id);
  },
};
</script>

<style>
.edit-form {
  max-width: 300px;
  margin: auto;
}
</style>