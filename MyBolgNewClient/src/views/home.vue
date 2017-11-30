<template>
  <div class="container">
    <div class="slider-img">
    <div id="myCarousel" class="carousel slide">
      <!-- 轮播（Carousel）指标 -->
      <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
      </ol>
      <!-- 轮播（Carousel）项目 -->
      <div class="carousel-inner">
        <div class="item active" style="height: 300px;">
          <img src="../assets/images/head.jpg" alt="First slide">
          <div class="carousel-caption">首页轮播一</div>
        </div>
        <div class="item" style="height: 300px;">
          <img src="../assets/images/head.jpg" alt="Second slide">
          <div class="carousel-caption">首页轮播二</div>
        </div>
        <div class="item" style="height: 300px;">
          <img src="../assets/images/head.jpg" alt="Third slide">
          <div class="carousel-caption">首页轮播三</div>
        </div>
      </div>
      <!-- 轮播（Carousel）导航 -->
      <a class="carousel-control left" href="#myCarousel"
         data-slide="prev">&lsaquo;</a>
      <a class="carousel-control right" href="#myCarousel"
         data-slide="next">&rsaquo;</a>
    </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'home',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App'
    }
  },
  comments: {}
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .container{width: 100%;margin: 0px;padding: 0px;}
  .slider-img{width: 100%;}
</style>
