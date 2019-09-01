Vue.component('pc', {
    template: //html
        `
    <span style="color:red;font-weight:bold;">;</span>
    `
});
Vue.component('const', {
    template: //html
        `
    <h4 :id="value">{{value}}</h4>
    `,
    props: ['value']
})
Vue.component('outvar', {
    template: '<var class="outvar">{{value}}</var>',
    props: ['value']
});

const app = new Vue({
    el: '#app'
});

Vue.component('ddlink', {
    template: //html
        `
    <a data-scroll class="dropdown-item" :href="'#' + nombre">{{nombre}}</a>
    `,
    props: ['nombre']
});

const nav = new Vue({
    el: '#navbar-example2',
});