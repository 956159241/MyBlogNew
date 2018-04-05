import Vue from 'vue'
import Router from 'vue-router'
import home from '@/views/home'
import diary from '@/views/diary'
import messages from '@/views/messages'
import shows from '@/views/shows'
import reads from '@/views/reads'
import itBlogs from '@/views/itBlogs'
import essay from '@/views/essay'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: home
    },
    {
      path: '/home',
      name: 'home',
      component: home
    },
    {
      path: '/diary',
      name: 'diary',
      component: diary
    },
    {
      path: '/messages',
      name: 'messages',
      component: messages
    },
    {
      path: '/shows',
      name: 'shows',
      component: shows
    },
    {
      path: '/reads',
      name: 'reads',
      component: reads
    },
    {
      path: '/itBlogs',
      name: 'itBlogs',
      component: itBlogs
    },
    {
      path: '/essay',
      name: 'essay',
      component: essay
    }
  ]
})
