<template>
  <div class="hello">
    <h3>Página não encontrada</h3>
    <router-link class="btn btn-success" :to="{name: 'studenst'}" >Retornar</router-link>
  </div>
</template>

<script>
export default {
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
