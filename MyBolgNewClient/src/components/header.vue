<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12">
        <ul class="nav nav-pills ls_nav">
          <li role="presentation"><a @click="$goRoute('/home')">首页</a></li>
          <li role="presentation"><a @click="$goRoute('/itBlogs')">IT杂记</a></li>
          <li role="presentation"><a @click="$goRoute('/reads')">文人墨客</a></li>
          <li role="presentation"><a @click="$goRoute('/shows')">劳有所获</a></li>
          <li role="presentation"><a @click="$goRoute('/diary')">生活杂记</a></li>
          <li role="presentation"><a @click="$goRoute('/messages')">七言八语</a></li>
        </ul>
      </div>
    </div>
  </div>
</template>

<script>

</script>
<style scoped>
  .ls_nav>li:hover{cursor: pointer;}
  /*.header{width: 100%;height: 150px; background: url('../assets/images/head.jpg') no-repeat;background-size:auto;}*/
  /*.navigation{width: 1200px;background: rgba(0,0,0,0.3);margin: auto;font-size: 18px;}*/

</style>

