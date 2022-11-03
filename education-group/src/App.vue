<template>
  <v-app>
    <v-app-bar app dark>
      <div class="d-flex align-center mr-2">
        Grupo A+
      </div>

      <v-btn to="/students" text>
        Lista de Alunos
      </v-btn>

      <v-btn to="/add" text>
        Cadastrar
      </v-btn>
    </v-app-bar>

    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script>

export default {
  name: 'App',

  components: {
  },

  data: () => ({
    //
  }),
};
</script>
