<template>
  <div id="app">
    <header-component></header-component>
    <div class="main" >
        <router-view></router-view>
    </div>
    <footer-component></footer-component>
  </div>
</template>

<script>
  import headerComponent from './components/header.vue'
  import footerComponent from './components/footer.vue'
  export default {
    name: 'app',
    data () {
      return {
        Theme: '',
        name: 'mynae'
      }
    },
    components: {headerComponent, footerComponent},
    mounted: function () {
      this.$http.get('/api/Index/GetTheme').then(response => {
        console.log(response)
        console.log(response.data)
        console.log(response.data.Name)
        this.Theme = response.data.Name
      })
    }
  }
</script>

<style>
#app {
  font-family: 'SimSun-ExtB', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
