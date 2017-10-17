<template>
  <div class="box">
    <header-component></header-component>
    <div class="main" >
      <div class="menu"></div>
      <div>
        <router-view transition="fade" transition-mode="out-in" keep-alive></router-view>
        <footer-component></footer-component>
      </div>
    </div>
  </div>
</template>

<script>
  import headerComponent from './components/header.vue'
  import footerComponent from './components/footer.vue'
  export default {
    data () { return {Theme: '', name: 'mynae'} },
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
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
