import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.config.productionTip = false;
Vue.use(VueRouter);

import {routes} from './router'

const router = new VueRouter({
    routes,
    mode: 'history'
});

new Vue({
    el: '#app',
    template: "<router-view></router-view>",
    router: router
});