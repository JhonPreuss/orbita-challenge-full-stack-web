<template>
    <div class="submit-form mt-3 mx-auto">
      <p class="headline">Cadastrar Aluno</p>
  
      <div v-if="!submitted">
        <v-form ref="form" lazy-validation>
          <v-text-field
            v-model="student.name"
            :rules="[(v) => !!v || 'O nome é obrigatório']"
            label="Nome"
            required
          ></v-text-field>
  
          <v-text-field
            v-model="student.email"
            :rules="[(v) => !!v || 'O E-mail é obrigatório']"
            label="E-mail"
            required
          ></v-text-field>

          <v-text-field
            v-model="student.academicRecord"
            :rules="[(v) => !!v || 'O registro acadêmico é obrigatório']"
            label="RA"
            required
          ></v-text-field>

          <v-text-field
            v-model="student.cpf"
            :rules="[(v) => !!v || 'O CPF é obrigatório']"
            label="CPF"
            required
          ></v-text-field>

        </v-form>
  
        <v-btn color="primary" class="mt-3" @click="saveStudent">Salvar</v-btn>
      </div>
  
      <div v-else>
        <v-card class="mx-auto">
          <v-card-title>
            Aluno cadastrado com sucesso!
          </v-card-title>
  
          <v-card-subtitle>
            Voltar para a tela de cadastro.
          </v-card-subtitle>
  
          <v-card-actions>
            <v-btn color="success" @click="newStudent">Cadastrar</v-btn>
          </v-card-actions>
        </v-card>
      </div>
    </div>
  </template>
  
  <script>
  import StudentDataService from "../services/StudentDataService";
  
  export default {
    name: "add-student",
    data() {
      return {
        student: {
          id: null,
          name: "",
          email: "",
          academicRecord: "",
          cpf: "",
          active: true,
        },
        submitted: false,
      };
    },
    methods: {
      saveStudent() {
        var data = {
          name: this.student.name,
          email: this.student.email,
          academicRecord: this.student.academicRecord,
          cpf: this.student.cpf,
          active: this.student.active,
        };
  
        StudentDataService.create(data)
          .then((response) => {
            this.student.id = response.data.id;
            console.log(response.data);
            this.submitted = true;
          })
          .catch((e) => {
            console.log(e);
          });
      },
  
      newStudent() {
        this.submitted = false;
        this.student = {};
      },
    },
  };
  </script>
  
  <style>
  .submit-form {
    max-width: 300px;
  }
  </style>